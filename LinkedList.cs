using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2data
{
    internal class LinkedList
    {
        private Node Head;
        private Node Tail;
        private int length = 0;
        private int min = int.MaxValue;
        private int max = int.MinValue;
        public int Length
        {
            get { return length; }
            //set { length = value; }
        }
        public void AddNode(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.pointer = newNode;
                Tail = newNode;
            }
            length = length + 1;
            if (data < min && data!= 0)
            {
                min = data;
            }
            if (data > max)
            {
                max = data;
            }
        }
        public int Min
        {
            get { return min; }
           
        }
        public int Max
        {
            get { return max; }
        }

        public override string ToString()
        {
            string a = "";
            for(Node i = Head;i!= null;i = i.pointer)
            {
                a = a + i.data.ToString() + ",";
            }
            return a;
        }
    }
}
