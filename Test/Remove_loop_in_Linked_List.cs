namespace AlgorithmSolutions
{


    // A C# program to detect and remove loop in linked list

    public class LinkedList
    {

        Node head;

        public class Node
        {

            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        // Function that detects loop in the list
        int detectAndRemoveLoop(Node node)
        {
            Node slow = node, fast = node;
            while(slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                // If slow and fast meet at same
                // point then loop is present
                if(slow == fast)
                {
                    removeLoop(slow, node);
                    return 1;
                }
            }
            return 0;
        }

        // Function to remove loop
        void removeLoop(Node loop, Node head)
        {
            Node ptr1 = loop;
            Node ptr2 = loop;

            // Count the number of nodes in loop
            int k = 1, i;
            while(ptr1.next != ptr2)
            {
                ptr1 = ptr1.next;
                k++;
            }

            // Fix one pointer to head
            ptr1 = head;

            // And the other pointer to k nodes after head
            ptr2 = head;
            for(i = 0; i < k; i++)
            {
                ptr2 = ptr2.next;
            }

            /* Move both pointers at the same pace, 
            they will meet at loop starting node */
            while(ptr2 != ptr1)
            {
                ptr1 = ptr1.next;
                ptr2 = ptr2.next;
            }

            // Get pointer to the last node
            while(ptr2.next != ptr1)
            {
                ptr2 = ptr2.next;
            }

            /* Set the next node of the loop ending node 
            to fix the loop */
            ptr2.next = null;
        }

        // Function to print the linked list
        void printList(Node node)
        {
            while(node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }

        // Driver program to test above functions
        public static void Main(String[] args)
        {
            LinkedList list = new LinkedList();
            list.head = new Node(50);
            list.head.next = new Node(20);
            list.head.next.next = new Node(15);
            list.head.next.next.next = new Node(4);
            list.head.next.next.next.next = new Node(10);

            // Creating a loop for testing
            list.head.next.next.next.next.next = list.head.next.next;
            list.detectAndRemoveLoop(list.head);
            Console.WriteLine("Linked List after removing loop : ");
            list.printList(list.head);
        }
    }

    // This code contributed by Rajput-Ji

}
