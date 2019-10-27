namespace ZarOyunu37
{
    partial class ZarOyunu
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
            this.txtZar1 = new System.Windows.Forms.TextBox();
            this.lblSayiSec = new System.Windows.Forms.Label();
            this.txtZar2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtZar1
            // 
            this.txtZar1.Location = new System.Drawing.Point(71, 74);
            this.txtZar1.Multiline = true;
            this.txtZar1.Name = "txtZar1";
            this.txtZar1.Size = new System.Drawing.Size(65, 38);
            this.txtZar1.TabIndex = 12;
            // 
            // lblSayiSec
            // 
            this.lblSayiSec.AutoSize = true;
            this.lblSayiSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayiSec.Location = new System.Drawing.Point(67, 13);
            this.lblSayiSec.Name = "lblSayiSec";
            this.lblSayiSec.Size = new System.Drawing.Size(267, 20);
            this.lblSayiSec.TabIndex = 13;
            this.lblSayiSec.Text = "Lütfen 1. ve 2. zar değerlerini girin.";
            // 
            // txtZar2
            // 
            this.txtZar2.Location = new System.Drawing.Point(269, 74);
            this.txtZar2.Multiline = true;
            this.txtZar2.Name = "txtZar2";
            this.txtZar2.Size = new System.Drawing.Size(65, 38);
            this.txtZar2.TabIndex = 14;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(153, 201);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(92, 39);
            this.btnHesapla.TabIndex = 15;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(176, 277);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(46, 17);
            this.lblSonuc.TabIndex = 17;
            this.lblSonuc.Text = "label1";
            // 
            // ZarOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtZar2);
            this.Controls.Add(this.lblSayiSec);
            this.Controls.Add(this.txtZar1);
            this.Name = "ZarOyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtZar1;
        private System.Windows.Forms.Label lblSayiSec;
        private System.Windows.Forms.TextBox txtZar2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}

