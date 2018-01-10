using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_FindTheDivisors
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0_Should_Be_Null()
        {
            Assert.IsNull(Kata.Divisors(0));
        }

        [TestMethod]
        public void Input_4_Should_Be_2()
        {
            CollectionAssert.AreEqual(new int[] { 2 }, Kata.Divisors(4));
        }

        [TestMethod]
        public void Input_6_Should_Be_2and3()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3 }, Kata.Divisors(6));
        }

        [TestMethod]
        public void Input_15_Should_Be_3and5()
        {
            CollectionAssert.AreEqual(new int[] { 3, 5 }, Kata.Divisors(15));
        }

        [TestMethod]
        public void Input_16_Should_Be2and4and8()
        {
            CollectionAssert.AreEqual(new int[] { 2, 4, 8 }, Kata.Divisors(16));
        }

        [TestMethod]
        public void Input_253_Should_Be_11and23()
        {
            CollectionAssert.AreEqual(new int[] { 11, 23 }, Kata.Divisors(253));
        }
    }

    public class Kata
    {
        public static int[] Divisors(int num)
        {
            var result = new List<int>();
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    result.Add(i);
                    if (num / i != i)
                        result.Add(num / i);
                }
            }
            return result.Count > 0 ? result.OrderBy(x => x).ToArray() : null;
        }
    }
}
