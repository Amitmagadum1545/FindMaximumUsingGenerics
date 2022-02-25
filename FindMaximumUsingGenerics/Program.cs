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

            

            string maxstring= Maximum.FindMaximum("Apple", "Peach", "Banana");
            int maxint = Maximum.FindMaximum(95, 70, 68);
            double maxdouble = Maximum.FindMaximum(2.85, 9.78, 11.35);
            Console.WriteLine("Maximum Value is : " + maxstring);
            Console.WriteLine("Maximum Value is : " + maxint);
            Console.WriteLine("Maximum Value is : " + maxdouble);
            Console.ReadLine();
        }
    }
}
