using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamariners.Core.Test.Infrastructure
{
    using TechTalk.SpecFlow;

    public class CoreStepBase
    {
        protected readonly ScenarioContext _scenarioContext;

        public CoreStepBase(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
        }
    }
}
