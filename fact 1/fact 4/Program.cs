using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    fact *= i;
                }
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
