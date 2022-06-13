
namespace RaktarKezeloRendszer
{
    partial class TarhelyBongeszes
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
            this.TarhelyBong_dgw = new System.Windows.Forms.DataGridView();
            this.Kereso_txtbx = new System.Windows.Forms.TextBox();
            this.Keres_btn = new System.Windows.Forms.Button();
            this.Kilep_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TarhelyBong_dgw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TarhelyBong_dgw
            // 
            this.TarhelyBong_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TarhelyBong_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TarhelyBong_dgw.Location = new System.Drawing.Point(12, 77);
            this.TarhelyBong_dgw.Name = "TarhelyBong_dgw";
            this.TarhelyBong_dgw.Size = new System.Drawing.Size(269, 186);
            this.TarhelyBong_dgw.TabIndex = 0;
            // 
            // Kereso_txtbx
            // 
            this.Kereso_txtbx.Location = new System.Drawing.Point(6, 19);
            this.Kereso_txtbx.Name = "Kereso_txtbx";
            this.Kereso_txtbx.Size = new System.Drawing.Size(154, 20);
            this.Kereso_txtbx.TabIndex = 2;
            // 
            // Keres_btn
            // 
            this.Keres_btn.Location = new System.Drawing.Point(194, 19);
            this.Keres_btn.Name = "Keres_btn";
            this.Keres_btn.Size = new System.Drawing.Size(75, 23);
            this.Keres_btn.TabIndex = 3;
            this.Keres_btn.Text = "Keresd!";
            this.Keres_btn.UseVisualStyleBackColor = true;
            this.Keres_btn.Click += new System.EventHandler(this.Keres_btn_Click);
            // 
            // Kilep_btn
            // 
            this.Kilep_btn.Location = new System.Drawing.Point(206, 282);
            this.Kilep_btn.Name = "Kilep_btn";
            this.Kilep_btn.Size = new System.Drawing.Size(75, 23);
            this.Kilep_btn.TabIndex = 4;
            this.Kilep_btn.Text = "Kilépés";
            this.Kilep_btn.UseVisualStyleBackColor = true;
            this.Kilep_btn.Click += new System.EventHandler(this.Kilep_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kereso_txtbx);
            this.groupBox1.Controls.Add(this.Keres_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kereső";
            // 
            // TarhelyBongeszes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Kilep_btn);
            this.Controls.Add(this.TarhelyBong_dgw);
            this.Name = "TarhelyBongeszes";
            this.Text = "Tárhely Böngészés";
            this.Load += new System.EventHandler(this.TarhelyBongeszes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TarhelyBong_dgw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TarhelyBong_dgw;
        private System.Windows.Forms.TextBox Kereso_txtbx;
        private System.Windows.Forms.Button Keres_btn;
        private System.Windows.Forms.Button Kilep_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}