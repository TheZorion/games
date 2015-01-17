using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameIntro.Item;

namespace GameIntro.Player
{
    public class Player : Creature
    {
        
        List<Items> equiptment = new List<Items>();
        Items firstHand;
        Items shield;
        Items belt;
        Items armor;
        Items pants;
        Items boots;
        Items helmet;
        Items ring;
        Items amulet;
        Items gloves;
        public Player(String name, TypesOfRaces.Race race, int health) 
            : base (name, race, health){
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
                    equiptment.Remove(i);
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
                equiptment.Add(item);
            return equiptment.Count;
        }
        public List<Items> getItems()
        {
            return equiptment;
        }
    }
}
