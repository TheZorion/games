using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    public abstract class Items
    {
        private String _name = "Not named";
        private int _damage = 0;
        private int _magicDamage= 0;
        private int _defense= 0;
        private int _magicDefense= 0;
        private Type _type = Type.Armor;
        private int _durability = 0;
        private int _special = 0;
        private int _value = 1;
        private Random r = new Random();
        public int Value { get { return _value; } set { _value = value; } }
        public Random Random {get{return r;}}
        public String Name { get { return _name; } set { _name = value; } }
        public int Damage { get { return _damage; } set { _damage = value;} }
        public int MagicDamage { get { return _magicDamage; } set { _magicDamage = value; } }
        public int Defense { get { return _defense; } set { _defense = value; } }
        public int MagicDefense { get { return _magicDefense; } set { _magicDefense = value; } }
        public Type Type { get { return _type; } set { _type = value; } }
        public int Durability { get{return _durability;} set{_durability = value;} }
        public int Special { get { return _special; } set { _special = value; } }

        public override string ToString()
        {
            if (Type == Type.OneHanded|| Type == Type.TwoHanded)
                return Name + "\nDurability: "+Durability+"\nDamage: " + Damage + "\nMagic Damage: " + MagicDamage;
            else
                return Name + "\nDurability: " + Durability + "\nDefense: " + Defense + "\nMagic Defense: " + MagicDefense;
        }

  
        public abstract String GetPic();
    }
}
