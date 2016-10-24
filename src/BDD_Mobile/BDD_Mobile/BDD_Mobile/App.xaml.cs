using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDDMobile.ViewModels;
using BDDMobile.Pages;
using BDDMobile.Services;
using Microsoft.Practices.Unity;
using Prism.Navigation;
using Xamarin.Forms;
using Prism.Unity;

namespace BDDMobile
{
    public partial class App : PrismApplication
    {
        public INavigationService GetNavigationService()
        {
            return NavigationService;
        }

        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }
        
        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync(nameof(TodoListPage));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();

            Container.RegisterTypeForNavigation<TodoListPage>();
            Container.RegisterTypeForNavigation<TodoItemDetailPage>();
            Container.RegisterTypeForNavigation<AddTodoItemPage>();

            Container.RegisterType<IDataService, FakeDataService>(new ContainerControlledLifetimeManager());
        }
    }
}
