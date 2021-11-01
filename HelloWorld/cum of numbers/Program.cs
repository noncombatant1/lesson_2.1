using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int k2 = Convert.ToInt32(Console.ReadLine());
            int k3 = Convert.ToInt32(Console.ReadLine());
            int k5 = Convert.ToInt32(Console.ReadLine());
            int k6 = Convert.ToInt32(Console.ReadLine());
            int Kmin = Math.Min(Math.Min(k2, k5), Math.Min(k5, k6));
            int Ks = Kmin * 256;
            k2 -= Kmin;
            int Nmin = Math.Min(k2, k3);
            int Ns = Nmin * 32;
            Console.WriteLine(Ks + Ns);
        }
    }
}
