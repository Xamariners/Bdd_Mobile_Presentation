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
using Prism.Logging;
using Prism.Unity.Navigation;
using SpecFlow.XForms;
using SpecFlow.XFormsDependency;
using SpecFlow.XFormsNavigation;

namespace BDDMobile.UnitTest
{
    public class TodoAppTest : TestApp
    {
        protected override void SetViewModelMapping()
        {
            TestViewFactory.EnableCache = false;
            RegisterView<TodoListPage, TodoListPageViewModel>();
        }
        
       
        protected override void InitialiseContainer()
        {
            Resolver.Instance.Register<Prism.Navigation.INavigationService, UnityPageNavigationService>();
            Resolver.Instance.Register<IUnityContainer, UnityContainer>();
            Resolver.Instance.Register<IApplicationProvider, ApplicationProvider>();
            Resolver.Instance.Register<ILoggerFacade, DebugLogger>();
            Resolver.Instance.Register<IDataService, FakeDataService>(LifetimeScopeEnum.Singleton);

            base.InitialiseContainer();
        }
    }
}