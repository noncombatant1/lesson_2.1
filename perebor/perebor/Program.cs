using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perebor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x <= 1000; x++)
            {
                if (a * x * x * x + b * x * x + c * x + d == 0)
                {
                    Console.Write(x + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
