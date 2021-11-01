using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle_for_4
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
                if (x1 % 10 == 0)
                {
                    sum++;
                }
            } Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
