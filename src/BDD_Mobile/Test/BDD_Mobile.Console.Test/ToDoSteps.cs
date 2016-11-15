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
    using System.Linq;

    using BDDMobile.Pages;
    using BDDMobile.Shared.Enums;
    using Microsoft.Practices.Unity;

    using Prism.Common;

    using Xamarin.Forms;

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

        [Then(@"the first item name is ""(.*)""")]
        public void ThenTheFirstItemNameIs(string name)
        {
            GetCurrentViewModel<TodoListPageViewModel>().TodoItems.First().Name.ShouldEqual(name);
        }

        [Then(@"the last item name is ""(.*)""")]
        public void ThenTheLastItemNameIs(string name)
        {
            GetCurrentViewModel<TodoListPageViewModel>().TodoItems.Last().Name.ShouldEqual(name);
        }

        [When(@"I tap on the item with name ""(.*)""")]
        public void WhenITapOnTheItemWithName(string name)
        {
            var item = GetCurrentViewModel<TodoListPageViewModel>().TodoItems.Single(x => x.Name == name);

            // simulates tap item
            GetCurrentViewModel<TodoListPageViewModel>().SelectedTodoItem = item;
        }

        [Then(@"I am on the TodoItemDetail Page")]
        public void ThenIAmOnTheTodoItemDetailPage()
        { 
           GetViewModel<TodoItemDetailPageViewModel>().GetType().ShouldEqualType<TodoItemDetailPageViewModel>();
        }

        [Then(@"the item name is ""(.*)""")]
        public void ThenTheItemNameIs(string name)
        {
            GetViewModel<TodoItemDetailPageViewModel>().TodoItem.Name.ShouldEqual(name);
        }

        [Then(@"the item description is ""(.*)""")]
        public void ThenTheItemDescriptionIs(string description)
        {
            GetViewModel<TodoItemDetailPageViewModel>().TodoItem.Description.ShouldEqual(description);
        }

        [Then(@"the item status is ""(.*)""")]
        public void ThenTheItemStatusIs(TodoStatus status)
        {
            GetViewModel<TodoItemDetailPageViewModel>().TodoItem.TodoStatus.ShouldEqual(status);
        }

        private TViewModel GetViewModel<TViewModel>()
        {  
            var page = ((NavigationPage)Resolver.Instance.Resolve<IApplicationProvider>().MainPage).CurrentPage;
            return (TViewModel)page.BindingContext;
        }
    }
}