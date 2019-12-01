using System;
using System.Collections.Generic;

namespace ThreeNumberSum
{
    public class Program
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

            for(int i = 0; i < array.Length -2; i++)
            {
                var left = i + 1;
                var right = array.Length - 1;

                while(left < right)
                {
                    var currentSum = array[i] + array[left] + array[right];

                    if(currentSum == targetSum)
                    {
                        triplets.Add(new int[] { array[i],  array[left], array[right] });

                        left++;
                        right--;
                    }
                    else if( currentSum < targetSum)
                    {
                        left++;
                    }
                    else if(currentSum > targetSum)
                    {
                        right--;
                    }
                }
            }




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
