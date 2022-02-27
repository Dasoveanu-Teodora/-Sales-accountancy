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
    public partial class Evidenta : Form
    {
        DateTimeOffset data;
       // string AdresaEmail;
        public Evidenta()
        {
        
     
                InitializeComponent();

            DataAccess da = new DataAccess();
            this.AddressText.Text = da.SelectUser(true).First();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }


        private void LogOutText_Click(object sender, EventArgs e)
        {
            
            Dashboard login = new Dashboard();
            login.LogOut();
            this.Hide();
            login.Show();
        }

        private void EditText_Click(object sender, EventArgs e)
        {
            EditProfile editare = new EditProfile();
            this.Hide();
            editare.Show();
        }
      
        private void EmailText_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            EmailText.Text = da.SelectUser(true).FirstOrDefault();
        }
      
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //Evidenta ev = new Evidenta();
            // ev.
           // pictureBox1Text.Image = new Bitmap("E:\BD\tema\DesktopAPP\SQLEvidentaVanzariAuto");

        }

        private void AddressText_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            AddressText.Text = da.SelectUser(true).First();
        }

        private void Evidenta_Load(object sender, EventArgs e)
        {

        }

        private void CreareFacturaText_Click(object sender, EventArgs e)
        {
            CreareFactura cf = new CreareFactura();
            this.Hide();
            cf.Show();
        }

        private void ModifFacText_Click(object sender, EventArgs e)
        {
            VizualizareFacturi vf = new VizualizareFacturi();
            vf.Show();
            this.Hide();
        }

        private void OPGarText_Click(object sender, EventArgs e)
        {
            OperatiiGarantie ag = new OperatiiGarantie();
            ag.Show();
            this.Hide();
        }

        private void CurrentTimeText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CurrentDateTExt_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TOPBut_Click(object sender, EventArgs e)
        {
            Bilant bil = new Bilant();
            bil.Show();
            this.Hide();
        }

        private void OpDotText_Click(object sender, EventArgs e)
        {

        }
    }
}
