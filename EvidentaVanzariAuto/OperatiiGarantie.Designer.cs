
namespace EvidentaVanzariAuto
{
    partial class OperatiiGarantie
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
            this.AddText = new System.Windows.Forms.Button();
            this.ExtdGarText = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.NumeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrenumeText = new System.Windows.Forms.TextBox();
            this.ExpDateText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GarExpText = new System.Windows.Forms.Button();
            this.MasiniText = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dText = new System.Windows.Forms.CheckBox();
            this.cText = new System.Windows.Forms.CheckBox();
            this.GarantiiExpirateText = new System.Windows.Forms.TextBox();
            this.backText = new System.Windows.Forms.Button();
            this.DeleteEcpGArTExt = new System.Windows.Forms.Button();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddText
            // 
            this.AddText.Location = new System.Drawing.Point(491, 290);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(147, 28);
            this.AddText.TabIndex = 0;
            this.AddText.Text = "Adaugare Garantie";
            this.AddText.UseVisualStyleBackColor = true;
            this.AddText.Click += new System.EventHandler(this.AddText_Click);
            // 
            // ExtdGarText
            // 
            this.ExtdGarText.Location = new System.Drawing.Point(491, 389);
            this.ExtdGarText.Name = "ExtdGarText";
            this.ExtdGarText.Size = new System.Drawing.Size(147, 29);
            this.ExtdGarText.TabIndex = 1;
            this.ExtdGarText.Text = "Extindere Garantie";
            this.ExtdGarText.UseVisualStyleBackColor = true;
            this.ExtdGarText.Click += new System.EventHandler(this.ExtdGarText_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(64, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // NumeText
            // 
            this.NumeText.Location = new System.Drawing.Point(64, 290);
            this.NumeText.Name = "NumeText";
            this.NumeText.Size = new System.Drawing.Size(133, 22);
            this.NumeText.TabIndex = 4;
            this.NumeText.TextChanged += new System.EventHandler(this.NumeText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume si Prenume Client  - Inserare Garantie";
            // 
            // PrenumeText
            // 
            this.PrenumeText.Location = new System.Drawing.Point(220, 290);
            this.PrenumeText.Name = "PrenumeText";
            this.PrenumeText.Size = new System.Drawing.Size(128, 22);
            this.PrenumeText.TabIndex = 6;
            this.PrenumeText.TextChanged += new System.EventHandler(this.PrenumeText_TextChanged);
            // 
            // ExpDateText
            // 
            this.ExpDateText.Location = new System.Drawing.Point(252, 343);
            this.ExpDateText.Name = "ExpDateText";
            this.ExpDateText.Size = new System.Drawing.Size(128, 22);
            this.ExpDateText.TabIndex = 11;
            this.ExpDateText.TextChanged += new System.EventHandler(this.ExpDateText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data Expirarii";
            // 
            // GarExpText
            // 
            this.GarExpText.Location = new System.Drawing.Point(208, 495);
            this.GarExpText.Name = "GarExpText";
            this.GarExpText.Size = new System.Drawing.Size(284, 23);
            this.GarExpText.TabIndex = 13;
            this.GarExpText.Text = "Lista Clienti Garantii Expirate";
            this.GarExpText.UseVisualStyleBackColor = true;
            // 
            // MasiniText
            // 
            this.MasiniText.FormattingEnabled = true;
            this.MasiniText.Location = new System.Drawing.Point(491, 73);
            this.MasiniText.Name = "MasiniText";
            this.MasiniText.Size = new System.Drawing.Size(121, 24);
            this.MasiniText.TabIndex = 14;
            this.MasiniText.SelectedIndexChanged += new System.EventHandler(this.FactText_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Masini Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prelungire garantie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 17;
            // 
            // dText
            // 
            this.dText.AutoSize = true;
            this.dText.Location = new System.Drawing.Point(196, 371);
            this.dText.Name = "dText";
            this.dText.Size = new System.Drawing.Size(61, 21);
            this.dText.TabIndex = 18;
            this.dText.Text = "2 ani";
            this.dText.UseVisualStyleBackColor = true;
            this.dText.CheckedChanged += new System.EventHandler(this.DText_CheckedChanged);
            // 
            // cText
            // 
            this.cText.AutoSize = true;
            this.cText.Location = new System.Drawing.Point(196, 424);
            this.cText.Name = "cText";
            this.cText.Size = new System.Drawing.Size(61, 21);
            this.cText.TabIndex = 19;
            this.cText.Text = "5 ani";
            this.cText.UseVisualStyleBackColor = true;
            this.cText.CheckedChanged += new System.EventHandler(this.CText_CheckedChanged);
            // 
            // GarantiiExpirateText
            // 
            this.GarantiiExpirateText.Location = new System.Drawing.Point(119, 524);
            this.GarantiiExpirateText.Multiline = true;
            this.GarantiiExpirateText.Name = "GarantiiExpirateText";
            this.GarantiiExpirateText.Size = new System.Drawing.Size(457, 181);
            this.GarantiiExpirateText.TabIndex = 20;
            this.GarantiiExpirateText.TextChanged += new System.EventHandler(this.GarantiiExpirateText_TextChanged);
            // 
            // backText
            // 
            this.backText.Location = new System.Drawing.Point(3, 2);
            this.backText.Name = "backText";
            this.backText.Size = new System.Drawing.Size(60, 23);
            this.backText.TabIndex = 21;
            this.backText.Text = "inapoi";
            this.backText.UseVisualStyleBackColor = true;
            this.backText.Click += new System.EventHandler(this.BackText_Click);
            // 
            // DeleteEcpGArTExt
            // 
            this.DeleteEcpGArTExt.Location = new System.Drawing.Point(666, 561);
            this.DeleteEcpGArTExt.Name = "DeleteEcpGArTExt";
            this.DeleteEcpGArTExt.Size = new System.Drawing.Size(127, 77);
            this.DeleteEcpGArTExt.TabIndex = 22;
            this.DeleteEcpGArTExt.Text = "Sterge Garantie Expirata";
            this.DeleteEcpGArTExt.UseVisualStyleBackColor = true;
            this.DeleteEcpGArTExt.Click += new System.EventHandler(this.DeleteEcpGArTExt_Click);
            // 
            // ClientList
            // 
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 16;
            this.ClientList.Location = new System.Drawing.Point(710, 73);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(246, 436);
            this.ClientList.TabIndex = 24;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            // 
            // OperatiiGarantie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 793);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.DeleteEcpGArTExt);
            this.Controls.Add(this.backText);
            this.Controls.Add(this.GarantiiExpirateText);
            this.Controls.Add(this.cText);
            this.Controls.Add(this.dText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MasiniText);
            this.Controls.Add(this.GarExpText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpDateText);
            this.Controls.Add(this.PrenumeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeText);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.ExtdGarText);
            this.Controls.Add(this.AddText);
            this.Name = "OperatiiGarantie";
            this.Text = "OperatiiGarantie";
            this.Load += new System.EventHandler(this.OperatiiGarantie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddText;
        private System.Windows.Forms.Button ExtdGarText;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox NumeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrenumeText;
        private System.Windows.Forms.TextBox ExpDateText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GarExpText;
        private System.Windows.Forms.ComboBox MasiniText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox dText;
        private System.Windows.Forms.CheckBox cText;
        private System.Windows.Forms.TextBox GarantiiExpirateText;
        private System.Windows.Forms.Button backText;
        private System.Windows.Forms.Button DeleteEcpGArTExt;
        private System.Windows.Forms.ListBox ClientList;
    }
}