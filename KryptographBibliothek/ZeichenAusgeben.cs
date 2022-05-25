using System;
using Figgle;



namespace KryptographBibliothek
{
    public class ZeichenAusgeben
    {
      public static void ZeichenAu() 
        {

            Console.ForegroundColor = ConsoleColor.Cyan;

            (int, int) cPosBM = Console.GetCursorPosition();

            Console.WriteLine();

           
            Console.WriteLine
                (FiggleFonts.Slant.Render("Ausgabe der Chiffre"));

           
            Console.Title = "Ausgabe der Chiffre";


            Console.ForegroundColor = ConsoleColor.White;




            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> Ausgabe der Chiffre <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Ihr Ausgegebener Text lautet :  ");
                Console.ReadKey();
            

            

            









        }
    }
}
