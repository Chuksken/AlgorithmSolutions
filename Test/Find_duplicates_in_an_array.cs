namespace AlgorithmSolutions
{


    // C# implementation of the
    // above approach

    class Find_duplicates_in_an_array
    {

        // Function to find the Duplicates,
        // if duplicate occurs 2 times or
        // more than 2 times in array so, 
        // it will print duplicate value 
        // only once at output
        static void findDuplicates(int[] arr, int len)
        {

            // Initialize ifPresent as false
            bool ifPresent = false;

            // ArrayList to store the output
            List<int> al = new List<int>();

            for(int i = 0; i < len - 1; i++)
            {
                for(int j = i + 1; j < len; j++)
                {
                    if(arr[i] == arr[j])
                    {

                        // Checking if element is
                        // present in the ArrayList
                        // or not if present then break
                        if(al.Contains(arr[i]))
                        {
                            break;
                        }

                        // If element is not present in the
                        // ArrayList then add it to ArrayList
                        // and make ifPresent at true
                        else
                        {
                            al.Add(arr[i]);
                            ifPresent = true;
                        }
                    }
                }
            }

            // If duplicates is present
            // then print ArrayList
            if(ifPresent == true)
            {
                Console.Write("[" + al[0] + ", ");
                for(int i = 1; i < al.Count - 1; i++)
                {
                    Console.Write(al[i] + ", ");
                }
                Console.Write(al[al.Count - 1] + "]");
            }
            else
            {
                Console.Write("No duplicates present in arrays");
            }
        }

        // Driver code 
        static void Main()
        {
            int[] arr = { 12, 11, 40, 12,
                5, 6, 5, 12, 11 };
            int n = arr.Length;

            findDuplicates(arr, n);
        }
    }

    // This code is contributed by divyesh072019

}
