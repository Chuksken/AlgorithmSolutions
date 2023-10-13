namespace AlgorithmSolutions
{


    // C# program for Fibonacci Series
    // using Space Optimized Method

    public class A_Nth_Fibonacci_Number

    {
        static int Fib(int n)
        {
            int a = 0, b = 1, c = 0;

            // To return the first Fibonacci number
            if (n == 0)
                return a;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }

        // Driver function
        public static void Main(string[] args)
        {

            int n = 9;
            Console.Write("{0} ", Fib(n));
        }
    }


    // This code is contributed by Sam007.

}
