using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaVanzariAuto
{
    public partial class changePassword : Form
    {
        string newPassword;

        public changePassword()
        {
            InitializeComponent();
        }

      

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
           
           
            newPassword = NPText.Text;
           

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            List<string> EA;

            if (da.UpdatePassword(newPassword))
            {
                
                EA = da.SelectUser(true);
                da.UpdateLogState(EA.First(), false);
                Dashboard db = new Dashboard();
                this.Hide();
                db.Show();

            }
            else
            {
                EA = da.SelectUser(true);
                da.UpdateLogState(EA.First(), false);
                MessageBox.Show("          plll   Database error.                                ");
            }
        }

        private void BackEvidBtn_Click(object sender, EventArgs e)
        {
            Evidenta ev = new Evidenta();
            ev.Show();
            this.Hide();
        }
    }
}
