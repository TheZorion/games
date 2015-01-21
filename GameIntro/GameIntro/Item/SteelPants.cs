using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    class SteelPants : Items
    {
        public SteelPants(String name)
        {
            Name = name;
            Durability = Random.Next(3, 5);
            Defense = Random.Next(5, 10);
            MagicDefense = Random.Next(3, 5);
            Type = Item.Type.Pants;
        }

        public override string GetPic()
        {
            return @"..\..\Pictures\steelPants.jpg";
        }
    }
}
