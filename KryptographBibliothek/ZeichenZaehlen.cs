using System;
using System.Collections.Generic;

namespace KryptographBibliothek
{
    public class ZeichenZaehlen
    {
        public static Dictionary<char,double> Zaehlen(string chiffre)
        {
            var result = new Dictionary<char, double>();  //Dictionary von Buchstabe mit der Prozentualen Anzahl
            int notletter = 0; //Anzahl von nicht Buchstaben im Text
            //Chiffre als Character durchgehen.
            for (int i = 0; i < chiffre.Length; i++)
            {
                char c = chiffre[i];
                //Wenn Char kein Buchstabe ist
                if (!Char.IsLetter(c))
                {
                    notletter++;
                    continue;
                }
                //Buchstabe in groß umwandeln
                c = Char.ToUpper(c);
                //Aktuelle Buchstaben Anzahl aus dem Dictionary holen und inkrementieren.
                double count = result.GetValueOrDefault(c);
                count++;
                result[c] = count;
            }

            //Alle Buchstaben im Dictionary durchgehen
            foreach (var key in result.Keys)
            {
                //Prozentuale Anzahl ausrechen
                result[key] = result[key] / (chiffre.Length-notletter);
            }
            //Ergebnis zurückgeben
            return result;
        }

    }
}
