using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameIntro.Views
{
    
    public partial class InventoryItem : UserControl
    {
        public Item.Items item{get;set;}
        public event EventHandler<EquiptItemArgs> SelectItem;
        ToolTip toolTip1 = new ToolTip();
        public InventoryItem(Item.Items item)
        {
            InitializeComponent();
            this.item = item;
            InitializeDescription();
            this.MouseDoubleClick += InventoryItem_MouseDoubleClick;
            this.MouseClick += InventoryItem_MouseClick;
            this.MouseHover += InventoryItem_MouseHover;
        }

        void InventoryItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                EventHandler<EquiptItemArgs> handler = SelectItem;
                if (handler != null)
                    handler(this, new EquiptItemArgs(this));
            }
        }
        private void InitializeToolTip()
        {
            // Create the ToolTip and associate with the Form container.
            toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 50000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
        }
        void InventoryItem_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this, item.ToString());
        }
        void InventoryItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EquiptItemArgs eq;
            EventHandler<EquiptItemArgs> handler = SelectItem;
            if(handler != null)
                handler(this,new EquiptItemArgs(this));
        }
        private InventoryItem() { }
        private void InitializeDescription()
        {
            Description.Text = item.Name();
            Special.Text = ""+item.Special();
            if (item.TheType() == Item.Type.Armor || item.TheType() == Item.Type.Gloves || item.TheType() == Item.Type.Helmet || item.TheType() == Item.Type.Pants || item.TheType() == Item.Type.Shield || item.TheType() == Item.Type.Shoes)
            {
                DamageArmor.Text = "Armor: " + item.GetDefense();
            }
            else
                DamageArmor.Text = "Damage: " + item.Damage() + " + " + item.MagicDamage();

        }
        public static int width()
        {
            return new InventoryItem().Width;
        }
    }
    public class EquiptItemArgs : EventArgs
    {
        InventoryItem _inventoryItem;
        public EquiptItemArgs(InventoryItem inventoryItem)
        {
            _inventoryItem = inventoryItem;
        }
        public InventoryItem InventoryItem
        {
            get { return _inventoryItem; }
            set { _inventoryItem = value; }
        }
    }
}
