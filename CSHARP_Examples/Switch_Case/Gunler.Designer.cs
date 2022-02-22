namespace CSHARP_Examples.Switch_Case
{
    partial class Gunler
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
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaçıncı Gün";
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(102, 34);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(100, 20);
            this.txtGun.TabIndex = 1;
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(127, 60);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(75, 23);
            this.txtBul.TabIndex = 2;
            this.txtBul.Text = "bul";
            this.txtBul.UseVisualStyleBackColor = true;
            this.txtBul.Click += new System.EventHandler(this.txtBul_Click);
            // 
            // Gunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 93);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.label1);
            this.Name = "Gunler";
            this.Text = "Gunler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.Button txtBul;
    }
}