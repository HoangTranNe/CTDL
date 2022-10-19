using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;

        public MyList(IntNode first, IntNode last)
        {
            this.First = first;
            this.Last = last;
        }

        internal IntNode First { get => first; set => first = value; }
        internal IntNode Last { get => last; set => last = value; }

        public MyList()
        {
            first = null;
            last = null;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }

        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                newNode.Next = last;
                last = newNode;
            }
        }

        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia Tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                {
                    return;
                }
                IntNode newNode = new IntNode(x);
                AddFirst(newNode);
                AddLast(newNode);
            } while (true);
        }

        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.Write("null");
        }

    }
}
