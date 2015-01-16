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
        public Player(String name, TypesOfRaces.Race race, int health) : base (name, race, health)
        {
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
            bool found = false;
            foreach (Items i in equiptment)
                if (i.TheType() == item.TheType())
                {
                    equiptment.Remove(i);
                    equiptment.Add(item);
                    found = true;
                    break;
                }
            if (!found)
                equiptment.Add(item);
            return equiptment.Count;
        }
    }
}
