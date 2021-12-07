using ClassWorkLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    public class ArraysHelperTests
    {
        [TestCase(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new[] { 3, -2, 1 }, new[] { -2, 1, 3 })]
        [TestCase(new[] { 2, 1 }, new[] { 1, 2})]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 3, 2, 1, 4, 0 }, new[] { 0, 1, 2, 3, 4 })]
        public void Sort_WhenArrayIsNotNull_ShouldSortArray(int[] array, int[] expectedArray)
        {
            ArraysHelper.Sort(array);

            Assert.AreEqual(expectedArray, array);
        }

        [Test]
        public void Sort_WhenArrayIsNull_ShouldThrowArgumentNullException()
        {
            try
            {
                ArraysHelper.Sort(null);
            }
            catch(ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null! (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
