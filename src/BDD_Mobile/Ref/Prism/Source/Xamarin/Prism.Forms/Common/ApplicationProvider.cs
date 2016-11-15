using Xamarin.Forms;

namespace Prism.Common
{
    public class ApplicationProvider : IApplicationProvider
    {
        private Page _mainPage;

        public Page MainPage
        {
            get { return _mainPage ?? Application.Current?.MainPage; }
            set
            {
                this._mainPage = value;

                if(Application.Current != null)
                    Application.Current.MainPage = value;
            }
        }
    }
}
