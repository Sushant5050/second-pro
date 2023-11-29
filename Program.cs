using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_pro
{
    internal class Program
    {
        public void square()
        {
            int a = 10, b;
            b = a * a;
            Console.WriteLine("square="+ b);

        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.square();
            Console.ReadLine();
        }
    }
}
