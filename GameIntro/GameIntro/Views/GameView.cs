using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameIntro.Views
{
    public partial class GameView : Form
    {
        ToolTip tip;
        Form _login;
        List<Panel> panels = new List<Panel>();
        public GameView(Form login)
        {
            InitializeComponent();
            InitializeToolTip();
            _login = login;
            InitializeEvents();
        }
        private void InitializeToolTip()
        {
            // Create the ToolTip and associate with the Form container.
            tip = new ToolTip();
            // Set up the delays for the ToolTip.
            tip.AutoPopDelay = 50000;
            tip.InitialDelay = 100;
            tip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            tip.ShowAlways = true;
        }
        private void InitializeEvents()
        {
            panels.Add(panelPlayer);
            panels.Add(panelShop);
            panels.Add(panelArena);
            foreach (Panel panel in panels)
            {
                panel.MouseHover += panel_MouseHover;
                panel.MouseClick += panel_MouseClick;
            }
        }

        void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (((Panel)sender).Equals(panelPlayer)){
                    EquiptmentView.GetView().Show();
                    Arena.GetView().Hide();
                    Shop.GetView().Hide();
                }

                else if (((Panel)sender).Equals(panelArena))
                {
                    Arena.GetView().Show();
                    EquiptmentView.GetView().Hide();
                    Shop.GetView().Hide();
                }
                else
                {
                    Shop.GetView().Show();
                    Arena.GetView().Hide();
                    EquiptmentView.GetView().Hide();
                }
            }
        }

        void panel_MouseHover(object sender, EventArgs e)
        {
            String message = "Press here to ";
            if ((Panel)sender == panelPlayer)
                message += "open the inventory";
            else if ((Panel)sender == panelArena)
                message += "enter the arena";
            else
                message += "enter the shop";
            tip.SetToolTip((Control)sender, message);
        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar.ToString().Equals("i") && !EquiptmentView.GetView().Visible)
                EquiptmentView.GetView().Show();
            else if (e.KeyChar.ToString().Equals("i") && EquiptmentView.GetView().Visible)
                EquiptmentView.GetView().Hide();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _login.Close();
            EquiptmentView.GetView().Close();
            base.OnFormClosing(e);
        }
    }
}
