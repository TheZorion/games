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
        Items broadSword;
        Player.Player _p1;
        ToolTip toolTip1;
        public EquiptmentView(Player.Player p1)
        {
            _p1 = p1;
            InitializeComponent();
            InitializeToolTip();
            button1.KeyPress += new KeyPressEventHandler(button1_KeyPress);
            FirstHandPic.MouseHover += new System.EventHandler(FirstHandPic_MouseHover);
            Inventory.MouseDoubleClick += Inventory_MouseDoubleClick;
            Inventory.MouseHover += Inventory_MouseHover;
        }
        void Inventory_MouseHover(object sender, EventArgs e)
        {
            Point point = Inventory.PointToClient(Cursor.Position);
            int index = Inventory.IndexFromPoint(point);
            if (index < 0) return;
            Items item = (Items)Inventory.Items[index];
            toolTip1.SetToolTip(Inventory, item.ToString());
        }
        private void InitializeToolTip()
        {
            // Create the ToolTip and associate with the Form container.
            toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
        }

        

        void Inventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Items item = (Items)Inventory.SelectedItem;
            if (Inventory.SelectedItem != null) {
                Inventory.Items.Remove(item);
                _p1.EquiptItem(item);
                FirstHandPic.BackgroundImage = Image.FromFile(item.GetPic());
                FirstHandPic.BackgroundImageLayout = ImageLayout.Stretch;
            }
            
        }
        
        void FirstHandPic_MouseHover(object sender, EventArgs e)
        {
            List<Items> test = _p1.getItems();
            Items i1 = test[0];
            i1.ToString();
            toolTip1.SetToolTip(this.FirstHandPic, i1.ToString());

        }

        void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals("i"))
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            broadSword = new BroadSword("Excellent broad sword");
            Inventory.Items.Add(broadSword);
           
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
