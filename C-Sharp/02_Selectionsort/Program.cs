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

            // List with sortable Integers
            List<int> sortingList = new List<int> { 50, 12, 72, 48, 12, 84, 3, 13, 35 };

            Console.WriteLine(string.Join(",",SelectionSort(sortingList)));

            Console.ReadKey();
        }

        private static int[] SelectionSort(List<int> list)
        {
            // Create a new Array where the sorted values will be stored
            var finalList = new int[list.Count];

            // Get the smallest value and add it to finalList
            for (int i = 0; i < finalList.Length; i++)
            {
                // Get the smallest value from current list
                int smallest = FindSmallestFrom(list);

                // Add the smallest value from list to finalList
                finalList[i] = list[smallest];

                // Because the new loop should not
                // find the current smallest value
                list.RemoveAt(smallest);
            }


            return finalList;
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
