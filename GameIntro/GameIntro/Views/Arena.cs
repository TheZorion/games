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
    public partial class Arena : Form
    {
        Controller.Controller _controller = Controller.Controller.getController();
        private static Arena _arena;
        private Arena()
        {
            InitializeComponent();
            InitializeArena();
            this.FormClosing +=Arena_FormClosing;
        }


        private void InitializeArena()
        {
            panelPlayer.Controls.Add(new CreatureStats(_controller.Player));
        }

        public static Arena GetView()
        {
            if(_arena == null)
                _arena = new Arena();
            return _arena;
        }
        void Arena_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
