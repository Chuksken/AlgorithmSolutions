using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSolutions
{
    

    
class A_Finding_middle_element_in_a_linked_list
    {
        public int data;
        public A_Finding_middle_element_in_a_linked_list next;
    }

    class NodeOperation
    {

        // Function to add a new node
        public void pushNode(ref A_Finding_middle_element_in_a_linked_list head_ref, int data_val)
        {

            // Allocate node
            A_Finding_middle_element_in_a_linked_list new_node = new A_Finding_middle_element_in_a_linked_list();

            // Put in the data
            new_node.data = data_val;

            // Link the old list of the new node
            new_node.next = head_ref;

            // move the head to point to the new node
            head_ref = new_node;
        }
    }

    public class GFG
    {
        static public void Main()
        {
            Node head = null;
            NodeOperation temp = new NodeOperation();
            for (int i = 5; i > 0; i--)
            {
                temp.pushNode(ref head, i);
            }
            List<int> v = new List<int>();
            while (head != null)
            {
                v.Add(head.data);
                head = head.next;
            }
            Console.Write("Middle Value Of Linked List is : ");
            Console.Write(v[v.Count / 2]);
            Console.WriteLine();
        }
    }

}
