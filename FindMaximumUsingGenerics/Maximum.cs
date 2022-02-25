using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class Maximum
    {
        public static T FindMaximum<T>(T a ,T b ,T c )
        {

            if (Comparer<T>.Default.Compare(a, b)>=0 && Comparer<T>.Default.Compare(a , c)>=0) 
            {
                return a;
            }
            if (Comparer<T>.Default.Compare(b, c)>=0 && Comparer<T>.Default.Compare(b,a)>=0)
            {
                return b;
            }
            if (Comparer<T>.Default.Compare(c,a)>=0 && Comparer<T>.Default.Compare(c,b)>=0)
            {
                return c;
            }
            return a;
        }
    }
}
