using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    public class FindMaximumNum // class
    {/*UC1:- Given 3 Integers find the maximum - Ensure to test code with the Test Case. 
            - To ensure your Code works you need 3 test cases with Max Number at 1st, 2ndand 3rd.
            - Use Integer Object and compareTo method to test the maximum number.
        */
        public int FindMaxInteger(int num1, int num2, int num3) //method
        {
            var MaxResult = (num1.CompareTo(num2) > 0 ? num1 : (num2.CompareTo(num3) > 0 ? num2 : num3));
            Console.WriteLine($"Maximum Integer Number is :- {MaxResult}");
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
        /* UC2:- Given 3 Floats find the maximum. 
                 - Ensure to test code with the Test Case and repeat with the similar 3 Test cases in UC 1
        */
        public double FindMaxFloat(double num1, double num2, double num3) //method
        {
            double MaxResult = (num1.CompareTo(num2) > 0 ? num1 : (num2.CompareTo(num3) > 0 ? num2 : num3));
            Console.WriteLine($"Maximum Float Number is :- {MaxResult}");
            return MaxResult;
        }

        /* UC3:- Given 3 Strings find the maximum. 
                 - Ensure to test code with the Test Case and repeat with the similar 3 Test cases in. 
                 - E.g. Apple Peach Banana.
        */

        public string FindMaxString(string str1, string str2, string str3) //method
        {
            string MaxResult = (str1.CompareTo(str2) > 0 ? str1 : (str2.CompareTo(str3) > 0 ? str2 : str3));
            Console.WriteLine($"Maximum String Number is :- {MaxResult}");
            return MaxResult;
        }
       
    }


    /* UC4:- Extend the max method to take more then three parameters. 
             - Use Options and use Sorting
    */
    public class Takemorethenthreeparameters<T> where T:IComparable //class
    {
        T[] array;
        public Takemorethenthreeparameters(T[] array) //constructor
        {
            this.array = array;
        }
        public T GetMaxUsingSort() //Create GetMaxUsingSort method
        {
            Array.Sort(array); //Array.Sort() method is used to sort an array Asc.
            var maximum = this.array[this.array.Length - 1]; //
            //Console.WriteLine($"Maximun Number is:- {maximum}"); //print maximum number
            printMax(maximum); //pas maximum value printMax method
            return maximum;
        }
        /* UC5:- Extend the max method to also print the max to std out using Generic Method 
                 - Write printMax Generic Method which is internally called from testMaximum.
        */
        static void printMax(T maximum) //create printMax method
        {
            Console.WriteLine($"Maximum Number is:- {maximum}"); //print maximum value
        }

    }
    public class Run
    {
        public static void Main(string[] args) //Main method
        {
            FindMaximumNum FindMaxInt = new FindMaximumNum();

            // Console.WriteLine(FindMaxInt.FindMaxInteger(10, 20, 30)); //calling method and passing parameter

           // FindMaxInt.FindMaxInteger(10, 20, 150);//calling method and passing parameter //Call UC1

           // FindMaxInt.FindMaxFloat(50.4, 890.2, 159.89);//calling method and passing parameter //Call UC2

            //FindMaxInt.FindMaxString("Apple", "Peach", "Banana");//calling method and passing parameter //Call UC3


            /* UC4:- Extend the max method to take more then three parameters. 
                     - Use Options and use Sorting
            */

            int[] intArr = { 10, 20, 30 ,99};
            double[] doubleArr = { 10.15, 80.89, 30.69, 87.58 };
            string[] stringArr = { "Apple", "Peach", "Banana","Omprakash" };

            new Takemorethenthreeparameters<int>(intArr).GetMaxUsingSort(); //Calling Generic method integer array
            new Takemorethenthreeparameters<double>(doubleArr).GetMaxUsingSort(); //Calling Generic method double array
            new Takemorethenthreeparameters<string>(stringArr).GetMaxUsingSort(); //Calling Generic method string array


            Console.ReadLine();


        }
    }




}
