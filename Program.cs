

/*
Author: Arpan Jaiswal
Date: 02/28/2024
Comments: This C# Console Application code demonstrates the
    Bubble Sort Algorithm. No input
    is required for the script. It will execute without 
    input against one pre-populated arrays. 
*/
using System;

namespace U04970974_ClassAsg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bs_arr = { 3, 62, 5, 16, 4, 10 }; // prededined array which will be sorted using bubble sort
            // The for loop will continue until the array is sorted in ascending order.
            // Bubble Sort starts from the beginning of the array each for loop iteration and checks the value
            // of the next element in the array to see if it is less. If it is less, then swap.
            for (int i = 0; i < bs_arr.Length - 1; i++)
            {
                for (int x = 0; x < bs_arr.Length - i - 1; x++)
                {
                    // In each nested for loop iteration check to see if the next element value is lower than the current element value
                    // If the next element value is less, then conduct the swap
                    if (bs_arr[x] > bs_arr[x + 1])
                    {
                        // Here you will swap temp and bs_arr[x]
                        // The temp variable is used to temporarily hold the value of the current element so that it can be swapped
                        int temp = bs_arr[x];
                        bs_arr[x] = bs_arr[x + 1];
                        bs_arr[x + 1] = temp;
                                                
                    } // End of if
                   
                } // End of inner for loop
               
            } // End of outer for loop

            for (int j=0; j < bs_arr.Length; j++)
            {
                Console.WriteLine(bs_arr[j]); // Prints the Array
            }

        }
    }
}