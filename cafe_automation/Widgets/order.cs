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
    public partial class order : UserControl
    {
        public order()
        {
            InitializeComponent();
        }

        private int count;
        private string name;
        private float cost;
        public event EventHandler btnReduce_Click = null;
        public event EventHandler btnIncrease_Click = null;
        public int Count{ get => count; set => count = value; }
        public string Name { get => name; set => name = value; }
        public float Cost { get => cost; set => cost = value; }

        public void refreshLabels()
        {
            lblName.Text = name + "   "+count;
            lblCost.Text = (count * cost).ToString("C2");
        }
        private void _btnReduce_Click(object sender, EventArgs e)
        {
            btnReduce_Click?.Invoke(this, e);
            /*count--;
            formDetay.updateTotalCost(-1 * Cost);
            if (count <= 0) this.Dispose();
            refreshLabels();*/
        }

        private void _btnIncrease_Click(object sender, EventArgs e)
        {
            btnIncrease_Click?.Invoke(this, e);
            /*count++;
            formDetay.updateTotalCost(Cost);
            formDetay.totalCost += Cost;
            refreshLabels();*/
        }
    }
}
