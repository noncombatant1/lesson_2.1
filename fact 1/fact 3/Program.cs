using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = a; i <= b; i++)
            {
                if (i % 10 == 7 || i % 10 == -7)
                {
                    fact *= i;
                }
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
