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
        public EquiptmentView(Player.Player p1)
        {
            _p1 = p1;
            InitializeComponent();
            button1.KeyPress += new KeyPressEventHandler(button1_KeyPress);
            FirstHandPic.MouseHover += new System.EventHandler(FirstHandPic_MouseHover);
        }
        
        void FirstHandPic_MouseHover(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

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
            Weapons broadSword = new BroadSword("Excellent broad sword");
            Items w = broadSword;
            _p1.EquiptItem(w);
            FirstHandPic.BackgroundImage = Image.FromFile(w.GetPic());
            FirstHandPic.BackgroundImageLayout = ImageLayout.Stretch;
            
        }
        
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar.ToString().Equals("i"))
            {
                this.Show();
            }
        }
    }
}
