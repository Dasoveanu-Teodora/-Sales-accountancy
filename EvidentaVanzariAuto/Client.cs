using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaVanzariAuto
{
   public class Client
    {  
        int clientId;
        string nume;
        string prenume;
        string CNP;
        string Email;
        string Domiciliu;
      public int GetClientId()
        {
            return clientId;
        }
      public  void SetClientId(int clientID)
        {
            clientId = clientID;
        }
     public   string GetNume()
        {
            return nume;
        }
      public  void SetNume(string clientNume)
        {
            nume = clientNume;
        }

     public   string GetPrenume()
        {
            return prenume;
        }
     public   void SetPrenume(string clientPrenume)
        {
            prenume = clientPrenume;
        }

      public  string GetCNP()
        {
            return CNP;
        }
      public  void SetCNP(string cenepe)
        {
            CNP = cenepe;
        }
       public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string mail)
        {
           Email = mail;
        }

      public  string GetDomiciliu()
        {
            return Domiciliu;
        }
      public  void SetDomiciliu(string domi)
        {
            Domiciliu = domi;
        }

    }
    
}
