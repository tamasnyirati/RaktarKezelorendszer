
namespace RaktarKezeloRendszer
{
    partial class TetelRakhelyValasztas
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
            this.RaktTetel_dgw = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ok_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RaktTetel_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // RaktTetel_dgw
            // 
            this.RaktTetel_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RaktTetel_dgw.Location = new System.Drawing.Point(1, 64);
            this.RaktTetel_dgw.Name = "RaktTetel_dgw";
            this.RaktTetel_dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RaktTetel_dgw.Size = new System.Drawing.Size(530, 153);
            this.RaktTetel_dgw.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Válaszd ki, hogy honnan szeretnéd mozgatni a terméket!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A kiválasztott tétel több raktárhelyen van tárolva!";
            // 
            // Ok_btn
            // 
            this.Ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok_btn.Location = new System.Drawing.Point(227, 240);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(75, 23);
            this.Ok_btn.TabIndex = 3;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TetelRakhelyValasztas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 271);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RaktTetel_dgw);
            this.Name = "TetelRakhelyValasztas";
            this.Text = "Tétel és Raktárhely választás";
            this.Load += new System.EventHandler(this.TetelRakhelyValasztas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaktTetel_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RaktTetel_dgw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ok_btn;
    }
}