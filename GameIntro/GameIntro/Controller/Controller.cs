using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameIntro.Player;
using GameIntro.Item;

namespace GameIntro.Controller
{
    class Controller
    {
        Player.Player player;
        public Player.Player Player
        {
            get { return player; }
            set {
                if (player == null)
                {
                    player = value;
                }
            }
        }
        private static Controller _controller;

        public static Controller getController()
        {
            if (_controller == null)
                _controller = new Controller();
            return _controller;
        }
        public List<Items> GetShopInventory()
        {
            return ShopManager.GetShopManager().Items;
        }
        public List<Items> getInventory()
        {
            return player.GetInventory();
        }
        public List<Items> GetEquiptment()
        {
            return player.GetEquiptment();
        }

        public void EquiptItem(Items item)
        {
            player.EquiptItem(item);
        }

        public void UnEquiptItem(Items item)
        {
            player.UnEquiptItem(item);
        }
        public Boolean UnEquiptItem(Item.Type type)
        {
            return player.UnEquiptItem(type);
        }
        public String ItemName(Item.Type type)
        {
            return player.ItemName(type);
        }
        public int SellItem(Items item)
        {
            ShopManager.GetShopManager().BuyItem(item);
            return player.SellItem(item);
        }

        public int BuyItem(Items item)
        {
            ShopManager.GetShopManager().SellItem(item);
            return player.BuyItem(item);
        }

        public void AddMethodToMoneyChanged(EventHandler<MoneyArgs> Args)
        {
            player.MoneyChanged += Args;
        }
        public void AddMethodToInventoryChanged(EventHandler<InventoryArgs> Args)
        {
            player.InventoryChanged += Args;
        }
        public void AddMethodToEquiptmentChanged(EventHandler<EquiptmentArgs> Args)
        {
            player.EquiptmentChanged += Args;
        }
        public void AddMethodToManaChanged(EventHandler<ManaArgs> Args)
        {
            player.ManaChanged += Args;
        }
        public void AddMethodToHealthChanged(EventHandler<HealthArgs> Args)
        {
            player.HealthChanged += Args;
        }
    }
}
