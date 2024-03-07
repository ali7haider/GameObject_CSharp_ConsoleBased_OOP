using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class GameObjectC
    {
        public char[,] Shape = new char[7, 13];
        public Point startingPoint;
        public Boundary Premises;
        public string direction = "LeftToRight";
        bool flag = true;
        bool flag2 = false;

        public GameObjectC(char[,] Shape, Point startingPoint, Boundary Premises)
        {

            this.startingPoint = new Point();

            direction = "LeftToRight";

        }
        public GameObjectC()
        {
            char[,] shape = new char[7, 13];
            this.startingPoint = new Point();
            this.Premises = new Boundary();
            direction = "LeftToRight";
        }
        public GameObjectC(char[,] Shape, Point startingPoint)
        {
            this.Shape = Shape;
            this.startingPoint = startingPoint;
            this.Premises = new Boundary();
            direction = "LeftToRight";
        }
        public GameObjectC(char[,] Shape, Point startingPoint, Boundary Premises, string direction)
        {
            this.Shape = Shape;
            this.startingPoint = startingPoint;
            this.Premises = Premises;
            this.direction = direction;

        }
        public void Move()
        {
            if (direction == "LeftToRight")
            {
                MoveLeftToRight();
            }
            if (direction == "RightToLeft")
            {
                MoveRightToLeft();
            }
            if (direction == "Patrolling")
            {
                MovePatrol();
            }
            if (direction == "Diagonal")
            {
                diagonal();
            }
            if (direction == "Projectile")
            {
                projectile();
            }
        }
        public void MoveLeftToRight()
        {
            if (startingPoint.getY() < 90)
            {
                if (startingPoint.getX() < 90)
                {
                    startingPoint.getX();
                    startingPoint.setY(startingPoint.getY() + 1);
                }
            }
        }
        public void MoveRightToLeft()
        {
            if (startingPoint.getY() > 2)
            {
                if (startingPoint.getX() > 1)
                {
                    startingPoint.getX();
                    startingPoint.setY(startingPoint.getY() - 1);

                }
            }
        }
        public void MovePatrol()
        {
            if (flag == true)
            {
                if (startingPoint.getY() < 90)
                {
                    startingPoint.getX();
                    startingPoint.setY(startingPoint.getY() + 1);
                }
                if (startingPoint.getY() == 90)
                {
                    flag = false;
                }
            }
            else if (flag == false)
            {
                if (startingPoint.getY() > 2)
                {
                    startingPoint.getX();
                    startingPoint.setY(startingPoint.getY() - 1);
                }
                else if (startingPoint.getY() == 2)
                {
                    flag = true;
                }
            }

        }
        public void diagonal()
        {
            if (startingPoint.getX() <= 90 && startingPoint.getY() <= 90)
            {
                startingPoint.setX(startingPoint.getX() + 1);
                startingPoint.setY(startingPoint.getY() + 3);
            }
        }
        public void Erase()
        {
            for (int i = startingPoint.getX(); i < startingPoint.getX() + 8; i++)
            {
                for (int j = startingPoint.getY(); j < startingPoint.getY() + 14; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                }


            }

        }
        public void projectile()
        {
            if (startingPoint.getX() <= 90 && startingPoint.getY() <= 90)
            {

                if (flag2 == false)
                {
                    if (startingPoint.getY() < 40)
                    {
                        startingPoint.setX(startingPoint.getX() - 1);
                        startingPoint.setY(startingPoint.getY() + 1);
                    }
                    else if (startingPoint.getY() == 40)
                    {
                        flag2 = true;
                    }

                }
                else if (flag2 == true)
                {
                    if (startingPoint.getX() < 89)
                    {
                        if (startingPoint.getY() > 2)
                        {
                            startingPoint.setX(startingPoint.getX() + 1);
                            startingPoint.setY(startingPoint.getY() + 2);
                        }
                    }
                }
            }
        }
        public void Draw()
        {
            for (int i = 0; i <7; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.SetCursorPosition(startingPoint.getY() + j, startingPoint.getX() + i);
                    Console.Write(Shape[i, j]);
                }

            }
        }
    }
}
