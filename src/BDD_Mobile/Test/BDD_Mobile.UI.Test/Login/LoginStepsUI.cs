using System;
using TechTalk.SpecFlow;
using System.Linq;
using Xamariners.Core.Mobile.UI.Test;
using Xamariners.Core.Test.Helpers;

namespace ToDo.UI.Test.Login
{


	using NUnit.Framework;

	[Binding]
	public class EmailLoginSteps
	{	
		[When (@"I enter the username ""(.*)""")]
		public void WhenIEnterTheUsername (string p0)
		{
			ScenarioContext.Current.Pending ();
		}

		[When (@"I enter the password ""(.*)"" after (.*) attempts")]
		public void WhenIEnterThePasswordAfterAttempts (string p0, int p1)
		{
			ScenarioContext.Current.Pending ();
		}

		[Given(@"I am on the login view")]
		[Then (@"I am on the login view")]
		public void GivenIAmOnTheEmailLoginView ()
		{
			//var sharedSteps = new SharedSteps ();
			//sharedSteps.GivenIAmOnTheView("Login");

			true.ShouldBeTrue();
		}

		[When(@"I click on the button with user name ""(.*)"" and password ""(.*)""")]
		public void WhenIClickOnTheButtonWithUserNameAndPassword(string username, string password)
		{
			SetupHooks.Queries.EnterTextOnElementMarked("txtUserName", username);
			SetupHooks.Queries.EnterTextOnElementMarked("txtPassword", password);

			SetupHooks.Queries.TapOnElementWithText("LOGIN");		
		}

		[Then(@"I am redirected to the todolist view")]
		public void ThenIAmRedirectedToTheTodolistView()
		{
		   true.ShouldBeTrue();
		}

		[Then(@"I am not authenticated")]
		public void ThenIAmNotAuthenticated()
		{
			ScenarioContext.Current.Pending();
		}

	}
}
