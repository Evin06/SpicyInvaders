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
        new List<Missile> missileS = new List<Missile>();

        private string[] view =
      {
            @"       |       ",
            @"      / \      ",
            @"     / _ \     ",
            @"  | | ( ) | |  ",
            @"  |-|     |-|  ",
            @"   /  | |  \  ",
            @"  /  /|_|\  \  ",
            @" |__/ www \__| ",
        };



        /// <summary>
        /// permet d'afficher le canon 
        /// </summary>
        public void Draw()
        {

            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(view[i]);
            }
        }

        /// <summary>
        /// permet de deplacer le canon a droite 
        /// </summary>
        public void MoveRight()
        {
            if (x == (Console.WindowWidth - 15))
            {
                x = Console.WindowWidth - 15;
            }
            else
            {
                x += 2;
            }

        }
        /// <summary>
        /// Permet de deplacer le canon à gauche 
        /// </summary>
        public void MoveLeft()
        {
            if (x == 1)
            {
                x = 1;
            }
            else
            {
                x -= 2;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Missile shotMissile()
        {
            Missile Missileshot = this.missileS.First();
            missileS.Remove(Missileshot);
            Missileshot.x = x;
            Missileshot.y = y;
            Missileshot.missileIsLaunched = true;
            return Missileshot;
        }

        public void chargement(Missile missileDefault)
        {
            this.missileS.Add(missileDefault);
        }
    }
}
