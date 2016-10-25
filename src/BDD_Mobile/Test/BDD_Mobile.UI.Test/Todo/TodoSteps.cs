using System;
using TechTalk.SpecFlow;

namespace BDDMobile.UI.Test.Todo
{
    using Xamariners.Core.Mobile.UI.Test;
    using Xamariners.Core.Test.Helpers;

    [Binding]
    public class TodoSteps
    {
        [Given(@"I am on the TodoList Page")]
        public void GivenIAmOnTheTodoListPage()
        {
            SetupHooks.App.Repl();

            true.ShouldBeTrue();
        }
        
        [When(@"I tap on the item with name ""(.*)""")]
        public void WhenITapOnTheItemWithName(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see (.*) items")]
        public void ThenIShouldSeeItems(int items)
        {
            SetupHooks.App.Query(q => q.Id("grid_table").Child()).Length.ShouldEqual(items);
        }
        
        [Then(@"the first item name is ""(.*)""")]
        public void ThenTheFirstItemNameIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the last item name is ""(.*)""")]
        public void ThenTheLastItemNameIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am on the TodoItemDetail Page")]
        public void ThenIAmOnTheTodoItemDetailPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the item name is ""(.*)""")]
        public void ThenTheItemNameIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the item description is ""(.*)""")]
        public void ThenTheItemDescriptionIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the item status is ""(.*)""")]
        public void ThenTheItemStatusIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
