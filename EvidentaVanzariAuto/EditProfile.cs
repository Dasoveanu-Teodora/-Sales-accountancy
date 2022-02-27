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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changePassword cp = new changePassword();
            this.Hide();
            cp.Show();
        }

        private void BackEvidBtn_Click(object sender, EventArgs e)
        {
            Evidenta ev = new Evidenta();
            ev.Show();
            this.Hide();
        }
    }
}
