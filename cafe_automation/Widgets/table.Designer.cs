
namespace cafe_automation.Widgets
{
    partial class table
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTable = new System.Windows.Forms.Panel();
            this.tableTitle = new System.Windows.Forms.Label();
            this.panelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTable
            // 
            this.panelTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(51)))));
            this.panelTable.Controls.Add(this.tableTitle);
            this.panelTable.Location = new System.Drawing.Point(8, 8);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(80, 80);
            this.panelTable.TabIndex = 0;
            this.panelTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTable_MouseDown);
            // 
            // tableTitle
            // 
            this.tableTitle.AutoSize = true;
            this.tableTitle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableTitle.Location = new System.Drawing.Point(7, 29);
            this.tableTitle.MaximumSize = new System.Drawing.Size(80, 0);
            this.tableTitle.Name = "tableTitle";
            this.tableTitle.Size = new System.Drawing.Size(66, 23);
            this.tableTitle.TabIndex = 0;
            this.tableTitle.Text = "Masa 1";
            this.tableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tableTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTable_MouseDown);
            // 
            // table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelTable);
            this.Name = "table";
            this.Size = new System.Drawing.Size(95, 95);
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Label tableTitle;
    }
}
