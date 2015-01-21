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
        static EquiptmentView _view;
        List<PictureBox> images;
        ToolTip toolTip1;
        Controller.Controller _controller;
        private EquiptmentView()
        {
            _controller = Controller.Controller.getController();
            InitializeComponent();
            InitializeToolTip();
            InitializeInventory(_controller.getInventory());
            AddPicturesToList();
            this.FormClosing += EquiptmentView_FormClosing;
            this.KeyPress += EquiptmentView_KeyPress;
            _controller.AddMethodToInventoryChanged(player_InventoryChanged);
            _controller.AddMethodToEquiptmentChanged(player_EquiptmentChanged);
        }
        void player_EquiptmentChanged(object sender, Player.EquiptmentArgs e)
        {
            InitializeEquiptment(e.GetEquiptment);
        }
        void player_InventoryChanged(object sender, Player.InventoryArgs e)
        {
            InitializeInventory(e.GetInventory);
        }
        void EquiptmentView_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar.ToString().Equals("i"))
            {
                this.Hide();

            }
        }
        // Use this event handler for the FormClosing event.
        private void InitializeEquiptment(List<Items> equiptment)
        {
            ArmorPic.BackgroundImage = null;
            HelmetPic.BackgroundImage = null;
            FirstHandPic.BackgroundImage = null;
            SecondHandPic.BackgroundImage = null;
            BeltPic.BackgroundImage = null;
            PantsPic.BackgroundImage = null;
            BootsPic.BackgroundImage = null;
            Gloves1Pic.BackgroundImage = null;
            Gloves2Pic.BackgroundImage = null;
            foreach(Items i in equiptment)
            {
                switch (i.Type)
                {
                    case Item.Type.Armor: ArmorPic.BackgroundImage = Image.FromFile(i.GetPic());
                        ArmorPic.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    case Item.Type.Helmet: HelmetPic.BackgroundImage = Image.FromFile(i.GetPic()); 
                        HelmetPic.BackgroundImageLayout = ImageLayout.Stretch;break;
                    case Item.Type.OneHanded:
                    case Item.Type.TwoHanded: FirstHandPic.BackgroundImage = Image.FromFile(i.GetPic()); 
                    FirstHandPic.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                    case Item.Type.Shield: SecondHandPic.BackgroundImage = Image.FromFile(i.GetPic()); 
                        SecondHandPic.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    case Item.Type.Belt: BeltPic.BackgroundImage = Image.FromFile(i.GetPic()); 
                        BeltPic.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    case Item.Type.Pants: PantsPic.BackgroundImage = Image.FromFile(i.GetPic()); 
                        PantsPic.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    case Item.Type.Gloves: 
                        Gloves1Pic.BackgroundImage = Image.FromFile(i.GetPic()); 
                        Gloves2Pic.BackgroundImage = Image.FromFile(i.GetPic());
                        Gloves1Pic.BackgroundImageLayout = ImageLayout.Stretch;
                        Gloves2Pic.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                    case Item.Type.Shoes: BootsPic.BackgroundImage = Image.FromFile(i.GetPic()); 
                        BootsPic.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                }
            }
        }
        void EquiptmentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
        public static EquiptmentView GetView()
        {
            if (_view == null)
            {
                _view = new EquiptmentView();
                return _view;
            }
            else return _view;
        }
        private void AddPicturesToList()
        {
            images = new List<PictureBox>();
            images.Add(FirstHandPic);
            images.Add(SecondHandPic);
            images.Add(PantsPic);
            images.Add(HelmetPic);
            images.Add(BootsPic);
            images.Add(ArmorPic);
            images.Add(BeltPic);
            images.Add(Gloves1Pic);
            images.Add(Gloves2Pic);

            foreach (PictureBox picture in images)
            {
                picture.MouseHover += picture_MouseHover;
                picture.MouseClick += picture_MouseClick;
            }
        }

        void picture_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right){
                if (((PictureBox)sender).Equals(FirstHandPic))
                {
                    if (!_controller.UnEquiptItem(Item.Type.OneHanded))
                        _controller.UnEquiptItem(Item.Type.TwoHanded);
                }
                else if (((PictureBox)sender).Equals(SecondHandPic))
                    _controller.UnEquiptItem(Item.Type.Shield);
                else if (((PictureBox)sender).Equals(HelmetPic))
                    _controller.UnEquiptItem(Item.Type.Helmet);
                else if (((PictureBox)sender).Equals(ArmorPic))
                    _controller.UnEquiptItem(Item.Type.Armor);
                else if (((PictureBox)sender).Equals(BeltPic))
                    _controller.UnEquiptItem(Item.Type.Belt);
                else if (((PictureBox)sender).Equals(PantsPic))
                    _controller.UnEquiptItem(Item.Type.Pants);
                else if (((PictureBox)sender).Equals(BootsPic))
                    _controller.UnEquiptItem(Item.Type.Shoes);
                else if (((PictureBox)sender).Equals(Gloves1Pic) || ((PictureBox)sender).Equals(Gloves2Pic))
                    _controller.UnEquiptItem(Item.Type.Gloves);
            }
        }

        void picture_MouseHover(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Equals(FirstHandPic))
            {
                String name =_controller.ItemName(Item.Type.OneHanded);
                if(name != null)
                    toolTip1.SetToolTip(FirstHandPic, name);
                else
                    toolTip1.SetToolTip(FirstHandPic, _controller.ItemName(Item.Type.TwoHanded));
            }
            else if (((PictureBox)sender).Equals(SecondHandPic) && _controller.ItemName(Item.Type.Shield) != null)
                toolTip1.SetToolTip(SecondHandPic, _controller.ItemName(Item.Type.Shield));
            else if (((PictureBox)sender).Equals(HelmetPic) && _controller.ItemName(Item.Type.Helmet)!= null)
                toolTip1.SetToolTip(HelmetPic, _controller.ItemName(Item.Type.Helmet));
            else if (((PictureBox)sender).Equals(ArmorPic) && _controller.ItemName(Item.Type.Armor)!= null)
                toolTip1.SetToolTip(ArmorPic, _controller.ItemName(Item.Type.Armor));
            else if ((((PictureBox)sender).Equals(Gloves1Pic) || ((PictureBox)sender).Equals(Gloves2Pic)) && _controller.ItemName(Item.Type.Gloves) != null)
                toolTip1.SetToolTip(Gloves1Pic, _controller.ItemName(Item.Type.Gloves));
            else if (((PictureBox)sender).Equals(PantsPic) && _controller.ItemName(Item.Type.Pants) != null)
                toolTip1.SetToolTip(PantsPic, _controller.ItemName(Item.Type.Pants));
            else if (((PictureBox)sender).Equals(BootsPic) && _controller.ItemName(Item.Type.Shoes) != null)
                toolTip1.SetToolTip(BootsPic, _controller.ItemName(Item.Type.Shoes));
            else if (((PictureBox)sender).Equals(BeltPic) && _controller.ItemName(Item.Type.Belt) != null)
                toolTip1.SetToolTip(BeltPic, _controller.ItemName(Item.Type.Belt));
        }
        private void InitializeInventory(List<Items> items)
        {
            //*2 is random number but it works
            panel1.Controls.Clear();
            panel1.Width = InventoryItem.width()*2;
            for (int i = 0; i < items.Count; i++)
            {
                InventoryItem II = new InventoryItem(items[i]);
                II.Location = new Point(II.Location.X, i*II.Height);
                panel1.Controls.Add(II);
                II.SelectItem += II_SelectItem;

            }
        }

        void II_SelectItem(object sender, EquiptItemArgs e){
            _controller.EquiptItem(e.InventoryItem.item);
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
    }
}
