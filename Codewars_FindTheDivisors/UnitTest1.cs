using System;
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
            Assert.AreEqual(new int[]{2},Kata.Divisors(4));
        }
    }

    public class Kata
    {
        public static int[] Divisors(int ints)
        {
            return null;
        }
    }
}
