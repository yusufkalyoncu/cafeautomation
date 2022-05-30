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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            CRUD.connectDataBase();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMain anaSayfa = new formMain();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
