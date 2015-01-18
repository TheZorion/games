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
        
        Form _login;
        Form _equiptment;
        Player.Player _p1;
        Controller.Controller _controller;
        public GameView(Form login, Player.Player p1)
        {
            InitializeComponent();
            _login = login;
            _p1 = p1;
            _controller = Controller.Controller.getController(_p1);
            _equiptment = new EquiptmentView(_p1);
        }

        

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar.ToString().Equals("i") && !_equiptment.Visible)
            {
                _equiptment.Show();
            }
            else if (e.KeyChar.ToString().Equals("i") && _equiptment.Visible)
            {
                _equiptment.Hide();
            }
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _login.Close();
            _equiptment.Close();
            base.OnFormClosing(e);
        }
    }
}
