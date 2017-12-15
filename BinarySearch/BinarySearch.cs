using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearch
    {
        public int DoBinarySearch(int[] arr, int target)
        {
            int min = 0;
            int max = arr.Length - 1;

            // must sort array before performing binary search
            Array.Sort(arr);

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (target > arr[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return -1;
        }

        public void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
