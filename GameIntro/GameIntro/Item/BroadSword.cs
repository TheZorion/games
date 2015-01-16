using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    class BroadSword : Weapons
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
            Damage = r.Next(10);
            Durability = r.Next(30) + 20;
            MagicDamage = r.Next(10);
            _name = name;

        }     
        String Name
        {
            get { return _name; }
        }
        int Damage
        {
            get{return _damage;}
            set{_damage = value;}  
        }
        int MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; } 
        }
        int Durability
        {
            get{return _durability;}
            set{_durability= value;}  
        }
        int Special
        {
            get { return _special; }
            set { _special = value; }
        }
        public String GetPic(){
        
            return @"..\..\Pictures\broadsword1.jpg";
        }
        override public String ToString()
        {
            return Name + "\nDurability: "+Durability+"\nDamage: " + Damage + "\nMagic Damage: " + MagicDamage;
        }
        public int GetAttack()
        {
            return Damage + MagicDamage;
        }
        public int GetDefense()
        {
            return 0;
        }
        public Type TheType()
        {
            return _type;
        }
    }
}
