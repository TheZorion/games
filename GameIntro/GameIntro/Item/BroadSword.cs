using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    class BroadSword : Items
    {
        Type _type = Type.TwoHanded;
        int _damage;
        int _magicDamage;
        int _durability;
        int _special;
        String _name;
        Random r = new Random();

        public BroadSword(String name)
        {
            _damage = r.Next(10);
            Durability = r.Next(30) + 20;
            _magicDamage = r.Next(10);
            _name = name;

        }     

        int Durability
        {
            get{return _durability;}
            set{_durability= value;}  
        }
        public String GetPic(){
        
            return @"..\..\Pictures\broadsword1.jpg";
        }
        override public String ToString()
        {
            return _name + "\nDurability: "+Durability+"\nDamage: " + _damage + "\nMagic Damage: " + _magicDamage;
        }
        public int GetAttack()
        {
            return _damage + _magicDamage;
        }
        public int GetDefense()
        {
            return 0;
        }
        public Type TheType()
        {
            return _type;
        }
        public int Damage()
        {
            return _damage;
        }
        public int Special()
        {
            return _special;
        }
        public int MagicDamage()
        {
            return _magicDamage;
        }
        public String Name()
        {
            return _name;
        }
    }
}
