﻿using System;
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
            new TestAppBootstrap().RunApplication<TodoAppTest, TodoListPageViewModel>();

        }
    }
}
