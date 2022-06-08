using System;
using System.Collections.Generic;
using System.IO;


namespace KryptographBibliothek
{
    public class AuslesenDerTabelle
    {

        public static void AuslesenTab(string pfad)
        {

            //1. Informationen als String auslesen über Pfad 
            //2. Ins Dictionary schreiben
            //3. Dictionary zurück gebeben

            Console.ForegroundColor = ConsoleColor.Cyan;

            string[] wahrschText = File.ReadAllLines(pfad);
            var dictionary = new Dictionary<string, double>();

            foreach (string rows in wahrschText)
            {
                string[] reihen = rows.Split();

                dictionary.Add((reihen[0]), Convert.ToDouble(reihen[1]));

                Console.WriteLine(reihen[0] + ", " + reihen[1]);
            }

            
            
        }   
    }
}
