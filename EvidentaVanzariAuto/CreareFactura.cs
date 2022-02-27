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
    public partial class CreareFactura : Form
    {
        Factura factura_noua = new Factura();
        Masina car = new Masina();
        List<KeyValuePair<int, string>> listaDotari = new List<KeyValuePair<int, string>>();
        List<KeyValuePair<int, string>> UpdatePretFact = new List<KeyValuePair<int, string>>(); 
        List <string> dotari = new List< string>();
        List<int> DotariId = new List<int>();
        List<string> EliminareDotari = new List<string>();
        List<string> RemovedStrings = new List<string>();
        // List<int> preturi = new List<int>();
        int IDCar = 0 ;
        public CreareFactura()
        {

            InitializeComponent();

            List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
            List<KeyValuePair<int, string>> data1 = new List<KeyValuePair<int, string>>();

          
            // Add data to the List
            DataAccess da = new DataAccess();
            List<Client> listaClienti = da.GetClienti();
            List<Masina> listaMasini = da.GetMasini();
           

            foreach (Client client in listaClienti)
            {
                clientiExistenti.Items.Add(client.GetNume() + "   " + client.GetPrenume());
                data.Add(new KeyValuePair<int, string>(client.GetClientId(), client.GetNume()));
            }
            // Clear the combobox
            this.SCText.DataSource = null;
            this.SCText.Items.Clear();

            // Bind the combobox
            this.SCText.DataSource = new BindingSource(data, null);

            foreach (Masina masina in listaMasini)
            {
                data1.Add(new KeyValuePair<int, string>(masina.GetMasinaId(), masina.GetModel()));

            }
            // Clear the combobox
            this.SMText.DataSource = null;
            this.SMText.Items.Clear();

            // Bind the combobox

            this.SMText.DataSource = new BindingSource(data1, null);

            //ataAccess da = new DataAccess()
            List<KeyValuePair<int, string>> data2= new List<KeyValuePair<int, string>>();
            List<Dotare> listaDotari = da.GetDotari();

            foreach (Dotare dot in listaDotari)
            {
                data2.Add(new KeyValuePair<int, string>(dot.GetDotareId(),dot.GetDenumire()));
               // dotari.Add(dot.GetDenumire());
             //   DotariId.Add(dot.GetDotareId());
            }
            // Clear the combobox
            this.DotText.DataSource = null;
            this.DotText.Items.Clear();

            // Bind the combobox

            this.DotText.DataSource = new BindingSource(data2, null);

        }

        private void SCText_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)SCText.SelectedItem;
            factura_noua.SetClientId(selectedPair.Key);
        }

        private void SMText_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedPair1 = (KeyValuePair<int, string>)SMText.SelectedItem;
            factura_noua.SetMasinaId(selectedPair1.Key);
            IDCar = factura_noua.GetMasinaID();
            DataAccess da = new DataAccess();
            int sum = da.GetPretMasina(selectedPair1.Key).First();
            factura_noua.SetSuma(sum + 25 / 100 * sum);
            factura_noua.SetUtilizatorID(da.SelectUserID(true).First());
           

        }

        private void CreareFactText_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();


            KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)SCText.SelectedItem;
            factura_noua.SetClientId(selectedPair.Key);
            KeyValuePair<int, string> selectedPair1 = (KeyValuePair<int, string>)SMText.SelectedItem;
            factura_noua.SetMasinaId(selectedPair1.Key);
            IDCar = factura_noua.GetMasinaID();
            int sum = da.GetPretMasina(selectedPair1.Key).First();
            factura_noua.SetSuma(sum + 25 / 100 * sum);
            factura_noua.SetUtilizatorID(da.SelectUserID(true).First());
            factura_noua.SetData(DateTime.Now);
            
            foreach(int id in DotariId)
            {
                da.InsertAsociereDotare(id, IDCar);
            }

            List<int> preturiDotari = new List<int>();
            List<int> aux = new List<int>();
            
          
            foreach (string numeDot in dotari)
            {
                aux =  da.GetPretDotari(numeDot);
                preturiDotari.Add(aux.First());
               
            }

            foreach (int  dotPR in preturiDotari)
            {
                factura_noua.SetSuma(dotPR + factura_noua.GetSuma());

                //da.InsertAsociereDotare(dotPR.Key, IDCar);
                // da.UpdateFacturaDotari(dotPR.Value,factura_noua.GetUtilizatorID(),factura_noua.GetClientID())
            }
           
            aux = new List<int>();

            List<int> preturiDotariEliminate = new List<int>();
            foreach (string numeDot in RemovedStrings)
            {
                aux = da.GetPretDotari(numeDot);
                preturiDotariEliminate.Add(aux.First());

            }

            foreach (int dotPR in preturiDotariEliminate)
            {
                factura_noua.SetSuma( factura_noua.GetSuma()-dotPR);

                //da.InsertAsociereDotare(dotPR.Key, IDCar);
                // da.UpdateFacturaDotari(dotPR.Value,factura_noua.GetUtilizatorID(),factura_noua.GetClientID())
            }

            foreach (string numeDot in RemovedStrings)
            {
                Console.WriteLine(numeDot);
                da.DeleteAsociereDotare(numeDot, IDCar);

            }
            
           
                
             da.InsertFactura(factura_noua);

            MessageBox.Show("Records Inserted Successfully");
            Evidenta ev = new Evidenta();
            ev.Show();
            this.Hide();
            
           
        }

        private void DtaText_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdaugareClient ac = new AdaugareClient();
            ac.Show();
            this.Hide();
        }

        private void DotText_SelectedIndexChanged(object sender, EventArgs e)
        { //dropdown
          //  dotareNoua.Add(DotText.SelectedText);
        }

        private void SelDotBttn_Click(object sender, EventArgs e)
        {  //btn select

            KeyValuePair<int, string> selectedPair = (KeyValuePair<int, string>)DotText.SelectedItem;
         
            DotariAdugateText.AppendText (selectedPair.Value);
            DotariAdugateText.AppendText("           ");
            UpdatePretFact.Add(new KeyValuePair<int, string>(selectedPair.Key, selectedPair.Value));
            dotari.Add(selectedPair.Value);
        
            DotariId.Add(selectedPair.Key);
            
        }

        private void DotSelectateText_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void DotariAdugateText_TextChanged(object sender, EventArgs e)
        { //dotari adaugate
        }

        private void OpDotText_Click(object sender, EventArgs e)
        {

        }

        private void CreareFactura_Load(object sender, EventArgs e)
        {

        }

        private void DotareDeEliminattext_TextChanged(object sender, EventArgs e)
        {

        }

        private void StergereDotarebutton1_Click(object sender, EventArgs e)
        {
            EliminareDotari.Add(DotareDeEliminattext.Text);
            foreach (string DotElimi in EliminareDotari)
            {
               if(dotari.Remove(DotElimi))
                {
                    RemovedStrings.Add(DotElimi);
                }
            }

            DotariAdugateText.Text = "";
            foreach(string dot in  dotari)
            {
                DotariAdugateText.AppendText(dot);
                DotariAdugateText.AppendText("                       ");
            }

        }

        private void BackEvidBtn_Click(object sender, EventArgs e)
        {
            Evidenta ev = new Evidenta();
            ev.Show();
            this.Hide();
        }

        private void clientiExistenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
