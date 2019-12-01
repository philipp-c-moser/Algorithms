using System;
using System.Collections.Generic;

namespace ThreeNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ThreeNumberSum");
            
            int[] inputValues = { 12, 3, 1, 2, -6, 5, -8, 6 };
            var targetSum = 0;

            var result = ThreeNumberSum(inputValues, targetSum);

            DisplayThreeNumberSum(result);
            

        }



        // Sample Input:    [12, 3, 1, 2, -6, 5, -8, 6], 0
        // Sample Output:   [[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]]
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            var triplets = new List<int[]>();          
            
            Array.Sort(array);



            return triplets;
        }


        private static void DisplayThreeNumberSum(List<int[]> input)
        {
            foreach (var triple in input)
            {
                var currentTriple = new System.Text.StringBuilder();
                currentTriple.Append("[");
                foreach (var tripleItem in triple)
                {
                    currentTriple.Append(" " + tripleItem + " ");
                }
                currentTriple.Append("]");

                Console.WriteLine("TripletItem: " + currentTriple.ToString());
            }
        }

    }
}
