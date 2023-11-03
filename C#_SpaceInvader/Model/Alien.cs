using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Alien
    {
        /// <summary>
        /// model de l'alien
        /// </summary>
        private string[] view =
      {
            @"   ▄ ▀▄  ▄▀ ▄    ",
            @"   █▄██████▄█    ",
            @"   ███▄██▄███    ",
            @"   ▀████████▀    ",
            @"    ▄▀    ▀▄     ",
        };


        public int x;//position x de l'alien
        public int y;//position y de l'alien 
        public bool movingRight = true;

        /// <summary>
        /// permet d'afficher l'alien 
        /// </summary>
        public void Draw()
        {
            //Affichage de l'alien
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(view[i]);
            }
        }
        /// <summary>
        /// permet de deplaer l'alien de faire des zig zag 
        /// </summary>
        public void Move()
        {
            // Movement de l'alien de gauche a droite 
            if (movingRight)
            {
                x += 15;
                //Si l'alien est au niveau de l'écran il descent 
                if (x == Console.WindowWidth - 15)//Si l'alien atteint le bord de l'écran, il descend
                {
                    this.y += 5;
                    movingRight = false;
                }

            }

            else //Movement de l'alien de droite a gauche
            {
                x -= 15;
                if (x <= 0)//Si l'alien atteint le bord de l'écran, il descend
                {
                    this.y += 5;
                    movingRight = true;
                }
            }

            if (y >= 40) // Arrêter le jeu lorsque la position y atteint 50
            {
                Console.Clear(); // Effacer l'écran
                Console.WriteLine("Game Over"); // Afficher un message de fin de jeu
                Environment.Exit(0);
            }

        }
    }
}
