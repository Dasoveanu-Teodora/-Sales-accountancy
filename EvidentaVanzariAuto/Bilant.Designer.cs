
namespace EvidentaVanzariAuto
{
    partial class Bilant
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
            this.TopVanzari = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TopCarText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TopDotare = new System.Windows.Forms.Label();
            this.BackEvidBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizatorul cu cele mai multe vanzari ";
            // 
            // TopVanzari
            // 
            this.TopVanzari.AutoSize = true;
            this.TopVanzari.Location = new System.Drawing.Point(547, 114);
            this.TopVanzari.Name = "TopVanzari";
            this.TopVanzari.Size = new System.Drawing.Size(46, 17);
            this.TopVanzari.TabIndex = 1;
            this.TopVanzari.Text = "label2";
            this.TopVanzari.Click += new System.EventHandler(this.TopVanzari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cea mai vanduta masina din istoria firmei  ";
            // 
            // TopCarText
            // 
            this.TopCarText.AutoSize = true;
            this.TopCarText.Location = new System.Drawing.Point(547, 172);
            this.TopCarText.Name = "TopCarText";
            this.TopCarText.Size = new System.Drawing.Size(46, 17);
            this.TopCarText.TabIndex = 3;
            this.TopCarText.Text = "label2";
            this.TopCarText.Click += new System.EventHandler(this.TopCarText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cea mai ceruta dotare din ultimul an la masina din istoria firmei  ";
            // 
            // TopDotare
            // 
            this.TopDotare.AutoSize = true;
            this.TopDotare.Location = new System.Drawing.Point(547, 252);
            this.TopDotare.Name = "TopDotare";
            this.TopDotare.Size = new System.Drawing.Size(46, 17);
            this.TopDotare.TabIndex = 5;
            this.TopDotare.Text = "label2";
            this.TopDotare.Click += new System.EventHandler(this.TopDotare_Click);
            // 
            // BackEvidBtn
            // 
            this.BackEvidBtn.Location = new System.Drawing.Point(12, 22);
            this.BackEvidBtn.Name = "BackEvidBtn";
            this.BackEvidBtn.Size = new System.Drawing.Size(149, 23);
            this.BackEvidBtn.TabIndex = 6;
            this.BackEvidBtn.Text = "Inapoi la Evidenta";
            this.BackEvidBtn.UseVisualStyleBackColor = true;
            this.BackEvidBtn.Click += new System.EventHandler(this.BackEvidBtn_Click);
            // 
            // Bilant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackEvidBtn);
            this.Controls.Add(this.TopDotare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TopCarText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopVanzari);
            this.Controls.Add(this.label1);
            this.Name = "Bilant";
            this.Text = "Bilant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TopVanzari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TopCarText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TopDotare;
        private System.Windows.Forms.Button BackEvidBtn;
    }
}