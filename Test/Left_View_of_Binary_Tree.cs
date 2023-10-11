namespace AlgorithmSolutions
{



    // C# program to print left view of binary tree

    /* Class containing left and right child of current
    node and key value*/
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

    /* Class to print the left view */
    public class BinaryTree
    {
        public Node root;
        public static int max_level = 0;

        // recursive function to print left view
        public virtual void leftViewUtil(Node node, int level)
        {
            // Base Case
            if(node == null)
            {
                return;
            }

            // If this is the first node of its level
            if(max_level < level)
            {
                Console.Write(node.data + " ");
                max_level = level;
            }

            // Recur for left and right subtrees
            leftViewUtil(node.left, level + 1);
            leftViewUtil(node.right, level + 1);
        }

        // A wrapper over leftViewUtil()
        public virtual void leftView()
        {
            leftViewUtil(root, 1);
        }

        /* testing for example nodes */
        public static void Main(string[] args)
        {
            /* creating a binary tree and entering the nodes */
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(10);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(7);
            tree.root.left.right = new Node(8);
            tree.root.right.right = new Node(15);
            tree.root.right.left = new Node(12);
            tree.root.right.right.left = new Node(14);

            tree.leftView();
        }
    }

    // This code is contributed by Shrikant13

}
