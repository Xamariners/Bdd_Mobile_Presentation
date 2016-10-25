// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Extensions.cs" company="">
//   
// </copyright>
// <summary>
//   UnitTesting extensions
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using KellermanSoftware.CompareNetObjects;


namespace Xamariners.Core.Test.Helpers
{
    /// <summary>
    ///     UnitTesting extensions
    /// </summary>
    public static partial class Extensions
    {
        #region Public Methods and Operators

        private static ComparisonConfig _config = new ComparisonConfig
        {
            AttributesToIgnore = new List<Type> {typeof (NotMappedAttribute)},
            CompareChildren = false,
            CompareFields = false,
            ComparePrivateFields = false,
            CompareProperties = true,
            MembersToIgnore =
                new List<string> {"Created", "Updated", "Completed", "Password", "CreatedBy", "CreatedByUsername", "CreatedByRole" },
            ClassTypesToIgnore = new List<Type> {typeof (DateTime), typeof (DateTime?)},
            ShowBreadcrumb = true
        };

        ///// <summary>
        ///// Compare 2 CoreObjects excluding [NotMapped] fields
        ///// </summary>
        ///// <param name="obj">
        ///// The obj.
        ///// </param>
        ///// <param name="obj2">
        ///// </param>
        ///// <returns>
        ///// The <see cref="bool"/>.
        ///// </returns>
        public static string Compare(this Object obj, Object obj2, string[] membersToIgnore = null )
        {
            if(membersToIgnore != null)
                _config.MembersToIgnore.AddRange(membersToIgnore);

            var comparer = new CompareLogic(_config);

            var result = comparer.Compare(obj, obj2);

            if (!result.AreEqual)
            {
                throw new Exception(result.DifferencesString);
                //return result.DifferencesString;
            }

            return string.Empty;
        }

        /// <summary>
        /// Returns number of items in enumerable list
        /// </summary>
        /// <param name="list">
        /// Enumerable list
        /// </param>
        /// <returns>
        /// Number of items in enumerable list
        /// </returns>
        private static int GetNumberOfItems(IEnumerable list)
        {
            var count = 0;
            var spin = list.GetEnumerator();
            while (spin.MoveNext())
            {
                count++;
            }

            return count;
        }

        #endregion


    }
}