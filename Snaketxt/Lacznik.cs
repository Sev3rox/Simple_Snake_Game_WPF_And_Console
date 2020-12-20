using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Input;
namespace Snake
{
    class Lacznik
    {
        private static System.Timers.Timer aTimer;
        public static Snake snake;
        private static Printer printer;
        public Lacznik(int x, int y)
        {
            snake = new Snake(x, y);
            printer = new Printer(x, y);
            SetTimer();
            printer.baseSciana();
        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(250);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {   if (snake.getEnd() == false)
            {
                if (snake.getScore() != printer.getwy())
                {
                    printer.setwy(snake.getScore());
                    printer.printWynik();
                }
                printer.food(snake.getFood());
                printer.printSnake(snake.returnElements());
                printer.clear(snake.clear());
                Snake.move();
            }
        }
        public Snake getSnake()
        {
            return snake;
        }

        public int getResult()
        {
            return snake.getScore();
        }

        public void endGame(Koniecgry graa)
        {
            aTimer.Stop();
            printer.clearr();
            printer.konGry(snake.getScore().ToString());
            while (true)
            {

                int sel = printer.koniecGry();
                if (sel == 0)
                {

                    printer.printNick();
                }
                else if (sel == 1)
                {



                    String s = printer.getxx();
                    graa.dodawanie(s);
                    printer.clearr();
                    printer.logo();
                    printer.setIndex(0);
                    break;
                }
                else if (sel == 2)
                {
                    printer.clearr();
                    printer.logo();
                    break;
                }

                Console.SetCursorPosition(0, 20);
            }
        }
    }
}

