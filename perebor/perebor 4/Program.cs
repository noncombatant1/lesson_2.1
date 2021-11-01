using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perebor_4
{
    class Program
    {
        static void Main(string[] args)
        { 
            {
                for (int n = 10; n <= 99; n++)
                {
                    if ((n % 10) * (n / 10) * 2 == n)
                    {
                        Console.Write(n + ",");
                        continue;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
