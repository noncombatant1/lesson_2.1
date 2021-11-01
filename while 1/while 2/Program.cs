using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int stepen = 1;

            while (stepen <= n)
            {
               
                if (stepen <= n)
                {
                    Console.WriteLine(stepen);
                }
                stepen *= 2;
            }

            Console.ReadLine();
        }
    }
}
