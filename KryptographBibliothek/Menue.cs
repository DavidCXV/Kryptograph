using Figgle;
using System;
using System.IO;

namespace KryptographBibliothek
{
    public class Menue
    {

        public static void MainMenue()
        {
            string HauptAusw; bool Exit = false;
            bool Mreturn; do
            {
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.WriteLine();
                
                Console.ForegroundColor = ConsoleColor.Cyan; //ASCII art Logo wird erzeugt.
               
                Console.WriteLine(FiggleFonts.Slant.Render("BFT - Kryptograph - Substitutions-Chiffre")); 
                
                Console.ResetColor();
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                
                //Konsolentitel wird geändert.
                Console.Title = "BFT - Kryptograph - Substitutions-Chiffre";
                
                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("------------------------------------------------------------------------------------\n" +
                " >>> Kryptograph Menue <<<\n" +
                "------------------------------------------------------------------------------------\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: Mreturn\t\t->\tkehrt zum Auswahlmenue zurueck"); 
               
                //Beschreibung der Software.
                Console.WriteLine("\n\nDieses Modul bietet die Möglichkeit"
                + "einen verschlüsselten Text, mit einem Prinzip zu entschlüsseln. \n\n"); Mreturn = false; //Eingabeaufforderung
               
                Console.WriteLine("Mit welcher Chiffre wollen sie arbeiten: ");
                Console.Write("1 - Substitutions-Chiffre\n");
                Console.Write("2 - Caesar-Chiffre\n");
                Console.Write("3 - Skytale-Chifre\n");
                Console.Write("Eingabe:");
                
                HauptAusw = Console.ReadLine(); switch (HauptAusw)
                {
                    case "exit":
                        Exit = true;
                        break;
                    case "1":
                        Substitution();
                        break;
                    case "2":
                        Caesar();
                        break;
                    case "3":
                        Skytale();
                        break;
                    default:
                        (int, int) cPosAM = Console.GetCursorPosition();
                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                        break;
                }
            } while (!Exit); if (Exit)
                Environment.Exit(0); Console.ResetColor();
        }
        public static string Pfadabfrage()
        {
            string fullPath = " "; 

            do
            {
                Console.WriteLine("Warte auf Eingabe eines Dateipfads");
                string curFile = Console.ReadLine(); string[] paths = { @"", curFile };
                fullPath = Path.Combine(paths);
                Console.WriteLine(File.Exists(fullPath) ? "Datei existiert." : "Datei existiert nicht.");
                Console.ReadKey();
            } while (!File.Exists(fullPath)); return fullPath;
        }
       
        public static void Substitution()
        {
            string pfad = Pfadabfrage();
        }
        public static void Caesar()
        {
            Console.WriteLine("Dieses Entschlüsselungsprinzip ist noch in Arbeit");
        }
        public static void Skytale()
        {
            Console.WriteLine("Dieses Entschlüsselungsprinzip ist noch in Arbeit");
        }
               
    }
}



