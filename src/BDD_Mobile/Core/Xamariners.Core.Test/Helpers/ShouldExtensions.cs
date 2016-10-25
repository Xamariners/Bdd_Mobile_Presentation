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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace Xamariners.Core.Test.Helpers
{

    /// <summary>
    ///     UnitTesting extensions
    /// </summary>
    public static partial class Extensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// Pass an assertion if a list is empty
        /// </summary>
        /// <param name="list">
        /// list of items
        /// </param>
        public static void ShouldBeEmpty(this IEnumerable list)
        {
            int numberOfItems = GetNumberOfItems(list);
            if (numberOfItems != 0)
            {
                Assert.Fail("Should be empty but contains {0} items.", numberOfItems);
            }
        }

        /// <summary>
        /// Pass an assertion if it is false
        /// </summary>
        /// <param name="expression">
        /// Logic expression
        /// </param>
        public static void ShouldBeFalse(this bool expression)
        {
            if (expression)
            {
                Assert.Fail("Should not be true but is.");
            }
        }

        /// <summary>
        /// Pass an assertion if a first operator is greater then a second operator
        /// </summary>
        /// <param name="firstOperator">
        /// First operator
        /// </param>
        /// <param name="secondOperator">
        /// Second operator
        /// </param>
        /// <typeparam name="T">
        /// Type of operators
        /// </typeparam>
        public static void ShouldBeGreaterThan<T>(this T firstOperator, T secondOperator) where T : IComparable
        {
            if (firstOperator.CompareTo(secondOperator) <= 0)
            {
                Assert.Fail("{0} should be greater than {1}", firstOperator, secondOperator);
            }
        }

        /// <summary>
        /// Pass an assertion if a first operator is greater then or equal to a second operator
        /// </summary>
        /// <param name="firstOperator">
        /// First operator
        /// </param>
        /// <param name="secondOperator">
        /// Second operator
        /// </param>
        /// <typeparam name="T">
        /// Type of operators
        /// </typeparam>
        public static void ShouldBeGreaterThanOrEqualTo<T>(this T firstOperator, T secondOperator) where T : IComparable
        {
            if (firstOperator.CompareTo(secondOperator) < 0)
            {
                Assert.Fail("{0} should be greater than or equal to {1}", firstOperator, secondOperator);
            }
        }

        /// <summary>
        /// Pass an assertion if a first operator is less then a second operator
        /// </summary>
        /// <param name="firstOperator">
        /// First operator
        /// </param>
        /// <param name="secondOperator">
        /// Second operator
        /// </param>
        /// <typeparam name="T">
        /// Type of operators
        /// </typeparam>
        public static void ShouldBeLessThan<T>(this T firstOperator, T secondOperator) where T : IComparable
        {
            if (firstOperator.CompareTo(secondOperator) >= 0)
            {
                Assert.Fail("{0} should be less than {1}", firstOperator, secondOperator);
            }
        }

        /// <summary>
        /// Pass an assertion if a first operator is less then or equal to a second operator
        /// </summary>
        /// <param name="firstOperator">
        /// First operator
        /// </param>
        /// <param name="secondOperator">
        /// Second operator
        /// </param>
        /// <typeparam name="T">
        /// Type of operators
        /// </typeparam>
        public static void ShouldBeLessThanOrEqualTo<T>(this T firstOperator, T secondOperator) where T : IComparable
        {
            if (firstOperator.CompareTo(secondOperator) > 0)
            {
                Assert.Fail("{0} should be less than or equal to {1}", firstOperator, secondOperator);
            }
        }

        /// <summary>
        /// Pass assertion if object is null
        /// </summary>
        /// <param name="value">
        /// object
        /// </param>
        public static void ShouldBeNull(this object value)
        {
            if (value != null)
            {
                Assert.Fail("Should be null but is not.");
            }
        }

        /// <summary>
        /// Pass assertion if string is null or empty
        /// </summary>
        /// <param name="value">
        /// object
        /// </param>
        public static void ShouldBeNullOrEmpty(this string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                Assert.Fail("Should be null or empty but is not.");
            }
        }

        /// <summary>
        /// Pass assertion if string is null or empty
        /// </summary>
        /// <param name="value">
        /// object
        /// </param>
        public static void ShouldBeNullOrEmpty(this Guid value)
        {
            if (value != null || value != Guid.Empty)
            {
                Assert.Fail("Should be null or empty but is not.");
            }
        }

        /// <summary>
        /// Pass assertion if string is null or empty
        /// </summary>
        /// <param name="value">
        /// object
        /// </param>
        public static void ShouldNotBeNullOrEmpty(this Guid value)
        {
            if (value == null || value == Guid.Empty)
            {
                Assert.Fail("Should not be null or empty but is not.");
            }
        }

        /// <summary>
        /// Pass an assertion if object is kind of type
        /// </summary>
        /// <param name="value">
        /// object
        /// </param>
        /// <typeparam name="T">
        /// type
        /// </typeparam>
        public static void ShouldBeOfType<T>(this object value)
        {
            if (value.GetType() != typeof(T))
            {
                Assert.Fail("Object of type: {0} should be of type: {1}", value.GetType(), typeof(T));
            }
        }

        /// <summary>
        /// Pass an assertion if it is true
        /// </summary>
        /// <param name="expression">
        /// Logic expression
        /// </param>
        public static void ShouldBeTrue(this bool expression)
        {
            if (!expression)
            {
                Assert.Fail("Should be true but is false.");
            }
        }

       
        /// <summary>
        /// Pass an assertion if a first operator contains the second operator
        /// </summary>
        /// <param name="firstOperator">
        /// First operator
        /// </param>
        /// <param name="secondOperator">
        /// Second operator
        /// </param>
        /// <typeparam name="T">
        /// Type of operators
        /// </typeparam>
        public static void ShouldContain(this string firstOperator, string secondOperator)
        {
            if (!firstOperator.Contains(secondOperator))
            {
                Assert.Fail("{0} should contain {1}", firstOperator, secondOperator);
            }
        }

        /// <summary>
        /// Pass an assertion if a first operator is equal to a second operator
        /// </summary>
        /// <param name="firstOperator">
        /// First operator
        /// </param>
        /// <param name="secondOperator">
        /// Second operator
        /// </param>
        /// <typeparam name="T">
        /// Type of operators
        /// </typeparam>
        public static void ShouldEqual<T>(this T firstOperator, T secondOperator) where T : IComparable
        {
            if (firstOperator.CompareTo(secondOperator) != 0)
            {
                Assert.Fail("{0} should equal {1}", firstOperator, secondOperator);
            }
        }

        /// <summary>
        /// Pass an assertion if object has property with name specified
        /// </summary>
        /// <param name="type">
        /// Type of object
        /// </param>
        /// <param name="propertyName">
        /// Property name
        /// </param>
        public static void ShouldHaveProperty(this Type type, string propertyName)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(type);
            if (properties != PropertyDescriptorCollection.Empty && properties.Count > 0)
            {
                PropertyDescriptor property = properties.Find(propertyName, false);
                if (property != null)
                {
                    return;
                }
            }

            Assert.Fail("{0} should have property {1}", type.Name, propertyName);
        }
        

        /// <summary>
        /// Pass an assertion if a list is not empty
        /// </summary>
        /// <param name="list">
        /// list of items
        /// </param>
        public static void ShouldNotBeEmpty(this IEnumerable list)
        {
            int numberOfItems = GetNumberOfItems(list);
            if (numberOfItems == 0)
            {
                Assert.Fail("Should contain items but is empty.");
            }
        }

        /// <summary>
        /// Pass an assertion if object is not null
        /// </summary>
        /// <param name="value">
        /// object
        /// </param>
        public static void ShouldNotBeNull(this object value)
        {
            if (value == null)
            {
                Assert.Fail("Should not be null but is.");
            }
        }

        /// <summary>
        /// Pass assertion if string is null or empty
        /// </summary>
        /// <param name="value">
        /// object
        /// </param>
        public static void ShouldNotBeNullOrEmpty(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Assert.Fail("Should not be null or empty but is.");
            }
        }

        /// <summary>
        /// Pass an assertion if a first operator is equal to a second operator
        /// </summary>
        /// <param name="firstOperator">
        /// First operator
        /// </param>
        /// <param name="secondOperator">
        /// Second operator
        /// </param>
        /// <typeparam name="T">
        /// Type of operators
        /// </typeparam>
        public static void ShouldNotEqual<T>(this T firstOperator, T secondOperator) where T : IComparable
        {
            if (firstOperator.CompareTo(secondOperator) == 0)
            {
                Assert.Fail("{0} should not equal {1}", firstOperator, secondOperator);
            }
        }

       

        #endregion
    }
}