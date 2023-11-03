using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Canon
    {

        public int x = 63;//position x du canon
        public int y = 41;//position y du canon 
        public bool move = true;//variable qui permet de dire si il part a droite ou a gauche
        new List<Missile> missileS = new List<Missile>();

        private string[] CANON =
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

            for (int i = 0; i < CANON.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(CANON[i]);
            }
        }

        /// <summary>
        /// permet de deplacer le canon a droite 
        /// </summary>
        public void MoveRight()
        {

            if (x == (Console.WindowWidth - 15))//si ca atteint le bord ca continue pas 
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
            if (x == 1)//si ca atteint le bord ca continue pas 
            {
                x = 1;
            }
            else
            {
                x -= 2;
            }
        }
        /// <summary>
        /// permet de tier les missiles 
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
