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
        public Items firstHand{get;set;}
        public Items shield { get; set; }
        public Items belt { get; set; }
        public Items armor { get; set; }
        public Items pants { get; set; }
        public Items boots { get; set; }
        public Items helmet { get; set; }
        public Items ring { get; set; }
        public Items amulet { get; set; }
        public Items gloves { get; set; }
        private Player(String name, TypesOfRaces.Race race, int health) 
            : base (name, race, health){
                Inventory.Add(new BroadSword("Bad sword"));    
            Inventory.Add(new BroadSword("Excellent broadsword"));
            Inventory.Add(new BroadSword("Bad sword"));
            Inventory.Add(new BroadSword("Excellent broadsword"));
            Inventory.Add(new BroadSword("Bad sword"));    
            Inventory.Add(new BroadSword("Excellent broadsword"));
            Inventory.Add(new BroadSword("Excellent broadsword"));
            Inventory.Add(new BroadSword("Bad sword"));
            Inventory.Add(new BroadSword("Excellent broadsword"));
            Inventory.Add(new BroadSword("Excellent broadsword"));
            Inventory.Add(new BroadSword("Bad sword"));
            Inventory.Add(new BroadSword("Excellent broadsword"));
                
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
                defense += item.GetDefense();
            }
            return defense;
        }
        override public int getAttack()
        {
            int attack = 0;
            foreach (Items item in equiptment)
            {
                attack += item.GetAttack();
            }
            return attack;
        }
        public int EquiptItem(Items item)
        {
            foreach (Items i in equiptment)
                if (i.TheType() == item.TheType())
                {
                    equiptment.Remove(i);
                    Inventory.Add(i); break;
                }
            switch (item.TheType())
            {
                case Item.Type.Gloves: gloves = item; break;
                case Item.Type.Pants: pants = item; break;
                case Item.Type.Armor: armor = item; break;
                case Item.Type.Helmet: helmet = item;break;
                case Item.Type.OneHanded: firstHand = item;break;
                case Item.Type.Shield: shield = item; break;
                case Item.Type.Shoes: boots = item;break;
                case Item.Type.TwoHanded: firstHand = item;
                    if(shield != null){
                        foreach (Items eq in equiptment)
                            if(eq.TheType() == Item.Type.Shield)
                                equiptment.Remove(eq);
                        shield = null;
                    }
                    break;                
            }
            Inventory.Remove(item);
            equiptment.Add(item);
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
                if (item.TheType() == type)
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
                if (item.TheType() == type)
                    return item.ToString();
            return null;

        }
        public List<Items> getItems()
        {
            return equiptment;
        }

        internal List<Items> GetInventory()
        {
            return Inventory;
        }
    }
}
