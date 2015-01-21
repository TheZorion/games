using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    class SteelCap : Items
    {
        Random r;
        public SteelCap(String name)
        {
            r = new Random();
            Defense = r.Next(5, 10);
            Durability = r.Next(20, 30);
            MagicDefense= r.Next(5, 10);
            Name = name;
            Type = Type.Helmet;

        }
        public override String GetPic()
        {
            return @"..\..\Pictures\steelCap.jpg";
        }
        /*public int GetDefense()
        {
            return _defense;
        }
        public int GetAttack()
        {
            return _damage + _magicDamage;

        }
        public int Durability()
        {
            return _durability;
        }
        public Type TheType()
        {
            return _type;
        }
        public String GetPic()
        {
            return @"..\..\Pictures\steelCap.jpg";
        }
        public String Name()
        {
            return _name;
        }
        public int MagicDamage()
        {
            return _magicDamage;
        }
        public int Damage()
        {
            return _damage;

        }

        public int Special()
        {
            return _special;
        }

        override public String ToString()
        {
            return _name + "\nDurability: " + _durability + "\nDefense: " + _defense+ "\nMagic Defense: " + _magicDefense;
        }*/
    }
}
