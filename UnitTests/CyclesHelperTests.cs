using ClassWorkLibrary;
using NUnit.Framework;
using System;

namespace UnitTests
{
    public class CyclesHelperTests
    {
        [TestCase(2, 4, 16)]
        [TestCase(3, 2, 9)]
        [TestCase(-3, 2, 9)]
        [TestCase(-3, 3, -27)]
        [TestCase(0, 5, 0)]
        [TestCase(10, 0, 1)]
        public void AToPowerB_WhenABPassed_ShouldAPowerToB
            (int a, int b, int expectedResult)
        {//Ctrl+Shift+Space
            int actualResult = CyclesHelper.AToPowerB(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AToPowerB_WhenBLessZero_ShouldThrowArgumentException()
        {
            try
            {
                CyclesHelper.AToPowerB(2, -1);
            }
            catch(ArgumentException ex)
            {
                Assert.AreEqual("B should be greater than zero!",
                    ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void SomeTest_WhenCalled_ShouldReturnDoubleValue()
        {
            double actualResult = CyclesHelper.SomeMethod();

            Assert.AreEqual(9.375, actualResult, 0.001);
        }
    }
}