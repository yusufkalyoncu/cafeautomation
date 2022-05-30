using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace cafe_automation.Widgets
{
    public partial class table : UserControl
    {
        public formDetay formDetail;
        public string tableName = "MASA1";
        public int posX,posY;
        public static bool clickedDelete = false;
        public table()
        {
            InitializeComponent();
            formDetail = new formDetay();
            isTableEmpty();
        }

        public string TableName { get => tableName; set { tableName = value; tableTitle.Text = value; } }
        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }
        public void isTableEmpty()
        {
            if(formDetail.totalCost <= 0)
            {
                panelTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
                panelTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(51)))));
            }
            else
            {
                panelTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
                panelTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            }
        }

        private void panelTable_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                formDetail.Visible = true;
            }
            if(e.Button == MouseButtons.Right && formMain.isChecked)
            {
                DeleteTableDialog td = new DeleteTableDialog();
                td.ShowDialog();
                
                if (td.clickedDelete)
                {
                    CRUD.deleteTable(this);
                    this.Dispose();
                }

            }
        }
    }
}
