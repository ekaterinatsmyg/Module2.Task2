using System;
using System.Collections.Generic;
using System.Linq;
using MentoringD1D2.Module2.Task2.Extensions;
using MentoringD1D2.Module2.Task2.Extensions.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MentoringD1D2.Module2.Task2.Tests
{
    [TestClass]
    public class ArrayStringExtensionTest
    {
        private readonly string[] _arrayOfStrings =
        {
            "quiy",
            null,
            "do",
            null,
            "winter",
            "deLimeter",
            "121_number",
            "wonderful",
            "air",
            "История",
            "string",
            "stringExample",
            "mark",
            "человек",
            "902 ^bb",
            "#$!",
            "Da"
        };

        private readonly List<string> _listOfStrings = new List<string>
        {
            "quiy",
            null,
            "do",
            null,
            "winter",
            "deLimeter",
            "121_number",
            "wonderful",
            "air",
            "История",
            "string",
            "stringExample",
            "mark",
            "человек",
            "902 ^bb",
            "#$!",
            "Da"
        };

        [TestMethod]
        public void DefaultSortTest()
        {
            _listOfStrings.Sort();
            CollectionAssert.AreEqual(_listOfStrings.ToArray(),_arrayOfStrings.CustomSort());
        }


        [TestMethod]
        public void DescendingSortTest()
        {
            _listOfStrings.Sort();
            CollectionAssert.AreEqual(_listOfStrings.OrderByDescending(x => x).ToArray(), _arrayOfStrings.CustomSort(StringComparison.OrdinalIgnoreCase, SortOrder.Descending));
        }

        [TestMethod]
        public void CaseSensitiveSortTest()
        {
            StringComparer stringComparer = StringComparer.Ordinal;
            _listOfStrings.Sort(stringComparer);
            CollectionAssert.AreEqual(_listOfStrings.OrderByDescending(x => x).ToArray(), _arrayOfStrings.CustomSort(StringComparison.OrdinalIgnoreCase, SortOrder.Descending));
        }


        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void SortNullTest()
        {
            string[] array = null;
            array.CustomSort();
        }


        [TestMethod]
        public void SortEmptyTest()
        {
            string[] expected = new string[] {};
           CollectionAssert.AreEqual(expected, expected.CustomSort());
        }
    }
}
