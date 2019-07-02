using System;
using System.Collections.Generic;

namespace DCP1
{
    class Program
    {
        // Description
        /*
         * Given a list of numbers and a number 'k', return whether any two
         * numbers from the list add up to 'k'.
         * 
         * For example, given '[10, 15, 3, 7]' and 'k' of '17', return true
         * since '10 + 7' is '17'.
         */


        // Method PrintPairs
        /*
         * Method will iterate through an array using a for loop while assigning 'temp' values to a HashSet.
         * 'temp' values are the second half of a solution to a sum.
         * These are checked for every value of the array and when a match occurs, prints out a pair.
         */

        static void PrintPairs(int[] arr, int sum, string name)
        {
            HashSet<int> s = new HashSet<int>(); 
            for (int i = 0; i < arr.Length; ++i) 
            {
                int temp = sum - arr[i]; 

                if (s.Contains(temp)) 
                {
                    Console.WriteLine("Array \"{0}\" with the given sum {1} had the pair ({2}, {3})", name, sum, arr[i], temp); 
                }
                s.Add(arr[i]);

                // Working on creating a case where if an inserted array doesn't return a pair, prints out text that states that.

                //if (!s.Contains(temp) && i == arr.Length - 1)
                //{
                //    Console.WriteLine("Array \"{0}\" with the given sum {1} did not yield a pair.", name, sum); // prints this if a pair was not found
                //}
                
            
            }
        }

        static void Main(string[] args)
        {
            int[] A = new int[] {10, 6, 3, 7};
            int n = 16;
            PrintPairs(A, n, nameof(A));

            //int[] B = new int[] { 20, -4, 5, -4};
            //int x = 1;
            //printpairs(B, x, nameof(B));
        }
    }
}
