﻿namespace AlgorithmSolutions
{


    // C# program to find maximum product subarray
    class Maximum_Product_Subarray
    {

        // Returns the product of max product subarray
        static int maxSubarrayProduct(int[] arr)
        {

            // Initializing result
            int result = arr[0];
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int mul = arr[i];

                // Traversing in current subarray
                for (int j = i + 1; j < n; j++)
                {

                    // Updating result every time
                    // to keep an eye over the
                    // maximum product
                    result = Math.Max(result, mul);
                    mul *= arr[j];
                }

                // Updating the result for (n-1)th index
                result = Math.Max(result, mul);
            }
            return result;
        }

        // Driver Code
        public static void Main(String[] args)
        {
            int[] arr = { 1, -2, -3, 0, 7, -8, -2 };

            Console.Write("Maximum Sub array product is "
                           + maxSubarrayProduct(arr));
        }
    }

    // This code is contributed by shivanisinghss2110

}
