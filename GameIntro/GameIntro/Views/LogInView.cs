﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GameIntro.Player;

namespace GameIntro.Views
{
    public partial class LogInView : Form
    {
        public LogInView()
        {
            
            InitializeComponent();
            BackPressed();
            InitializeList();
            
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewPressed();
        }
        
        private void BackButton_Click(object sender, EventArgs e)
        {
            BackPressed();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
           if (NameTextBox.Text != "" && ClassList.SelectedItem != null)
            {
                foreach(TypesOfRaces.Race race in Player.TypesOfRaces.GetRaces())
                    if (race.ToString().Equals(ClassList.SelectedItem.ToString()))
                    { 
                        Controller.Controller c = Controller.Controller.getController();
                        c.Player = Player.Player.GetPlayer(NameTextBox.Text, race, 200);
                        GameView g = new GameView(this);
                        this.Hide();
                        g.Show();
                    }
                    
            }
        }
        private void NewPressed()
        {
            NewGameButton.Hide();
            LoadButton.Hide();
            BackButton.Show();
            StartButton.Show();
            NameLabel.Show();
            NameTextBox.Show();
            ClassLabel.Show();
            ClassList.Show();
        }
        private void BackPressed()
        {
            NameTextBox.Clear();
            ClassList.Hide();
            NameTextBox.Hide();
            NewGameButton.Show();
            LoadButton.Show();
            BackButton.Hide();
            StartButton.Hide();
            NameLabel.Hide();
            ClassLabel.Hide();
            
        }
        private void InitializeList()
        {
            foreach (TypesOfRaces.Race race in Player.TypesOfRaces.GetRaces())
                ClassList.Items.Add(race);
        }

        
        
    }
}
