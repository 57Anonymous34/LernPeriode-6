using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lern_periode_6.Bösewicht
{
    class Bösemann
    {



        public string name;
        public string weapon;
        public string ability;
        public int life;
        public int damage;

        public Bösemann(string name, string Weapon, string ability, int life, int damage)
        {
            this.name = name;
            this.weapon = Weapon;
            this.ability = ability;
            this.life = life;
            this.damage = damage;
        }
    }
}
