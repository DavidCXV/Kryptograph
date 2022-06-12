using System;
using System.Collections.Generic;

namespace KryptographBibliothek
{
    public class ZeichenZaehlen
    {
        public static Dictionary<char,double> Zaehlen(string chiffre)
        {
            var result = new Dictionary<char, double>();

            for (int i = 0; i < chiffre.Length; i++)
            {
                char c = chiffre[i];
                if (!Char.IsLetter(c))
                {
                    continue;
                }
                c = Char.ToUpper(c);
                double count = result.GetValueOrDefault(c);
                count++;
                result[c] = count;
            }
            foreach (var key in result.Keys)
            {
                result[key] = result[key] / chiffre.Length;
            }

            return result;
        }

    }
}
