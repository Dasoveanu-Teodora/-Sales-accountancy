
namespace EvidentaVanzariAuto
{
    partial class AdaugareClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.PrenumeText = new System.Windows.Forms.TextBox();
            this.CNPText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.DomiciliuTest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InserareText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumeText
            // 
            this.NumeText.Location = new System.Drawing.Point(134, 80);
            this.NumeText.Name = "NumeText";
            this.NumeText.Size = new System.Drawing.Size(100, 22);
            this.NumeText.TabIndex = 0;
            this.NumeText.TextChanged += new System.EventHandler(this.NumeText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume:";
            // 
            // PrenumeText
            // 
            this.PrenumeText.Location = new System.Drawing.Point(134, 163);
            this.PrenumeText.Name = "PrenumeText";
            this.PrenumeText.Size = new System.Drawing.Size(100, 22);
            this.PrenumeText.TabIndex = 2;
            this.PrenumeText.TextChanged += new System.EventHandler(this.PrenumeText_TextChanged);
            // 
            // CNPText
            // 
            this.CNPText.Location = new System.Drawing.Point(134, 243);
            this.CNPText.Name = "CNPText";
            this.CNPText.Size = new System.Drawing.Size(100, 22);
            this.CNPText.TabIndex = 3;
            this.CNPText.TextChanged += new System.EventHandler(this.CNPText_TextChanged);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(134, 318);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(100, 22);
            this.EmailText.TabIndex = 4;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // DomiciliuTest
            // 
            this.DomiciliuTest.Location = new System.Drawing.Point(134, 399);
            this.DomiciliuTest.Name = "DomiciliuTest";
            this.DomiciliuTest.Size = new System.Drawing.Size(100, 22);
            this.DomiciliuTest.TabIndex = 5;
            this.DomiciliuTest.TextChanged += new System.EventHandler(this.DomiciliuTest_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "CNP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Domiciliu";
            // 
            // InserareText
            // 
            this.InserareText.Location = new System.Drawing.Point(378, 209);
            this.InserareText.Name = "InserareText";
            this.InserareText.Size = new System.Drawing.Size(88, 56);
            this.InserareText.TabIndex = 10;
            this.InserareText.Text = "Adaugare";
            this.InserareText.UseVisualStyleBackColor = true;
            this.InserareText.Click += new System.EventHandler(this.InserareText_Click);
            // 
            // AdaugareClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InserareText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DomiciliuTest);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.CNPText);
            this.Controls.Add(this.PrenumeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeText);
            this.Name = "AdaugareClient";
            this.Text = "AdaugareClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrenumeText;
        private System.Windows.Forms.TextBox CNPText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox DomiciliuTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button InserareText;
    }
}