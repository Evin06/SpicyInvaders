using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Missile
    {
        //Position x du missile
        public int x;
        //Position y du missile
        public int y;
        
        public bool missileIsLaunched = false;
        //Dégat du missile
        public int damage;
        public static string MISSILE = @"  |  ";
    
           public static void DrawMissileJoueur(MissileCanon missile, Alien alien)
        {
            if (missile.missileIsLaunched)
            {
                if (MISSILE == null) return;
                 Console.SetCursorPosition(missile.x + 5, missile.y-1);
                Console.WriteLine(MISSILE);
            }


        }
    }
}
