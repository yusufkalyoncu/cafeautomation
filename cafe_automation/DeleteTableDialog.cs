using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_automation
{
    public partial class DeleteTableDialog : Form
    {
        
        public DeleteTableDialog()
        {
            InitializeComponent();
        }
        public bool clickedDelete = false;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clickedDelete = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
