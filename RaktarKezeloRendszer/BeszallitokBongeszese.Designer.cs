
namespace RaktarKezeloRendszer
{
    partial class BeszallitokBongeszese
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bezar_btn = new System.Windows.Forms.Button();
            this.Keresd_btn = new System.Windows.Forms.Button();
            this.Kereso_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Beszallito_dgw = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Beszallito_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bezar_btn);
            this.groupBox1.Controls.Add(this.Keresd_btn);
            this.groupBox1.Controls.Add(this.Kereso_txtbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beszállító Kereső";
            // 
            // Bezar_btn
            // 
            this.Bezar_btn.Location = new System.Drawing.Point(255, 56);
            this.Bezar_btn.Name = "Bezar_btn";
            this.Bezar_btn.Size = new System.Drawing.Size(75, 23);
            this.Bezar_btn.TabIndex = 3;
            this.Bezar_btn.Text = "Bezárás";
            this.Bezar_btn.UseVisualStyleBackColor = true;
            this.Bezar_btn.Click += new System.EventHandler(this.Bezar_btn_Click);
            // 
            // Keresd_btn
            // 
            this.Keresd_btn.Location = new System.Drawing.Point(151, 56);
            this.Keresd_btn.Name = "Keresd_btn";
            this.Keresd_btn.Size = new System.Drawing.Size(75, 23);
            this.Keresd_btn.TabIndex = 2;
            this.Keresd_btn.Text = "Keresd!";
            this.Keresd_btn.UseVisualStyleBackColor = true;
            this.Keresd_btn.Click += new System.EventHandler(this.Keresd_btn_Click);
            // 
            // Kereso_txtbx
            // 
            this.Kereso_txtbx.Location = new System.Drawing.Point(27, 56);
            this.Kereso_txtbx.Name = "Kereso_txtbx";
            this.Kereso_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Kereso_txtbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keresősáv";
            // 
            // Beszallito_dgw
            // 
            this.Beszallito_dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Beszallito_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Beszallito_dgw.Location = new System.Drawing.Point(12, 130);
            this.Beszallito_dgw.Name = "Beszallito_dgw";
            this.Beszallito_dgw.RowHeadersWidth = 30;
            this.Beszallito_dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Beszallito_dgw.Size = new System.Drawing.Size(336, 164);
            this.Beszallito_dgw.TabIndex = 1;
            // 
            // BeszallitokBongeszese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 317);
            this.Controls.Add(this.Beszallito_dgw);
            this.Controls.Add(this.groupBox1);
            this.Name = "BeszallitokBongeszese";
            this.Text = "Beszállitok Böngészése";
            this.Load += new System.EventHandler(this.BeszallitokBongeszese_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Beszallito_dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Keresd_btn;
        private System.Windows.Forms.TextBox Kereso_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Beszallito_dgw;
        private System.Windows.Forms.Button Bezar_btn;
    }
}