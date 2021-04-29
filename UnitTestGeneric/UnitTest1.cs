﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Generics;

namespace UnitTestGeneric
{
    [TestClass]
    public class UnitTest1
    {/* TC1.1:- Given Max Number at 1st Position return the Same Number. 
                - Ensure the test data has Max Number in the First position. 
      */
        [TestMethod]
        [DataRow(55, 3, 5, 55)]
        
        public void FindMaxNumberat1stPosition(int num1, int num2, int num3, int expected)
        {
            FindMaximumNum maxOfIntegers = new FindMaximumNum();

            int actual = maxOfIntegers.FindMaxInteger(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }

        /* TC1.2:- Given Max Number at 2nd Position return the Same Number.
                   - Ensure the test data has Max Number in the Second position. 
      */
        [TestMethod]
        [DataRow(55, 599, 5, 599)]

        public void FindMaxNumberat2ndPosition(int num1, int num2, int num3, int expected)
        {
            FindMaximumNum maxOfIntegers = new FindMaximumNum();

            int actual = maxOfIntegers.FindMaxInteger(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }

        /* TC1.3:- Given Max Number at 3rd Position return the Same Number.
                   - Ensure the test data has Max Number in the Third position. 
      */
        [TestMethod]
        [DataRow(55, 599, 5100, 5100)]

        public void FindMaxNumberat3rdPosition(int num1, int num2, int num3, int expected)
        {
            FindMaximumNum maxOfIntegers = new FindMaximumNum();

            int actual = maxOfIntegers.FindMaxInteger(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }


    }
}
