using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01 Binary Search");

            List<int> searchList = new List<int> { 4, 2, 6, 9, 1, 7, 5, 3 };

            Console.ReadKey();
        }


        // This method will return the position of the given parameter
        // If not available, it should return null
        private static int? BinarySearch(List<int> list, int searchItem)
        {
            // will save the current searching-part of list
            int lowest = 0;
            int highest = list.Count() - 1;

            while (lowest <= highest)
            {
                // Check only the element in the middle
                int middle = (lowest + highest) / 2;

                // guess, that the element in the middle will be the searched item
                int guess = list[middle];

                
                // The guessed value was to large
                if (guess > searchItem)
                {
                    highest = middle - 1;
                }
                // The guessed value was to small
                else
                {
                    lowest = middle + 1;
                }
            }

            return null;
        }
    }
}
