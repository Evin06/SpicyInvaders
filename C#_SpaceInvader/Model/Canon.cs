using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Canon
    {
        public int x = 63;
        public int y = 41;
        public bool move = true;
        new List<Missile> missiles = new List<Missile>();

        private string[] view =
      {
            @"       |       ",
            @"      / \      ",
            @"     / _ \     ",
            @"  | | ( ) | |  ",
            @"  |-|     |-|  ",
            @"   /  | |  \  ",
            @"  /   |_|   \  ",
            @" |___________| ",
        };



        //affichage du canon
        public void Draw()
        {

            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(view[i]);
            }
        }
        public void Move()
        {

        }
        //movement a droite
        public void MoveRight()
        {
            if (x == (Console.WindowWidth - 15))
            {
                x = Console.WindowWidth - 15;
            }
            else
            {
                x++;
            }

        }
        //movement a gauche
        public void MoveLeft()
        {
            if (x == 0)
            {
                x = 0;
            }
            else
            {
                x--;
            }
        }

    }
}
