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
        }

        void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals("i"))
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Weapons broadSword = new BroadSword("Excellent broad sword");
            textBox1.Text = broadSword.ToString();
            Items w = new BroadSword("bad");
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
