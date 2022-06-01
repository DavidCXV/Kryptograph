using System;

namespace StartKryptograph
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string beispielpfad = @"C:\Users\david.w15\Source\Repos\MyTeam.IsBetter-true_Kryptograph\Deutsch_Wahrscheinlichkeiten.txt";
            KryptographBibliothek.AuslesenDerTabelle.AuslesenTab(beispielpfad);
        }
    }
}
