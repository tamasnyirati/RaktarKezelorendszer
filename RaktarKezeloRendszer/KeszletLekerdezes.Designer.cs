
namespace RaktarKezeloRendszer
{
    partial class KeszletLekerdezes
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
            this.label2 = new System.Windows.Forms.Label();
            this.Kereso_txtbx = new System.Windows.Forms.TextBox();
            this.Kereso_cbx = new System.Windows.Forms.ComboBox();
            this.Keresd_btn = new System.Windows.Forms.Button();
            this.Keszlet_dgw = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bezar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Keszlet_dgw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keresősáv";
            // 
            // Kereso_txtbx
            // 
            this.Kereso_txtbx.Location = new System.Drawing.Point(6, 40);
            this.Kereso_txtbx.Name = "Kereso_txtbx";
            this.Kereso_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Kereso_txtbx.TabIndex = 2;
            // 
            // Kereso_cbx
            // 
            this.Kereso_cbx.FormattingEnabled = true;
            this.Kereso_cbx.Items.AddRange(new object[] {
            "Megnevezés",
            "Cikkszám"});
            this.Kereso_cbx.Location = new System.Drawing.Point(127, 40);
            this.Kereso_cbx.Name = "Kereso_cbx";
            this.Kereso_cbx.Size = new System.Drawing.Size(121, 21);
            this.Kereso_cbx.TabIndex = 3;
            // 
            // Keresd_btn
            // 
            this.Keresd_btn.Location = new System.Drawing.Point(291, 40);
            this.Keresd_btn.Name = "Keresd_btn";
            this.Keresd_btn.Size = new System.Drawing.Size(75, 23);
            this.Keresd_btn.TabIndex = 4;
            this.Keresd_btn.Text = "Keresd!";
            this.Keresd_btn.UseVisualStyleBackColor = true;
            this.Keresd_btn.Click += new System.EventHandler(this.Keresd_btn_Click);
            // 
            // Keszlet_dgw
            // 
            this.Keszlet_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Keszlet_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Keszlet_dgw.Location = new System.Drawing.Point(16, 113);
            this.Keszlet_dgw.Name = "Keszlet_dgw";
            this.Keszlet_dgw.Size = new System.Drawing.Size(663, 192);
            this.Keszlet_dgw.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bezar_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Kereso_txtbx);
            this.groupBox1.Controls.Add(this.Keresd_btn);
            this.groupBox1.Controls.Add(this.Kereso_cbx);
            this.groupBox1.Location = new System.Drawing.Point(99, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kereső";
            // 
            // Bezar_btn
            // 
            this.Bezar_btn.Location = new System.Drawing.Point(408, 40);
            this.Bezar_btn.Name = "Bezar_btn";
            this.Bezar_btn.Size = new System.Drawing.Size(75, 23);
            this.Bezar_btn.TabIndex = 6;
            this.Bezar_btn.Text = "Bezárás";
            this.Bezar_btn.UseVisualStyleBackColor = true;
            this.Bezar_btn.Click += new System.EventHandler(this.Bezar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Típus";
            // 
            // KeszletLekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Keszlet_dgw);
            this.Name = "KeszletLekerdezes";
            this.Text = "Készlet Lekérdezés";
            this.Load += new System.EventHandler(this.KeszletLekerdezes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Keszlet_dgw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kereso_txtbx;
        private System.Windows.Forms.ComboBox Kereso_cbx;
        private System.Windows.Forms.Button Keresd_btn;
        private System.Windows.Forms.DataGridView Keszlet_dgw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bezar_btn;
    }
}