using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem001
    {
        public IEnumerable<int> GetNaturalNumbersWhichAreMultiplesOf3Or5(int maxValue, int start = 1)
        {
            for (var i = start; i < maxValue; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    yield return i;
                }
            }
        }


        [TestCase(10, new[] { 3, 5, 6, 9 })]
        public void GetNaturalNumbersWhichAreMultiplesOf3Or5_Test(int maxValue, IEnumerable<int> expectedResult)
        {
            Assert.AreEqual(expectedResult, GetNaturalNumbersWhichAreMultiplesOf3Or5(maxValue));
        }


        [TestCase(10, 23)]
        [TestCase(1000, 233168)]
        public void GetSumOfNaturalNumbersWhichAreMultiplesOf3Or5_Test(int maxValue, int expectedSum)
        {
            Assert.AreEqual(expectedSum, GetNaturalNumbersWhichAreMultiplesOf3Or5(maxValue).Sum());
        }
    }
}