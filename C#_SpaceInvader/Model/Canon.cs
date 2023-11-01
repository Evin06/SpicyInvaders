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
                x+=2;
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
                x-=2;
            }
        }
        public Missile dropMissile()
        {
            Missile Missiledrop = this.missileS.First();
            missileS.Remove(Missiledrop);
            Missiledrop.x = x;
            Missiledrop.y = y;
            Missiledrop.missileIsLaunched = true;
            return Missiledrop;
        }

        public void chargement(Missile missileDefault)
        {
            this.missileS.Add(missileDefault);
        }
    }
}
