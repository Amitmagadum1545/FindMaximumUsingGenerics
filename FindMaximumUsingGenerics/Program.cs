using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Find Maximum Value Using Generics");

            string[] stringArray= { "Apple", "Peach", "Banana", "Watermenone" };
            int[] intArray = { 195, 70, 268 ,90,105,205,210};
            double[] doubleArray = { 2.85, 19.78, 11.35 };

            Maximum<string> maxstring = new Maximum<string>(stringArray);
            maxstring.printMax();
            Maximum<int> maxint = new Maximum<int>(intArray);
            maxint.printMax();
            Maximum<double> maxdouble = new Maximum<double>(doubleArray);
            maxdouble.printMax();
         
            Console.ReadLine();
        }
    }
}
