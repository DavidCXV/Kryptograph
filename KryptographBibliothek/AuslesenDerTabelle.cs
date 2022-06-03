using System;
using System.Collections.Generic;


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

            string[] Wahrsch_Text = System.IO.File.ReadAllLines(pfad);
            var dictionary = new Dictionary<string, double>();

            foreach (string rows in Wahrsch_Text)
            {
                string[] Reihen = rows.Split();

                dictionary.Add((Reihen[0]), Convert.ToDouble(Reihen[1]));

                Console.WriteLine(Reihen[0] + ", " + Reihen[1]);
            }

            
            
        }   
    }
}
