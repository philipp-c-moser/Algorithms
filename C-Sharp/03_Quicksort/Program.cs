using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03 Quicksort");

            // Console.WriteLine(Count(new[] { 1, 2, 3, 4, 5 }));


            // QuickSort
            var sortItems = new[] { 12, 4, 8, 3, 1, 5 };
            Console.WriteLine(string.Join(", ", QuickSort()));


            Console.ReadKey();
        }


        private static IEnumerable<int> QuickSort(IEnumerable<int> list)
        {
            // If the parameter contains zero or one item
            // The list doesn't need to be sorted.
            if (list.Count() <= 1)
            {
                return list;
            }

            // select at first the first element from list
            // This element is called Pivot
            var pivot = list.First();

            // Search for elements,
            // that are smaller than pivot
            var less = list.Skip(1).Where(i => i <= pivot);


        }



        private static int Count(IEnumerable<int> list)
        {
            // If the list doesn't contain any items.
            if (!list.Any())
            {
                return 0;
            }
            
            // Call the Count() Method recursive
            return 1 + Count(list.Skip(1));
        }

    }
}
