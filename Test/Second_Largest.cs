namespace AlgorithmSolutions
{


    // C# program to find second largest 
    // element in an array 


    class Second_Largest
    {

        // Function to print the 
        // second largest elements 
        static void print2largest(int[] arr,
                                int arr_size)
        {
            int i;

            // There should be 
            // atleast two elements 
            if(arr_size < 2)
            {
                Console.Write(" Invalid Input ");
                return;
            }

            // Sort the array 
            Array.Sort(arr);

            // Start from second last element 
            // as the largest element is at last 
            for(i = arr_size - 2; i >= 0; i--)
            {

                // If the element is not 
                // equal to largest element 
                if(arr[i] != arr[arr_size - 1])
                {
                    Console.Write("The second largest " +
                                    "element is {0}\n", arr[i]);
                    return;
                }
            }

            Console.Write("There is no second " +
                            "largest element\n");
        }

        // Driver code 
        public static void Main(String[] args)
        {
            int[] arr = { 12, 35, 1, 10, 34, 1 };
            int n = arr.Length;

            print2largest(arr, n);
        }
    }

    // This code is contributed by Amit Katiyar

}
