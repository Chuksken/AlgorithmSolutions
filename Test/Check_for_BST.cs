namespace AlgorithmSolutions
{


    class Check_for_BST
    {

        /* A binary tree node has data, pointer to left child
        and a pointer to right child */
        class node
        {
            public int data;
            public node left, right;
        };

        /* Helper function that allocates a new node with the
        given data and null left and right pointers. */
        static node newNode(int data)
        {
            node node = new node();
            node.data = data;
            node.left = null;
            node.right = null;
            return node;
        }

        static int maxValue(node node)
        {
            if(node == null)
            {
                return Int16.MinValue;
            }
            int value = node.data;
            int leftMax = maxValue(node.left);
            int rightMax = maxValue(node.right);

            return Math.Max(value, Math.Max(leftMax, rightMax));
        }

        static int minValue(node node)
        {
            if(node == null)
            {
                return Int16.MaxValue;
            }
            int value = node.data;
            int leftMax = minValue(node.left);
            int rightMax = minValue(node.right);

            return Math.Min(value, Math.Min(leftMax, rightMax));
        }

        /* Returns true if a binary tree is a binary search tree */
        static int isBST(node node)
        {
            if(node == null)
                return 1;

            /* false if the max of the left is > than us */
            if(node.left != null
                && maxValue(node.left) > node.data)
                return 0;

            /* false if the min of the right is <= than us */
            if(node.right != null
                && minValue(node.right) < node.data)
                return 0;

            /* false if, recursively, the left or right is not a BST
            */
            if(isBST(node.left) == 0 || isBST(node.right) == 0)
                return 0;

            /* passing all that, it's a BST */
            return 1;
        }

        /* Driver code*/
        public static void Main()
        {
            node root = newNode(4);
            root.left = newNode(2);
            root.right = newNode(5);
            // root.right.left = newNode(7);
            root.left.left = newNode(1);
            root.left.right = newNode(3);

            // Function call
            if(isBST(root) == 1)
                Console.Write("Is BST");
            else
                Console.Write("Not a BST");

        }
    }

}
