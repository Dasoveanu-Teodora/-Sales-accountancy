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
    public partial class OperatiiGarantie : Form
    {
        Factura factura_noua = new Factura();
        public  List<Client> listaClienti;
    
        string Nume;
        string Prenume;
        string data;
        int pret = 2000;
        int FactId;
        int prelungire;
        public OperatiiGarantie()
        {
            InitializeComponent();

            DataAccess da1 = new DataAccess();
            listaClienti = da1.DepasireGarantie();

            List<KeyValuePair<int, string>> data1 = new List<KeyValuePair<int, string>>();
            foreach (Client cl in listaClienti)
            {

                data1.Add(new KeyValuePair<int, string>(cl.GetClientId(), cl.GetNume() + " " + cl.GetPrenume()));
                this.GarantiiExpirateText.AppendText(cl.GetNume() + "  " + cl.GetPrenume() + "       ");
           

            }

            List<DataAccessGetNPNOGar> clNOGar = new List<DataAccessGetNPNOGar>();
            clNOGar = da1.GetInfoNOGar();

            foreach(DataAccessGetNPNOGar nogar in clNOGar)
            {
                ClientList.Items.Add(nogar.nume + "  " +nogar.prenume);
            }

        }

        private void AddText_Click(object sender, EventArgs e)
        {
            // KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)
            DataAccess da = new DataAccess();
            List<DataAccessGar> facturi = new List<DataAccessGar>();
            facturi = da.GetFacturaID(NumeText.Text,PrenumeText.Text,MasiniText.Text);
            
            FactId = facturi.First().facturaID;
            Console.WriteLine(FactId);

           
            da.InsertGarantie(FactId,Nume, Prenume, data,pret);
            da.UpdateFactura(Nume, Prenume, pret);

            Evidenta ev = new Evidenta();
            ev.Show();
            this.Hide();
        }

        private void NumeText_TextChanged(object sender, EventArgs e)
        {
            Nume = NumeText.Text;
        }

        private void PrenumeText_TextChanged(object sender, EventArgs e)
        {
            Prenume = PrenumeText.Text;

            DataAccess da = new DataAccess();
            List<DataAccessMModel> listaClient = new List<DataAccessMModel>();
            listaClient = da.GetModelMasina(Nume, Prenume);

            //  List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
            List<string> data = new List<string>();
            foreach (DataAccessMModel mod in listaClient)
            {
                data.Add(mod.model);
            }

            this.MasiniText.DataSource = null;
            this.MasiniText.Items.Clear();

            // Bind the combobox
            this.MasiniText.DataSource = new BindingSource(data, null);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ExpDateText.Text = monthCalendar1.SelectionStart.ToString();
            data = ExpDateText.Text;
        }

        private void ExpDateText_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ExtdGarText_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            da.UpdateGarantie(Nume, Prenume, prelungire);
            Evidenta ev = new Evidenta();
            ev.Show();
            this.Hide();
        }

        private void FactText_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)MasiniText.SelectedItem;
          //  FactId = selectedPair.Key;



        }

        private void KeyText_TextChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)MasiniText.SelectedItem;
            FactId =  selectedPair.Key;
        //   KeyText.Text = FactId;
            Console.WriteLine(FactId);

        }

        private void DText_CheckedChanged(object sender, EventArgs e)
        {
            prelungire = 2;
        }

        private void CText_CheckedChanged(object sender, EventArgs e)
        {
            prelungire = 5;
        }

        private void GarExpText_Click(object sender, EventArgs e)
        {
   
            foreach (Client cl in listaClienti)
            {   

                
                this.GarantiiExpirateText.AppendText(cl.GetNume() + " " + cl.GetPrenume());
                Console.WriteLine(cl.GetNume() + " " + cl.GetPrenume());
            }

        }

        private void GarantiiExpirateText_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void OperatiiGarantie_Load(object sender, EventArgs e)
        {

        }

        private void BackText_Click(object sender, EventArgs e)
        {
            CreareFactura cf = new CreareFactura();
            cf.Show();
            this.Hide();
        }

        private void DeleteEcpGArTExt_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            da.DeleteGarantie();
            Evidenta ev = new Evidenta();
            ev.Show();
            this.Hide();
        }

        private void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
