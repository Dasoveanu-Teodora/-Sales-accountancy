
using System.Collections.Generic;
using System.Windows.Forms;

namespace EvidentaVanzariAuto
{
    partial class CreareFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CNText = new System.Windows.Forms.Button();
            this.SCText = new System.Windows.Forms.ComboBox();
            this.SMText = new System.Windows.Forms.ComboBox();
            this.CreareFactText = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DotText = new System.Windows.Forms.ComboBox();
            this.SelDotBttn = new System.Windows.Forms.Button();
            this.DotariAdugateText = new System.Windows.Forms.TextBox();
            this.StergereDotarebutton1 = new System.Windows.Forms.Button();
            this.DotareDeEliminattext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BackEvidBtn = new System.Windows.Forms.Button();
            this.clientiExistenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creare factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduceti clientul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alegeti un model de masina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Client deja existent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Adaugati client nou";
            // 
            // CNText
            // 
            this.CNText.Location = new System.Drawing.Point(554, 84);
            this.CNText.Name = "CNText";
            this.CNText.Size = new System.Drawing.Size(185, 38);
            this.CNText.TabIndex = 8;
            this.CNText.Text = "Adaugare client nou";
            this.CNText.UseVisualStyleBackColor = true;
            this.CNText.Click += new System.EventHandler(this.button1_Click);
            // 
            // SCText
            // 
            this.SCText.FormattingEnabled = true;
            this.SCText.Location = new System.Drawing.Point(182, 88);
            this.SCText.Name = "SCText";
            this.SCText.Size = new System.Drawing.Size(116, 24);
            this.SCText.TabIndex = 10;
            // 
            // SMText
            // 
            this.SMText.FormattingEnabled = true;
            this.SMText.Location = new System.Drawing.Point(255, 190);
            this.SMText.Name = "SMText";
            this.SMText.Size = new System.Drawing.Size(121, 24);
            this.SMText.TabIndex = 11;
            // 
            // CreareFactText
            // 
            this.CreareFactText.Location = new System.Drawing.Point(604, 492);
            this.CreareFactText.Name = "CreareFactText";
            this.CreareFactText.Size = new System.Drawing.Size(184, 79);
            this.CreareFactText.TabIndex = 12;
            this.CreareFactText.Text = "Salvare factura";
            this.CreareFactText.UseVisualStyleBackColor = true;
            this.CreareFactText.Click += new System.EventHandler(this.CreareFactText_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dotari disponibile";
            // 
            // DotText
            // 
            this.DotText.FormattingEnabled = true;
            this.DotText.Location = new System.Drawing.Point(53, 331);
            this.DotText.Name = "DotText";
            this.DotText.Size = new System.Drawing.Size(199, 24);
            this.DotText.TabIndex = 16;
            this.DotText.SelectedIndexChanged += new System.EventHandler(this.DotText_SelectedIndexChanged);
            // 
            // SelDotBttn
            // 
            this.SelDotBttn.Location = new System.Drawing.Point(311, 315);
            this.SelDotBttn.Name = "SelDotBttn";
            this.SelDotBttn.Size = new System.Drawing.Size(153, 40);
            this.SelDotBttn.TabIndex = 19;
            this.SelDotBttn.Text = "Adaugare dotare";
            this.SelDotBttn.UseVisualStyleBackColor = true;
            this.SelDotBttn.Click += new System.EventHandler(this.SelDotBttn_Click);
            // 
            // DotariAdugateText
            // 
            this.DotariAdugateText.Location = new System.Drawing.Point(578, 243);
            this.DotariAdugateText.Multiline = true;
            this.DotariAdugateText.Name = "DotariAdugateText";
            this.DotariAdugateText.ReadOnly = true;
            this.DotariAdugateText.Size = new System.Drawing.Size(210, 165);
            this.DotariAdugateText.TabIndex = 20;
            this.DotariAdugateText.TextChanged += new System.EventHandler(this.DotariAdugateText_TextChanged);
            // 
            // StergereDotarebutton1
            // 
            this.StergereDotarebutton1.Location = new System.Drawing.Point(299, 497);
            this.StergereDotarebutton1.Name = "StergereDotarebutton1";
            this.StergereDotarebutton1.Size = new System.Drawing.Size(153, 33);
            this.StergereDotarebutton1.TabIndex = 21;
            this.StergereDotarebutton1.Text = "Elimina dotarea";
            this.StergereDotarebutton1.UseVisualStyleBackColor = true;
            this.StergereDotarebutton1.Click += new System.EventHandler(this.StergereDotarebutton1_Click);
            // 
            // DotareDeEliminattext
            // 
            this.DotareDeEliminattext.Location = new System.Drawing.Point(65, 502);
            this.DotareDeEliminattext.Name = "DotareDeEliminattext";
            this.DotareDeEliminattext.Size = new System.Drawing.Size(136, 22);
            this.DotareDeEliminattext.TabIndex = 22;
            this.DotareDeEliminattext.TextChanged += new System.EventHandler(this.DotareDeEliminattext_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Eliminare dotari vechicul";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Introduceti denumire dotarii pe care nu o mai doriti";
            // 
            // BackEvidBtn
            // 
            this.BackEvidBtn.Location = new System.Drawing.Point(27, 25);
            this.BackEvidBtn.Name = "BackEvidBtn";
            this.BackEvidBtn.Size = new System.Drawing.Size(149, 23);
            this.BackEvidBtn.TabIndex = 25;
            this.BackEvidBtn.Text = "Inapoi la Evidenta";
            this.BackEvidBtn.UseVisualStyleBackColor = true;
            this.BackEvidBtn.Click += new System.EventHandler(this.BackEvidBtn_Click);
            // 
            // clientiExistenti
            // 
            this.clientiExistenti.FormattingEnabled = true;
            this.clientiExistenti.ItemHeight = 16;
            this.clientiExistenti.Location = new System.Drawing.Point(863, 84);
            this.clientiExistenti.Name = "clientiExistenti";
            this.clientiExistenti.Size = new System.Drawing.Size(191, 372);
            this.clientiExistenti.TabIndex = 26;
            this.clientiExistenti.SelectedIndexChanged += new System.EventHandler(this.clientiExistenti_SelectedIndexChanged);
            // 
            // CreareFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 611);
            this.Controls.Add(this.clientiExistenti);
            this.Controls.Add(this.BackEvidBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DotareDeEliminattext);
            this.Controls.Add(this.StergereDotarebutton1);
            this.Controls.Add(this.DotariAdugateText);
            this.Controls.Add(this.SelDotBttn);
            this.Controls.Add(this.DotText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreareFactText);
            this.Controls.Add(this.SMText);
            this.Controls.Add(this.SCText);
            this.Controls.Add(this.CNText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreareFactura";
            this.Text = "CreareFactura";
            this.Load += new System.EventHandler(this.CreareFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CNText;
        private System.Windows.Forms.ComboBox SCText;
        private System.Windows.Forms.ComboBox SMText;
        private Button CreareFactText;
        private Label label5;
        private ComboBox DotText;
        private Button SelDotBttn;
        private TextBox DotariAdugateText;
        private Button StergereDotarebutton1;
        private TextBox DotareDeEliminattext;
        private Label label7;
        private Label label8;
        private Button BackEvidBtn;
        private ListBox clientiExistenti;
    }
}