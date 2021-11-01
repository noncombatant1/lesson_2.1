using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x * 75);
        }
    }
}
