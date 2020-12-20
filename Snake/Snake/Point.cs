using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Xml.Schema;

namespace Snake
{
    public class Point
    {
        private int x, y;
        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
        public int getX()
        {
            return x;
        }
        public void setX(int _x)
        {
            x = _x; ;
        }
        public int getY()
        {
            return y;
        }
        public void setY(int _y)
        {
            y=_y;
        }
    }
}
