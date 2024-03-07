using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GameObject.BL;

namespace GameObject
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] A = new char[7,13] { { ' ', ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ', ' ', '*', ' ', '*', ' ', ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ', ' ', ' ' },
                                 { ' ', ' ', ' ', '*', '*', '*', '*', '*', '*', '*', ' ', ' ', ' ' },{ ' ', ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*', ' ', ' ' }, { ' ', '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*', ' ' },{ '*', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '*' }   };
            Boundary b = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameObjectC G1 = new GameObjectC(A, new Point(1, 1), b, "LeftToRight");
            GameObjectC G2 = new GameObjectC(A, new Point(20, 90), b, "RightToLeft");
            GameObjectC G3 = new GameObjectC(A, new Point(50, 1), b, "Projectile");
            GameObjectC G4 = new GameObjectC(A, new Point(1, 1), b, "Diagonal");
            GameObjectC G5 = new GameObjectC(A, new Point(10, 1), b, "Patrolling");
            List<GameObjectC> Objects = new List<GameObjectC>();
            Objects.Add(G1);
            Objects.Add(G2);
            Objects.Add(G3);
            Objects.Add(G4);
            Objects.Add(G5);
            while (true)
            {
                Thread.Sleep(100);
                foreach (GameObjectC G in Objects)
                {
                    G.Erase();
                    G.Move();
                    G.Draw();

                }
            }
        }

    }
}
