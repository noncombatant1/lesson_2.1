using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Convert.ToInt32(Console.ReadLine());
            int c = Math.Max(Math.Max(x1, x2), Math.Max(x2, x3));
            int b = Math.Min(Math.Min(x1, x2), Math.Min(x2, x3));
            int a = (x1 + x2 + x3) - (b + c);
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                Console.WriteLine("impossible");
            }
            else if (Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2) < 0)
            {
                Console.WriteLine("obtuse");
            }
            else if (Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2) > 0)
            {
                Console.WriteLine("acute");
            }
            else if (Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2) == 0)
            {
                Console.WriteLine("right");
            }
            Console.ReadLine();
        }
    }
}
