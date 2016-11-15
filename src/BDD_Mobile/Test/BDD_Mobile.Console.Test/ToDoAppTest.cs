using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.ViewModels;
using BDDMobile.Pages;
using BDDMobile.Services;
using Microsoft.Practices.Unity;
using Prism.Common;
using SpecFlow.XForms;
using SpecFlow.XFormsDependency;
using SpecFlow.XFormsNavigation;

namespace BDDMobile.UnitTest
{
    using Prism.Logging;
    using Prism.Navigation;
    using Prism.Unity.Navigation;

    using Xamarin.Forms;

    public class TodoAppTest : TestApp
    {
        protected override void SetViewModelMapping()
        {
            TestViewFactory.EnableCache = false;
            RegisterView<TodoListPage, TodoListPageViewModel>();
            RegisterView<TodoItemDetailPage, TodoItemDetailPageViewModel>();
        }
        
        protected override void InitialiseContainer()
        {
            Resolver.Instance.Register<Prism.Navigation.INavigationService, UnityPageNavigationService>(LifetimeScopeEnum.Singleton);
            Resolver.Instance.Register<IUnityContainer, UnityContainer>(LifetimeScopeEnum.Singleton);
            Resolver.Instance.Register<IApplicationProvider, ApplicationProvider>(LifetimeScopeEnum.Singleton);
            Resolver.Instance.Register<ILoggerFacade, DebugLogger>();
            Resolver.Instance.Register<IDataService, FakeDataService>(LifetimeScopeEnum.Singleton);

            base.InitialiseContainer();

        }
    }
}