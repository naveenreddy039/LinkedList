using System;

namespace DataStrcture1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.add(56);
            list.add(30);
            list.add(70);
            //list.display();
            list.InsertAtParticularPosition(2, 30);
        }
    }
}
