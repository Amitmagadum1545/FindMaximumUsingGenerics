using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUsingGenerics
{
    internal class Maximum<T>
    {
        public T[] generalValue;

        public Maximum(T[] generalValue)
        {
            this.generalValue = generalValue;
        }

        public static T FindMaximum(T[] generalValue)
        {
            Array.Sort(generalValue);
            Array.Reverse(generalValue);
            return generalValue[0];
        }
        public T MaxMetode()
        {
            T Max =FindMaximum(this.generalValue);
            return Max;
        }
    }
}
