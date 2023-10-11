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
            //Affichage de l'alien
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(view[i]);
            }
        }
        public void Move()
        {
            // Movement de l'alien de gauche a droite 
            if (limit == true)
            {
                x += 15;
                //Si l'alien est au niveau de l'écran il descent 
                if (x == Console.WindowWidth)
                {
                    this.y += 6;
                    limit = false;
                }

            }
            //Movement de l'alien de droite a gauche
            if (limit == false)
            {
                x -= 15;
                if (x == 0)
                {
                    this.y += 6;
                    limit = true;
                }

            }
            

        }
    }
}
