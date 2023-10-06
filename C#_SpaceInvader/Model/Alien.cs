using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Alien
    {
        private string[] view =
      {
            @"   ▄ ▀▄  ▄▀ ▄    ",
            @"   █▄██████▄█    ",
            @"   ███▄██▄███    ",
            @"   ▀████████▀    ",
            @"    ▄▀    ▀▄     ",
        };


        public int x;
        public int y;
        public bool limit = true;
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

            if (limit == true)
            {
                x++;
                if (x == Console.WindowWidth - 15)
                {
                    y++;
                    limit = false;
                }

            }
            if (limit == false)
            {
                x--;
                if (x == 0 )
                {
                    y++;
                    limit = true;
                }

            }
            



        }
    }
}
