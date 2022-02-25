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

            string maxstring = new Maximum<string>("Apple", "Peach", "Banana").MaxMetode();
            int maxint = new Maximum<int>(95, 70, 68).MaxMetode();
            double maxdouble = new Maximum<double>(2.85, 9.78, 11.35).MaxMetode();
            Console.WriteLine("Maximum Value is : " + maxstring);
            Console.WriteLine("Maximum Value is : " + maxint);
            Console.WriteLine("Maximum Value is : " + maxdouble);
            Console.ReadLine();
        }
    }
}
