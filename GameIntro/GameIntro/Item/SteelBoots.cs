using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    class SteelBoots : Items
    {
        public SteelBoots(String name)
        {
            Name = name;
            Durability = Random.Next(3, 5);
            Defense = Random.Next(5, 10);
            MagicDefense = Random.Next(3, 5);
            Type = Item.Type.Shoes;
        }

        public override string GetPic()
        {
            return @"..\..\Pictures\steelBoots.jpg";
        }
    }
}
