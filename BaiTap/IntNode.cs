using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class IntNode
    {
        private int data;
        private IntNode next;

        public IntNode(int data, IntNode next)
        {
            this.Data = data;
            this.Next = next;
        }

        public int Data { get => data; set => data = value; }
        internal IntNode Next { get => next; set => next = value; }

        public IntNode(int x = 0)
        {
            data = x;
            next = null;
        }
    }
}
