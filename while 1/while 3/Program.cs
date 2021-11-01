using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int stepen = 1;
            int pokazatel = 0;
            while(stepen <= n)
            {
                stepen *= 2;
                pokazatel++;
                
            }
            Console.WriteLine(pokazatel);
            Console.ReadLine();
        }
    }
}
