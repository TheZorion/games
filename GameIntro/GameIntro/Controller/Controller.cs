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

        public List<Items> getInventory()
        {
            return player.GetInventory();
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
    }
}
