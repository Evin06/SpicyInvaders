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
        public bool movingRight = true;
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
            // Movement de l'alien de gauche a droite 
            if (movingRight)
            {
                x += 15;
                //Si l'alien est au niveau de l'écran il descent 
                if (x == Console.WindowWidth - 15)
                {
                    this.y += 5;
                    movingRight = false;
                }

            }
            {
                x -= 15;
                if (x <= 3)
                {
                    this.y += 5;
                    movingRight = true;
                }

            }
        }
    }
}
