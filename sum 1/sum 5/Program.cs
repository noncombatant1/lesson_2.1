using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (n1 != 0)
            {
                int n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 > n1)
                sum++;
                n1 = n2;
            }
            Console.WriteLine(sum);
        }
    }
}
