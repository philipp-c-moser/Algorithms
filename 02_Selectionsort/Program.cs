using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Selectionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02 Selectionsort");
            Console.ReadKey();
        }


        // Before writing values in a new array
        // the smallest list-item must be found
        private static int FindSmallestFrom(List<int> list)
        {
            // Save the smallest value
            int valueOfSmallest = list[0];

            // Save the index of the smallest value
            int indexOfSmallest = 0;


            // Loop all List-Items
            for (int i = 0; i < list.Count; i++)
            {
                // If the current item is smaller than
                // the first item
                if (list[i] < valueOfSmallest)
                {
                    valueOfSmallest = list[i];
                    indexOfSmallest = i;
                }
            }

            // After Looping all items
            // return the index of the smallest
            return indexOfSmallest;
        }
    }
}
