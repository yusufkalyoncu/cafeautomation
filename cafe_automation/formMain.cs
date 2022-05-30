using cafe_automation.Widgets;
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
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace cafe_automation
{
    public partial class formMain : Form
    {
        public static List<table> allTables;
        public static double posX;
        public static double posY;
        public static bool isChecked;
        public static List<int> deletedTableID = new List<int>();
        public formMain()
        {
            InitializeComponent();
            allTables = CRUD.getTables();
            if (allTables == null)
            {
                allTables = new List<table>();
            }
            else
            {
                setTables();
            }
        }
        
        private void panelTables_MouseDown(object sender, MouseEventArgs e)
        {
            
            if(e.Button == MouseButtons.Right && tableEditCheckBox.Checked)
            {
                CreateTableDialog td = new CreateTableDialog();
                td.ShowDialog();
                
                if (td.clickedOK)
                {
                    table masa1 = new table();
                    panelTables.Controls.Add(masa1);
                    masa1.Location = new Point(e.X, e.Y);
                    masa1.PosX = e.X;
                    masa1.PosY = e.Y;
                    masa1.TableName = td.nextTableName;
                    allTables.Add(masa1);
                    CRUD.addTable(masa1);
                    
                }
            }
        }

        public void setTables()
        {
            foreach(table tbl in allTables)
            {
                panelTables.Controls.Add(tbl);
                tbl.Location = new Point(tbl.PosX, tbl.PosY);
            }
        }

        private void tableEditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = tableEditCheckBox.Checked;
        }

        public static void isTableAvailable()
        {
            foreach (table tbl in allTables)
            {
                tbl.isTableEmpty();
            }
        }
    }
}
