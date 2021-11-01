using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_numbers_new
{
    class Program
    {
        static void Main(string[] args)
        {
            int k2 = Convert.ToInt32(Console.ReadLine());
            int k3 = Convert.ToInt32(Console.ReadLine());
            int k5 = Convert.ToInt32(Console.ReadLine());
            int k6 = Convert.ToInt32(Console.ReadLine());

            int n256 = Math.Min(k2, Math.Min(k5, k6));
            int n32 = Math.Min(k3, k2 - n256);

            Console.WriteLine(256 * n256 + 32 * n32);
        }
    }
}
