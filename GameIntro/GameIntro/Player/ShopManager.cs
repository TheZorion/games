using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameIntro.Item;

namespace GameIntro.Player
{
    
    class ShopManager
    {
        private List<Items> _items;
        private static ShopManager _shopManager;
        private ShopManager()
        {
            _items = new List<Items>();
        }
        public List<Items> Items
        {
            get { return _items;}
            set { _items = value;}
        }
        public void BuyItem(Items item)
        {
            _items.Add(item);
        }
        public void SellItem(Items item)
        {
            if(_items.Contains(item))
                _items.Remove(item);
        }
        public static ShopManager GetShopManager()
        {
            if (_shopManager == null)
                _shopManager = new ShopManager();
            return _shopManager;

        }
    }
}
