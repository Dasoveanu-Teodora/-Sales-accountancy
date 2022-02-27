
using System.Linq;

namespace EvidentaVanzariAuto
{
    partial class Evidenta
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
            this.LogOutText = new System.Windows.Forms.Button();
            this.EditText = new System.Windows.Forms.Button();
            this.EmailText = new System.Windows.Forms.Label();
            this.CreareFacturaText = new System.Windows.Forms.Button();
            this.VizualizareFacturiText = new System.Windows.Forms.Button();
            this.masinaZileiText = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.Label();
            this.OPGarText = new System.Windows.Forms.Button();
            this.TOPBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pentru modificare datelor contului apasati EDIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(339, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Meniu";
            // 
            // LogOutText
            // 
            this.LogOutText.Location = new System.Drawing.Point(371, 38);
            this.LogOutText.Name = "LogOutText";
            this.LogOutText.Size = new System.Drawing.Size(100, 23);
            this.LogOutText.TabIndex = 3;
            this.LogOutText.Text = "LOG OUT";
            this.LogOutText.UseVisualStyleBackColor = true;
            this.LogOutText.Click += new System.EventHandler(this.LogOutText_Click);
            // 
            // EditText
            // 
            this.EditText.Location = new System.Drawing.Point(371, 91);
            this.EditText.Name = "EditText";
            this.EditText.Size = new System.Drawing.Size(100, 23);
            this.EditText.TabIndex = 4;
            this.EditText.Text = "EDIT";
            this.EditText.UseVisualStyleBackColor = true;
            this.EditText.Click += new System.EventHandler(this.EditText_Click);
            // 
            // EmailText
            // 
            this.EmailText.AutoSize = true;
            this.EmailText.Location = new System.Drawing.Point(111, 38);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(0, 20);
            this.EmailText.TabIndex = 5;
            this.EmailText.UseCompatibleTextRendering = true;
            this.EmailText.Click += new System.EventHandler(this.EmailText_Click);
            // 
            // CreareFacturaText
            // 
            this.CreareFacturaText.Location = new System.Drawing.Point(38, 308);
            this.CreareFacturaText.Name = "CreareFacturaText";
            this.CreareFacturaText.Size = new System.Drawing.Size(145, 33);
            this.CreareFacturaText.TabIndex = 6;
            this.CreareFacturaText.Text = "Creati o factura";
            this.CreareFacturaText.UseVisualStyleBackColor = true;
            this.CreareFacturaText.Click += new System.EventHandler(this.CreareFacturaText_Click);
            // 
            // VizualizareFacturiText
            // 
            this.VizualizareFacturiText.Location = new System.Drawing.Point(38, 387);
            this.VizualizareFacturiText.Name = "VizualizareFacturiText";
            this.VizualizareFacturiText.Size = new System.Drawing.Size(145, 34);
            this.VizualizareFacturiText.TabIndex = 7;
            this.VizualizareFacturiText.Text = "Vizualizare facturi";
            this.VizualizareFacturiText.UseVisualStyleBackColor = true;
            this.VizualizareFacturiText.Click += new System.EventHandler(this.ModifFacText_Click);
            // 
            // masinaZileiText
            // 
            this.masinaZileiText.AutoSize = true;
            this.masinaZileiText.Location = new System.Drawing.Point(602, 76);
            this.masinaZileiText.Name = "masinaZileiText";
            this.masinaZileiText.Size = new System.Drawing.Size(0, 17);
            this.masinaZileiText.TabIndex = 14;
            // 
            // AddressText
            // 
            this.AddressText.AutoSize = true;
            this.AddressText.Location = new System.Drawing.Point(137, 38);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(46, 17);
            this.AddressText.TabIndex = 16;
            this.AddressText.Text = "label7";
            this.AddressText.Click += new System.EventHandler(this.AddressText_Click);
            // 
            // OPGarText
            // 
            this.OPGarText.Location = new System.Drawing.Point(38, 455);
            this.OPGarText.Name = "OPGarText";
            this.OPGarText.Size = new System.Drawing.Size(152, 34);
            this.OPGarText.TabIndex = 18;
            this.OPGarText.Text = "Operatii garantie";
            this.OPGarText.UseVisualStyleBackColor = true;
            this.OPGarText.Click += new System.EventHandler(this.OPGarText_Click);
            // 
            // TOPBut
            // 
            this.TOPBut.Location = new System.Drawing.Point(566, 330);
            this.TOPBut.Name = "TOPBut";
            this.TOPBut.Size = new System.Drawing.Size(136, 91);
            this.TOPBut.TabIndex = 21;
            this.TOPBut.Text = "Bilant";
            this.TOPBut.UseVisualStyleBackColor = true;
            this.TOPBut.Click += new System.EventHandler(this.TOPBut_Click);
            // 
            // Evidenta
            // 
            this.ClientSize = new System.Drawing.Size(756, 527);
            this.Controls.Add(this.TOPBut);
            this.Controls.Add(this.OPGarText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.masinaZileiText);
            this.Controls.Add(this.VizualizareFacturiText);
            this.Controls.Add(this.CreareFacturaText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.EditText);
            this.Controls.Add(this.LogOutText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Evidenta";
            this.Load += new System.EventHandler(this.Evidenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogOutText;
        private System.Windows.Forms.Button EditText;
        private System.Windows.Forms.Label EmailText;
        private System.Windows.Forms.Button CreareFacturaText;
        private System.Windows.Forms.Button VizualizareFacturiText;
        private System.Windows.Forms.Label masinaZileiText;
        private System.Windows.Forms.Label AddressText;
        private System.Windows.Forms.Button OPGarText;
        private System.Windows.Forms.Button TOPBut;
    }
}