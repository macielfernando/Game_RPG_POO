using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_rpg.Entities
{
    public class Arus : Hero

    {
        public Arus(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public string name;
        public int level;
        public string heroType;

        public override string Attack()
        {
            return this.Name + " " + "Atacou com sua espada";
        }

    }

}


