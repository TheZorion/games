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
        Controller.Controller _controller;
        public GameView(Form login)
        {
            InitializeComponent();
            _login = login;
            _equiptment = new EquiptmentView();
        }

        

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar.ToString().Equals("i") && !_equiptment.Visible)
            {
                EquiptmentView.GetView().Show();
            }
            else if (e.KeyChar.ToString().Equals("i") && _equiptment.Visible)
            {
                EquiptmentView.GetView().Hide();
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
