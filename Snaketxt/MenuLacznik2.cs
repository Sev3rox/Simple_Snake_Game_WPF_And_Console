using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class MenuLacznik2
    {
        public Printer printer;
        public int xx, yy;
       public MenuLacznik2(int x, int y)
        {
            xx = x;
            yy = y;
            printer = new Printer(x,y);
            printer.Windowsize();
            printer.logo();
            menu();
  
        }
        public void menu()
        {

           

            while (true)
            {

                int sel = Printer.drawMenu();
                if (sel == 0)
                {
                   GraLaczik3 gra = new GraLaczik3();
                }
                else if (sel == 1)
                {
                    Wyniki wyniki = new Wyniki(xx,yy);
                    List<String> list = wyniki.getlist();
                    printer.results(list);
                }
                else if (sel == 2)
                {
                    printer.clearr();
                    printer.pomLogo();

                    while (true)
                    {

                        int sell = printer.pomoc();
                        if (sell == 0)
                        {
                            printer.sterowaniee();
                        }
                        else if (sell == 1)
                        {
                            printer.zasadygryy();
                        }
                        else if (sell == 2)
                        {
                            printer.clearr();
                            printer.logo();
                            break;
                        }
                        Console.SetCursorPosition(0, 8);

                    }

                }
               
                else if (sel == 3)
                {
                    Environment.Exit(0);
                }
                Console.SetCursorPosition(0, 8);
            }

        }





    }
}
