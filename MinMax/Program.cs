using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] doubleArray = { 5.8, 7.3, 1.2, 8.8, 100.56, 5.1, 25.2, 9 };
            Sorter<double> sort = new Sorter<double>();
            Console.WriteLine("The max in the double array is: " + sort.FindMax(doubleArray));
            Console.WriteLine("The min in the double array is: " + sort.FindMin(doubleArray));

            int[] intArray = { 10, 25, 45, 12, 0, 89, 42, -1, 5, 1 };
            Sorter<int> sort2 = new Sorter<int>();
            Console.WriteLine("The max in the int array is: " + sort2.FindMax(intArray));
            Console.WriteLine("The min in the int array is: " + sort2.FindMin(intArray));

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
