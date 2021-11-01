using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            while(n != 0)
            {
                if(n > 0)
                {
                    sum++;
                }else
                {
                    sum1++;
                }
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(sum - sum1);
            Console.ReadLine();
        }
    }
}
