using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrcture1
{
    public class LinkedList
    {
        internal Node head;

        internal void add(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next !=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linkedlist", node.data);
        }
        internal void display()
        {
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("linkedlist is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

        }
        internal Node InsertAtParticularPosition(int position,int data)
        {
            if(position<1)
            {
                Console.WriteLine("Invalid Position");
            }
            if(position==1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while(position !=0)
                {
                    if(position==1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if(position!=1)
                {
                    Console.WriteLine("Position is out of Range");
                }
            }
            return head;
        }
    }
}
