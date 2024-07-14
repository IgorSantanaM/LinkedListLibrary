using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public class List
    {
        private ListNode firstNode;
        private ListNode lastNode;
        private string name;

        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        public List() : this("list") { }

        public void InsertAtFront(object insertItem)
        {
            if (IsEmpty())
                firstNode = lastNode = new ListNode(insertItem);
            else
                firstNode = new ListNode(insertItem, firstNode);
        }

        public void InsertAtBack(object insertItem)
        {
            if (IsEmpty())
                firstNode = lastNode = new ListNode(insertItem);
            else
                lastNode = lastNode.Next = new ListNode(insertItem);
        }

        public object RemoveFromFront()
        {
            if (IsEmpty())
                throw new EmptyListException(name);

            object removeItem = firstNode.Data;

            if (firstNode == lastNode)
                firstNode = lastNode = null;
            else
                firstNode = firstNode.Next;

            return removeItem;
        }

        public object RemoveFromBack()
        {
            if (IsEmpty())
                throw new EmptyListException(name);

            object removeItem = lastNode.Data;

            if (firstNode == lastNode)
                firstNode = lastNode = null;
            else
            {
                ListNode current = firstNode;
                while (current.Next != lastNode)
                    current = current.Next;

                lastNode = current;
                current.Next = null;
            }

            return removeItem;
        }

        public bool IsEmpty() => firstNode == null;

        public void Display()
        {
            if (IsEmpty())
                Console.WriteLine("Empty " + name);
            else
            {
                Console.Write("The " + name + " is: ");
                ListNode current = firstNode;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
