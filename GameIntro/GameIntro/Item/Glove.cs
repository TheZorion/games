using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    class SteelGlove : Items
    {
        public SteelGlove(String name)
        {
            Name = name;
            Durability = Random.Next(5, 10);
            Defense = Random.Next(3, 5);
            MagicDefense = Random.Next(2, 4);
            Type = Item.Type.Gloves;
        }

        public override string GetPic()
        {
            return @"..\..\Pictures\steelGlove.jpg";
        }
    }
}
