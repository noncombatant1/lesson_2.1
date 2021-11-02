using System;

namespace ConsoleApplication2
{
    class Program
    {
        const int TABLEWIDTH = 77;

        static void Main(string[] args)
        {
            PrintLine();
            PrintRow(new string[] { "Field", "Type", "Null" });
            PrintLine();
            PrintRow(new string[] { "id", "int(11)", "NO" });
            PrintRow(new string[] { "name", "varchar(25)", "NO" });
            PrintRow(new string[] { "age", "int(3)", "NO" });
            PrintLine();

            Console.ReadKey();
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', TABLEWIDTH));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (TABLEWIDTH - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}



