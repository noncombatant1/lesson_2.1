using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle_for_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int x1;
            for (int i = 1; i <= x; i++)
            {
                x1 = Convert.ToInt32(Console.ReadLine());
                if (x1 % 2 == 0 && x1 % 3 != 0)
                {


                    sum += x1;

                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
