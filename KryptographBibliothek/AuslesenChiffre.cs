using System;

namespace KryptographBibliothek
 
{
    public class AuslesenChiffre
    {
        public static string ChiffreAuslesen(string pfad)
        {

            
           
            string Chiffre = System.IO.File.ReadAllText(pfad);
            //---------------------

            Console.WriteLine(Chiffre);


           

            //----------------------



            return Chiffre;

            
        }
    }
}
