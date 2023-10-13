namespace AlgorithmSolutions
{


    // C# program for the above approach

    class A_Check_if_two_arrays_are_equal_or_not
    {

        // Returns true if arr1[0..n-1] and
        // arr2[0..m-1] contain same elements.
        public static bool areEqual(int[] arr1, int[] arr2)
        {
            int N = arr1.Length;
            int M = arr2.Length;

            // If lengths of array are not
            // equal means array are not equal
            if (N != M)
                return false;

            // Sort both arrays
            Array.Sort(arr1);
            Array.Sort(arr2);

            // Linearly compare elements
            for (int i = 0; i < N; i++)
                if (arr1[i] != arr2[i])
                    return false;

            // If all elements were same.
            return true;
        }

        // Driver's code
        public static void Main()
        {
            int[] arr1 = { 3, 5, 2, 5, 2 };
            int[] arr2 = { 2, 3, 5, 5, 2 };

            // Function call
            if (areEqual(arr1, arr2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }

    // This code is contributed by anuj_67.

}
