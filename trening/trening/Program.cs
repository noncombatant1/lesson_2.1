﻿using System;

namespace ConsoleApplication2
{
    public class Zebra
    {
        public string StripWhite = "Полоска белая";
        public string StripBlack = "Полоска черная";
        public void GetStripe()
        {
            for (int i = 1; i < 4; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Полоска белая");
                }
                else
                {
                    Console.WriteLine("Полоска черная");
                }
            }
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



