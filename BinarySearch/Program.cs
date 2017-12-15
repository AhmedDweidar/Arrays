using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 56, 48, 3, 25, 17 };
            BinarySearch bs = new BinarySearch();
            var result = bs.DoBinarySearch(numbers, 48);
            bs.Print(numbers);
            Console.WriteLine(result);

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
