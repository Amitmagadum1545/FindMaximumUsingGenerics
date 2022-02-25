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

            string maxstring = new Maximum<string>(stringArray).MaxMetode();
            int maxint = new Maximum<int>(intArray).MaxMetode();
            double maxdouble = new Maximum<double>(doubleArray).MaxMetode();
            Console.WriteLine("Maximum Value is : " + maxstring);
            Console.WriteLine("Maximum Value is : " + maxint);
            Console.WriteLine("Maximum Value is : " + maxdouble);
            Console.ReadLine();
        }
    }
}
