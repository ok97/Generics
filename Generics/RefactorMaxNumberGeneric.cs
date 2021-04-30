using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{/* Refactor1:- Refactor all the 3 to One Generic Method and find the maximum.
                - Ensure the Generic Type extends Comparable
                - Make the test case work.
    Refactor2:- Refactor to create Generic Class to take in 3 variables of Generic Type.
                - Ensure the Generic Type extends Comparable.
                - Write parameter constructor
                - Write testMaximum method to internally call the static testMaximum method passing the 3 instance variables
                - Define new test case to use the Generic Class
    */
    public class RefactorMaxNumberGeneric<R> where R : IComparable
    {
        public R Take_input1, Take_input2, Take_input3; // declare veriables
        public RefactorMaxNumberGeneric(R Take_input1, R Take_input2, R Take_input3) //Constructor
        {
            this.Take_input1 = Take_input1;
            this.Take_input2 = Take_input2;
            this.Take_input3 = Take_input3;
        }
        public  R getMaximum() 
        {
            var MaxResult = this.Take_input1.CompareTo(Take_input2) > 0 ? Take_input1 : (this.Take_input2.CompareTo(Take_input3) > 0 ? Take_input2 : Take_input3); //Find maximum number/result

            Console.WriteLine("Maximum Number is : " + MaxResult); // print resule

            return MaxResult;
        }

    }
    //public class Refactor
    //{
    //    static void Main(string[] args) // Main method
    //    {
    //        RefactorMaxNumberGeneric<int> intMax = new RefactorMaxNumberGeneric<int>(55, 599, 5100); //Create object and passing integer parameter
    //        intMax.getMaximum();

    //        RefactorMaxNumberGeneric<double> doubleMax = new RefactorMaxNumberGeneric<double>(3.3, 55.25, 10.5); //Create object and passing double parameter
    //        doubleMax.getMaximum();

    //        RefactorMaxNumberGeneric<string> stringMax = new RefactorMaxNumberGeneric<string>("Apple", "Banana", "Peach"); //Create object and passing string parameter
    //        stringMax.getMaximum();

    //        Console.ReadLine();
    //    }
    //}
}


