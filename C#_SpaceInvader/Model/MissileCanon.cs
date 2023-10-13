using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{ 
    public class MissileCanon : Missile
    {
        public MissileCanon(int damage)
        {
            this.damage = damage;
        }
        public void UpdateMisille()
        {
            if (missileIsLaunched)
            {

                this.y-=2 ;

                if (this.y == 3)// Quand il dépasse la bordure il s'enlève
                {
                    missileIsLaunched = false;
                }
            }

        } 
    }
}
