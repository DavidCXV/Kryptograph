using System;
using System.IO;

namespace KryptographBibliothek
 
{
    public class AuslesenChiffre
    {
        public static string ChiffreAuslesen(string pfad)
        {                     
            string chiffre = File.ReadAllText(pfad);
            Console.WriteLine(chiffre);                              
            return chiffre;                      
        }
    }
}
