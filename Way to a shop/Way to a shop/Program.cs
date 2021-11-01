using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Way_to_a_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int wayone = Convert.ToInt32(Console.ReadLine());
            int waytwo = Convert.ToInt32(Console.ReadLine());
            int waythree = Convert.ToInt32(Console.ReadLine());
            if(wayone > waytwo + waythree)
            {
                Console.WriteLine( (waytwo + waythree) * 2);
            }
            else if (waytwo > wayone + waythree)
            {
                Console.Write((wayone + waythree) * 2);
            }
            else if(waythree > wayone + waytwo)
            {
                Console.WriteLine((wayone + waytwo) * 2);
            }
            else
            {
                Console.WriteLine(wayone + waytwo + waythree);
            }
            Console.ReadLine();
        }
    }
}
