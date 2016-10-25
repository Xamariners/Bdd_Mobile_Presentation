using TechTalk.SpecFlow;
using System.Linq;
using Xamariners.Core.Test.Helpers;
using Xamarin.UITest.Queries;

namespace Xamariners.Core.Mobile.UI.Test
{
   [Binding]
	public class SharedSteps
	{
        // see https://github.com/techtalk/SpecFlow/wiki/Use-Bindings-from-External-Assemblies
        [When (@"I launch the app, after the splash screen")]
		public void WhenILaunchTheAppAfterTheSplashScreen ()
		{
			// nothing to validate here
			true.ShouldBeTrue ();
		}

		[Given(@"I am an unauthenticated user")]
		public void GivenIAmAnUnauthenticatedUser()
		{
			// nothing to validate here
			true.ShouldBeTrue ();
		}

        // Scenario: Login
        /// <summary>
        /// The then i am an authenticated user named.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        [Then(@"I am an authenticated user named ""(.*)""")]
        public void ThenIAmAnAuthenticatedUserNamed(string email)
        {
            //TODO: Check if the first name on the screen matches the name we entered during sign up
            true.ShouldBeTrue ();
        }

        [Then (@"an error message ""(.*)"" is shown")]
		[Then(@"I can see a label with the text ""(.*)""")]
		[Given(@"I can see a label with the text ""(.*)""")]
		public void ICanSeeALabelWithTheText(string text)
		{		
			SetupHooks.Queries.ValidateLabelText (text);		
		}
        

		[Then(@"I can see a label ""(.*)"" with the text ""(.*)""")]
		[Given(@"I can see a label ""(.*)"" with the text ""(.*)""")]
		public void ICanSeeALabelWithTheText(string labelname, string text)
		{
            //TODO: Remove any HTML characters from the string, not only these ones
		    text = text.Replace("<u>", "").Replace("</u>", "");
			// we ignore the label name here
			SetupHooks.Queries.ValidateLabelText (text);		
		}

        [Then(@"I can see a picture box with the text ""(.*)""")]
        [Then(@"the navbar has a ""(.*)"" title")]
        public void ICanSeeATittleWithTheText(string text)
        {
            // we ignore the label name here
            SetupHooks.Queries.ValidateLabelText(text);
        }

        [Then(@"I tap on the ""(.*)"" button")]
		[When(@"I tap on the ""(.*)"" button")]
		[When(@"I click the ""(.*)"" button")]
		[When(@"I tap the button with the text ""(.*)""")]
		public void ITapAButtonWithTheText(string text)
		{		
			SetupHooks.Queries.TapOnElementWithText (text);		
		}
        
        [Then(@"I can see a right button with the text ""(.*)""")]
        [Then(@"the navbar has a left back button labelled ""(.*)"" on the navbar")]
		[Then(@"I can see a ""(.*)"" button")]
		public void ThenICanSeeAButton(string text)
		{
			SetupHooks.Queries.ValidateButtonMarked (text);
		}

        [Then(@"I can see a ""(.*)"" button with text ""(.*)""")]
        public void ThenICanSeeAButtonWithText(string name, string text)
        {
            SetupHooks.Queries.ValidateButtonMarked(text);
        }

        [Then (@"I can see a textbox ""(.*)"" with the watermark ""(.*)""")]
		public void ThenICanSeeATextboxWithTheWatermark (string mark, string watermark)
		{
		    if (watermark == "Password")
		        watermark = "Choose a password (minimum 8 chars)";

			SetupHooks.Queries.ValidateTextField (mark, watermark);
		}

		[Then (@"I am on the ""(.*)"" view")]
		[Given (@"I am on the ""(.*)"" view")]
		[Then(@"I am redirected to the ""(.*)"" view")]
		public void GivenIAmOnTheView (string view)
		{
			SetupHooks.Queries.ValidateWindowMarked (view);
		}

		[Then (@"I can see a keypad ""(.*)"" with a button ""(.*)"" with the text ""(.*)""")]
		public void ThenICanSeeAKeypadWithAButton (string keypadType, string keypadButton, string labelText = "")
		{
            //maybe add statement to validate keypad type
			SetupHooks.Queries.ValidateButtonMarked (keypadButton, labelText);
		}
      
		[When (@"I enter the text ""(.*)"" in the field ""(.*)""")]
		public void IEnterTheTextInTheField (string text, string fieldName)
		{
			SetupHooks.Queries.EnterTextOnElementMarked(fieldName, text);
		}

        [When(@"I pick a picture from my camera roll using the standard photo pick from the system")]
        public void WhenIPickAPictureFromMyCameraRollUsingTheStandardPhotoPickFromTheSystem()
        {
			//TODO: Download a picture first from the Internet or take a snapshot
            //SetupHooks.App.Invoke("TakeASnapshot:");              
            //SetupHooks.GetPicture();
            SetupHooks.Queries.TapOnElementMarked("Photo");
            SetupHooks.Queries.TapOnElementMarked("Saved Photos");
			//HACK: At present we have to add an image manually until we can properly add an image automatically 
            //before running the scenario either Taking a Snapshot or Downloading an image
			AppResult[] visualElements = SetupHooks.App.Query (c => c.All ());			
            var photo = visualElements.FirstOrDefault(c => c.Class == "PUPhotosGridCell");
            SetupHooks.Queries.TapOnElementMarked(photo.Label);
        }

        [Then(@"there is not any validation errors")]
        public void ThenThereIsNotAnyValidationErrors()
        {
            //TODO: Check if there is any alert view in the list of visual elements
        }

        [Then(@"I should see a popup with ""(.*)"" error\(s\)")]
        public void ThenIShouldSeeAPopupWithErrorS(string errors)
        {
            //TODO: Check if there is any alert view in the list of visual elements and its content
        }
	}
}