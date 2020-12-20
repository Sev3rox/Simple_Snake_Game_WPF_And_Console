using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Runtime.CompilerServices;
using System.Timers;
namespace Snake
{
    class Snakee
    {
        private static List<Element> elements;
        private static int dx,dy;
        private static int sizx,sizy;
        private static int size;
        private static short score;
        private static Food fod;
        private static Element clr;
        private static bool End;
        private static bool moved;
        public Snakee(int x,int y)
        {
            init(x,y);
        }
        public void init(int x, int y)
        {
            score = 0;
            elements = new List<Element>();
            elements.Add(new Element((x / 2) - 2, y / 2));
            elements.Add(new Element((x / 2) - 1, y / 2));
            elements.Add(new Element((x / 2), y / 2));
            clr = new Element(x / 2 - 3, y / 2);
            dx = 1;
            dy = 0;
            size = elements.Count;
            sizx = x;
            sizy = y;
            End = false;
            newFood();
        }
        public void setMoved(bool b)
        {
            moved = b;
        }
        public bool getMoved()
        {
            return moved;
        }
        public bool getEnd()
        { return End; }
        public int getScore()
        {
            return score;
        }
        public void setDy(short x)
        {
            dy = x;
        }
        public void setDx(short  x)
        {
            dx = x;
        }
        public int getDy()
        {
            return dy;
        }
        public int getDx()
        {
            return dx;
        }

        public List<Element> returnElements()
        {
            return elements;
        }
        public Food getFood()
        {
            return fod;
        }
        public Element clear()
        {
            return clr;
        }
        public static void newFood()
        {
            bool rest = false;
            Random rnd = new Random();
            int x = (rnd.Next() % (sizx - 1)) + 1;
            int y = (rnd.Next() % (sizy - 1)) + 1;
            foreach (Element e in elements)
            {
                if(e.getPunkt().getX()==x&&e.getPunkt().getX()==y)
                {
                    rest = true;break;
                }    
            }
            if (rest == true) 
                newFood();
            else
                fod=new Food(x, y);
        }
        public Element lastEl()
        {
            return elements[0]; 
        }
        public static bool checkSelf(Point x)
        {
            for(int i=0;i<elements.Count;i++)
            {
                if(x.getY()== elements[i].getPunkt().getY()&& x.getX() == elements[i].getPunkt().getX()) return true;
            }
            return false;

        }
        public static void move()
        {
            size = elements.Count-1;
            int newX = elements[size].getPunkt().getX() + dx;
            int newY = elements[size].getPunkt().getY() + dy;
            Point p = new Point(newX, newY);
           // Console.WriteLine("poszło");
            if (newX == 0 || newX == sizx || newY == 0 || newY == sizy||checkSelf(p)==true)
            {End=true;}
            else
            {
                bool breaked = false;
                foreach (Element element in elements)
                {
                    if (element.getPunkt().getX() == fod.getPunkt().getX() && element.getPunkt().getY() == fod.getPunkt().getY())
                    {
                        score++;

                        elements.Add(new Element(newX, newY));
                        breaked = true;
                        newFood();
                        break;
                    }
                }
                if (!breaked)
                {
                    elements.Add(new Element(newX, newY));
                    clr = elements[0];
                    elements.RemoveAt(0);

                }
            }
            moved = false;
        }
    }
}
