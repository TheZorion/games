using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    class Buckle : Items
    {
        public Buckle(String name)
        {
            Name = name;
            Durability = Random.Next(10, 20);
            Defense = Random.Next(5, 10);
            MagicDefense = Random.Next(5, 10);
            Type = Item.Type.Shield;
 
        }

        public override string GetPic()
        {
            return @"..\..\Pictures\buckle.jpg";
        }
    }
}
