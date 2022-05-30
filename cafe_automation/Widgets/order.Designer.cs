
namespace cafe_automation.Widgets
{
    partial class order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(189)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.btnIncrease);
            this.panel1.Controls.Add(this.btnReduce);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(17, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 47);
            this.panel1.TabIndex = 0;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCost.Location = new System.Drawing.Point(217, 14);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(54, 19);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "17.50₺";
            // 
            // btnIncrease
            // 
            this.btnIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIncrease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(189)))), ((int)(((byte)(43)))));
            this.btnIncrease.Location = new System.Drawing.Point(8, 9);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(30, 30);
            this.btnIncrease.TabIndex = 3;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this._btnIncrease_Click);
            // 
            // btnReduce
            // 
            this.btnReduce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReduce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.btnReduce.FlatAppearance.BorderSize = 0;
            this.btnReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduce.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReduce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(189)))), ((int)(((byte)(43)))));
            this.btnReduce.Location = new System.Drawing.Point(280, 10);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(30, 30);
            this.btnReduce.TabIndex = 2;
            this.btnReduce.Text = "-";
            this.btnReduce.UseVisualStyleBackColor = false;
            this.btnReduce.Click += new System.EventHandler(this._btnReduce_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(56, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ürün adı    1";
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "order";
            this.Size = new System.Drawing.Size(355, 59);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnIncrease;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblCost;
    }
}
