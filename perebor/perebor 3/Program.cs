using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perebor_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 0;
            int i = 0;
            int sum = 0;
            while (n < 999)
            {
                for (n = 100; n <= 999; n++)
                {
                    int m = n % 10;
                    int k = n / 100;
                    int l = n / 10 % 10;
                    sum = m + k + l;
                    if (sum == 8)
                    {
                        i++;
                        Console.WriteLine(sum + " " + i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
