using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameIntro.Item;
using GameIntro.Player;

namespace GameIntro.Views
{
    public partial class EquiptmentView : Form
    {
        Player.Player _p1;
        ToolTip toolTip1;
        Controller.Controller _controller;
        public EquiptmentView(Player.Player p1)
        {
            _p1 = p1;
            _controller = Controller.Controller.getController(_p1);
            InitializeComponent();
            InitializeToolTip();
            InitializeInventory();
            FirstHandPic.MouseHover += new System.EventHandler(FirstHandPic_MouseHover);
            //Inventory.MouseDoubleClick += Inventory_MouseDoubleClick;
            //Inventory.MouseHover += Inventory_MouseHover;
        }

        private void InitializeInventory()
        {
            //*2 is random number but it works
            panel1.Controls.Clear();
            panel1.Width = InventoryItem.width()*2;
            List<Items> items = _controller.getInventory();
            for (int i = 0; i < items.Count; i++)
            {
                InventoryItem II = new InventoryItem(items[i]);
                II.Location = new Point(II.Location.X, i*II.Height);
                panel1.Controls.Add(II);
                II.SelectItem += II_SelectItem;

            }
        }

        void II_SelectItem(object sender, EquiptItemArgs e)
        {
            _controller.EquiptItem(e.InventoryItem.item);
            panel1.Controls.Remove(e.InventoryItem);
            InitializeInventory();
            FirstHandPic.BackgroundImage = Image.FromFile(e.InventoryItem.item.GetPic());
            FirstHandPic.BackgroundImageLayout = ImageLayout.Stretch;

        }
        void Inventory_MouseHover(object sender, EventArgs e)
        {
            //Point point = Inventory.PointToClient(Cursor.Position);
            //int index = Inventory.IndexFromPoint(point);
            //if (index < 0) return;
            //Items item = ((InventoryItem)Inventory.Items[index]).item;
            //toolTip1.SetToolTip(Inventory, item.ToString());
        }
        private void InitializeToolTip()
        {
            // Create the ToolTip and associate with the Form container.
            toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 50000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
        }
        
        void FirstHandPic_MouseHover(object sender, EventArgs e)
        {
            List<Items> test = _p1.getItems();
            Items i1 = test[0];
            i1.ToString();
            if(_p1.firstHand != null)
                toolTip1.SetToolTip(this.FirstHandPic, _p1.firstHand.ToString());

        }

        void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals("i"))
                this.Hide();
        }

        
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar.ToString().Equals("i"))
            {
                this.Hide();
            }
        }
    }
}
