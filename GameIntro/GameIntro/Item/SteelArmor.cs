using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    class SteelArmor : Items
    {
        public SteelArmor(String name)
        {
            Name = name;
            Defense = Random.Next(10, 20);
            MagicDefense = Random.Next(5, 10);
            Durability = Random.Next(20, 30);
            Type = Type.Armor;
        }
        public override String GetPic()
        {
            return @"..\..\Pictures\steelArmor.png";
        }
    }

    
}
