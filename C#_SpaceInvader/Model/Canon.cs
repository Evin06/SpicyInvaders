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
        new List<MissileCanon> missiles = new List<MissileCanon>();

        private string[] CANON =
      {
            @"       |       ",
            @"      / \      ",
            @"     / _ \     ",
            @"  | | ( ) | |  ",
            @"  |-|     |-|  ",
            @"   /  | |  \  ",
            @"  |__/|_|\__|  ",
            @"   WW www WW  ",
        };



        //affichage du canon
        public void Draw()
        {

            for (int i = 0; i < CANON.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(CANON[i]);
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
                x += 2;
            }

        }
        //movement a gauche
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
        public void chargement(MissileCanon missileDefault)
        {
            this.missiles.Add(missileDefault);
        }
        public Missile dropMissile()
        {
            MissileCanon Missiledrop = this.missiles.First();
            Missiledrop.x = x;
            Missiledrop.y = y;
            Missiledrop.missileIsLaunched = true;
            return Missiledrop;
        }
    }
}
