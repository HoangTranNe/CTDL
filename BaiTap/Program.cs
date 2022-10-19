using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class Program
    {
        static void TestInput()
        {
            MyList list = new MyList();
            list.Input();
            Console.Write("DSLK so nguyen: ");
            list.ShowList();
        }
        static void Main(string[] args)
        {
            TestInput();
        }
    }
}
