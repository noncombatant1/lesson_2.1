using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakandcontinue_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 10)
                {
                    continue;
                }
                if (n >= 10 && n <= 100)
                {
                    Console.WriteLine(n);
                }
                if (n > 100)
                {
                    break;
                }
            }
        }
    }
}
