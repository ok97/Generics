using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 10, 20, 30 };
            double[] doubleArr = { 10.15, 80.89, 30.69 };
            char[] CharArr = { 'W', 'O', 'R', 'L','D' };

            PrintArray.ToPrintInteger(intArr); //calling method
            PrintArray.ToPrintdouble(doubleArr);//calling method
            PrintArray.ToPrintCharachter(CharArr);//calling method




            Console.ReadLine();

        }
    }
}
