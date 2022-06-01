using System;
using Figgle;



namespace KryptographBibliothek
{
    public class ZeichenAusgeben
    {
      public static void ZeichenAu() 
        {

            Console.ForegroundColor = ConsoleColor.Cyan; // Farbe auf Cyan-blau geändert

            (int, int) cPosBM = Console.GetCursorPosition();  // Zeiger wird geladen

            Console.WriteLine(); 

           
            Console.WriteLine
                (FiggleFonts.Slant.Render("Ausgabe der Chiffre")); // Benutze Figgle um den Text zu Rendern

           
            Console.Title = "Ausgabe der Chiffre"; // Title auf Ausgabe der Chiffre geändert


            Console.ForegroundColor = ConsoleColor.White; // Farbe auf weiß geändert


           

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> Ausgabe der Chiffre <<<\n" +                                       // Überschrift
                              "------------------------------------------------------------------------------------\n\n");

            Console.ForegroundColor = ConsoleColor.Cyan; // Farbe auf Cyan-blau geändert

            Console.WriteLine("Ihr Ausgegebener Text lautet : Test  ");   // Ausgabe des Fertigen Textes
            Console.ReadKey();                                                                               // Wartet auf eingabe um das Programm zu beenden
                


            

            

            









        }
    }
}
