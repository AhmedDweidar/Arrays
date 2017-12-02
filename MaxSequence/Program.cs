using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 30, 31, 32, 50, 52, 59, 45 };
            Array.Sort(numbers);
            Print(numbers);
            int result = FindMaxSequence(numbers);
            Console.WriteLine("The max sequence is: {0}", result);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static int FindMaxSequence(int[] array)
        {
            int currentSequenceCount = 1; // holds the current sequence
            int maxSequence = 1; // holds the max sequence count found in the array
            
            for (int i = 0; i < array.Length; i++)
            {
                // to avoid IndexOutOfRange error
                if (i + 1 < array.Length)
                {
                    // increment the sequence count if the next number in the array is either the same number or greater by one
                    if ((array[i] == array[i + 1]) || ((array[i] + 1) == array[i + 1]))
                    {
                        currentSequenceCount++;
                    }
                    // goes here once the sequence has been broken
                    else
                    {
                        // once the sequence breaks, maxSequence is updated if currentSequenceCount is greater
                        if (currentSequenceCount > maxSequence)
                        {
                            maxSequence = currentSequenceCount;
                        }
                        // resets for next iteration through array
                        currentSequenceCount = 1;
                    }
                }

                // once you reach the end of the array, check to see if maxSequence should be updated
                if (i + 1 == array.Length && currentSequenceCount > maxSequence)
                {
                    maxSequence = currentSequenceCount;
                }
            }

            return maxSequence;
        }

        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
