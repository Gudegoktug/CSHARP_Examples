namespace CSHARP_Examples.Dice_Game
{
    partial class Simple_Dice_Game
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
            this.lblComputer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.btnSalla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgisayar: ";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(134, 23);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(35, 13);
            this.lblComputer.TabIndex = 0;
            this.lblComputer.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Senin Zar";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Location = new System.Drawing.Point(134, 60);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(35, 13);
            this.lblSayi.TabIndex = 0;
            this.lblSayi.Text = "label1";
            // 
            // btnSalla
            // 
            this.btnSalla.Location = new System.Drawing.Point(57, 88);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(123, 23);
            this.btnSalla.TabIndex = 1;
            this.btnSalla.Text = "Salla Kocccum";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // Simple_Dice_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 146);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.label1);
            this.Name = "Simple_Dice_Game";
            this.Text = "Simple_Dice_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Button btnSalla;
    }
}