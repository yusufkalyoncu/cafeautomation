using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_automation.Widgets
{
    public enum categories { Foods, ColdDrinks, HotDrinks, Deserts }
    public partial class item : UserControl
    {
        public event EventHandler OnSelect = null;
        private categories _category;
        private int category_id;
        private float _cost;
        public item()
        {
            InitializeComponent();
            imgPic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        
        public categories Category { get => _category; set => _category = value; }
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public float Cost { get => _cost; set { _cost = value; lblCost.Text = _cost.ToString("C2");} }
        public Image Icon { get => imgPic.Image; set => imgPic.Image = value; }
        public int CategoryID { get => category_id; set => category_id = value; }

    }
}
