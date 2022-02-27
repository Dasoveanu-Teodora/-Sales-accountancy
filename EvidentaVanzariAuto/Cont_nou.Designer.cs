
namespace EvidentaVanzariAuto
{
    partial class Cont_nou
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
            this.NumeText = new System.Windows.Forms.TextBox();
            this.PrenumeText = new System.Windows.Forms.TextBox();
            this.AdresaEmailText = new System.Windows.Forms.TextBox();
            this.ParolaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeText
            // 
            this.NumeText.Location = new System.Drawing.Point(328, 87);
            this.NumeText.Name = "NumeText";
            this.NumeText.Size = new System.Drawing.Size(100, 22);
            this.NumeText.TabIndex = 0;
            this.NumeText.TextChanged += new System.EventHandler(this.NumeText_TextChanged);
            // 
            // PrenumeText
            // 
            this.PrenumeText.Location = new System.Drawing.Point(328, 161);
            this.PrenumeText.Name = "PrenumeText";
            this.PrenumeText.Size = new System.Drawing.Size(100, 22);
            this.PrenumeText.TabIndex = 1;
            // 
            // AdresaEmailText
            // 
            this.AdresaEmailText.Location = new System.Drawing.Point(328, 228);
            this.AdresaEmailText.Name = "AdresaEmailText";
            this.AdresaEmailText.Size = new System.Drawing.Size(100, 22);
            this.AdresaEmailText.TabIndex = 2;
            // 
            // ParolaText
            // 
            this.ParolaText.Location = new System.Drawing.Point(328, 299);
            this.ParolaText.Name = "ParolaText";
            this.ParolaText.PasswordChar = '*';
            this.ParolaText.Size = new System.Drawing.Size(100, 22);
            this.ParolaText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Introduceti Numele Utilizatorului";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Introduceti Prenumele Utilizatorlui";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Introduceti Adresa de Email ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Introduceti Parola Contului ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(94, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Creare utilizator nou";
            // 
            // SubmitText
            // 
            this.SubmitText.Location = new System.Drawing.Point(328, 378);
            this.SubmitText.Name = "SubmitText";
            this.SubmitText.Size = new System.Drawing.Size(96, 23);
            this.SubmitText.TabIndex = 10;
            this.SubmitText.Text = "Creare";
            this.SubmitText.UseVisualStyleBackColor = true;
            this.SubmitText.Click += new System.EventHandler(this.SubmitText_Click);
            // 
            // Cont_nou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParolaText);
            this.Controls.Add(this.AdresaEmailText);
            this.Controls.Add(this.PrenumeText);
            this.Controls.Add(this.NumeText);
            this.Name = "Cont_nou";
            this.Text = "Cont_nou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeText;
        private System.Windows.Forms.TextBox PrenumeText;
        private System.Windows.Forms.TextBox AdresaEmailText;
        private System.Windows.Forms.TextBox ParolaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitText;
    }
}