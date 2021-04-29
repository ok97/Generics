using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        /* TC2.1:- Given Max Number at 1st Position return the Same Number. 
                - Ensure the test data has Max Number in the First position. 
      */
        [TestMethod]
        [DataRow(55.25, 3.3, 10.5, 55.25)]

        public void FindMaxFloatNumberat1stPosition(double num1, double num2, double num3, double expected)
        {
            FindMaximumNum maxOffloat = new FindMaximumNum();

            double actual = maxOffloat.FindMaxFloat(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }


        /* TC2.2:- Given Max Number at 2nd Position return the Same Number. 
                - Ensure the test data has Max Number in the First position. 
      */
        [TestMethod]
        [DataRow( 3.3, 55.25, 10.5, 55.25)]

        public void FindMaxFloatNumberat2stPosition(double num1, double num2, double num3, double expected)
        {
            FindMaximumNum maxOffloat = new FindMaximumNum();

            double actual = maxOffloat.FindMaxFloat(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }



        /* TC2.3:- Given Max Number at 3rd Position return the Same Number. 
                - Ensure the test data has Max Number in the First position. 
      */
        [TestMethod]
        [DataRow(3.3,  10.5, 55.25, 55.25)]

        public void FindMaxFloatNumberat3rdPosition(double num1, double num2, double num3, double expected)
        {
            FindMaximumNum maxOffloat = new FindMaximumNum();

            double actual = maxOffloat.FindMaxFloat(num1, num2, num3);

            Assert.AreEqual(expected, actual);
        }


        /* TC3.1:- Given Max String Number at 1st Position return the Same Number. 
                - Ensure the test data has Max Number in the First position. 
      */
        [TestMethod]
        [DataRow("Peach", "Apple", "Banana", "Peach")]

        public void FindMaxStringNumberat1stPosition(string str1, string str2, string str3, string expected)
        {
            FindMaximumNum maxOfString = new FindMaximumNum();

            string actual = maxOfString.FindMaxString(str1, str2, str3);

            Assert.AreEqual(expected, actual);
        }


        /* TC3.2:- Given Max String Number at 2nd Position return the Same Number. 
                - Ensure the test data has Max Number in the First position. 
      */
        [TestMethod]
        [DataRow("Apple", "Peach", "Banana", "Peach")]

        public void FindMaxStringNumberat2ndPosition(string str1, string str2, string str3, string expected)
        {
            FindMaximumNum maxOfString = new FindMaximumNum();

            string actual = maxOfString.FindMaxString(str1, str2, str3);

            Assert.AreEqual(expected, actual);
        }
        /* TC3.3:- Given Max String Number at 3rd Position return the Same Number. 
               - Ensure the test data has Max Number in the First position. 
     */
        [TestMethod]
        [DataRow("Apple", "Banana", "Peach", "Peach")]

        public void FindMaxStringNumberat3rdPosition(string str1, string str2, string str3, string expected)
        {
            FindMaximumNum maxOfString = new FindMaximumNum();

            string actual = maxOfString.FindMaxString(str1, str2, str3);

            Assert.AreEqual(expected, actual);
        }


    }
}
