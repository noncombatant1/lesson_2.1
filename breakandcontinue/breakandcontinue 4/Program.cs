using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakandcontinue_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //По данной последовательности строк, определите какой по счету встретится строка s
            String s = Console.ReadLine();
            int i = 1;
            while (true)
            {
                String s1 = Console.ReadLine();
                if (s1 != s)
                {
                    i++;
                    continue;
                    
                }
                else
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
