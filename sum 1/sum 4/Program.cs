using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n = Convert.ToDouble(Console.ReadLine());
            Double sum = 0;
            Double sum1 = 0;

            while (n != 0)
            {
                sum += n; // сначала прибавляем, а потом вводим!
                sum1++;
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(sum / sum1);
            Console.ReadLine();
        }
    }
}
