using System;
using Xamariners.Core.Test.Helpers;
using Xamarin.UITest.Queries;


namespace Xamariners.Core.Mobile.UI.Test
{
	public class AndroidQueries : IScreenQueries
	{
		public AppResult[] WaitForElementMarked(string mark, string timeoutMessage, int timeout)
		{
			return SetupHooks.App.WaitForElement(c => c.Id(mark), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForWindowMarked(string mark, string timeoutMessage, int timeout)
		{
			return SetupHooks.App.WaitForElement(c => c.Id(mark), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}


		public AppResult[] WaitForTextFieldText(string text, string timeoutMessage, int timeout)
		{
			return SetupHooks.App.WaitForElement(c => c.Id(text), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForTextFieldLabelMarked(string marked, string timeoutMessage, int timeout)
		{
			return SetupHooks.App.WaitForElement(c => c.Id(marked), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForButtonMarked(string mark, string timeoutMessage, int timeout)
		{
			return SetupHooks.App.WaitForElement(c => c.Id(mark), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForButtonLabelText(string parentMark, string text, string timeoutMessage, int timeout)
		{
			return SetupHooks.App.WaitForElement(c => c.Id(parentMark).Child("UIButtonLabel").Text(text), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForLabelText(string text, string timeoutMessage, int timeout)
		{
			return SetupHooks.App.WaitForElement(c => c.Id(text), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public AppResult[] WaitForNavigationBarText(string accessibilityLabel, string timeoutMessage, int timeout)
		{
			return SetupHooks.App.WaitForElement(c => c.Id("action_bar_title").Text(accessibilityLabel), timeoutMessage, TimeSpan.FromSeconds(timeout));
		}

		public void EnterTextOnElementMarked(string mark, string text)
		{
			SetupHooks.App.EnterText(c => c.Id(mark), text);
		}

		public void TapOnElementMarked(string mark)
		{
			SetupHooks.App.Tap(c => c.Id(mark));
		}

		public void TapOnElementWithText(string text)
		{
			SetupHooks.App.Tap(c => c.Id(text));
		}

		public void ValidateLabelText(string text)
		{
			var result = WaitForLabelText(text, string.Format("'{0}' does not exist", text), 5);
			result[0].Text.ShouldEqual(text);
		}

		public void ValidateWindowMarked(string mark)
		{
			var result = WaitForWindowMarked (mark, string.Format ("'{0}' does not exist", mark), 5);
			result [0].Label.ShouldEqual (mark);
		}

		public void ValidateButtonMarked(string mark)
		{
			var result = WaitForButtonMarked (mark, string.Format ("'{0}' does not exist", mark), 5);
			result [0].Label.ShouldEqual (mark);
		}

		public void ValidateLabelMarked(string mark)
		{
			var result = WaitForElementMarked(mark, string.Format("'{0}' does not exist", mark), 5);
			result[0].Label.ShouldEqual(mark);
		}

		public void ValidateNavId(string id)
		{
			var result = SetupHooks.Queries.WaitForNavigationBarText (id, string.Format ("'{0}' does not exist", id), 5);
			result[0].Id.ShouldEqual (id);
		}

		public void ValidateTextField(string mark, string watermark  = "")
		{
			var result = WaitForTextFieldLabelMarked(mark, string.Format ("'{0}' does not exist", mark), 5);
			result [0].Label.ShouldEqual (mark);

			if(! string.IsNullOrEmpty(watermark))
			{
				var result2 = WaitForTextFieldText(watermark, string.Format ("'{0}' does not exist", watermark), 5);
				result2 [0].Label.ShouldEqual (watermark);
			}
		}

		public void ValidateButtonMarked(string mark, string labelText = "")
		{
			var result = WaitForButtonMarked (mark, string.Format ("'{0}' does not exist", mark), 5);
			result [0].Label.ShouldEqual (mark);

			if(!string.IsNullOrEmpty(labelText))
			{
				var result2 = WaitForButtonLabelText (mark, labelText, string.Format ("'{0}' does not exist", mark), 5);
				result2 [0].Label.ShouldEqual (labelText);
			}
		}
	}
}
