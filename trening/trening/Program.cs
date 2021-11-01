using System;

namespace trening
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int maxspeed = 0;
            int number;
            string minspeed;
            for (int i = 0; i < n; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > maxspeed)
                {
                    maxspeed = number;
                }
                
                if (number < 30)
                {
                    minspeed = "YES";
                }
                else
                {
                    minspeed = "NO";
                }
            }
            Console.Write(maxspeed + " " + minspeed);
        }
    }
}
