namespace CSHARP_Examples.Switch_Case
{
    partial class Reyon
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
            this.txtReyon = new System.Windows.Forms.TextBox();
            this.btnUrunBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // txtReyon
            // 
            this.txtReyon.Location = new System.Drawing.Point(74, 25);
            this.txtReyon.Name = "txtReyon";
            this.txtReyon.Size = new System.Drawing.Size(101, 20);
            this.txtReyon.TabIndex = 1;
            // 
            // btnUrunBul
            // 
            this.btnUrunBul.Location = new System.Drawing.Point(99, 63);
            this.btnUrunBul.Name = "btnUrunBul";
            this.btnUrunBul.Size = new System.Drawing.Size(75, 23);
            this.btnUrunBul.TabIndex = 2;
            this.btnUrunBul.Text = "reyon bul";
            this.btnUrunBul.UseVisualStyleBackColor = true;
            this.btnUrunBul.Click += new System.EventHandler(this.btnUrunBul_Click);
            // 
            // Reyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 114);
            this.Controls.Add(this.btnUrunBul);
            this.Controls.Add(this.txtReyon);
            this.Controls.Add(this.label1);
            this.Name = "Reyon";
            this.Text = "Reyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReyon;
        private System.Windows.Forms.Button btnUrunBul;
    }
}