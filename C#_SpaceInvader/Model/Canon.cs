using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Canon
    {
        private string[] view =
      {
            @"       |       ",
            @"      / \      ",
            @"     / _ \     ",
            @"  | | ( ) | |  ",
            @"  |-|     |-|  ",
            @"    |  _  |    ",
            @"|__/  | |  \__|  ",
            @"  /   |_|   \  ",
            @" |___________| ",
            @"   |_|_|_|_|  ",
            @"    WWWWWWW ",
        };


        public int x = 65;
        public int y = 35;
        public bool move = true;
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
