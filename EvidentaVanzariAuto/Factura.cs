using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaVanzariAuto
{
   public  class Factura
    {
        int FacturaId;
        int ClientId;
        int MasinaId;
        int UtilizatorId;
        int suma;
        DateTimeOffset data;

        public void SetFacturaID(int fac)
        {
            FacturaId = fac;
        }
        public void SetUtilizatorID(int ut)
        {
            UtilizatorId = ut;
        }
        public void SetClientId(int cl)
        {
            ClientId = cl;
        }
        public void SetMasinaId(int mas)
        {
            MasinaId = mas;
        }
        public void SetSuma(int sum)
        {
            suma = sum;
        }

     

        public int GetClientID()
        {
            return ClientId;
        }
        public int GetUtilizatorID()
        {
            return UtilizatorId;
        }
        public int GetFacturaID()
        {
            return FacturaId;
        }

        public int GetMasinaID()
        {
            return MasinaId;
        }

        public int GetSuma()
        {
            return suma;
        }

        public DateTimeOffset GetData()
        {
            return data;
        }

        public void SetData(DateTimeOffset dt )
        {
            this.data = dt;
        }
    }
}
