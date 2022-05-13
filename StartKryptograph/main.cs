using System;
using System.IO;
namespace StartKryptograph
{
    class main
    {
        static void Main(string[] args)
        {
            // KryptographBibliothek.Menue.MainMenue();

            string curFile = @"C:\Users\david.s58.SCHULE.000\source\repos\MyTeam.IsBetter-true_Kryptograph\Chiffe.txt";
            Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");

            
        }
    }
}
