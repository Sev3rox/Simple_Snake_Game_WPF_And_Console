using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class GraLaczik3
    {
        public GraLaczik3()
        {
            Console.Clear();
            Lacznik lacznik = new Lacznik(60,27);
            while (lacznik.getSnake().getEnd()==false)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();

                    switch (input.Key)
                    {

                        case ConsoleKey.LeftArrow:
                            if (lacznik.getSnake().getDy() != 0&&lacznik.getSnake().getMoved()==false)
                            { lacznik.getSnake().setDy(0); lacznik.getSnake().setDx(-1); lacznik.getSnake().setMoved(true); }
                            break;
                        case ConsoleKey.RightArrow:
                            if (lacznik.getSnake().getDy() != 0 && lacznik.getSnake().getMoved() == false)
                            { lacznik.getSnake().setDy(0); lacznik.getSnake().setDx(1); lacznik.getSnake().setMoved(true); }
                            break;
                        case ConsoleKey.UpArrow:
                            if (lacznik.getSnake().getDx() != 0 && lacznik.getSnake().getMoved() == false)
                            { lacznik.getSnake().setDx(0); lacznik.getSnake().setDy(-1); lacznik.getSnake().setMoved(true); }
                            break;
                        case ConsoleKey.DownArrow:
                            if (lacznik.getSnake().getDx() != 0 && lacznik.getSnake().getMoved() == false)
                            { lacznik.getSnake().setDx(0); lacznik.getSnake().setDy(1); lacznik.getSnake().setMoved(true); }
                            break;
                    }
                }
            };
            Koniecgry graa = new Koniecgry(lacznik.getResult());
            lacznik.endGame(graa);

        }
    }
}
