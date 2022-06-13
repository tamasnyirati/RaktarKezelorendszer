
namespace RaktarKezeloRendszer
{
    partial class UjTetelFelviteleTorzsbe
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cikkszam_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Megnevezes_txtbx = new System.Windows.Forms.TextBox();
            this.Ar_txtbx = new System.Windows.Forms.TextBox();
            this.Beszallito_cbx = new System.Windows.Forms.ComboBox();
            this.MennyisegiEgyseg_cbx = new System.Windows.Forms.ComboBox();
            this.Rogzit_btn = new System.Windows.Forms.Button();
            this.Bezar_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Raktarhely_txtbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Info_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új tétel rögzítése a törzsállományba:";
            // 
            // Cikkszam_txtbx
            // 
            this.Cikkszam_txtbx.Location = new System.Drawing.Point(119, 60);
            this.Cikkszam_txtbx.Name = "Cikkszam_txtbx";
            this.Cikkszam_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Cikkszam_txtbx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cikkszám: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Megnevezés:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mennyiségi egység:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ár: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Beszállító Neve:";
            // 
            // Megnevezes_txtbx
            // 
            this.Megnevezes_txtbx.Location = new System.Drawing.Point(119, 94);
            this.Megnevezes_txtbx.Name = "Megnevezes_txtbx";
            this.Megnevezes_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Megnevezes_txtbx.TabIndex = 7;
            // 
            // Ar_txtbx
            // 
            this.Ar_txtbx.Location = new System.Drawing.Point(120, 163);
            this.Ar_txtbx.Name = "Ar_txtbx";
            this.Ar_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Ar_txtbx.TabIndex = 9;
            // 
            // Beszallito_cbx
            // 
            this.Beszallito_cbx.FormattingEnabled = true;
            this.Beszallito_cbx.Items.AddRange(new object[] {
            "Villamossági Kft.",
            "Informatikai Kft.",
            "Elektronikai Kft."});
            this.Beszallito_cbx.Location = new System.Drawing.Point(119, 200);
            this.Beszallito_cbx.Name = "Beszallito_cbx";
            this.Beszallito_cbx.Size = new System.Drawing.Size(100, 21);
            this.Beszallito_cbx.TabIndex = 10;
            // 
            // MennyisegiEgyseg_cbx
            // 
            this.MennyisegiEgyseg_cbx.FormattingEnabled = true;
            this.MennyisegiEgyseg_cbx.Items.AddRange(new object[] {
            "Darab",
            "Folyóméter",
            "Készlet"});
            this.MennyisegiEgyseg_cbx.Location = new System.Drawing.Point(120, 129);
            this.MennyisegiEgyseg_cbx.Name = "MennyisegiEgyseg_cbx";
            this.MennyisegiEgyseg_cbx.Size = new System.Drawing.Size(99, 21);
            this.MennyisegiEgyseg_cbx.TabIndex = 11;
            // 
            // Rogzit_btn
            // 
            this.Rogzit_btn.Location = new System.Drawing.Point(280, 160);
            this.Rogzit_btn.Name = "Rogzit_btn";
            this.Rogzit_btn.Size = new System.Drawing.Size(100, 23);
            this.Rogzit_btn.TabIndex = 12;
            this.Rogzit_btn.Text = "Rögzít";
            this.Rogzit_btn.UseVisualStyleBackColor = true;
            this.Rogzit_btn.Click += new System.EventHandler(this.Rogzit_btn_Click);
            // 
            // Bezar_btn
            // 
            this.Bezar_btn.Location = new System.Drawing.Point(280, 200);
            this.Bezar_btn.Name = "Bezar_btn";
            this.Bezar_btn.Size = new System.Drawing.Size(100, 23);
            this.Bezar_btn.TabIndex = 13;
            this.Bezar_btn.Text = "Bezárás";
            this.Bezar_btn.UseVisualStyleBackColor = true;
            this.Bezar_btn.Click += new System.EventHandler(this.Bezar_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Raktárhely: ";
            // 
            // Raktarhely_txtbx
            // 
            this.Raktarhely_txtbx.Location = new System.Drawing.Point(119, 228);
            this.Raktarhely_txtbx.Name = "Raktarhely_txtbx";
            this.Raktarhely_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Raktarhely_txtbx.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Forint";
            // 
            // Info_lbl
            // 
            this.Info_lbl.AutoSize = true;
            this.Info_lbl.Location = new System.Drawing.Point(90, 16);
            this.Info_lbl.Name = "Info_lbl";
            this.Info_lbl.Size = new System.Drawing.Size(94, 13);
            this.Info_lbl.TabIndex = 17;
            this.Info_lbl.Text = "A rögzítés sikerült!";
            this.Info_lbl.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Info_lbl);
            this.groupBox1.Location = new System.Drawing.Point(16, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 40);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendszerüzenet";
            // 
            // UjTetelFelviteleTorzsbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Raktarhely_txtbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Bezar_btn);
            this.Controls.Add(this.Rogzit_btn);
            this.Controls.Add(this.MennyisegiEgyseg_cbx);
            this.Controls.Add(this.Beszallito_cbx);
            this.Controls.Add(this.Ar_txtbx);
            this.Controls.Add(this.Megnevezes_txtbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cikkszam_txtbx);
            this.Controls.Add(this.label1);
            this.Name = "UjTetelFelviteleTorzsbe";
            this.Text = "Új Tétel Felvitele a Törzsbe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cikkszam_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Megnevezes_txtbx;
        private System.Windows.Forms.TextBox Ar_txtbx;
        private System.Windows.Forms.ComboBox Beszallito_cbx;
        private System.Windows.Forms.ComboBox MennyisegiEgyseg_cbx;
        private System.Windows.Forms.Button Rogzit_btn;
        private System.Windows.Forms.Button Bezar_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Raktarhely_txtbx;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label Info_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}