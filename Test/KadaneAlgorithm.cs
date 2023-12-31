﻿// C# program to print largest
// contiguous array sum
//Write an efficient program to find the sum of contiguous subarray within
//a one-dimensional array of numbers that has the largest sum. 
using System;

class GFG
{
    static int maxSubArraySum(int[] a)
    {
        int size = a.Length;
        int max_so_far = int.MinValue,
            max_ending_here = 0;

        for(int i = 0; i < size; i++)
        {
            max_ending_here = max_ending_here + a[i];

            if(max_so_far < max_ending_here)
                max_so_far = max_ending_here;

            if(max_ending_here < 0)
                max_ending_here = 0;
        }

        return max_so_far;
    }

    // Driver code
    public static void Main()
    {
        int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
        Console.Write("Maximum contiguous sum is " +
                                maxSubArraySum(a));
    }

}

// This code is contributed by Sam007_
