
namespace RaktarKezeloRendszer
{
    partial class TetelMozgatas
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
            this.label2 = new System.Windows.Forms.Label();
            this.Megnevezes_txtbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ujTarhelyCbx = new System.Windows.Forms.ComboBox();
            this.MennyEgys_lbl = new System.Windows.Forms.Label();
            this.AthelyezMenny = new System.Windows.Forms.TextBox();
            this.AthelyezMenny_lbl = new System.Windows.Forms.Label();
            this.Mozgatas_btn = new System.Windows.Forms.Button();
            this.Mennyiseg_txtbx = new System.Windows.Forms.TextBox();
            this.JelenlegiTarhely_txtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Kereso_btn = new System.Windows.Forms.Button();
            this.Info_lbl = new System.Windows.Forms.Label();
            this.Bezar_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cikkszam_cbx = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cikkszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Megnevezés: ";
            // 
            // Megnevezes_txtbx
            // 
            this.Megnevezes_txtbx.Location = new System.Drawing.Point(94, 41);
            this.Megnevezes_txtbx.Name = "Megnevezes_txtbx";
            this.Megnevezes_txtbx.ReadOnly = true;
            this.Megnevezes_txtbx.Size = new System.Drawing.Size(130, 20);
            this.Megnevezes_txtbx.TabIndex = 3;
            this.Megnevezes_txtbx.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ujTarhelyCbx);
            this.groupBox1.Controls.Add(this.MennyEgys_lbl);
            this.groupBox1.Controls.Add(this.AthelyezMenny);
            this.groupBox1.Controls.Add(this.AthelyezMenny_lbl);
            this.groupBox1.Controls.Add(this.Mozgatas_btn);
            this.groupBox1.Controls.Add(this.Mennyiseg_txtbx);
            this.groupBox1.Controls.Add(this.JelenlegiTarhely_txtbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mozgatás";
            // 
            // ujTarhelyCbx
            // 
            this.ujTarhelyCbx.FormattingEnabled = true;
            this.ujTarhelyCbx.Location = new System.Drawing.Point(316, 30);
            this.ujTarhelyCbx.Name = "ujTarhelyCbx";
            this.ujTarhelyCbx.Size = new System.Drawing.Size(100, 21);
            this.ujTarhelyCbx.TabIndex = 10;
            // 
            // MennyEgys_lbl
            // 
            this.MennyEgys_lbl.AutoSize = true;
            this.MennyEgys_lbl.Location = new System.Drawing.Point(163, 68);
            this.MennyEgys_lbl.Name = "MennyEgys_lbl";
            this.MennyEgys_lbl.Size = new System.Drawing.Size(62, 13);
            this.MennyEgys_lbl.TabIndex = 9;
            this.MennyEgys_lbl.Text = "MennyEgys";
            // 
            // AthelyezMenny
            // 
            this.AthelyezMenny.Location = new System.Drawing.Point(165, 107);
            this.AthelyezMenny.Name = "AthelyezMenny";
            this.AthelyezMenny.Size = new System.Drawing.Size(43, 20);
            this.AthelyezMenny.TabIndex = 8;
            // 
            // AthelyezMenny_lbl
            // 
            this.AthelyezMenny_lbl.AutoSize = true;
            this.AthelyezMenny_lbl.Location = new System.Drawing.Point(12, 113);
            this.AthelyezMenny_lbl.Name = "AthelyezMenny_lbl";
            this.AthelyezMenny_lbl.Size = new System.Drawing.Size(147, 13);
            this.AthelyezMenny_lbl.TabIndex = 7;
            this.AthelyezMenny_lbl.Text = "Áthelyezésre váró mennyiség:";
            // 
            // Mozgatas_btn
            // 
            this.Mozgatas_btn.Location = new System.Drawing.Point(316, 104);
            this.Mozgatas_btn.Name = "Mozgatas_btn";
            this.Mozgatas_btn.Size = new System.Drawing.Size(75, 23);
            this.Mozgatas_btn.TabIndex = 6;
            this.Mozgatas_btn.Text = "Mozgatás";
            this.Mozgatas_btn.UseVisualStyleBackColor = true;
            this.Mozgatas_btn.Click += new System.EventHandler(this.Mozgatas_btn_Click);
            // 
            // Mennyiseg_txtbx
            // 
            this.Mennyiseg_txtbx.Location = new System.Drawing.Point(98, 61);
            this.Mennyiseg_txtbx.Name = "Mennyiseg_txtbx";
            this.Mennyiseg_txtbx.ReadOnly = true;
            this.Mennyiseg_txtbx.Size = new System.Drawing.Size(55, 20);
            this.Mennyiseg_txtbx.TabIndex = 4;
            this.Mennyiseg_txtbx.Visible = false;
            // 
            // JelenlegiTarhely_txtbx
            // 
            this.JelenlegiTarhely_txtbx.Location = new System.Drawing.Point(98, 27);
            this.JelenlegiTarhely_txtbx.Name = "JelenlegiTarhely_txtbx";
            this.JelenlegiTarhely_txtbx.ReadOnly = true;
            this.JelenlegiTarhely_txtbx.Size = new System.Drawing.Size(100, 20);
            this.JelenlegiTarhely_txtbx.TabIndex = 3;
            this.JelenlegiTarhely_txtbx.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Új tárhely: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mennyiség:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jelenlegi tárhely:";
            // 
            // Kereso_btn
            // 
            this.Kereso_btn.Location = new System.Drawing.Point(230, 10);
            this.Kereso_btn.Name = "Kereso_btn";
            this.Kereso_btn.Size = new System.Drawing.Size(75, 23);
            this.Kereso_btn.TabIndex = 5;
            this.Kereso_btn.Text = "Keresd!";
            this.Kereso_btn.UseVisualStyleBackColor = true;
            this.Kereso_btn.Click += new System.EventHandler(this.Kereso_btn_Click);
            // 
            // Info_lbl
            // 
            this.Info_lbl.AutoSize = true;
            this.Info_lbl.Location = new System.Drawing.Point(44, 16);
            this.Info_lbl.Name = "Info_lbl";
            this.Info_lbl.Size = new System.Drawing.Size(115, 13);
            this.Info_lbl.TabIndex = 6;
            this.Info_lbl.Text = "Az átmozgatás sikerült!";
            this.Info_lbl.Visible = false;
            // 
            // Bezar_btn
            // 
            this.Bezar_btn.Location = new System.Drawing.Point(332, 10);
            this.Bezar_btn.Name = "Bezar_btn";
            this.Bezar_btn.Size = new System.Drawing.Size(75, 23);
            this.Bezar_btn.TabIndex = 7;
            this.Bezar_btn.Text = "Bezárás";
            this.Bezar_btn.UseVisualStyleBackColor = true;
            this.Bezar_btn.Click += new System.EventHandler(this.Bezar_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Info_lbl);
            this.groupBox2.Location = new System.Drawing.Point(16, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 50);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rendszerüzenet";
            // 
            // Cikkszam_cbx
            // 
            this.Cikkszam_cbx.FormattingEnabled = true;
            this.Cikkszam_cbx.Location = new System.Drawing.Point(94, 12);
            this.Cikkszam_cbx.Name = "Cikkszam_cbx";
            this.Cikkszam_cbx.Size = new System.Drawing.Size(130, 21);
            this.Cikkszam_cbx.TabIndex = 11;
            // 
            // TetelMozgatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 315);
            this.Controls.Add(this.Cikkszam_cbx);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Bezar_btn);
            this.Controls.Add(this.Kereso_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Megnevezes_txtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TetelMozgatas";
            this.Text = "Tétel Mozgatás";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Mozgatas_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Kereso_btn;
        private System.Windows.Forms.Label Info_lbl;
        private System.Windows.Forms.Button Bezar_btn;
        private System.Windows.Forms.TextBox AthelyezMenny;
        private System.Windows.Forms.Label AthelyezMenny_lbl;
        public System.Windows.Forms.TextBox Mennyiseg_txtbx;
        public System.Windows.Forms.TextBox JelenlegiTarhely_txtbx;
        public System.Windows.Forms.TextBox Megnevezes_txtbx;
        public System.Windows.Forms.Label MennyEgys_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ujTarhelyCbx;
        private System.Windows.Forms.ComboBox Cikkszam_cbx;
    }
}