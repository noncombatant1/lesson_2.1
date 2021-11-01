using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 3;
            int s = 0;
            while (n % i == 0)
            {
                n /= i;
                s++;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
