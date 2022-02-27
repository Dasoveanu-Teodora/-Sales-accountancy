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
    public partial class Dashboard : Form
    {
        Utilizator user = new Utilizator();
       
        public static string Email;
        string Password;
        

        public Dashboard()
        {
            InitializeComponent();
        }

        private void EmailAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            
            Email = EmailAddressText.Text;
        
            Password = ParolaText.Text;

            List<Utilizator>  useri = db.GetUtilizatori(Email, Password);

            if(useri.Count() == 0)
            {
                //eroare ca nu exista user cu combinatia de email si parola
                MessageBox.Show("Email and password combination does not exist");
            }
            else
            {
                if(useri.Count > 1)
                {
                    //eroare ca-s mai mmulti utilizatori gasiti
                    MessageBox.Show("Database error. More than one users found with the same credentials");
                }
                else
                {

                    //redirect pe pagina cu evidenta
                    //si salveaza utilizatorul in memorie
                    useri.First().setLogat(true);
                    db.UpdateLogState(Email, useri.First().getLogat());
                    Evidenta objEvidenta = new Evidenta();
                    this.Hide();
                    objEvidenta.Show();
                }
            }
        }

        public void LogOut()
        {
            DataAccess db = new DataAccess();
          
            db.UpdateLogState(Email,false);
        }

        private void Parola_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cont_nou objCont_nou = new Cont_nou();
            
            this.Hide();
            objCont_nou.Show();
           
        }


    }
}
