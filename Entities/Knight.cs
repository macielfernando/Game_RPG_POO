using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_rpg.Entities
{
    internal class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }


        public override string Attack()
        {
            return this.Name + " " + "Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
             return this.Name + "Lançou Magia SUPER com Bonus de"+ " "+ Bonus;
            }
            else
            {
                return this.Name + "Lançou uma magia com força fraca com bonus de" + " " + Bonus;
            }
           
        }
        
        

    }
}
