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
   
    public partial class AdaugareClient : Form
    {
        Client clientNou = new Client();
        public AdaugareClient()
        {
            InitializeComponent();
        }

        private void NumeText_TextChanged(object sender, EventArgs e)
        {
            clientNou.SetNume(NumeText.Text);
        }

        private void PrenumeText_TextChanged(object sender, EventArgs e)
        {
            clientNou.SetPrenume(PrenumeText.Text);
        }

        private void CNPText_TextChanged(object sender, EventArgs e)
        {   
      
                clientNou.SetCNP(CNPText.Text);
            
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {
            clientNou.SetEmail(EmailText.Text);
        }

        private void DomiciliuTest_TextChanged(object sender, EventArgs e)
        {
            clientNou.SetDomiciliu(DomiciliuTest.Text);
        }

        private void InserareText_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
         
            if (da.InsertClient(clientNou))
            {
                CreareFactura cf = new CreareFactura();


                this.Hide();
                cf.Show();
            }
            else MessageBox.Show("Error");
        }
    }
}
