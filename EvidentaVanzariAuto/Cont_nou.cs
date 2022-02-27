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
    public partial class Cont_nou : Form
    {
        string Nume;
        string Prenume;
        string AdresaEmail;
        string Parola;
        bool Log = false;
        bool OK = false;
        public Cont_nou()
        {
            InitializeComponent();
        }

        private void SubmitText_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Nume = NumeText.Text;
            Prenume = PrenumeText.Text;
            AdresaEmail = AdresaEmailText.Text;
            Parola = ParolaText.Text;
            if (Nume == "" || Nume == null || Prenume == "" || Prenume == null || AdresaEmail == "" || AdresaEmail == null || Parola == "" || Parola == null)
            {
                MessageBox.Show("Completeati toate campurile pentru a creea un utilizator");
            }
            else
            {
                List<Utilizator> utilizatoriEmail = db.GetUtilizatoriEmail(AdresaEmail);

                if (utilizatoriEmail.Count != 0)
                {
                    MessageBox.Show("Deja exista un utilizator cu aceasta adresa de email");
                }
                else
                {   
                    if (db.InsertUtilizatori(Nume, Prenume, AdresaEmail, Parola,Log))
                    {
                        OK = true;
                        Dashboard login = new Dashboard();

                        this.Hide();
                        login.Show();
                    }
                }
            }
        }

        private void NumeText_TextChanged(object sender, EventArgs e)
        {



        }

        public bool getOK()
         {
            return OK;
          }

        public void getInsertStatus(bool OK)
        {
            if (OK)
                this.Hide();
        }
    }
}
