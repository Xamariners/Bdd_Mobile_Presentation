using System;
using System.Threading.Tasks;
using BDDMobile.ViewModels;
using SpecFlow.XForms;
using TechTalk.SpecFlow;
using SpecFlow.XFormsDependency;
using SpecFlow.XFormsExtensions;
using SpecFlow.XFormsNavigation;

namespace BDDMobile.UnitTest
{
    [Binding]
    public class TodoSteps : TestStepBase
    {
        public TodoSteps(ScenarioContext scenarioContext)
            : base(scenarioContext)
        {
            // you need to instantiate your steps by passing the scenarioContext to the base
        }

        [Given(@"I am on the TodoList Page")]
        public void GivenIAmOnTheTodoListPage()
        {
            Resolver.Instance.Resolve<INavigationService>().PushAsync<TodoListPageViewModel>();
            Resolver.Instance.Resolve<INavigationService>().CurrentViewModelType.ShouldEqualType<TodoListPageViewModel>();
        }
        
        [Then(@"I should see (.*) items")]
        public void ThenIShouldSeeItems(int amount)
        {
            GetCurrentViewModel<TodoListPageViewModel>().TodoItems.Count.ShouldEqual(amount);
        }
    }
}
