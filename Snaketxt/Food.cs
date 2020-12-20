using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Food
    {
        private Point punkt;
        public Food(int x,int y)
        {
            punkt = new Point(x, y);
        }
        public Point getPunkt()
        {
            return punkt;
        }
    }
}
