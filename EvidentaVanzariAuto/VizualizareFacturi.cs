using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaVanzariAuto
{
    public partial class VizualizareFacturi : Form
    {
        string query;
        List<DataAccessGetNP> getNP = new List<DataAccessGetNP>();

        List<string> nume = new List<string>();
        List<string> prenume = new List<string>();
        string Nume;
        string Prenume;

        // Date continut;
        List<string> pers = new List<string>();
      
        // private object dataGridView1;

        public VizualizareFacturi()
        {
            InitializeComponent();

            DataAccess da = new DataAccess();

          //  pers = da.GetNumePrenume();

        }


        private void NumeClfacText_TextChanged(object sender, EventArgs e)
        {
          Nume = NumeClfacText.Text;
        }

        private void PrenumClText_TextChanged(object sender, EventArgs e)
        {
           Prenume = PrenumClText.Text;

            DataAccess da = new DataAccess();
            List<DataAccessMModel> listaClient = new List<DataAccessMModel>();
            listaClient = da.GetModelMasina(Nume, Prenume);

            //  List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
            List<string> data = new List<string>();
            foreach (DataAccessMModel mod in listaClient)
            {
                data.Add(mod.model);
            }

            this.MasinaClientText.DataSource = null;
            this.MasinaClientText.Items.Clear();

            // Bind the combobox
            this.MasinaClientText.DataSource = new BindingSource(data, null);
        }
        private void VizFacturiBtn_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            List<DataAccessGetNP> getNP = da.GetNumePrenume();

            foreach (DataAccessGetNP np in getNP)
            {
                if (rBNume.Checked)
                    NumeBox.Items.Add(np.nume);
            }


            foreach (DataAccessGetNP np in getNP)
            {
                if (rBData.Checked)
                    DataBox.Items.Add(np.data);

            }






            foreach (DataAccessGetNP np in getNP)
             {
                 if (rBPrenume.Checked)
                     PrenumeBox.Items.Add(np.prenume);
             }

             foreach (DataAccessGetNP np in getNP)
             {
                if (rBMasina.Checked)
                    MasinaBox.Items.Add(np.model);

             }
             foreach (DataAccessGetNP np in getNP)
             {
                if (rBSuma.Checked)
                    SumaBox.Items.Add(np.suma);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
           string model =  MasinaClientText.Text;
            DataAccess da = new DataAccess();
            List<DataAccessGar> facturi = new List<DataAccessGar>();
            facturi = da.GetFacturaID(Nume, Prenume, MasinaClientText.Text);
            int FactId = facturi.First().facturaID;
            List<string> den = new List<string>();
            den = da.GetDotari(Nume, Prenume, MasinaClientText.Text, FactId);

            foreach (string dot in den)
            {
                if (rBDotari.Checked)
                     DotariBox.Items.Add(dot);

            }


            List<DataAccessGetTermneGar> termGar = new List<DataAccessGetTermneGar>();
            termGar = da.GetTermenGarantie(Nume, Prenume, MasinaClientText.Text, FactId);

            foreach (DataAccessGetTermneGar  trmn in termGar)
            {
                if (rBGarantie.Checked)
                    GarantieBox.Items.Add(trmn.termen);

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
