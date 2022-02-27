using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace EvidentaVanzariAuto
{
    public class DataAccessGetNP
    {
        public string nume;
        public string prenume;
        public string model;
        public DateTime data;
        public int suma;
    }

    public class DataAccessTopDotareTopCar
    {
        public string Denumire;
        public int incasari;
        public int cantitate;
    }

    public class DataAccessTopUser
    {
        public string NumeUtilizator;
   
        public int NrMasini;
    }


    public class DataAccessTopCar
    {
        public string Denumire;

        public int Exemplare;
    }

    public class DataAccessMModel
    {
     
        public string model;
       // public DateTime data; 
    }

    public class DataAccessDenDotari
    {

        public string denumire;
        // public DateTime data; 
    }

    public class DataAccessGar
    {
        public int facturaID;
        public DateTime data;
    }
    public class DataAccessGetNPNOGar
    {
        public string nume;
        public string prenume;
  
    }
    public class DataAccessGetInfo
    {
        public string model;
        public DateTime data;
        public bool garantie;
        public bool dotari;
        public int suma;

    }

    public class DataAccessGetTermneGar
    {

        public DateTime termen;
     

    }
    public class DataAccess
    {
        string query;

        public List<Utilizator> GetUtilizatori(string EmailAddress, string Password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<Utilizator>($"select * from Utilizator where EmailAddress = '{EmailAddress}' AND Parola = '{Password}'").ToList();

                return output;
            }
        }

        public List<Utilizator> GetUtilizatoriEmail(string EmailAddress)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<Utilizator>($"select * from Utilizator where EmailAddress = '{EmailAddress}'").ToList();

                return output;
            }
        }

        public bool InsertUtilizatori(string FirstName, string LastName, string EmailAddress, string Password, bool Log)
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                query = "insert into Utilizator(Nume,Prenume,EmailAddress,Parola,Logat) values ('" + LastName + "','" + FirstName + "','" + EmailAddress + "','" + Password + "','" + Log + "');";

                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    OK = true;
                    MessageBox.Show("Records Inserted Successfully");

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    connection.Close();


                }
                return OK;

            }
        }


        public bool UpdateLogState(string EmailAddress, bool Log)
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {


                query = " update  Utilizator set Logat = @lg where  EmailAddress = @EA ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@lg", Log);
                command.Parameters.AddWithValue("@EA", EmailAddress);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    OK = true;


                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    connection.Close();


                }
                return OK;

            }
        }


        public bool UpdatePassword(string NewPass)
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {


                query = " update  Utilizator set Parola = @np where  Logat = @state ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("np", NewPass);
                command.Parameters.AddWithValue("state", true);
                try
                {
                    connection.Open();
                    OK = true;
                    command.ExecuteNonQuery();



                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {

                    connection.Close();


                }

                return OK;
            }
        }



        public List<string> SelectUser(bool state)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {

                var output = connection.Query<String>($"select EmailAddress from Utilizator where Logat = {1} ").ToList();


                return output;
            }

        }

        public List<int> SelectUserID(bool state)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {

                var output = connection.Query<int>($"select UtilizatorId from Utilizator where Logat = {1} ").ToList();


                return output;
            }

        }

        public List<Client> GetClienti()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<Client>($"select ClientID, Nume, Prenume from Client ").ToList();
                return output;
            }
        }

        public List<Masina> GetMasini()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<Masina>($"select MasinaID, Model  from Masina ").ToList();
                return output;
            }
        }

        public List<int> GetPretMasina(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<int>($"select Pret from Masina where MasinaId = {ID}").ToList();
                return output;
            }
        }


        public bool InsertFactura(Factura fact)
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                query = "insert into Factura(ClientID,MasinaID,UtilizatorID,Suma,Data) values ('" + fact.GetClientID() + "','" + fact.GetMasinaID() + "','" + fact.GetUtilizatorID() + "','" + fact.GetSuma() + "','" + fact.GetData().ToString().Substring(0, 9) + "');";

                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    OK = true;
                    //   MessageBox.Show("Records Inserted Successfully");

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    connection.Close();


                }
                return OK;

            }
        }

        public bool InsertClient(Client cl)
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                query = "insert into Client(Nume,Prenume,CNP,Email,Domiciliu) values ('" + cl.GetNume() + "','" + cl.GetPrenume() + "','" + cl.GetCNP() + "','" + cl.GetEmail() + "','" + cl.GetDomiciliu() + "');";

                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    OK = true;
                    MessageBox.Show("Records Inserted Successfully");

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    connection.Close();


                }
                return OK;

            }
        }

        public bool InsertGarantie(int FactID, string nume, string prenume, string data, int pret)
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                query = " insert into Garantie(FacturaId, Termen, Pret) values('" + FactID + "','" + data + "','" + pret + "') ;";

                SqlCommand command = new SqlCommand(query, connection);
                // command.Parameters.AddWithValue("name", nume);
                // command.Parameters.AddWithValue("prename", prenume);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    OK = true;
                    MessageBox.Show("Records Inserted Successfully");

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    connection.Close();


                }
                return OK;

            }
        }

        public bool UpdateFactura(string nume, string prenume, int pret)
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {


                query = "update  Factura set suma = suma + @pr where FacturaID IN (  select FacturaID from Factura f inner join client c on f.clientId = c.clientId "
                          + " where c.nume = @name And c.prenume = @prename ) ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("name", nume);
                command.Parameters.AddWithValue("prename", prenume);
                command.Parameters.AddWithValue("pr", pret);
                try
                {
                    connection.Open();
                    OK = true;
                    command.ExecuteNonQuery();



                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {

                    connection.Close();


                }

                return OK;
            }
        }


        public List<Factura> GetFacturiClient(string nume, string prenume)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<Factura>($"select * from Factura f ,Client c where  c.ClientId = f.ClientId and  c.nume = '{nume}' and c.prenume = '{prenume}'").ToList();
                return output;
            }
        }

        public bool UpdateGarantie(string nume, string prenume, int prelungire )
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {

                query = "update Garantie set  termen = DATEADD(YY, @p, termen) from Garantie  where GarantieID IN (  select GarantieID from Factura F inner join client c on f.clientId = c.clientId  where c.Nume = @name And c.Prenume = @prename  ) ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("name", nume);
                command.Parameters.AddWithValue("prename", prenume);
                command.Parameters.AddWithValue("p", prelungire);
                
                try
                {
                    connection.Open();
                    OK = true;
                    command.ExecuteNonQuery();



                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {

                    connection.Close();


                }

                return OK;
            }
        }

        public List<Client> DepasireGarantie()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<Client>($" select * from  Client c  inner join Factura f on c.ClientId = f.ClientId inner join garantie g on f.facturaId = g.facturaID where g.termen < CURRENT_TIMESTAMP").ToList();
                return output;
            }
        }


        public bool DeleteGarantie()
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {

                query = "delete garantie where termen < CURRENT_TIMESTAMP";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    OK = true;
                    command.ExecuteNonQuery();



                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {

                    connection.Close();


                }

                return OK;
            }
        }

      /*  private class ceva
        {
            int id; string nume;
        }*/
        public List<Dotare> GetDotari()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<Dotare>($"select * from Dotare").ToList();
                return output;
            }
        }

        public bool InsertAsociereDotare(int DotareID, int MasinaId)
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                query = " insert into AsociereDotare (DotareId, MasinaId) values('" + DotareID + "','" + MasinaId + "') ;";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    OK = true;
                    //  MessageBox.Show("Records Inserted Successfully");

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    connection.Close();


                }
                return OK;

            }
        }

        /* public bool UpdateFacturaDotari(string Denumire,int FactId)
         {
             bool OK = false;

             using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
             {


                 query = " update Factura set suma = suma + " 
                         + "(select d.pret from Dotare d inner join AsociereDotare ad on d.dotareid = ad.dotareId"
                           + "    where d.Denumire = @den  ) " +
                           " where FacturaId = @id) ";

                 SqlCommand command = new SqlCommand(query, connection);
                 command.Parameters.AddWithValue("den", Denumire);
                 command.Parameters.AddWithValue("id", FactId);

                 try
                 {
                     connection.Open();
                     OK = true;
                     command.ExecuteNonQuery();



                 }
                 catch (SqlException e)
                 {
                     Console.WriteLine("Error Generated. Details: " + e.ToString());
                 }
                 finally
                 {

                     connection.Close();


                 }

                 return OK;
             }
         }*/


        public List<int> GetPretDotari(string Denumire)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<int>($"select pret from Dotare where Denumire  = '{Denumire}'").ToList();
                return output;
            }
        }

        public bool DeleteAsociereDotare(string numeDot, int MasinaId)
        {
            bool OK = false;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                query = "delete AsociereDotare  where MasinaId = @mID AND dotareID in (select d.dotareID from dotare d inner join asociereDotare ad on d.dotareId = ad.dotareId where d.Denumire = @nd) ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nd", numeDot);
                command.Parameters.AddWithValue("mID", MasinaId);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    OK = true;
                    //  MessageBox.Show("Records Inserted Successfully");

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    connection.Close();


                }
                return OK;

            }
        }

    /*  public bool GetNumePrenume()
        {
            List<string> clienti = new List<string>();
         //   List <struct Pers> ceva = new List<struct Pers>() ;

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                query = "select  c.nume,c.prenume from client c inner join factura f on c.clientId = f.clientId ";

                SqlCommand command = new SqlCommand(query, connection);
              
                try
                {
                    connection.Open();
                    // SqlDataReader reader = command.ExecuteReader();
                    //  command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet client = new DataSet();
                    adapter.Fill(client, "client");
                    //  MessageBox.Show("Records Inserted Successfully");

                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error Generated. Details: " + e.ToString());
                }
                finally
                {
                    connection.Close();


                }
                return clienti;

            }
        }*/

       
    public List<DataAccessGetNP> GetNumePrenume()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<DataAccessGetNP>($"select  c.nume, c.prenume,m.model, f.data,f.suma from client c inner join factura f on c.clientId = f.clientId  inner join masina m on f.masinaID = m.masinaID").ToList();
                return output;
            }
        }

       /* public List<DataAccessGetNP> GetInformatii()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<DataAccessGetNP>($"select m.model from masina m inner join factura f on f.masinaID = m.masinaID").ToList();
                return output;
            }
        }*/

      
        public List<DataAccessGetNPNOGar> GetInfoNOGar()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<DataAccessGetNPNOGar>($"select c.nume, c.prenume from client c inner join factura f on c.clientId = f.clientID where facturaID not in (select facturaId from garantie )").ToList();
                return output;
            }
        }

        public List<DataAccessMModel> GetModelMasina(string nume, string prenume)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<DataAccessMModel>($"select m.model from masina m inner join factura f on f.masinaId = m.masinaId inner join client c on f.clientId = c.clientID where c.nume = '{nume}' and c.prenume = '{prenume}' order by f.data DESC").ToList();
                return output;
            }
        }


        public List<DataAccessGar> GetFacturaID(string nume, string prenume,string model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<DataAccessGar>($"  select f.FacturaID, f.data from factura f inner join client c on f.clientId = c.clientID inner join masina m on f.masinaId = m.masinaId where c.nume = '{nume}' and c.prenume = '{prenume}' and m.model = '{model}' order by f.data DESC").ToList();
                return output;
            }
        }

        public List<string> GetDotari(string nume, string prenume, string model, int factID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<string>($" select d.denumire from masina m inner join factura f on m.masinaID = f.masinaId inner join asociereDotare ad on m.masinaId = ad.masinaID inner join dotare d on ad.dotareID = d.dotareID inner join client c on c.clientid = f.clientID where c.nume = '{nume}' and c.prenume = '{prenume}' and m.model = '{model}' and f.facturaId = '{factID}' ").ToList();
               
                return output;
            }
        }

        public List<DataAccessGetTermneGar> GetTermenGarantie(string nume, string prenume, string model, int factID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<DataAccessGetTermneGar>($" select g.termen from masina m inner join factura f on m.masinaID = f.masinaId  inner join client c on c.clientid = f.clientID inner join garantie g on g.facturaId = f.facturaId where c.nume = '{nume}' and c.prenume = '{prenume}' and m.model = '{model}' and f.facturaId = '{factID}' ").ToList();

                return output;
            }
        }

        public List<DataAccessTopUser> GetTopUser()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<DataAccessTopUser>($" select Top 1 v.NrMasini,v.NumeUtilizator from(select count(f.masinaId) as NrMasini, u.Nume + ' ' + u.Prenume as NumeUtilizator from factura f inner join utilizator u on f.utilizatorId = u.utilizatorId group by u.Nume, u.Prenume) as v Order by V.NrMAsini DESC ").ToList();

                return output;
            }
        }


        public List<DataAccessTopCar> GetTopCar()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<DataAccessTopCar>($" select top 1  v.Exemplare , v.Denumire from (select count(f.masinaId) as Exemplare, m.model as Denumire from factura f inner join masina m on f.masinaId = m.masinaId group by m.model) as v order by v.Exemplare Desc ").ToList();

                return output;
            }
        }

        public List<DataAccessTopDotareTopCar> GetTopCarTopDotare(string model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Linker.LinkerVal("SampleDB")))
            {
                var output = connection.Query<DataAccessTopDotareTopCar>($"  select top 1 v.cantitate,v.denumire, v.incasari from (select count(ad.DotareID) as Cantitate, d.Denumire as Denumire, sum(d.pret) as Incasari  from AsociereDotare ad inner join dotare d on ad.dotareId = d.dotareId inner join masina m on m.masinaId = ad.masinaId inner join factura f on m.masinaID = f.masinaId where f.Data > DATEADD(year, -1, GETDATE()) and m.model = '{model}'   group by d.Denumire) as v order by v.cantitate desc ").ToList();

                return output;
            }
        }





    }
}
