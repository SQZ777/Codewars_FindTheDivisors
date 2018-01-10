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
    }

    public class Kata
    {
        public static int[] Divisors(int num)
        {
            var result = new List<int>();
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    result.Add(i);
                }
            }
            return result.Count > 0 ? result.ToArray() : null;
        }
    }
}
