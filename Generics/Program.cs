//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Generics
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] intArr = { 10, 20, 30 };
//            double[] doubleArr = { 10.15, 80.89, 30.69 };
//            char[] CharArr = { 'W', 'O', 'R', 'L','D' };

//            //PrintArray.ToPrintInteger(intArr); //calling method
//            //PrintArray.ToPrintdouble(doubleArr);//calling method
//            //PrintArray.ToPrintCharachter(CharArr);//calling method

//         /* UC2:- Given an array of Integer, Double and Character, write a program to print the same using Generics.
//         */
//            PrintArray.ToPrintArray<int>(intArr); //Calling Generic method integer array
//            PrintArray.ToPrintArray<double>(doubleArr); //Calling Generic method Double array
//            PrintArray.ToPrintArray<char>(CharArr); //Calling Generic method Character array

//            Console.ReadLine();

//        }
//    }
//}
