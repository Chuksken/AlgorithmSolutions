namespace AlgorithmSolutions
{


    // C# Program to find the smallest
    // positive missing number

    class A_Smallest_Positive_missing_number
    {
        static int solution(int[] A)
        {
            // Our original array

            int m = A.Max(); // Storing maximum value

            // In case all values in our array are negative
            if (m < 1)
            {
                return 1;
            }
            if (A.Length == 1)
            {

                // If it contains only one element
                if (A[0] == 1)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            int i = 0;
            int[] l = new int[m];
            for (i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    // Changing the value status at the index of
                    // our list
                    if (l[A[i] - 1] != 1)
                    {
                        l[A[i] - 1] = 1;
                    }
                }
            }

            // Encountering first 0, i.e, the element with least
            // value
            for (i = 0; i < l.Length; i++)
            {
                if (l[i] == 0)
                {
                    return i + 1;
                }
            }

            // In case all values are filled between 1 and m
            return i + 2;
        }

        // Driver code
        public static void Main()
        {
            int[] arr = { 0, 10, 2, -10, -20 };
            Console.WriteLine(solution(arr));
        }
    }

    // This code is contributed by PrinciRaj1992

}
