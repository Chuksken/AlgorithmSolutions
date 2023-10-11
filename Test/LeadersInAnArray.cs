namespace Test
{


    // C# program to print
    // leaders in array

    class LeadersInAnArray
    {
        void printLeaders(int[] arr,
                        int size)
        {
            for(int i = 0; i < size; i++)
            {
                int j;
                for(j = i + 1; j < size; j++)
                {
                    if(arr[i] <= arr[j])
                        break;
                }

                // the loop didn't break
                if(j == size)
                    Console.Write(arr[i] + " ");
            }
        }

        // Driver Code
        public static void Main()
        {
            LeadersInAnArray lead = new LeadersInAnArray();
            int[] arr = new int[] { 16, 17, 4, 3, 5, 2 };
            int n = arr.Length;
            lead.printLeaders(arr, n);
        }
    }

    // This code is contributed by
    // Akanksha Rai(Abby_akku)

}
