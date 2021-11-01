using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            { 
                int last = n % 2;
                Console.Write(last);
                n /= 2;
            }
            Console.ReadLine();
        }
    }
}
