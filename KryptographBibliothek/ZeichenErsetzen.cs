using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace KryptographBibliothek
{
    public class ZeichenErsetzen
    {
        public static string Zeichenersetzen(string chiffre,Dictionary<string,int> Buchstaben,Dictionary<string,double> Wahrscheinlichkeiten)
        {
            ////beide Dictionarys sortieren
            /////

            //var sortedDict_chiffre = from entry in Buchstaben orderby entry.Value ascending select entry;
            //var sortedDict_deutsch = from entry in Wahrscheinlichkeiten orderby entry.Value ascending select entry;



            ////tabelle_zeichen_chiffre = tabelle_zeichen_chiffre.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            //for(int i = 0;i<chiffre.Length;i++)
            //{
            //    char zeichen = chiffre[i];

            //    if(sortedDict_chiffre.ToString().Contains(zeichen))
            //    {
            //        int index = sortedDict_chiffre.ToList().IndexOf(zeichen);

            //        Console.WriteLine(index);
                
            //    }
            
            //}
                                
            //for (int i = 0; i < Buchstaben.Count; i++)
            //{

            //    chiffre = chiffre.Replace(sortedDict_chiffre.ElementAt(sortedDict_chiffre.Count() - i - 1).Key, sortedDict_deutsch.ElementAt(sortedDict_deutsch.Count() - i - 1).Key);

            //}

            //// Sortiert Value
            return chiffre;
        }

    }
}
