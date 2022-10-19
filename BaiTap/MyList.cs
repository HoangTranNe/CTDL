using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            if (first==null)
            {
                last = first = newNode;
            }
            else
            {
                Last.Next = last;
                last = newNode;
            }
        }

        public void Input()
        {
            int n, x;
            Console.Write("So luong node = ");
            n = int.Parse(Console.ReadLine());
            for(int i =1; i <= n; i++)
            {
                Console.Write("Nhap Gia Tri = ");
                x = int.Parse(Console.ReadLine());
                IntNode newNode = new IntNode(x);
                AddLast(newNode);
            }
        }

        public void ShowList()
        {
           for(IntNode p = first; p!=null; p=p.Next)
                Console.Write("{0} ->",p.Data);
        }
        public int DemSL()
        {
            int d = 0;
            for(IntNode p = first; p!= null; p = p.Next)
            {
                d++;
            }
            return d;
        }
        public IntNode TimMax()
        {
            IntNode pMax = first;
            for (IntNode p = first.Next; p != null; p = p.Next)
                if (p.Data > pMax.Data)
                    pMax = p;
            return pMax;
        }
        public IntNode TimX(int x)
        {
            for (IntNode p = first; p != null; p = p.Next)
            {
                if (p.Data == x)
                {
                    return p;
                }
            }
            return null;
        }
        public void XuatChan()
        {
            for (IntNode p = first; p != null; p = p.Next)
                if (p.Data % 2 == 0)
                    Console.Write("{0}->", p.Data);
        }
        public double TBLe()
        {
            int s = 0, d = 0;
            for(IntNode p = first; p!=null;p=p.Next)
                if (p.Data % 2 != 0)
                {
                    s += p.Data;
                    d++;
                }
            if (d == 0)
                return 0;
            return (double)s / d;
        }
        public void InsertAfterP(IntNode p, IntNode newNode)
        {
            if (p==last)
                AddLast(newNode);
            else
            {
                newNode.Next = p.Next;
                p.Next = newNode;
            }
        }
        public IntNode TimMin()
        {
            IntNode pMin = first;
            for (IntNode p = first; p != null; p = p.Next)
                if (p.Data < pMin.Data)
                    pMin = p;
            return pMin;
        }
        public void ChenXSauMin(int x)
        {
            IntNode p = TimMin();
            IntNode newNode = new IntNode(x);
            InsertAfterP(p, newNode);
        }
        public void Swap(IntNode a, IntNode b)
        {
            int tam = a.Data;
            a.Data = b.Data;
            b.Data = tam;
        }
        public void InserBeforeP(IntNode p, IntNode newNode)
        {
            InsertAfterP(p, newNode);
            Swap(p, newNode);
        }
        public void ChenXTruocMin(int x)
        {
            IntNode p = TimMin();
            IntNode newNode = new IntNode(x);
            InserBeforeP(p, newNode);
        }
    }
}
