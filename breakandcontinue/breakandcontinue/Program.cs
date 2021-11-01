using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakandcontinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найдите максимальный делитель числа N, отличный от N.
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n - 1; i < n; i--)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }

            }
            Console.ReadKey();
        }
    }
}
