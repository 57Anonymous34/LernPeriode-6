using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lern_periode_6
{
    internal class Schwert
    {




        public string Name;
        public int Damage { get; }
        public int Price { get; }

        public Schwert(string name, int damage, int price)
        {
            Name = name;
            Damage = damage;
            Price = price;

        }
    }
}
