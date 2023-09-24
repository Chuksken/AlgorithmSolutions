namespace Test
{

    public class MissingNumberInArray
    {

        public static void findMissing(int[] arr, int N)
        {

            // this will create a new array containing 0
            int[] temp = new int[N + 1];

            for(int i = 0; i < N; i++)
            {
                temp[arr[i] - 1] = 1;
            }

            int ans = 0;
            for(int i = 0; i <= N; i++)
            {
                if(temp[i] == 0)
                    ans = i + 1;
            }
            Console.WriteLine(ans);
        }
        static public void Main()
        {
            int[] arr = { 1, 3, 7, 5, 6, 2 };
            int n = arr.Length;

            findMissing(arr, n);
        }
    }

    // This code is contributed by nikhilm2302.

}
