using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Alien
    {
        private string[] ALIEN =
    {
            @"  ▄ ▀▄ ▄▀ ▄   ",
            @"  █▄█████▄█   ",
            @"  ███▄█▄███   ",
            @"  ▀███████▀   ",
            @"   ▄▀   ▀▄    ",
        };


        public int x;
        public int y = 2;
        public bool movingRight = true;
        public void Draw()
        {
            //Affichage de l'alien
            for (int i = 0; i < ALIEN.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(ALIEN[i]);
            }
        }
        public void Move()
        {
            // Movement de l'alien de gauche a droite 
            // Movement de l'alien de gauche a droite 
            if (movingRight)
            {
                x += 12;
                //Si l'alien est au niveau de l'écran il descent 
                if (x == Console.WindowWidth - 18)
                {
                    this.y += 5;
                    movingRight = false;
                }

            }
            else //Movement de l'alien de droite a gauche
            {
                x -= 11;
                if (x <= 3)
                {
                    this.y += 5;
                    movingRight = true;
                }

            }
        }
    }
}
