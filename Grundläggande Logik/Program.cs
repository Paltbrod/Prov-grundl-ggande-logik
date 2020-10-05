using System;

namespace Grundläggande_Logik
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = "";

            while (!(x == "5"))
            {
                System.Console.WriteLine("Skriv en siffra mellan 0-10: ");
                x = Console.ReadLine();

                if (x == "1" || x == "2" || x == "8" || x == "9")
                {
                    Console.WriteLine("miss");
                }

                if (x == "3" || x == "4" || x == "6" || x == "7")
                {
                    Console.WriteLine("near miss");


                }
                if (x == "0" || x == "10")
                {
                    Console.WriteLine("Jag sa ett nummer mellan 0-10 ");
                }
                if (x != "5")
                {
                    Console.WriteLine("inte rätt");
                }






            }

            System.Console.WriteLine("rätt");

            Console.ReadLine();
        }
    }
}