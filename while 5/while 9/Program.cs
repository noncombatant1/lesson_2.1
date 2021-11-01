using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                int last = n % 2;
                if(last == 1)
                {
                    sum += last;
                }
                n /= 2;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
