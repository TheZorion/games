using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameIntro.Item;

namespace GameIntro.Player
{
    
    public class Player : Creature
    {
        public event EventHandler<MoneyArgs> MoneyChanged;
        public event EventHandler<InventoryArgs> InventoryChanged;
        public event EventHandler<EquiptmentArgs> EquiptmentChanged;

        private static Player _player;
        List<Items> _inventory = new List<Items>();
        List<Items> _equiptment = new List<Items>();
        private int _money;
        private Player(String name, TypesOfRaces.Race race, int health, int mana) 
            : base (name, race, health, mana){
                _inventory.Add(new BroadSword("Excellent sword"));    
            _inventory.Add(new SteelCap("Excellent Steel Cap"));
            _inventory.Add(new SteelArmor("Excellent Steel Armor"));
            _inventory.Add(new SteelPants("Excellent Steel Legs"));
            _inventory.Add(new SteelBelt("Excellent Steel Belt"));
            _inventory.Add(new SteelBoots("Excellent Steel Boots"));
            _inventory.Add(new SteelGlove("Excellent Steel Gloves"));
            _inventory.Add(new Buckle("Excellet Buckle"));
            FireInventoryEvent();
            FireEquiptmentEvent();
            
                
        }
        public override string GetPic()
        {
            return @"..\..\Pictures\knight.jpg";
        }
        public int Money { 
            get { 
                return _money; 
            } 
            set {
                
                _money = value;
                EventHandler<MoneyArgs> handler = MoneyChanged;
                if (handler != null)
                    handler(this, new MoneyArgs(Money));
            } 
        }
        public static Player GetPlayer(String name, TypesOfRaces.Race race, int health, int mana)
        {
            if (_player == null)
                _player = new Player(name, race, health, mana);
            return _player;
        }

        override public int getDefense()
        {
            int defense = 0;
            foreach (Items item in _equiptment)
            {
                defense += item.Defense;
            }
            return defense;
        }
        override public int getAttack()
        {
            int attack = 0;
            foreach (Items item in _equiptment)
            {
                attack += item.Damage;
            }
            return attack;
        }
        public int EquiptItem(Items item)
        {
            //Remove equited item
            foreach (Items i in _equiptment)
                if (i.Type == item.Type)
                {
                    _equiptment.Remove(i);
                    _inventory.Add(i); break;
                }
            _inventory.Remove(item);
            _equiptment.Add(item);
            //Removing shield if a two-hand weapon is equipted
            if (item.Type == Item.Type.TwoHanded)
                foreach (Items i in _equiptment)
                    if (i.Type == Item.Type.Shield)
                    {
                        _equiptment.Remove(i);
                        _inventory.Add(i);
                        break;
                    }
            FireInventoryEvent();
            FireEquiptmentEvent();
            return _equiptment.Count;
        }
        public void UnEquiptItem(Items item)
        {
            if (item != null && _equiptment.Contains(item))
            {
                _equiptment.Remove(item);
                _inventory.Add(item);
                FireInventoryEvent();
            }
        }
        public bool UnEquiptItem(Item.Type type)
        {
            foreach (Items item in _equiptment)
                if (item.Type == type)
                {
                    _equiptment.Remove(item);
                    _inventory.Add(item);
                    FireEquiptmentEvent();
                    FireInventoryEvent();
                    return true;
                }
            return false;
        }
        public String ItemName(Item.Type type)
        {
            foreach (Items item in _equiptment)
                if (item.Type == type)
                    return item.ToString();
            return null;

        }
        public List<Items> GetEquiptment()
        {
            return _equiptment;
        }

        internal List<Items> GetInventory()
        {
            return _inventory;
        }
        public int SellItem(Items item)
        {
            if (_inventory.Contains(item))
            {
                Money += item.Value;
                _inventory.Remove(item);
                FireInventoryEvent();
                return item.Value;
            }
            else return 0;
        }
        public int BuyItem(Items item)
        {
            _inventory.Add(item);
            Money -= item.Value;
            FireInventoryEvent();
            return item.Value;
        }
        private void FireEquiptmentEvent()
        {
            EventHandler<EquiptmentArgs> handler = EquiptmentChanged;
            if (handler != null)
                handler(this, new EquiptmentArgs(_equiptment));
        }
        private void FireInventoryEvent()
        {
            EventHandler<InventoryArgs> handler = InventoryChanged;
            if (handler != null)
                handler(this, new InventoryArgs(_inventory));
        }
    }

    
    public class MoneyArgs: EventArgs
    {
        int _money;
        public MoneyArgs(int money)
        {
            _money = money;
        }
        public int GetMoney
        {
            get { return _money; }
            set { _money = value; }
        }
    }
    public class InventoryArgs : EventArgs
    {
        List<Items> _inventory;
        public InventoryArgs(List<Items> inventory)
        {
            _inventory = inventory;
        }
        public List<Items> GetInventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }
    }
    public class EquiptmentArgs : EventArgs
    {
         List<Items> _equiptment;
         public EquiptmentArgs(List<Items> equiptment)
        {
            _equiptment = equiptment;
        }
        public List<Items> GetEquiptment
        {
            get { return _equiptment; }
            set { _equiptment = value; }
        }
    }
    
}
