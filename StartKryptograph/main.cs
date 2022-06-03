using System;
using System.Collections.Generic;
namespace StartKryptograph
{
    class main
    {
        static void Main(string[] args)
        {
            string chiffre = "IQ UQM IUD HXGXNUIQPXMUQFJIQ BXDN UD NIP IUDIP KICGXMIDI QXMYMIUBI UD NID PZDN TBUIKID";
            var Buchstabe = new Dictionary<string, double>() { { "A", 0 }, { "AE", 0 }, { "B", 3 }, { "C", 1 }, { "D", 9 }, { "E", 0 }, { "F", 1 }, { "G", 2 }, { "H", 1 }, { "I", 15 }, { "J", 1 }, { "K", 2 }, { "L", 0 }, { "M", 5 }, { "N", 5 }, { "O", 0 }, { "OE", 0 }, { "P", 4 }, { "Q", 6 }, { "R", 0 }, { "SZ", 0 }, { "S", 0 }, { "T", 1 }, { "U", 9 }, { "UE", 0 }, { "V", 0 }, { "W", 0 }, { "X", 6 }, { "Y", 1 }, { "Z", 1 } };
            var Wahrscheinlichkeiten = new Dictionary<string, double>() { { "A", 0.0558 }, { "AE", 0.0054 }, { "B", 0.0196 }, { "C", 0.0316 }, { "D", 0.0498 }, { "E", 0.1693 }, { "F", 0.0149 }, { "G", 0.0302 }, { "H", 0.0498 }, { "I", 0.0802 }, { "J", 0.0024 }, { "K", 0.0132 }, { "L", 0.0360 }, { "M", 0.0255 }, { "N", 0.1053 }, { "O", 0.0224 }, { "OE", 0.0030 }, { "P", 0.067 }, { "Q", 0.0002 }, { "R", 0.0689 }, { "SZ", 0.0037 }, { "S", 0.0642 }, { "T", 0.0579 }, { "U", 0.0383 }, { "Ue", 0.0065 }, { "V", 0.0084 }, { "W", 0.0558 }, { "X", 0.0558 }, { "Y", 0.0558 }, { "Z", 0.0558 } };


            
            string text = KryptographBibliothek.ZeichenErsetzen.Zeichenersetzen(chiffre, Buchstabe, Wahrscheinlichkeiten);


            Console.WriteLine(text);

        }
    }
}
