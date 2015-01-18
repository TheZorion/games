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
        private static Player.Player player;
        private static Controller _controller;

        public static Controller getController(Player.Player p1)
        {
            if (_controller == null)
            {
                _controller = new Controller();
                player = p1;
            }
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
    }
}
