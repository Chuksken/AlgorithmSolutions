using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class SubarrayWithGgivenSum
    {

        /* Returns true if the there is a subarray of arr[] with a sum equal to
        'sum' otherwise returns false. Also, prints the result */
       public static void subArraySum(int[] arr, int n, int sum)
        {

            // Pick a starting point
            for(int i = 0; i < n; i++)
            {
                int currentSum = arr[i];

                if(currentSum == sum)
                {
                    Console.WriteLine("Sum found at indexe " + i);
                    return;
                }
                else
                {

                    // Try all subarrays starting with 'i'
                    for(int j = i + 1; j < n; j++)
                    {
                        currentSum += arr[j];

                        if(currentSum == sum)
                        {
                            Console.WriteLine("Sum found between indexes " + i + " and " + j);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No subarray found");
            return;
        }
    }
}
