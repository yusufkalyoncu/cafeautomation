
namespace cafe_automation
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.borderLeft = new System.Windows.Forms.Panel();
            this.borderRight = new System.Windows.Forms.Panel();
            this.boderDown = new System.Windows.Forms.Panel();
            this.tableEditCheckBox = new System.Windows.Forms.CheckBox();
            this.borderTop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTables = new System.Windows.Forms.Panel();
            this.borderMid = new System.Windows.Forms.Panel();
            this.boderDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderLeft
            // 
            this.borderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderLeft.Location = new System.Drawing.Point(0, 0);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(50, 631);
            this.borderLeft.TabIndex = 0;
            // 
            // borderRight
            // 
            this.borderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.borderRight.Location = new System.Drawing.Point(1043, 0);
            this.borderRight.Name = "borderRight";
            this.borderRight.Size = new System.Drawing.Size(50, 631);
            this.borderRight.TabIndex = 1;
            // 
            // boderDown
            // 
            this.boderDown.Controls.Add(this.tableEditCheckBox);
            this.boderDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.boderDown.Location = new System.Drawing.Point(50, 581);
            this.boderDown.Name = "boderDown";
            this.boderDown.Size = new System.Drawing.Size(993, 50);
            this.boderDown.TabIndex = 2;
            // 
            // tableEditCheckBox
            // 
            this.tableEditCheckBox.AutoSize = true;
            this.tableEditCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(51)))));
            this.tableEditCheckBox.Location = new System.Drawing.Point(19, 21);
            this.tableEditCheckBox.Name = "tableEditCheckBox";
            this.tableEditCheckBox.Size = new System.Drawing.Size(107, 17);
            this.tableEditCheckBox.TabIndex = 0;
            this.tableEditCheckBox.Text = "Masaları Düzenle";
            this.tableEditCheckBox.UseVisualStyleBackColor = true;
            this.tableEditCheckBox.CheckedChanged += new System.EventHandler(this.tableEditCheckBox_CheckedChanged);
            // 
            // borderTop
            // 
            this.borderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTop.Location = new System.Drawing.Point(50, 0);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(993, 50);
            this.borderTop.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(50, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 531);
            this.panelMenu.TabIndex = 4;
            // 
            // panelTables
            // 
            this.panelTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTables.Location = new System.Drawing.Point(310, 50);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(733, 531);
            this.panelTables.TabIndex = 5;
            this.panelTables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTables_MouseDown);
            // 
            // borderMid
            // 
            this.borderMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderMid.Location = new System.Drawing.Point(260, 50);
            this.borderMid.Name = "borderMid";
            this.borderMid.Size = new System.Drawing.Size(50, 531);
            this.borderMid.TabIndex = 6;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1093, 631);
            this.Controls.Add(this.panelTables);
            this.Controls.Add(this.borderMid);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.borderTop);
            this.Controls.Add(this.boderDown);
            this.Controls.Add(this.borderRight);
            this.Controls.Add(this.borderLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMain";
            this.Text = "formMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.boderDown.ResumeLayout(false);
            this.boderDown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel borderLeft;
        private System.Windows.Forms.Panel borderRight;
        private System.Windows.Forms.Panel boderDown;
        private System.Windows.Forms.Panel borderTop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTables;
        private System.Windows.Forms.Panel borderMid;
        private System.Windows.Forms.CheckBox tableEditCheckBox;
    }
}