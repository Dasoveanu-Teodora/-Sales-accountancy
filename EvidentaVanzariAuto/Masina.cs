using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaVanzariAuto
{
    public class Masina
    {
        int masinaID;
        int categorieID;
        string model;
        string consum;
        string numar;
        int pret;

        public int GetMasinaId()
        {
            return masinaID;
        }

        public int GetCategorieId()
        {
            return categorieID;
        }

        public int GetPret()
        {
            return pret;
        }
        public string GetModel()
        {
            return model;
        }

        public string GetNumar()
        {
            return numar;
        }

        public string GetConsum()
        {
            return consum;
        }

        public void SetModel(string mod)
        {
            model = mod;
        }

        public void SetConsum(string con)
        {
           consum = con;
        }


        public void SetNumar(string nr)
        {
            numar = nr;
        }


        public void SetMasinaId(int nr)
        {
            masinaID = nr;
        }

        public void SetCategorieId(int nr)
        {
           categorieID = nr;
        }


        public void SetPret(int nr)
        {
            pret = nr;
        }


    }
}
