namespace AlgorithmSolutions
{



    // A simple C# program to find three elements
    // whose sum is equal to zero


    class Find_triplets_with_zero_sum
    {

        // Prints all triplets in arr[] with 0 sum
        static void findTriplets(int[] arr, int n)
        {
            bool found = false;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.Write(arr[i]);
                            Console.Write(" ");
                            Console.Write(arr[j]);
                            Console.Write(" ");
                            Console.Write(arr[k]);
                            Console.Write("\n");
                            found = true;
                        }
                    }
                }
            }

            // If no triplet with 0 sum found in
            // array
            if (found == false)
                Console.Write(" not exist ");
        }

        // Driver code
        public static void Main()
        {
            int[] arr = { 0, -1, 2, -3, 1 };
            int n = arr.Length;
            findTriplets(arr, n);
        }
    }

    // This code is contributed by nitin mittal.

}
