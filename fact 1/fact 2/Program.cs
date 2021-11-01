using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = n; i <= m; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
