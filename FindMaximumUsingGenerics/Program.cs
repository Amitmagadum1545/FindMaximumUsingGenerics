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
            string max= Maximum.FindMaximu("A","K","Q");
            Console.WriteLine("Maximum Value is : " + max);
            Console.ReadLine();
        }
    }
}
