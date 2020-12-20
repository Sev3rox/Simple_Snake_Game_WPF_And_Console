using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Element
    {
        private Point punkt;
        public Element(int xx, int yy) 
        {
            punkt = new Point(xx, yy);
        }
        public Point getPunkt()
        {
            return punkt;
        }
        public void setPunkt(Point nPunkt)
        {
            punkt=nPunkt;
        }
    }
}
