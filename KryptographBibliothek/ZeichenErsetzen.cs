using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace KryptographBibliothek
{
    public class ZeichenErsetzen
    {
        public static string Zeichenersetzen(string chiffre,Dictionary<string,double> Buchstaben,Dictionary<string,double> Wahrscheinlichkeiten)
        {
            //beide Dictionarys sortieren
            ///



            var sortedDict_chiffre = from entry in Buchstaben orderby entry.Value descending select entry;
            var sortedDict_deutsch = from entry in Wahrscheinlichkeiten orderby entry.Value descending select entry;

            //sortedDict_deutsch.ToDictionary<KeyValuePair<string, double>, string, double>(pair => pair.Key,pair=>pair.Value);


            //tabelle_zeichen_chiffre = tabelle_zeichen_chiffre.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                for(int i = 0;i<chiffre.Length;i++)
                {
                    char symbols = chiffre[i];

                    if(sortedDict_chiffre.ToString().Contains(symbols))
                    {
                        int index = 0;
                        int count = 0;
                        foreach (KeyValuePair<string, double> element in sortedDict_chiffre) 
                        {
                            count++;
                            if (element.Key == chiffre[i].ToString())
                                index = count;

                        }


                        Console.WriteLine(sortedDict_chiffre);
                        //chiffre[i] = sortedDict_deutsch.ElementAt(index);
                        //string text = chiffre[i].ToString().Replace(sortedDict_chiffre.ElementAt(sortedDict_chiffre.Count() - index - 1).Key, sortedDict_deutsch.ElementAt(sortedDict_deutsch.Count() - index - 1).Key);

                    

                        //Console.WriteLine(text);
                
                    }
            
            }
                
                
            for (int i = 0; i < Buchstaben.Count; i++)
            {



                chiffre = chiffre.Replace(sortedDict_chiffre.ElementAt(sortedDict_chiffre.Count() - i - 1).Key, sortedDict_deutsch.ElementAt(sortedDict_deutsch.Count() - i - 1).Key);

            }




            // Sortiert Value





            return chiffre;
        }



        
    }
}
