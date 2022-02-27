using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaVanzariAuto
{
   public class Garantie
    {
        int GarantieID;
        int FacturaID;
        DateTimeOffset termen;
        int pret;



        public void SetGarantieID(int gr)
        {
            GarantieID = gr;
        }
        public void GetFacturaIDint (int fid)
        {
            FacturaID = fid;
        }
        public void GetTermen(DateTimeOffset tm)
        {
             termen = tm;
        }

        public void SetPret(int pr)
        {
            pret = pr;
        }
        public int GetGarantieID()
        {
            return GarantieID;
        }
        public int GetFacturaID()
        {
            return FacturaID;
        }
        public DateTimeOffset GetTermen()
        {
            return termen;
        }
        
        public int GetPret()
        {
            return pret;
        }
    }
}
