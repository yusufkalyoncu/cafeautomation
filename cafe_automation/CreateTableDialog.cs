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
    public partial class CreateTableDialog : Form
    {
        public CreateTableDialog()
        {
            InitializeComponent();
        }
        public string nextTableName;
        public bool clickedOK = false;
            

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtboxTableName.Text.Length > 0)
            {
                nextTableName = txtboxTableName.Text;
                clickedOK = true;
                this.Dispose();
            }
            else
            {
                lblError.Text = "Masa adı boş bırakılamaz ! ";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clickedOK = false;
            this.Dispose();
        }
    }
}
