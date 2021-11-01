using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perebor_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 1;
            
            for (int i = 1; i < 1000; i++)
            {
                sum = 0;
                for (n = 1; n <= i; n++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                    if (sum == n)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
