using System;


namespace KryptographBibliothek
{
    public class ZeichenEntfernen
    {
        public static void Entfernen()
        {
            Console.WriteLine("Das ist ihr verschlüsselter Text:");

            string chiffre = "Kly ulbl KbhsZluzl Jvuayvssly pza pu Mburapvuzbtmhun buk Clyhyilpabun lpul rshyl Clyilzzlybun gbt KbhsZovjr 4, hsslykpunz mpls tpy kpl nlypunl Hrrb-Shbmglpa däoyluk klz Alzaz ulnhapc hbm, kpl cvy hsslt Jvyl Nhtly zaöylu küymal.Lilumhssz upjoa glpanltäß pza kpl Nyößl kly pualyulu Mlzawshaal, dlsjol upjoa 1 AI, zvuklyu uby 825 NI nyvß pza, cvu klulu dplklybt uby 667 NI nlubaga dlyklu röuulu, kh kly Ylza cvt Zfzalt ilslna dpyk. Pu Glpalu, pu klulu Zwplsl hbjo zjovuths ipz gb 100 NI nyvß zpuk, dlyklu oply zjoulss Wshagwyvisltl luazalolu.Kpl Rvuzvsl bualyzaüaga lydlpalyal Zwlpjolytönspjorlpalu pu Mvyt cvu BZI - Shbmdlyrlu, hsslykpunz röuulu oply uby WZ4 - Zwplsl hbznlshnlya dlyklu. Kly pualyul Zwlpjoly rhuu müy WZ5-Zwplsl tpa ZZK-Lydlpalybunzrhyalu(khur T.2.- Zjoupaazalssl) clynyößlya dlyklu, hsslykpunz dpyk kplzlz Mlahbyl ilp Ylslhzl uvjo upjoa gby Clymünbunz zalolu, kluu lz pza lyza müy lpu gbrüumapnlz Bwkhal nlwshua. Lz islpia higbdhyalu, dpl zpjo kpl WZ5 pt Shunglpaalza zjoshnlu dpyk. Khur Hidäyazrvtwhapipspaäa, klu Shbujo - Apalsu buk klu Lersbzpc - Zwplslu khym hily qlaga zjovu nlyul tpa Zvufz Ulea-Nlu - Rvuzvsl nlspliäbnlsa dlyklu";          

            Console.WriteLine("Kly ulbl KbhsZluzl Jvuayvssly pza pu Mburapvuzbtmhun buk Clyhyilpabun lpul rshyl Clyilzzlybun gbt KbhsZovjr 4, hsslykpunz mpls tpy kpl nlypunl Hrrb-Shbmglpa däoyluk klz Alzaz ulnhapc hbm, kpl cvy hsslt Jvyl Nhtly zaöylu küymal. Lilumhssz upjoa glpanltäß pza kpl Nyößl kly pualyulu Mlzawshaal, dlsjol upjoa 1 AI, zvuklyu uby 825 NI nyvß pza, cvu klulu dplklybt uby 667 NI nlubaga dlyklu röuulu, kh kly Ylza cvt Zfzalt ilslna dpyk. Pu Glpalu, pu klulu Zwplsl hbjo zjovuths ipz gb 100 NI nyvß zpuk, dlyklu oply zjoulss Wshagwyvisltl luazalolu. Kpl Rvuzvsl bualyzaüaga lydlpalyal Zwlpjolytönspjorlpalu pu Mvyt cvu BZI-Shbmdlyrlu, hsslykpunz röuulu oply uby WZ4-Zwplsl hbznlshnlya dlyklu. Kly pualyul Zwlpjoly rhuu müy WZ5-Zwplsl tpa ZZK-Lydlpalybunzrhyalu (khur T.2.-Zjoupaazalssl) clynyößlya dlyklu, hsslykpunz dpyk kplzlz Mlahbyl ilp Ylslhzl uvjo upjoa gby Clymünbunz zalolu, kluu lz pza lyza müy lpu gbrüumapnlz Bwkhal nlwshua. Lz islpia higbdhyalu, dpl zpjo kpl WZ5 pt Shunglpaalza zjoshnlu dpyk. Khur Hidäyazrvtwhapipspaäa, klu Shbujo-Apalsu buk klu Lersbzpc-Zwplslu khym hily qlaga zjovu nlyul tpa Zvufz Ulea-Nlu-Rvuzvsl nlspliäbnlsa dlyklu. ", Environment.NewLine, chiffre);  //Die verschlüsselte Chiffre wird angezeigt

            Console.WriteLine("\n \n \n \n Welche Zeichen möchten sie entfernen?");   // Der Benutzer wird gefragt was er entfernen möchte

            string Zeichen = Convert.ToString(Console.ReadLine()); // Der Nutzer gibt das zu entfernende Zeichen ein und es wird eingelesen
            
            string correctString = chiffre.Replace(Zeichen, "");  // Das Zeichen wird entfernt

            bool flag = true;

            if(flag == true)   // Es werden große und kleine Zeichen entfernt, da diese gleichgestellt werden
            {

                correctString = correctString.Replace(Zeichen.ToLower(), "");   
                correctString = correctString.Replace(Zeichen.ToUpper(), "");

            }

            Console.WriteLine("Das ist der Text ohne das Zeichen das entfernt werden sollte \n \n \n \n {0}", correctString);  // Der text wird ausgegeben ohne das Zeichen

            Console.WriteLine("\n\nMöchten sie noch weitere Zeichen entfernen?\n\nFalls sie dies wünschen geben sie die Zahl 1 ein und falls sie nicht fortfahren möchten geben sie eine 2 ein:");  // Der Benutzer wird gefragt ob er noch weitere Zeichen entfernen möchte
            int value = Convert.ToInt32(Console.ReadLine());  // Die eingegebene Zehl wird eingelesen und dadrauf basierend wird fortgefahren

            if (value == 1)
            {
               
                Console.WriteLine("Welches Zeichen möchten sie nun entfernen?\n\n");  //Der Benutzer wird gefragt welches Zeichen er entfernen möchte
                string Zeichen2 = Convert.ToString(Console.ReadLine());  // Der Nutzer gibt das zu entfernende Zeichen ein und es wird eingelesen
                string correctString2 = correctString.Replace(Zeichen2, "");

                bool flag2 = true;

                if (flag2 == true) // Es werden große und kleine Zeichen entfernt, da diese gleichgestellt werden
                {
                    correctString2 = correctString2.Replace(Zeichen.ToLower(), "");
                    correctString2 = correctString2.Replace(Zeichen.ToUpper(), "");

                }
               
                Console.WriteLine("Das ist der Text ohne das Zeichen das entfernt werden sollte\n\n{0}", correctString2);  // Der text wird ohne das Zeichen ausgegeben

            }
            else 
            {

                Console.WriteLine("Sie möchten also keinen Buchstaben mehr entfernen, nun können sie zum nächsten Schritt fortfahren."); // Falls der benutzer kein Zeichen mehr entfernen möchte wird nun fortgeschritten zum nächsten Feature

            }
        }
    }
}
