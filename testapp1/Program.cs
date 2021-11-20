using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 20;
            float x;
            int result = mathbasic.math.ptb1(a, b, out x);
            if (result == 0)
                Console.WriteLine("phuong trinh vo so nghiem");
            else if (result == -1)
                Console.WriteLine("phuong trinh vo nghiem");
            else
                    Console.WriteLine($"phuong trinh {a}x+{b} = 0 co nghiem la {x}");
                    Console.ReadKey();
        }
    }
}
