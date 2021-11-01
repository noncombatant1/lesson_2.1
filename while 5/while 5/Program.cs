using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(n > 0)
            {
                int lastdigit = n % 10;
                if(lastdigit == 4)
                {
                    sum++;
                }
                n /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
