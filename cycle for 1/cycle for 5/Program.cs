using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle_for_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                int x1 = Convert.ToInt32(Console.ReadLine());
                if (x1 == 0)
                {
                    sum++;
                }
            }if(sum != 0)
            {
                Console.WriteLine("YES");
            }else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
