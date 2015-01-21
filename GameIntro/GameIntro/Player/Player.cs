using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameIntro.Item;

namespace GameIntro.Player
{
    public class Player : Creature
    {
        private static Player _player;
        List<Items> Inventory = new List<Items>();
        List<Items> equiptment = new List<Items>();
        private Player(String name, TypesOfRaces.Race race, int health) 
            : base (name, race, health){
            Inventory.Add(new BroadSword("Bad sword"));    
            Inventory.Add(new SteelCap("Excellet Steel Cap"));
            Inventory.Add(new SteelArmor("Excellet Steel Armor"));
            Inventory.Add(new SteelPants("Excellet Steel Legs"));
            Inventory.Add(new SteelBelt("Excellet Steel Belt"));
            Inventory.Add(new SteelBoots("Excellet Steel Boots"));
            Inventory.Add(new SteelGlove("Excellet Steel Gloves"));
            Inventory.Add(new Buckle("Excellet Buckle"));

                
        }
        public static Player GetPlayer(String name, TypesOfRaces.Race race, int health)
        {
            if (_player == null)
                _player = new Player(name, race, health);
            return _player;
        }

        override public int getDefense()
        {
            int defense = 0;
            foreach (Items item in equiptment)
            {
                defense += item.Defense;
            }
            return defense;
        }
        override public int getAttack()
        {
            int attack = 0;
            foreach (Items item in equiptment)
            {
                attack += item.Damage;
            }
            return attack;
        }
        public int EquiptItem(Items item)
        {
            //Remove equited item
            foreach (Items i in equiptment)
                if (i.Type == item.Type)
                {
                    equiptment.Remove(i);
                    Inventory.Add(i); break;
                }
            Inventory.Remove(item);
            equiptment.Add(item);
            //Removing shield if a two-hand weapon is equipted
            if (item.Type == Item.Type.TwoHanded)
                foreach (Items i in equiptment)
                    if (i.Type == Item.Type.Shield)
                    {
                        equiptment.Remove(i);
                        Inventory.Add(i);
                        break;
                    }
            return equiptment.Count;
        }
        public void UnEquiptItem(Items item)
        {
            if (item != null && equiptment.Contains(item))
            {
                equiptment.Remove(item);
                Inventory.Add(item);
            }
        }
        public bool UnEquiptItem(Item.Type type)
        {
            foreach (Items item in equiptment)
                if (item.Type == type)
                {
                    equiptment.Remove(item);
                    Inventory.Add(item);
                    return true;
                }
            return false;
        }
        public String ItemName(Item.Type type)
        {
            foreach (Items item in equiptment)
                if (item.Type == type)
                    return item.ToString();
            return null;

        }
        public List<Items> GetEquiptment()
        {
            return equiptment;
        }

        internal List<Items> GetInventory()
        {
            return Inventory;
        }
    }
}
