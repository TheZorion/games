using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    class BroadSword : Items
    {
        public BroadSword(String name)
        {
            Damage = Random.Next(0, 10);
            Durability = Random.Next(30) + 20;
            MagicDamage = Random.Next(10);
            Name = name;
            Type = Type.OneHanded;

        }
        public override String GetPic(){
        
            return @"..\..\Pictures\broadsword1.jpg";
        }
    }
}
