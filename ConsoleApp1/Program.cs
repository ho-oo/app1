using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Moikka, koodaus-bootcamp!");

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Anna nimesi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei!" + nimi + "!");

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
