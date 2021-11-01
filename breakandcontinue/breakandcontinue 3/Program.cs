using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakandcontinue_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найдите первое число от 1 до n, кратное c, но НЕ кратное d.
            int n = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if ((i % c == 0 && i % d != 0) || i > n)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
