namespace AlgorithmSolutions
{




    class collection_share_common_elements
    {
        static void Main(string[] args)
        {
            // Create a HashSet and a List
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            List<int> list1 = new List<int> { 5, 4, 3, 2, 1 };

            // Check if the HashSet and List contain the same elements
            bool areEqual = set1.SetEquals(list1);
            Console.WriteLine("Are set1 and list1 equal? " + areEqual);

            // Create another List with different elements
            List<int> list2 = new List<int> { 6, 7, 8 };

            // Check if the HashSet and List2 contain the same elements
            bool areEqual2 = set1.SetEquals(list2);
            Console.WriteLine("Are set1 and list2 equal? " + areEqual2);

            Console.ReadLine();
        }
    }

}
