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
    public partial class Bilant : Form
    {
        public Bilant()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            List<DataAccessTopUser> top = new List<DataAccessTopUser>();
            top = da.GetTopUser();
            TopVanzari.Text = top.First().NumeUtilizator + "    " + top.First().NrMasini;

            List<DataAccessTopCar> topCar = new List<DataAccessTopCar>();
            topCar = da.GetTopCar();
            TopCarText.Text = topCar.First().Denumire + "    " + topCar.First().Exemplare;


            List<DataAccessTopDotareTopCar> topDotare = new List<DataAccessTopDotareTopCar>();
            topDotare = da.GetTopCarTopDotare(topCar.First().Denumire);
            TopDotare.Text = topDotare.First().cantitate + "    " + topDotare.First().Denumire + "  " + topDotare.First().incasari;

        }

        private void TopVanzari_Click(object sender, EventArgs e)
        {

        }

        private void TopCarText_Click(object sender, EventArgs e)
        {

        }

        private void TopDotare_Click(object sender, EventArgs e)
        {

        }

        private void BackEvidBtn_Click(object sender, EventArgs e)
        {
            Evidenta ev = new Evidenta();
            ev.Show();
            this.Hide();
        }
    }
}
