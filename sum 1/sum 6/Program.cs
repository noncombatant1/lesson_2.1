using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_6
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
                if ((n1 > 0 && n2 < 0) || (n1 < 0 && n2 > 0))
                    sum++;
                n1 = n2;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            // Последовательность состоит из целых чисел и завершается числом 00. Определите, сколько раз в этой последовательности меняется знак.
        }
    }
}
