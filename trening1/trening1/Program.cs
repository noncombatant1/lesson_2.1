using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEssentials
{
    public class Zebra
    {
        public string StripWhite= "Полоска белая";
        public string StripBlack = "Полоска черная";
        public void GetStripe()
        {
            Console.WriteLine(StripWhite + " " + StripBlack);
        }
    }
    class Program
    {
        static void Main()
        {
            Zebra zebra1 = new Zebra();
            zebra1.GetStripe();
            zebra1.GetStripe();
            zebra1.GetStripe();

            Zebra zebra2 = new Zebra();
            zebra2.GetStripe();
        }
    }
}
