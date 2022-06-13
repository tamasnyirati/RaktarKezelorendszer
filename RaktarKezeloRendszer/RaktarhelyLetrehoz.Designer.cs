
namespace RaktarKezeloRendszer
{
    partial class RaktarhelyLetrehoz
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
            this.Letrehoz_btn = new System.Windows.Forms.Button();
            this.Kilep_btn = new System.Windows.Forms.Button();
            this.TarhelyNeve_txtbx = new System.Windows.Forms.TextBox();
            this.TarhelyTip_cbx = new System.Windows.Forms.ComboBox();
            this.Info_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új tárhely neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Új tárhely típusa: ";
            // 
            // Letrehoz_btn
            // 
            this.Letrehoz_btn.Location = new System.Drawing.Point(42, 142);
            this.Letrehoz_btn.Name = "Letrehoz_btn";
            this.Letrehoz_btn.Size = new System.Drawing.Size(75, 23);
            this.Letrehoz_btn.TabIndex = 2;
            this.Letrehoz_btn.Text = "Létrehoz";
            this.Letrehoz_btn.UseVisualStyleBackColor = true;
            this.Letrehoz_btn.Click += new System.EventHandler(this.Letrehoz_btn_Click);
            // 
            // Kilep_btn
            // 
            this.Kilep_btn.Location = new System.Drawing.Point(169, 142);
            this.Kilep_btn.Name = "Kilep_btn";
            this.Kilep_btn.Size = new System.Drawing.Size(75, 23);
            this.Kilep_btn.TabIndex = 3;
            this.Kilep_btn.Text = "Kilépés";
            this.Kilep_btn.UseVisualStyleBackColor = true;
            this.Kilep_btn.Click += new System.EventHandler(this.Kilep_btn_Click);
            // 
            // TarhelyNeve_txtbx
            // 
            this.TarhelyNeve_txtbx.Location = new System.Drawing.Point(123, 55);
            this.TarhelyNeve_txtbx.Name = "TarhelyNeve_txtbx";
            this.TarhelyNeve_txtbx.Size = new System.Drawing.Size(121, 20);
            this.TarhelyNeve_txtbx.TabIndex = 4;
            // 
            // TarhelyTip_cbx
            // 
            this.TarhelyTip_cbx.AutoCompleteCustomSource.AddRange(new string[] {
            "Salgópolc",
            "Nehézállvány"});
            this.TarhelyTip_cbx.FormattingEnabled = true;
            this.TarhelyTip_cbx.Items.AddRange(new object[] {
            "Salgópolc",
            "Nehézállvány"});
            this.TarhelyTip_cbx.Location = new System.Drawing.Point(123, 93);
            this.TarhelyTip_cbx.Name = "TarhelyTip_cbx";
            this.TarhelyTip_cbx.Size = new System.Drawing.Size(121, 21);
            this.TarhelyTip_cbx.TabIndex = 5;
            // 
            // Info_lbl
            // 
            this.Info_lbl.AutoSize = true;
            this.Info_lbl.Location = new System.Drawing.Point(6, 27);
            this.Info_lbl.Name = "Info_lbl";
            this.Info_lbl.Size = new System.Drawing.Size(35, 13);
            this.Info_lbl.TabIndex = 6;
            this.Info_lbl.Text = "label3";
            this.Info_lbl.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Info_lbl);
            this.groupBox1.Location = new System.Drawing.Point(13, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 58);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendszerüzenet";
            // 
            // RaktarhelyLetrehoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 275);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TarhelyTip_cbx);
            this.Controls.Add(this.TarhelyNeve_txtbx);
            this.Controls.Add(this.Kilep_btn);
            this.Controls.Add(this.Letrehoz_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RaktarhelyLetrehoz";
            this.Text = "Új tárhely Létrehozása";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Letrehoz_btn;
        private System.Windows.Forms.Button Kilep_btn;
        private System.Windows.Forms.TextBox TarhelyNeve_txtbx;
        private System.Windows.Forms.ComboBox TarhelyTip_cbx;
        private System.Windows.Forms.Label Info_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}