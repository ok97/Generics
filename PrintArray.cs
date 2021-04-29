using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PrintArray
    { /* UC1:- Given an array of Integer, Double and Character, write a program to print the same.
               - Create PrintArray class and define toPrint method to print corresponding elements to console.
       */
        public static void ToPrintInteger(int [] arr) // create ToPrintInteger Method
        {
            Console.Write("Display Integer Array :- ");
            foreach (var element in arr) //
            {
                Console.Write(element + " "); // Print item in int array
            }
        } public static void ToPrintdouble(double[] arr) //create ToPrintdouble Method
        {
            Console.Write("\nDisplay Double Array:- ");
            foreach (var element in arr)//
            {
                Console.Write(element + " "); //Print item in double array
            }
        } public static void ToPrintCharachter(char[] arr) //create ToPrintCharachter Method
        {
            Console.Write("\nDisplay Character Array:- "); //print item in array
            foreach (var element in arr) //
            {
                Console.Write(element + " "); //print item in char array
            }
        }
       
        }
    }
}
