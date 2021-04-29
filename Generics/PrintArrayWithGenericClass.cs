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
}
