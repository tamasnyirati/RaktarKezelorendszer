
namespace RaktarKezeloRendszer
{
    partial class BeszallitoFelvitele
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
            this.label3 = new System.Windows.Forms.Label();
            this.BeszallitoNev_txtbx = new System.Windows.Forms.TextBox();
            this.BeszTermTip_cbx = new System.Windows.Forms.ComboBox();
            this.Rogzit_btn = new System.Windows.Forms.Button();
            this.Kilep_btn = new System.Windows.Forms.Button();
            this.Info_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ú beszállító rögzítése a törzsállományba:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beszállító neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Beszállított termék típusa: ";
            // 
            // BeszallitoNev_txtbx
            // 
            this.BeszallitoNev_txtbx.Location = new System.Drawing.Point(156, 66);
            this.BeszallitoNev_txtbx.Name = "BeszallitoNev_txtbx";
            this.BeszallitoNev_txtbx.Size = new System.Drawing.Size(158, 20);
            this.BeszallitoNev_txtbx.TabIndex = 3;
            // 
            // BeszTermTip_cbx
            // 
            this.BeszTermTip_cbx.FormattingEnabled = true;
            this.BeszTermTip_cbx.Items.AddRange(new object[] {
            "Informatikai",
            "Elektronikai",
            "Villamossági"});
            this.BeszTermTip_cbx.Location = new System.Drawing.Point(156, 104);
            this.BeszTermTip_cbx.Name = "BeszTermTip_cbx";
            this.BeszTermTip_cbx.Size = new System.Drawing.Size(158, 21);
            this.BeszTermTip_cbx.TabIndex = 4;
            // 
            // Rogzit_btn
            // 
            this.Rogzit_btn.Location = new System.Drawing.Point(156, 152);
            this.Rogzit_btn.Name = "Rogzit_btn";
            this.Rogzit_btn.Size = new System.Drawing.Size(75, 23);
            this.Rogzit_btn.TabIndex = 5;
            this.Rogzit_btn.Text = "Rögzít";
            this.Rogzit_btn.UseVisualStyleBackColor = true;
            this.Rogzit_btn.Click += new System.EventHandler(this.Rogzit_btn_Click);
            // 
            // Kilep_btn
            // 
            this.Kilep_btn.Location = new System.Drawing.Point(239, 152);
            this.Kilep_btn.Name = "Kilep_btn";
            this.Kilep_btn.Size = new System.Drawing.Size(75, 23);
            this.Kilep_btn.TabIndex = 6;
            this.Kilep_btn.Text = "Kilépés";
            this.Kilep_btn.UseVisualStyleBackColor = true;
            this.Kilep_btn.Click += new System.EventHandler(this.Kilep_btn_Click);
            // 
            // Info_lbl
            // 
            this.Info_lbl.AutoSize = true;
            this.Info_lbl.Location = new System.Drawing.Point(86, 16);
            this.Info_lbl.Name = "Info_lbl";
            this.Info_lbl.Size = new System.Drawing.Size(86, 13);
            this.Info_lbl.TabIndex = 7;
            this.Info_lbl.Text = "Sikeres rögzítés!";
            this.Info_lbl.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Info_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendszerüzenet";
            // 
            // BeszallitoFelvitele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Kilep_btn);
            this.Controls.Add(this.Rogzit_btn);
            this.Controls.Add(this.BeszTermTip_cbx);
            this.Controls.Add(this.BeszallitoNev_txtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BeszallitoFelvitele";
            this.Text = "Beszallitó Felvitele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BeszallitoNev_txtbx;
        private System.Windows.Forms.ComboBox BeszTermTip_cbx;
        private System.Windows.Forms.Button Rogzit_btn;
        private System.Windows.Forms.Button Kilep_btn;
        private System.Windows.Forms.Label Info_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}