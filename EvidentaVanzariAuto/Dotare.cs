using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaVanzariAuto
{
   public  class Dotare
    {

        int DotareId;
        string Denumire;
        string Descriere;
        String Localizare;
        int pret;

        public int GetDotareId()
        {
            return DotareId;
        }
        public string GetDenumire()
        {
            return Denumire;
        }
        public int GetPret()
        {
            return pret;
        }
        public string GetDescriere()
        {
            return Descriere;
        }
        public string GetLocalizare()
        {
            return Localizare;
        }
       

        public void SetPret(int pret)
        {
            this.pret = pret;
        }

        public void SetDotareId(int DotareId)
        {
            this.DotareId = DotareId;
        }

        public void Set(string Localizare)
        {
            this.Localizare=Localizare;
        }

        public void SetDenumire(string den)
        {
            Denumire = den;
        }

        public void SetDescriere(string des)
        {
            Descriere = des;
        }

    }
}
