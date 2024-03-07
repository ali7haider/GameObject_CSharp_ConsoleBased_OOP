using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class Boundary
    {
        private Point topLeft;
        private Point topRight;
        private Point bottomLeft;
        private Point bottomRight;
        public Boundary()
        {
            this.topLeft.setX(0); 
            this.topLeft.setY(0);
            topRight.setX(0);
            topRight.setY(90) ;
            bottomRight.setX(90);
            bottomRight.setY(90);
            bottomLeft.setX(90);
            bottomLeft.setY(0);
        }
        public Boundary(Point topLeft,Point topRight,Point bottomRight,Point bottomLeft)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }
    }
}
