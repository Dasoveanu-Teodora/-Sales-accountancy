using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaVanzariAuto
{
    public class Utilizator
    {
        public int UtilizatorID { get; set; }
        public string EmailAddress { get; set; }
        public string getEmailAddress()
        {
            return EmailAddress;
        }
        public string Parola { get; set; }
        public bool Logat { get; set; }
       
        public void setLogat(bool log)
        {
            Logat = log;
        }

        public bool getLogat()
        {
           return Logat ;
        }

        public string Nume { get; set; }
        public string Prenume { get; set; }

        public Utilizator()
        {
            UtilizatorID = 0;
            Logat = false;

        }
    }
}
