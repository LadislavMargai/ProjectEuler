using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ProjectEulerTests
{
    [TestFixture]
    public class Problem003
    {
        public IEnumerable<int> GetPrimeFactorsOfNumber(long number)
        {
            long sum = 1;

            for (var i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum *= i;

                    if (sum <= number)
                    {
                        yield return i;
                    }
                    else
                    {
                        break; 
                    }
                }
            }
        }


        [TestCase(13195, new[] { 5, 7, 13, 29 })]
        public void GetPrimeFactorsOfNumber_Test(int number, IEnumerable<int> expectedResult)
        {
            Assert.AreEqual(expectedResult, GetPrimeFactorsOfNumber(number));
        }


        [TestCase(13195, 29)]
        [TestCase(600851475143, 6857)]
        public void GetLargestPrimeFactorOfNumber_Test(long number, int expectedLargestPrimeFactor)
        {
            Assert.AreEqual(expectedLargestPrimeFactor, GetPrimeFactorsOfNumber(number).Last());
        }
    }
}
