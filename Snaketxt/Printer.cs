using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Snake
{
    class Printer
    {
        private static int sizx = 20, sizy = 20,index=0,index2=0,index3=0;
        const int m = 5;
        int wy = 0;
        String xx="";
        public Printer(int x, int y)
        {
            sizx = x;
            sizy = y;
        }
        public void setIndex(int nowyIndex)
        {
            index3 = nowyIndex;
        }
        public void printElement(Element e)
        {
            Console.SetCursorPosition(m+e.getPunkt().getX(), m + e.getPunkt().getY());
            Console.WriteLine("O");
        }
        public void printSnake(List<Element> el)
        {
            foreach (Element e in el)
            {
                printElement(e);
            }
            Console.SetCursorPosition(m + el[el.Count-1].getPunkt().getX(), m + el[el.Count-1].getPunkt().getY());
            Console.WriteLine("☺");
        }
        public void clear(Element e)
        {
            Console.SetCursorPosition(m + e.getPunkt().getX(), m + e.getPunkt().getY());
            Console.Write(" ");
        }
        public void food(Food foo)
        {
            Console.SetCursorPosition(m + foo.getPunkt().getX(), m + foo.getPunkt().getY());
            Console.Write("$");
        }
        public void baseSciana()
        {
            Console.SetCursorPosition(m, 0);
            for (int i = 0; i < sizx + 1; i++)
            {
                Console.Write("▓");
            }
            Console.SetCursorPosition(m, 4);
            for (int i = 0; i < sizx + 1; i++)
            {
                Console.Write("▓");
            }
             for(int i=1;i<4;i++)
            {
                for(int j=0;j<15; j++)
                {
                    Console.SetCursorPosition(m+j, i);
                    Console.Write("▓");
                }

                for (int g = 0; g < 15; g++)
                {
                    Console.SetCursorPosition(m + sizx-g, i);
                    Console.Write("▓");
                }
            }
            printWynik();

           


            Console.SetCursorPosition(m, m);
            for (int i=0;i<sizx+1;i++)
            {
                Console.Write("█");
            }
            for(int i=1;i<sizy+1;i++)
            {
                Console.SetCursorPosition(m, m+i);
                Console.Write("█");
                Console.SetCursorPosition(m+sizx, m + i);
                Console.Write("█");
            }
            Console.SetCursorPosition(m, m+sizy);
            for (int i = 0; i < sizx + 1; i++)
            {
                Console.Write("█");
            }
        }
        public void Windowsize()
        {
            Console.SetWindowSize(sizx+3,sizy+3);
            Console.CursorVisible = false;
        }

        public void logo()
        {
             Console.WriteLine("\n");
            Console.SetCursorPosition((Console.WindowWidth - 25) / 2, Console.CursorTop);
            Console.WriteLine(" _____             _         ");
            Console.SetCursorPosition((Console.WindowWidth - 25) / 2, Console.CursorTop);
            Console.WriteLine("/  ___|           | |        ");
            Console.SetCursorPosition((Console.WindowWidth - 25) / 2, Console.CursorTop);
            Console.WriteLine('\u005C' + " `--. _ __   __ _| | _____  ");
            Console.SetCursorPosition((Console.WindowWidth - 25) / 2, Console.CursorTop);
            Console.WriteLine(" `--. " + '\u005C' + " '_ " + '\u005C' + " / _` | |/ / _ " + '\u005C' + " ");
            Console.SetCursorPosition((Console.WindowWidth - 25) / 2, Console.CursorTop);
            Console.WriteLine("/" + '\u005C' + "__/ / | | | (_| |   <  __/ ");
            Console.SetCursorPosition((Console.WindowWidth - 25) / 2, Console.CursorTop);
            Console.WriteLine("" + '\u005C' + "____/|_| |_|" + '\u005C' + "__,_|_|_" + '\u005C' + "___| ");
        }
        
        public void resLogo()
        {
            Console.WriteLine("\n");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine(" _   _       _ _                          __  ___  ");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("| " + '\u005C' + " | |     (_) |                        /_ |/ _ " + '\u005C' + " ");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("|  " + '\u005C' + "| | __ _ _| | ___ _ __  ___ _______   | | | | |");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("| . ` |/ _` | | |/ _ " + '\u005C' + " '_ " + '\u005C' + "/ __|_  / _ " + '\u005C' + "  | | | | |");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("| |" + '\u005C' + "  | (_| | | |  __/ |_) " + '\u005C' + "__ " + '\u005C' + "/ /  __/  | | |_| |");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("|_| " + '\u005C' + "_|" + '\u005C' + "__,_| |_|" + '\u005C' + "___| .__/|___/___" + '\u005C' + "___|  |_|" + '\u005C' + "___/ ");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("           _/ |      | |                          ");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("          |__/       |_|                          ");

        }

        public void pomLogo()
        {
            Console.WriteLine("\n");
            Console.SetCursorPosition((Console.WindowWidth - 30) / 2, Console.CursorTop);
            Console.WriteLine("  _____                           ");
            Console.SetCursorPosition((Console.WindowWidth - 30) / 2, Console.CursorTop);
            Console.WriteLine(" |  __ " + '\u005C' + "                          ");
            Console.SetCursorPosition((Console.WindowWidth - 30) / 2, Console.CursorTop);
            Console.WriteLine(" | |__) |__  _ __ ___   ___   ___ ");
            Console.SetCursorPosition((Console.WindowWidth - 30) / 2, Console.CursorTop);
            Console.WriteLine(" |  ___/ _ " + '\u005C' + "| '_ ` _ " + '\u005C' + " / _ " + '\u005C' + " / __|");
            Console.SetCursorPosition((Console.WindowWidth - 30) / 2, Console.CursorTop);
            Console.WriteLine(" | |  | (_) | | | | | | (_) | (__ ");
            Console.SetCursorPosition((Console.WindowWidth - 30) / 2, Console.CursorTop);
            Console.WriteLine(" |_|   " + '\u005C' + "___/|_| |_| |_|" + '\u005C' + "___/ " + '\u005C' + "___|");
   
        }

        public void sterLogo()
        {
            Console.WriteLine("\n");
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, Console.CursorTop);
            Console.WriteLine("  _____ _                                    _      ");
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, Console.CursorTop);
            Console.WriteLine(" / ____| |                                  (_)     ");
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, Console.CursorTop);
            Console.WriteLine("| (___ | |_ ___ _ __ _____      ____ _ _ __  _  ___ ");
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, Console.CursorTop);
            Console.WriteLine(" " + '\u005C' + "___ " + '\u005C' + "| __/ _ " + '\u005C' + " '__/ _ " + '\u005C' + " " + '\u005C' + " /" + '\u005C' + " / / _` | '_ " + '\u005C' + "| |/ _ " + '\u005C');
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, Console.CursorTop);
            Console.WriteLine(" ____) | ||  __/ | | (_) " + '\u005C' + " V  V / (_| | | | | |  __/");
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, Console.CursorTop);
            Console.WriteLine("|_____/ " + '\u005C' + "__" + '\u005C' + "___|_|  " + '\u005C' + "___/ " + '\u005C' + "_/" + '\u005C' + "_/ " + '\u005C' + "__,_|_| |_|_|" + '\u005C' + "___|");


        }


        public void zaslogo()
        {
            Console.WriteLine("\n");
            Console.SetCursorPosition((Console.WindowWidth - 55) / 2, Console.CursorTop);
            Console.WriteLine("  ______                   _          _____            ");
            Console.SetCursorPosition((Console.WindowWidth - 55) / 2, Console.CursorTop);
            Console.WriteLine(" |___  /                  | |        / ____|           ");
            Console.SetCursorPosition((Console.WindowWidth - 55) / 2, Console.CursorTop);
            Console.WriteLine("    / / __ _ ___  __ _  __| |_   _  | |  __ _ __ _   _ ");
            Console.SetCursorPosition((Console.WindowWidth - 55) / 2, Console.CursorTop);
            Console.WriteLine("   / / / _` / __|/ _` |/ _` | | | | | | |_ | '__| | | |");
            Console.SetCursorPosition((Console.WindowWidth - 55) / 2, Console.CursorTop);
            Console.WriteLine("  / /_| (_| " + '\u005C' + "__ " + '\u005C' + " (_| | (_| | |_| | | |__| | |  | |_| |");
            Console.SetCursorPosition((Console.WindowWidth - 55) / 2, Console.CursorTop);
            Console.WriteLine(" /_____" + '\u005C' + "__,_|___/" + '\u005C' + "__,_|" + '\u005C' + "__,_|" + '\u005C' + "__, |  " + '\u005C' + "_____|_|   " + '\u005C' + "__, |");
            Console.SetCursorPosition((Console.WindowWidth - 55) / 2, Console.CursorTop);
            Console.WriteLine("                              __/ |               __/ |");
            Console.SetCursorPosition((Console.WindowWidth - 55) / 2, Console.CursorTop);
            Console.WriteLine("                             |___/               |___/ ");

        }


        public void konLogo()
        {
            Console.WriteLine("\n");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("  _  __           _              _____            ");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine(" | |/ /          (_)            / ____|           ");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine(" | ' / ___  _ __  _  ___  ___  | |  __ _ __ _   _ ");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine(" |  < / _ " + '\u005C' + "| '_ " + '\u005C' + "| |/ _ " + '\u005C' + "/ __| | | |_ | '__| | | |");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine(" | . " + '\u005C' + " (_) | | | | |  __/ (__  | |__| | |  | |_| |");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine(" |_|" + '\u005C' + "_" + '\u005C' + "___/|_| |_|_|" + '\u005C' + "___|" + '\u005C' + "___|  " + '\u005C' + "_____|_|   " + '\u005C' + "__, |");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("                                             __/ |");
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.CursorTop);
            Console.WriteLine("                                            |___/ ");

        }

       





        public static int drawMenu()
        {
            
            List<string> menuItem = new List<string>()
            {
                "                            :¯¯¯¯¯¯¯:                            \n                            | Start |                            \n                            :¯¯¯¯¯¯¯:                           ",
                    "                           :¯¯¯¯¯¯¯¯¯:                            \n                           | Wyniki: |                            \n                           :¯¯¯¯¯¯¯¯¯:                         ",
                    "                            :¯¯¯¯¯¯¯:                            \n                            | Pomoc |                            \n                            :¯¯¯¯¯¯¯:                          ",
                  //  "                            :¯¯¯¯¯¯¯:                            \n                            | Opcje |                              \n                            :¯¯¯¯¯¯¯:                         ",
                  "                           :¯¯¯¯¯¯¯¯¯:                            \n                           | Wyjście |                            \n                           :¯¯¯¯¯¯¯¯¯:                          ",
            ""};
            Console.WriteLine("\n\n");

            for (int i = 0; i < menuItem.Count; i++)
            {
                Console.ResetColor();
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                else
                {
                    Console.ResetColor();
                }

                Console.WriteLine(menuItem[i]);
            }

            ConsoleKeyInfo ckey = Console.ReadKey();
            if (ckey.Key == ConsoleKey.DownArrow)
            {
                index++;
                if (index > 3)
                    index = 0;

            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                index--;
                if (index < 0)
                    index = 3;
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
               return index;
            }
            
            Console.SetCursorPosition(0, 8);
            return -1;
        }

        public void results(List<string> list)
        {
            Console.Clear();

            resLogo();
            Console.WriteLine("\n\n");
            foreach (string res in list){
                Console.SetCursorPosition((Console.WindowWidth - res.Length) / 2, Console.CursorTop);
                Console.WriteLine(res);
            }
         
            Console.WriteLine("\n\n\n");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                          :¯¯¯¯¯¯¯¯:                            \n                          | Powrót |                            \n                          :¯¯¯¯¯¯¯¯:                           ");
            Console.ResetColor();
            while (true)
            {
                ConsoleKeyInfo ckey = Console.ReadKey();
                if (ckey.Key ==ConsoleKey.Enter)
                    break;
            }
            Console.Clear();
            logo();
        }



        public int pomoc()
        {
            
            List<string> Item = new List<string>()
            {
                "                          :¯¯¯¯¯¯¯¯¯¯¯¯:                            \n                          | Sterowanie |                            \n                          :¯¯¯¯¯¯¯¯¯¯¯¯:                           ",
                    "                          :¯¯¯¯¯¯¯¯¯¯¯¯:                            \n                          | Zasady Gry |                            \n                          :¯¯¯¯¯¯¯¯¯¯¯¯:                         ",
                    "                            :¯¯¯¯¯¯¯¯:                             \n                            | Powrót |                            \n                            :¯¯¯¯¯¯¯¯:                          ",
                    ""
            };
            


            Console.WriteLine("\n\n");

            for (int i = 0; i < Item.Count; i++)
            {
                Console.ResetColor();
                if (i == index2)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                else
                {
                    Console.ResetColor();
                }

                Console.WriteLine(Item[i]);
            }

            ConsoleKeyInfo ckey = Console.ReadKey();
            if (ckey.Key == ConsoleKey.DownArrow)
            {
                index2++;
                if (index2 > 2)
                    index2 = 0;

            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                index2--;
                if (index2 < 0)
                    index2 = 2;
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return index2;
            }

            Console.SetCursorPosition(0, 8);
            return -1;


        }

        public void sterowanie()
        {
            Console.WriteLine("\n\n\n");
            Console.SetCursorPosition((Console.WindowWidth - 5) / 2, Console.CursorTop);
            Console.WriteLine("Menu:\n");
            Console.SetCursorPosition((Console.WindowWidth - 46) / 2, Console.CursorTop);
            Console.WriteLine("Strzałki w góre i dół służa do zmiany wyboru.");
            Console.SetCursorPosition((Console.WindowWidth - 36) / 2, Console.CursorTop);
            Console.WriteLine("Enter słuzy do zatwierdzenia wyboru.");
            Console.WriteLine("\n\n");
            Console.SetCursorPosition((Console.WindowWidth - 4) / 2, Console.CursorTop);
            Console.WriteLine("Gra:\n");
            Console.SetCursorPosition((Console.WindowWidth - 42) / 2, Console.CursorTop);
            Console.WriteLine("Poruszanie się wężem za pomocą strzałek.");
           



            Console.WriteLine("\n\n\n");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                          :¯¯¯¯¯¯¯¯:                            \n                          | Powrót |                            \n                          :¯¯¯¯¯¯¯¯:                           ");
            Console.ResetColor();
            while (true)
            {
                ConsoleKeyInfo ckey = Console.ReadKey();
                if (ckey.Key == ConsoleKey.Enter)
                    break;
            }
            Console.Clear();
            pomLogo();

        }

        public void zasadyGry()
        {
            Console.WriteLine("\n\n\n");
            Console.SetCursorPosition((Console.WindowWidth - 15) / 2, Console.CursorTop);
            Console.WriteLine("Sterujesz wężem");
            Console.SetCursorPosition((Console.WindowWidth - 58) / 2, Console.CursorTop);
            Console.WriteLine("Twoim celem jest zebranie jak największej ilości jedzenia.");
            Console.SetCursorPosition((Console.WindowWidth - 42) / 2, Console.CursorTop);
            Console.WriteLine("Każde zebranie jedzenia wydłuża ogon węża.\n");
            Console.SetCursorPosition((Console.WindowWidth - 43) / 2, Console.CursorTop);
            Console.WriteLine("Gra kończy się w momencie udeżenia głową węża");
            Console.SetCursorPosition((Console.WindowWidth - 27) / 2, Console.CursorTop);
            Console.WriteLine("o ściane, lub o własne ciało.");







            Console.WriteLine("\n\n\n\n\n");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                          :¯¯¯¯¯¯¯¯:                            \n                          | Powrót |                            \n                          :¯¯¯¯¯¯¯¯:                           ");
            Console.ResetColor();
            while (true)
            {
                ConsoleKeyInfo ckey = Console.ReadKey();
                if (ckey.Key == ConsoleKey.Enter)
                    break;
            }
            Console.Clear();
            pomLogo();

        }

        public void konGry(String x)
        {
            konLogo();
            Console.WriteLine("\n\n");
            Console.WriteLine("                          Twój Wynik:");
            if (x.Length == 1)
                Console.WriteLine("\n                               " + x);
            else if (x.Length == 2)
                Console.WriteLine("\n                              " + x);
            else
                Console.WriteLine("\n                             " + x);

            //   Console.WriteLine("\n                          Podaj Nick:");

            Console.WriteLine("\n");
        }

        public int koniecGry()
        {
            List<string> Item = new List<string>()
            {
                "",
                    "                          :¯¯¯¯¯¯¯¯:                            \n                          | Zapisz |                            \n                          :¯¯¯¯¯¯¯¯:                         ",
                    "                        :¯¯¯¯¯¯¯¯¯¯¯¯:                             \n                        | NieZapisuj |                            \n                        :¯¯¯¯¯¯¯¯¯¯¯¯:                          ",
                    ""
            };

            for (int i = 0; i < Item.Count; i++)
            {
                Console.ResetColor();
                if (i == index3)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                   
                   

                }
                else
                {
                    Console.ResetColor();
                }
                if (i == 0)
                {
                    String d = "Nick: " + xx;
                    Console.SetCursorPosition(((Console.WindowWidth - d.Length) / 2)+1, 18);
                    Console.WriteLine(d);
                    Console.WriteLine("\n\n");
                }
                else
                Console.WriteLine(Item[i]);
            }


         
            {
                ConsoleKeyInfo ckey = Console.ReadKey();
                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    index3++;
                    if (index3 > 2)
                        index3 = 0;

                }
                else if (ckey.Key == ConsoleKey.UpArrow)
                {
                    index3--;
                    if (index3 < 0)
                        index3 = 2;
                }
                else if (ckey.Key == ConsoleKey.Enter)
                {
                   
                    return index3;
                }
            }

            Console.SetCursorPosition(0, 18);
            return -1;

        }
        public String getxx()
        {
            return xx;
        }

        public void printNick()
        {
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("                                                         ");
            Console.SetCursorPosition(((Console.WindowWidth - 6) / 2) + 1, 18);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Nick: ");
            Console.SetCursorPosition(68 / 2, 18);
            xx = Console.ReadLine();
            Console.ResetColor();
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("                                                         ");
        }




        public void printWynik()
        {
            String x = "   Wynik: " + wy.ToString()+"   ";
            Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2+m, 2);
            Console.WriteLine(x);
        }
        public void setwy(int wyx)
        {
            wy = wyx;
        }

        public int getwy()
        {
            return wy;
        }

        public void clearr()
        {
            Console.Clear();
        }

        public void sterowaniee()
        {
            Console.Clear();
            sterLogo();

           sterowanie();
        }

        public void zasadygryy()
        {
            Console.Clear();
            zaslogo();

            zasadyGry();
        }

    }
}
