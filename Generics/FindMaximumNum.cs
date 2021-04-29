using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaximumNum // class
    {/* UC1:- Given 3 Integers find the maximum - Ensure to test code with the Test Case. 
            - To ensure your Code works you need 3 test cases with Max Number at 1st, 2ndand 3rd.
            - Use Integer Object and compareTo method to test the maximum number.
        */
        public int FindMaxInteger(int num1, int num2, int num3) //method
        {
            var MaxResult = (num1.CompareTo(num2) > 0 ? num1 : (num2.CompareTo(num3) > 0 ? num2 : num3));
            Console.WriteLine($"Maximum Number is :- {MaxResult}");
            return MaxResult;
            //if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            //{
            //    return num1;
            //}
            //else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            //{
            //    return num2;
            //}
            //else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            //{
            //    return num3;
            //}
            //else
            //{
            //    Console.WriteLine("All number same");
            //    return 0;
            //}


        }
       public static void Main(string[] args) //Main method
        {
            FindMaximumNum FindMaxInt = new FindMaximumNum();
             
            //Console.WriteLine(FindMaxInt.FindMaxInteger(10, 20, 30)); //calling method and passing parameter

            FindMaxInt.FindMaxInteger(10, 20, 150);//calling method and passing parameter
            Console.ReadLine();
           

        }
    }
}
