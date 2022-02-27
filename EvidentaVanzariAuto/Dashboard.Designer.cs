
namespace EvidentaVanzariAuto
{
    partial class Dashboard
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
            this.EmailAddressText = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.ParolaLabel = new System.Windows.Forms.Label();
            this.ParolaText = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailAddressText
            // 
            this.EmailAddressText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailAddressText.Location = new System.Drawing.Point(216, 79);
            this.EmailAddressText.Name = "EmailAddressText";
            this.EmailAddressText.Size = new System.Drawing.Size(155, 22);
            this.EmailAddressText.TabIndex = 0;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailAddressLabel.Location = new System.Drawing.Point(39, 79);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(128, 22);
            this.EmailAddressLabel.TabIndex = 1;
            this.EmailAddressLabel.Text = "Email Address";
            this.EmailAddressLabel.Click += new System.EventHandler(this.EmailAddressLabel_Click);
            // 
            // ParolaLabel
            // 
            this.ParolaLabel.AutoSize = true;
            this.ParolaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ParolaLabel.Location = new System.Drawing.Point(39, 149);
            this.ParolaLabel.Name = "ParolaLabel";
            this.ParolaLabel.Size = new System.Drawing.Size(90, 23);
            this.ParolaLabel.TabIndex = 3;
            this.ParolaLabel.Text = "Password";
            // 
            // ParolaText
            // 
            this.ParolaText.BackColor = System.Drawing.Color.White;
            this.ParolaText.Location = new System.Drawing.Point(216, 149);
            this.ParolaText.Name = "ParolaText";
            this.ParolaText.PasswordChar = '*';
            this.ParolaText.Size = new System.Drawing.Size(155, 22);
            this.ParolaText.TabIndex = 2;
            this.ParolaText.TextChanged += new System.EventHandler(this.Parola_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginButton.Location = new System.Drawing.Point(252, 205);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 33);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(205, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apasati aici pentru a crea un cont nou";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(615, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ParolaLabel);
            this.Controls.Add(this.ParolaText);
            this.Controls.Add(this.EmailAddressLabel);
            this.Controls.Add(this.EmailAddressText);
            this.Name = "Dashboard";
            this.Text = "Login Evidenta Vanzari";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailAddressText;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.Label ParolaLabel;
        private System.Windows.Forms.TextBox ParolaText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button button1;
    }
}

