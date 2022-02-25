using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class Maximum<T>
    {
        public T a, b, c;

        public Maximum(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static T FindMaximum(T a ,T b ,T c )
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
        public T MaxMetode()
        {
            T Max = Maximum<T>.FindMaximum(this.a, this.b, this.c);
            return Max;
        }
    }
}
