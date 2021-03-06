﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LinkedList
{
    class SLinkedList<T>
    {
        public Node<T> Head { get; private set; }

        /// <summary>
        /// Add a Node with data to the front of the list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            //If the head is empty
            if(Head==null)
            {
                Head = new Node<T>(data);
            }
            //If the head is not empty
            else
            {
                Node<T> nodeToAdd = new Node<T>(data, Head);
                Head = nodeToAdd;
            }
        }

        /// <summary>
        /// Add a node to the end of the list
        /// </summary>
        public void Append(T data)
        {
            Node<T> nodeToAppend = new Node<T>(data);

            Node<T> pointer = Head;

            while(pointer.Next != null)
            {
                pointer = pointer.Next;
            }
                pointer.Next = nodeToAppend;
        }

        /// <summary>
        /// Get the last value in the list
        /// </summary>
        public T GetLast()
        {
            Node<T> pointer = Head;
            while(pointer.Next!= null)
            {
                pointer = pointer.Next;
            }
            return pointer.Data;
        }

        /// <summary>
        /// Get the first value in the list
        /// </summary>
        public T GetFirst()
        {
            return Head.Data;
        }

        /// <summary>
        /// Prints the formated values of the list
        /// </summary>
        public override string ToString()
        {

            string result = "";

            //If the list is empty
            if (Head == null)
            {
                result = "null";
                return result;
            }

            //Else run through the list and make a string
            else
            {
                Node<T> pointer = Head;
                while (pointer != null)
                {
                    result += (pointer.Data + " -> ");
                    pointer = pointer.Next;
                }
                result += "null";
            }
            return result;
        }

        /// <summary>
        /// Inserts a node after a specified value
        /// </summary>
        /// <param name="value">Number to insert the node after</param>
        /// <param name="data">Data to insert</param>
        public void Insert(T data, T value)
        {
            Node<T> pointer = Head;

            //Iterate through the list while the pointer data does not equal the value
            while(!Match.Equals(pointer.Data, value))
            {
                if(pointer.Next == null)
                {
                    throw new Exception("List does not contain the given value");
                }
                pointer = pointer.Next;
            }
            Node<T> nodeToAdd = new Node<T>(data, pointer.Next);
            pointer.Next = nodeToAdd;
        }

        /// <summary>
        ///  Inserts a node into the correct location of a pre-sorted linked list which is sorted in ascending order
        /// </summary>
        public void SortedInsert(Node<int> head, int data)
        {
            if(head == null)
            {
                Node<int> node = new Node<int>(data);
                head = node;
            }
            Node<int> pointer = head;
            
            while(pointer != null)
            {
                //if the pointer data is less than given data 
                //and pointer.next data is greater than or null
                //insert the node
                if (pointer.Data <= data && pointer.Next == null)
                {
                    Node<int> nodeToAdd = new Node<int>(data);
                    pointer.Next = nodeToAdd;
                    break;
                }
                else if(pointer.Data <= data && pointer.Next.Data >= data)
                {
                    Node<int> nodeToAdd = new Node<int>(data, pointer.Next);
                    pointer.Next = nodeToAdd;
                    break;
                }
                else
                    pointer = pointer.Next;
            }
        }

        /// <summary>
        /// Returns the number of nodes in a list
        /// </summary>
        public int Length()
        {
            if (Head == null) return 0;

            int count = 0;
            Node<T> pointer = Head;

            while(pointer != null)
            {
                count += 1;
                pointer = pointer.Next;
            }

            return count;
        }

        /// <summary>
        /// Returns the count of data in the list that meets the criteria specified in the function
        /// </summary>
        public int Count(Node<T> head, Predicate<T> func)
        {
            if (head == null) return 0;
           
            int counter = 0;
            Node<T> pointer = head;

            while(pointer != null)
            {
                if(func(pointer.Data))
                {
                    counter += 1;
                }
                pointer = pointer.Next;
            }

            return counter;
        }

        /// <summary>
        /// Returns the node at the given index
        /// </summary>
        public Node<T> GetNth(Node<T> node, int index)
        {
            if (node == null)
                throw new ArgumentException();

            var pointer = node;
            int idx = 0;

            while (true)
            {

                if (pointer == null)
                {
                    throw new ArgumentException();
                }

                if (idx != index)
                {
                    idx++;
                    pointer = pointer.Next;
                }

                else
                    return pointer;
            }

        }

        /// <summary>
        /// Inserts a node at a given index
        /// </summary>
        public Node<T> InsertAt(Node<T> head, int index, T data)
        {
            if ((head == null && index > 0) || (index < 0)) throw new ArgumentOutOfRangeException("Index out of bounds");
            if (index == 0) return new Node<T>(data, head);
            head.Next = InsertAt(head.Next, --index, data);

            return head;

            #region Long Way
            //Node<T> pointer = head;
            //int count = 1;
            //Node<T> nodeToAdd = new Node<T>(data);

            //if ((head == null && index > 0) || (index < 0)) throw new ArgumentOutOfRangeException("Index out of bounds");

            ////If the list is empty add the node
            //if (head == null)
            //    head = nodeToAdd;
            ////If the index is 0 replace the head
            //else if (index == 0)
            //{
            //    nodeToAdd.Next = head;
            //    head = nodeToAdd;
            //}
            //else 
            //    try
            //    {
            //        while (count != index)
            //        {
            //            if (pointer == null)
            //            {
            //                throw new ArgumentOutOfRangeException();
            //            }
            //            count++;
            //            pointer = pointer.Next;

            //        }
            //        nodeToAdd.Next = pointer.Next;
            //        pointer.Next = nodeToAdd;
            //    }
            //    catch (Exception)
            //    {
            //        throw new ArgumentOutOfRangeException();
            //    }
            //return head;
            #endregion
        }

        public static Node<int> MergeTwoLists(Node<int> l1, Node<int> l2)
        {
            //Check edge cases
            if (l1 == null && l2 == null)
                return null;
            else if (l1 != null && l2 == null)
                return l1;
            else if(l1 == null && l2 != null)
                return l2;

            //Create Pointers
            var p1 = l1;
            var p2 = l2;
            var p3 = l1;

            //point p3 to the lowest node
            if (p1.Data <= p2.Data)
            {
                p3 = p1;
                p1 = p1.Next;
            }
            else
            {
                p3 = p2;
                p2 = p2.Next;
            }

            //Create pointer for result
            var p4 = p3;

            //iterate through each list
            while (p1 != null && p2 != null)
            {

                //point p3 to the lowest node
                if (p1.Data <= p2.Data)
                {
                    p4.Next = p1;
                    p1 = p1.Next;
                    p4 = p4.Next;
                }
                else
                {
                    p4.Next = p2;
                    p2 = p2.Next;
                    p4 = p4.Next;
                }

            }
            
            //If one list goes null, add the rest
            if(p1 == null)
            {
                p4.Next = p2;
            }
            else
            {
                p4.Next = p1;
            }
            return p3;

        }
        /*****WORKING ON THIS
        public void Reverse()
        {
            Head = ReverseHelper(Head);
        }

        private Node<T> ReverseHelper(Node<T> head)
        {
            if (head == null || head.Next == null) 
                return head;

            Node<T> pointer = ReverseHelper(head.Next);
            head.Next.Next = head;
            head.Next = null;

            return pointer;
        }
        ******/
    }


    class Node<T>
    {
        public T Data { get; private set; }
        public Node<T> Next { get; set; }

        public Node(T data, Node<T> next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
