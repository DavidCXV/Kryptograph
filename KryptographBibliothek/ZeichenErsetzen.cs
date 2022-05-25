using System;
using System.Collections.Generic;
using System.Linq;

namespace KryptographBibliothek
{
    public class ZeichenErsetzen
    {
        public static string Zeichenersetzen(string chiffre,Dictionary<string,int> Buchstaben,Dictionary<string,double> Wahrscheinlichkeiten)
        {
            //beise Dictionarys sortieren
            ///



            var sortedDict_chiffre = from entry in Buchstaben orderby entry.Value ascending select entry;
            var sortedDict_deutsch = from entry in Wahrscheinlichkeiten orderby entry.Value ascending select entry;



            //tabelle_zeichen_chiffre = tabelle_zeichen_chiffre.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);






            for (int i = 0; i < Buchstaben.Count; i++)
            {



                chiffre.Replace(sortedDict_chiffre.ElementAt(sortedDict_chiffre.Count() - i - 1).Key, sortedDict_deutsch.ElementAt(sortedDict_deutsch.Count() - i - 1).Key);



                Console.WriteLine(chiffre);
            }



            // klartext auf Deutsch = Khf ez
            // Klartext auf Englisch = Ber by



            // Sortiert Value
        
    



return chiffre;
        }
    }
}
