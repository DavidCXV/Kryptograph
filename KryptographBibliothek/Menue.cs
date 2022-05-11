using System;
using Figgle

namespace KryptographBibliothek
{
    public class Menue
    {

        public static void MainMenue() 
        {

            string HauptAusw;

            bool Exit = false;
            bool Hmenue;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Elektrotechnik Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit Hilfe dieses SubMenues, können sie ganz simpel häufig auftretende"
                                    + " Problemstellungen im Elektrotechnik Unterricht lösen\n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Widerstand/Leistungs Berechnung");
                Console.WriteLine("\t2 - Strom Aufbau ");
                Console.WriteLine("\t3 - Wiederstand/Leistungs Übersicht");
                Console.WriteLine("\t4 - Elektronische Bauelemente");
                Console.WriteLine("\t5 - Elektronische Bauelemente Version 2 \n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        
                        break;

                    case "2":
                        Console.Clear();
                         
                        break;

                    case "3":
                        Console.Clear();
                        
                        break;

                    case "4":
                        Console.Clear();
                        
                        break;

                    case "5":
                        Console.Clear();
                        
                        break;

                    case "hauptmenü":
                        Console.Clear();
                        Hmenue = true;
                        break;
                    case "exit":
                        Exit = true;
                        break;

                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                        
                        break;
                }


            } while (!Exit & !Hmenue);

            if (Exit)
                Environment.Exit(0);

        }
    
    }
    
}
