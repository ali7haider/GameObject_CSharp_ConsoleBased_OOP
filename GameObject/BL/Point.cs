using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class Point
    {
        private int x;
        private int y;
        public Point()
        {
           
        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public int getY()
        {
            return y;
        }
        public void setY(int y)
        {
            this.y=y;
        }
        public void setXY(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
