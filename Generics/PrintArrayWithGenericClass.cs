using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PrintArrayWithGenericClass<T>  //class

    {
        T[] array;
        public PrintArrayWithGenericClass(T[] array) //constructor
        {
            this.array = array;
        }
        public void ToPrintArray()
        {
            Console.Write("\nDisplay Array Element:- "); //Print message
            foreach (T elements in array)
            {
                Console.Write(elements + " ");  // print array element
            }
        }
    }
    class Run
    {
        public static void Main(string[] args)
        {
            int[] intArr = { 10, 20, 30 };
            double[] doubleArr = { 10.15, 80.89, 30.69 };
            char[] CharArr = { 'W', 'O', 'R', 'L', 'D' };

            new PrintArrayWithGenericClass<int>(intArr).ToPrintArray(); //Calling Generic method integer array
            new PrintArrayWithGenericClass<double>(doubleArr).ToPrintArray(); //Calling Generic method Double array
            new PrintArrayWithGenericClass<char>(CharArr).ToPrintArray(); //Calling Generic method Character array

            Console.ReadLine();  

        }
        

    }
}
