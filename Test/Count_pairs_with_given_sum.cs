namespace AlgorithmSolutions
{



    // C# implementation of simple
    // method to find count of
    // pairs with given sum.


    class Count_pairs_with_given_sum
    {
        public static void getPairsCount(int[] arr, int sum)
        {

            int count = 0; // Initialize result

            // Consider all possible pairs
            // and check their sums
            for(int i = 0; i < arr.Length; i++)
                for(int j = i + 1; j < arr.Length; j++)
                    if((arr[i] + arr[j]) == sum)
                        count++;

            Console.WriteLine("Count of pairs is " + count);
        }

        // Driver Code
        static public void Main()
        {
            int[] arr = { 1, 5, 7, -1, 5 };
            int sum = 6;
            getPairsCount(arr, sum);
        }
    }

    // This code is contributed
    // by Sach_Code

}
