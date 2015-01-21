using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameIntro.Player;
using GameIntro.Controller;

namespace GameIntro.Views
{
    public partial class CreatureStats : UserControl
    {
        Controller.Controller _controller = Controller.Controller.getController();
        Creature _creature;
        ToolTip tip = new ToolTip();
        public CreatureStats(Player.Creature creature)
        {
            _creature = creature;
            InitializeComponent();
            InitializeToolTip();
            InitializeSetup();
            _controller.AddMethodToHealthChanged(HealthChanged);
            _controller.AddMethodToManaChanged(ManaChanged);
        }
        private void ManaChanged(object sender, ManaArgs e)
        {
            progressBarMana.Value = _creature.CurrentMana;
            progressBarMana.Refresh();
        }
        private void HealthChanged(object sender, HealthArgs e)
        {
            progressBarHealth.Value = _creature.CurrentHealth;
            progressBarHealth.Refresh();
        }
        private void InitializeSetup()
        {
            pictureBox.BackgroundImage = Image.FromFile(_creature.GetPic());
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            progressBarHealth.Maximum = _creature.Health;
            progressBarMana.Maximum = _creature.Mana;
            progressBarHealth.Show();
            progressBarMana.Show();
            progressBarHealth.MouseHover += bar_MouseHover;
            progressBarMana.MouseHover += bar_MouseHover;
            pictureBox.MouseHover += pictureBox_MouseHover;
            
        }

        void pictureBox_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(this, _creature.ToString());
        }
        void bar_MouseHover(object sender, EventArgs e)
        {
            if (((ProgressBar)sender).Equals(progressBarHealth))
                tip.SetToolTip(this, _creature.CurrentHealth + "/" + _creature.Health);
            else
                tip.SetToolTip(this, _creature.CurrentMana + "/" + _creature.Mana);
            
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
    }
}
