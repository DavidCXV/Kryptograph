using System;

namespace StartKryptograph
{
    class main
    {
        static void Main(string[] args)
        {
            string pfad = @"C:\Users\tamim.h2\Source\Repos\MyTeam.IsBetter-true_Kryptograph\Chiffre.txt";
            KryptographBibliothek.AuslesenChiffre.ChiffreAuslesen(pfad);
        }
    }
}
