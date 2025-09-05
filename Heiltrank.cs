using Lern_periode_6.Held;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lern_periode_6
{
    class Heiltrank
    {
        public int Heilung;
        public int Price;

        public Heiltrank(int heilung, int price)
        {
            this.Heilung = Math.Abs(heilung);
            Price = price;


        }

        public void Anwenden(Hulk hulk)
        {
            hulk.TrankTrinken(Heilung);

        }
    }
} 

