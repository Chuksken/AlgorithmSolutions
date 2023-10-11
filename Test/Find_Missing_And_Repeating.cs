namespace AlgorithmSolutions
{



    public class Find_Missing_And_Repeating
    {
        public static void printTwoElements(int[] arr, int n)
        {
            int[] temp = new int[n]; // Creating temp array of size n with initial values as 0.
            int repeatingNumber = -1;
            int missingNumber = -1;

            for(int i = 0; i < n; i++)
            {
                temp[arr[i] - 1]++;
                if(temp[arr[i] - 1] > 1)
                {
                    repeatingNumber = arr[i];
                }
            }
            for(int i = 0; i < n; i++)
            {
                if(temp[i] == 0)
                {
                    missingNumber = i + 1;
                    break;
                }
            }

            Console.WriteLine("The repeating number is " + repeatingNumber + ".");
            Console.WriteLine("The missing number is " + missingNumber + ".");
        }

        public static void Main()
        {
            int[] arr = { 7, 3, 4, 5, 5, 6, 2 };
            int n = arr.Length;
            printTwoElements(arr, n);
        }
    }

}
