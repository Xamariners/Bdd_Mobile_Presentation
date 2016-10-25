using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamariners.Core.Test.Helpers
{
    using Xamariners.Core.Test.Helpers.Enums;

    public static class Utilities
    {
        public static DateTime? GetDateFromDateOption(DateOption dateOption)
        {
            if (dateOption == DateOption.None) return null;
            return dateOption == DateOption.LowerThanToday ? DateTime.UtcNow.AddDays(-7) : DateTime.UtcNow.AddDays(7);
        }
    }
}
