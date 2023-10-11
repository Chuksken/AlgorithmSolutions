namespace AlgorithmSolutions
{


    // Simple C# program to print next
    // greater elements in a given array


    class GFNext_Greater_ElementG
    {

        /* prints element and NGE pair for
        all elements of arr[] of size n */
        static void printNGE(int[] arr, int n)
        {
            int next, i, j;
            for(i = 0; i < n; i++)
            {
                next = -1;
                for(j = i + 1; j < n; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        next = arr[j];
                        break;
                    }
                }
                Console.WriteLine(arr[i] + " -- " + next);
            }
        }

        // driver code
        public static void Main()
        {
            int[] arr = { 11, 13, 21, 3 };
            int n = arr.Length;

            printNGE(arr, n);
        }
    }

    // This code is contributed by Sam007

}
