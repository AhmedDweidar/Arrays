using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Sorter<T> where T : IComparable<T>
    {
        public T FindMax(T[] array)
        {
            // set the max element as the first element in the array
            T max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                // compare i with max, if i > max then max = i
                if ((array[i].CompareTo(max)) > 0)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public T FindMin(T[] array)
        {
            // set the min element as the first element in the array
            T min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                // compare i with min, if i < max then min = i
                if ((array[i].CompareTo(min)) < 0)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}
