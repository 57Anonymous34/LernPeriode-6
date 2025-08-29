using Lern_periode_6.Waffen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lern_periode_6.Held
{
    class Scofield
    {


        public string name;
        public string weapon;
        // public Brechstange brechstange
        public string ability;
        public int life;
        public int damage;

        public Scofield(string name, string Weapon, string ability, int life, int damage)
        {
            this.name = name;
            this.weapon = Weapon;
            this.ability = ability;
            this.life = life;
            this.damage = damage;   
        }
        


    }
}
