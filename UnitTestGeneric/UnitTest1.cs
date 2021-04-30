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
        
        public void FindMaxNumberat1stPosition(int num1, int num2, int num3, int expected) //get parametes
        {
            FindMaximumNum maxOfIntegers = new FindMaximumNum(); //create object of the class

            int actual = maxOfIntegers.FindMaxInteger(num1, num2, num3); //call method

            Assert.AreEqual(expected, actual); // compare 
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

        public void FindMaxNumberat3rdPosition(int num1, int num2, int num3 )
        {
            int expected = 5100;
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



        /* TC4.1:- Given Max Integer Number at return the Same Number. 
                - Ensure the test data has Max Number in the Array. 
      */
        [TestMethod]
        public void FindMaxNumberatPositionmorethanthreeparameter()
        {
            int[] intArr = { 99, 10, 20, 30, 5 }; //integer array
            int expected = 99; //asigin expected value
            Takemorethenthreeparameters<int> maxOfIntegers = new Takemorethenthreeparameters<int>(intArr); //create object and passing array
            int actual = maxOfIntegers.GetMaxUsingSort(); //actual call Get Max Using Sort method using Takemorethenthreeparameters generic class

            Assert.AreEqual(expected, actual);
        }


        /* TC4.2:- Given Max Double Number at return the Same Number. 
                - Ensure the test data has Max Number in the Array. 
      */
        [TestMethod]
        public void FindMaxDoubleatPositionmorethanthreeparameter()
        {
            double[] DoubleArr = {  10.1, 99.50, 20.100, 30.25, 5.8 }; //double array
            double expected = 99.50; //asigin expected value
            Takemorethenthreeparameters<double> maxOfIntegers = new Takemorethenthreeparameters<double>(DoubleArr); //create object and passing array
            double actual = maxOfIntegers.GetMaxUsingSort(); //actual call Get Max Using Sort method using Takemorethenthreeparameters generic class

            Assert.AreEqual(expected, actual);
        }

        /* TC4.3:- Given Max String Number at return the Same Number. 
               - Ensure the test data has Max Number in the Array. 
     */
        [TestMethod]
        public void FindMaxStringatPositionmorethanthreeparameter()
        {
            string[] stringArr = { "Apple", "Peach", "Banana", "Omprakash" }; //String array
            string expected = "Peach"; //asigin expected value
            Takemorethenthreeparameters<string> maxOfIntegers = new Takemorethenthreeparameters<string>(stringArr); //create object and passing array
            string actual = maxOfIntegers.GetMaxUsingSort(); //actual call Get Max Using Sort method using Takemorethenthreeparameters generic class

            Assert.AreEqual(expected, actual);
        }


        /* TC5:- Given Max String Number at return the Same Number. 
               - Ensure the test data has Max Number in the Array. 
     */
        [TestMethod]
        public void FindMaxAllatPositionmorethanthreeparameter()
        {
            int[] intArr = { 99, 10, 20, 30, 5 }; //integer array
            int iexpected = 99; //asigin expected value
            Takemorethenthreeparameters<int> maxOfIntegers = new Takemorethenthreeparameters<int>(intArr); //create object and passing array
            int iactual = maxOfIntegers.GetMaxUsingSort(); //actual call Get Max Using Sort method using Takemorethenthreeparameters generic class

            Assert.AreEqual(iexpected, iactual);
            double[] DoubleArr = { 10.1, 99.50, 20.100, 30.25, 5.8 }; //double array
            double dexpected = 99.50; //asigin expected value
            Takemorethenthreeparameters<double> maxOfdouble= new Takemorethenthreeparameters<double>(DoubleArr); //create object and passing array
            double dactual = maxOfdouble.GetMaxUsingSort(); //actual call Get Max Using Sort method using Takemorethenthreeparameters generic class

            Assert.AreEqual(dexpected, dactual);
            string[] stringArr = { "Apple", "Peach", "Banana", "Omprakash" }; //String array
            string sexpected = "Peach"; //asigin expected value
            Takemorethenthreeparameters<string> maxOfstring = new Takemorethenthreeparameters<string>(stringArr); //create object and passing array
            string sactual = maxOfstring.GetMaxUsingSort(); //actual call Get Max Using Sort method using Takemorethenthreeparameters generic class

            Assert.AreEqual(sexpected, sactual);
        }


    }
}
