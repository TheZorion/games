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
        List<Control> controls = new List<Control>();
        public Item.Items item{get;set;}
        public event EventHandler<EquiptItemArgs> SelectItem;
        ToolTip toolTip1 = new ToolTip();
        public InventoryItem(Item.Items item)
        {
            InitializeComponent();
            this.item = item;
            InitializeDescription();
            InitializeEvents();
        }

        private InventoryItem() { }

        private void InitializeEvents()
        {
            controls.Add(Description);
            controls.Add(DamageArmor);
            controls.Add(Special);
            controls.Add(this);
            foreach (Control c in controls)
            {
                c.MouseClick += InventoryItem_MouseClick;
                c.MouseHover += InventoryItem_MouseHover;
                c.MouseDoubleClick += InventoryItem_MouseDoubleClick;
            }
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
            EventHandler<EquiptItemArgs> handler = SelectItem;
            if(handler != null)
                handler(this,new EquiptItemArgs(this));
        }
        private void InitializeDescription()
        {
            Description.Text = item.Name;
            Special.Text = ""+item.Special;
            if (item.Type == Item.Type.OneHanded || item.Type == Item.Type.TwoHanded)
            {
                DamageArmor.Text = "Damage: " + item.Damage + " + " + item.MagicDamage;
            }
            else
                DamageArmor.Text = "Armor: " + item.Defense;

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
