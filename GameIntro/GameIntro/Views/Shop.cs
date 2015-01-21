using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameIntro.Controller;
using GameIntro.Item;

namespace GameIntro.Views
{
    public partial class Shop : Form
    {
        private Controller.Controller _controller;
        private static Shop _shop; 
        private Shop()
        {
            _controller = Controller.Controller.getController();
            InitializeComponent();
            InitializeInventory(_controller.getInventory());
            _controller.AddMethodToMoneyChanged(player_MoneyChanged);
            _controller.AddMethodToInventoryChanged(player_InventoryChanged);
            this.FormClosing += Shop_FormClosing;
            
        }
        void player_InventoryChanged(object sender, Player.InventoryArgs e){
            InitializeInventory(e.GetInventory);
        }
        void player_MoneyChanged(object sender, Player.MoneyArgs e)
        {
            toolStripMoney.Text = ""+e.GetMoney;
        }
        void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;// this cancels the close event.
        }

        public static Shop GetView()
        {
            if (_shop == null)
                _shop = new Shop();
            return _shop;
        }

        private void InitializeInventory(List<Items> items)
        {
            //*2 is random number but it works
            Inventory.Controls.Clear();
            Inventory.Width = InventoryItem.width() * 2;
            Inventory.Controls.Add(menuStrip1);
            for (int i = 0; i < items.Count; i++)
            {
                InventoryItem II = new InventoryItem(items[i]);
                II.Location = new Point(II.Location.X, i * II.Height+menuStrip1.Height);
                Inventory.Controls.Add(II);
                II.SelectItem += II_SelectItem;

            }
            ShopInventory.Controls.Clear();
            List<Items> shopItems = _controller.GetShopInventory();
            for(int i = 0; i<shopItems.Count; i++)
            {
                InventoryItem II = new InventoryItem(shopItems[i]);
                II.Location = new Point(II.Location.X, i * II.Height);
                ShopInventory.Controls.Add(II);
                II.SelectItem += II_SelectItem;
            }


        }
        void II_SelectItem(object sender, EquiptItemArgs e)
        {
            if (((InventoryItem)sender).Parent == Inventory)
                _controller.SellItem(e.InventoryItem.item);
            else if (((InventoryItem)sender).Parent == ShopInventory)
                _controller.BuyItem(e.InventoryItem.item);
        }
    }
}
