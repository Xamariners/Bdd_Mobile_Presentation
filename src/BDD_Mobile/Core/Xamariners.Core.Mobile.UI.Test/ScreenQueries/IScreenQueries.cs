namespace Xamariners.Core.Mobile.UI.Test
{
    using Xamarin.UITest.Queries;

    public interface IScreenQueries
    {
        AppResult[] WaitForElementMarked(string mark, string timeoutMessage, int timeout);
        AppResult[] WaitForLabelText(string text, string timeoutMessage, int timeout);
		AppResult[] WaitForButtonMarked (string mark, string timeoutMessage, int timeout);
		AppResult[] WaitForNavigationBarText(string accessibilityLabel, string timeoutMessage, int timeout);
		AppResult[] WaitForTextFieldText (string text, string timeoutMessage, int timeout);
		AppResult[] WaitForTextFieldLabelMarked (string marked, string timeoutMessage, int timeout);
		AppResult[] WaitForButtonLabelText (string parentMark, string text, string timeoutMessage, int timeout);

		void ValidateLabelText(string text);
		void ValidateWindowMarked(string mark);
		void ValidateLabelMarked(string mark);
		void ValidateTextField (string mark, string watermark = "");
		void ValidateButtonMarked(string mark, string labelText = "");

		void ValidateNavId (string id);
        
        void EnterTextOnElementMarked(string mark, string text);

        void TapOnElementMarked(string mark);
		void TapOnElementWithText (string text);

    }
}
