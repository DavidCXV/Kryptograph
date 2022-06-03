using System;

namespace KryptographBibliothek
 
{
    public class AuslesenChiffre
    {
        public static string ChiffreAuslesen(string pfad)
        {                     
            string chiffre = System.IO.File.ReadAllText(pfad);
            Console.WriteLine(chiffre);                              
            return chiffre;                      
        }
    }
}
