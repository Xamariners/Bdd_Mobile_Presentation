using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.ViewModels;
using SpecFlow.XForms;
using TechTalk.SpecFlow;

namespace BDDMobile.UnitTest
{
    using BDDMobile.Pages;

    using Microsoft.Practices.Unity;

    using Prism.Common;
    using Prism.Unity;

    using SpecFlow.XFormsDependency;

    using Xamarin.Forms;

    [Binding]
    public class SetupHook : TestSetupHooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            // bootstrap test app with your test app and your starting viewmodel
            var app = new TestAppBootstrap();
            app.RunApplication<TodoAppTest, TodoListPageViewModel>();

            Resolver.Instance.Resolve<IApplicationProvider>().MainPage = app.TestApp.MainPage;
            Resolver.Instance.Resolve<IUnityContainer>().RegisterTypeForNavigation<NavigationPage>();
            Resolver.Instance.Resolve<IUnityContainer>().RegisterTypeForNavigation<TodoListPage, TodoListPageViewModel>(nameof(TodoListPage));
            Resolver.Instance.Resolve<IUnityContainer>().RegisterTypeForNavigation<TodoItemDetailPage, TodoItemDetailPageViewModel>(nameof(TodoItemDetailPage));
            Resolver.Instance.Resolve<IUnityContainer>().RegisterTypeForNavigation<AddTodoItemPage, AddTodoItemPageViewModel>(nameof(AddTodoItemPage));

        }
    }
}
