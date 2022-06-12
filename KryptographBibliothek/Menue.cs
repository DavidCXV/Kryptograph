using Figgle;
using System;
using System.IO;

namespace KryptographBibliothek
{
    public class Menue
    {

        public static void MainMenue()
        {
            string mainSelection; bool exit = false;
            
            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();
                Console.WriteLine();
                
                Console.ForegroundColor = ConsoleColor.Cyan; //ASCII art Logo wird erzeugt.
               
                Console.WriteLine(FiggleFonts.Slant.Render("BFT - Kryptograph - Chiffre")); 
                
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
                Console.WriteLine("\n\nDieses Modul bietet die Möglichkeit,"
                + "einen verschlüsselten Text, mit einem Prinzip zu entschlüsseln. \n\n"); 
                //Eingabeaufforderung
               
                Console.WriteLine("Mit welcher Chiffre wollen sie arbeiten: ");
                Console.Write("1 - Substitutions-Chiffre\n");
                Console.Write("2 - Caesar-Chiffre\n");
                Console.Write("3 - Skytale-Chiffre\n");
                Console.Write("Eingabe:");
                
                mainSelection = Console.ReadLine(); switch (mainSelection)
                {
                    case "exit":
                        exit = true;
                        break;
                    case "1":
                        Console.Clear();
                        Substitution();
                        break;
                    case "2":
                        Console.Clear();
                        Caesar();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        Skytale();
                        Console.ReadKey();
                        break;
                    default:
                        (int, int) cPosAM = Console.GetCursorPosition();
                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);
                        break;
                }
            } while (!exit);
            
            if (exit)
                Environment.Exit(0); Console.ResetColor();
        }
        public static string Pfadabfrage()
        {
            string fullPath = " "; 

            do
            {
                string curFile = Console.ReadLine();
                string[] paths = { @"", curFile };
                fullPath = Path.Combine(paths);
                Console.WriteLine(File.Exists(fullPath) ? "Datei existiert." : "Datei existiert nicht.");
                Console.ReadKey();
            } while (!File.Exists(fullPath)); 
            
            return fullPath;
        }
       
        public static void Substitution()
        {
            Console.WriteLine("Geben sie den Pfad der Chiffre an ");
            string pathChiffre = Pfadabfrage();
            Console.ReadKey();
            Console.Clear();
           
            Console.WriteLine("Die Chiffre sieht wie folgt aus:");
            Console.WriteLine();
            AuslesenChiffre.ChiffreAuslesen(pathChiffre);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Geben sie den Pfad der Tabelle an");
            string pathChart = Pfadabfrage();
            Console.ReadKey(); 
            Console.Clear();

            Console.WriteLine("Der Inhalt der Tabelle lautet wie folgt:");
            Console.WriteLine();
            AuslesenDerTabelle.AuslesenTab(pathChart);
            Console.ReadKey();

            //ZeichenEntfernen.Entfernen(Chiffre);

            //ZeichenZählen.Zaehlen(Chiffre);

            //ZeichenErsetzen.Zeichenersetzen(Chiffre);

            //ZeichenAusgeben.ZeichenAu(Chiffre);
            
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



