using System;
using Figgle;
using System.IO;

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

                Console.ForegroundColor = ConsoleColor.Cyan;

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFT - Kryptograph - Substitutions-Chiffre"));

                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Cyan;

                //Konsolentitel wird geändert.
                Console.Title = "BFT - Kryptograph - Substitutions-Chiffre";

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Kryptograph Menue <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");


                //Beschreibung der Software.
                Console.WriteLine("\n\nDieses Modul bietet die Möglichkeit"
                                    + "einen verschlüsselten Text, mit dem Substitutions-Chiffren Prinzip zu entschlüsseln. \n\n");

                Hmenue = false;

                //Eingabeaufforderung 

                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "exit":
                        Exit = true;
                        break;

                    case "1":

                        break;
                    default:





                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (!Exit & !Hmenue);

            if (Exit)
                Environment.Exit(0);

            Console.ResetColor();

        }


        public static string Pfadabfrage()
        {
            string fullPath = " ";


            do
            {
                Console.WriteLine("Warte auf Eingabe eines Dateipfads");
                string curFile = Console.ReadLine();

                string[] paths = { @"", curFile };
                fullPath = Path.Combine(paths);


                Console.WriteLine(File.Exists(fullPath) ? "File exists." : "File does not exist.");
            } while (!File.Exists(fullPath));

            return fullPath;




        }
        
        public static void Substitution()
        {

            string pfad = Pfadabfrage();

        }
    }
}    
    

