using System;
using System.CodeDom;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Xamariners.Core.Mobile.UI.Test
{
    using System.IO;
    using System.Reflection;
    using System.Net;
    using Xamarin.UITest;    

    [Binding]
    public class SetupHooks
    {
        public static IScreenQueries Queries;

        public static IApp App;

        private readonly AppSettingsReader _reader;

        public static string PathToIPA { get; private set; }

        public static string PathToAPK { get; private set; }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public SetupHooks()
        {
            _reader = new AppSettingsReader();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            if (TestEnvironment.Platform.Equals(TestPlatform.TestCloudiOS))
            {
                PathToIPA = string.Empty;

                App = ConfigureApp.iOS.StartApp();

                Queries = new iOSQueries();
            }
            else if (TestEnvironment.Platform.Equals(TestPlatform.TestCloudAndroid))
            {
                PathToAPK = string.Empty;

                App = ConfigureApp.Android.StartApp();

                Queries = new AndroidQueries();
            }
            else if (TestEnvironment.Platform.Equals(TestPlatform.Local))
            {

                var localTestRunPlatform =
                    (LocalTestRunPlatform)
                    Enum.Parse(typeof(LocalTestRunPlatform),
                    _reader.GetValue("localtestrun.platform", typeof(string)).ToString());

                switch (localTestRunPlatform)
                {
                    case LocalTestRunPlatform.IOS_DEVICE:
                        RunIosDevice();
                        break;

                    case LocalTestRunPlatform.IOS_SIMULATOR:
                        RunIosSimulator();
                        break;

                    case LocalTestRunPlatform.ANDROID_DEVICE:
                        RunAndroidDevice();
                        break;

                    case LocalTestRunPlatform.ANDROID_SIMULATOR:
                        RunAndroidSimulator();
                        break;
                }
            }
            else
            {
                throw new NotImplementedException(
                    $"I don't know this platform {TestEnvironment.Platform}");
            }

            // uncomment to get the repl console and put a breakpoint on the following curly bracket
            //App.Repl();            
        }

        private void RunAndroidSimulator()
        {
            var apkPath = GetApkPath();
            App = ConfigureApp.Android.ApkFile(apkPath).StartApp();
            Queries = new AndroidQueries();
        }

        private void RunAndroidDevice()
        {
            throw new NotImplementedException();
        }

        private void RunIosSimulator()
        {
            var appPath = GetAppPath();
            App = ConfigureApp.iOS.AppBundle(appPath).StartApp();
            Queries = new iOSQueries();
        }

        private void RunIosDevice()
        {
            var iosBundleName = _reader.GetValue("ios.bundlename", typeof(string)).ToString();
            var iosDeviceIp = _reader.GetValue("ios.deviceip", typeof(string)).ToString();

            var device = ConfigureApp.iOS.DeviceIp(iosDeviceIp);
            App = device.InstalledApp(iosBundleName).StartApp();
            Queries = new iOSQueries();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {

        }

        private string GetApkPath()
        {
            var androidProjectName = _reader.GetValue("android.projectname", typeof(string)).ToString();
            string currentFile = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            FileInfo fi = new FileInfo(currentFile);
            string dir = fi.Directory.Parent.Parent.Parent.FullName;

            PathToAPK = Path.Combine(
                dir,
                androidProjectName,
                "bin",
                "Release",
                androidProjectName, ".APK");

            return PathToAPK;
        }

        private string GetAppPath()
        {
            var iosAssemblyName = _reader.GetValue("ios.assemblyname", typeof(string)).ToString();
            var iosAppPath = _reader.GetValue("ios.apppath", typeof(string)).ToString();
            string currentFile = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            FileInfo fi = new FileInfo(currentFile);
            string dir = fi.Directory.Parent.Parent.Parent.Parent.FullName;

            PathToIPA = Path.Combine(
                dir,
                iosAppPath,
                "bin",
                "iPhoneSimulator",

                #if FAKE 
                "DebugFake",
                #else
                "Debug",
                #endif

                iosAssemblyName + ".app");

            return PathToIPA;
        }

        [BeforeFeature("disableCache")]
        public static void BeforeFeatureDisableBache()
        {
        }

        [BeforeFeature("clearCache")]
        public static void BeforeFeatureEnableCache()
        {
        }

        public static void GetPicture(string url)
        {
            var webClient = new WebClient();

            var uri = new Uri(url);
            
            webClient.DownloadDataCompleted += (s, e) =>
            {
                var bytes = e.Result; // get the downloaded data
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string localFilename = "downloaded.png";
                string localPath = Path.Combine(documentsPath, localFilename);
                File.WriteAllBytes(localPath, bytes); // writes to local storage   
            };

            webClient.DownloadData(uri);
                        
        }

    }
}
