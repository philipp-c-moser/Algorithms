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


            Console.ReadKey();
        }


        private static int Count(IEnumerable<int> list)
        {
            // If the list doesn't contain any items.
            if (!list.Any())
            {
                return 0;
            }

            return 1;
        }

    }
}
