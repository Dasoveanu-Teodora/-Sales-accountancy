using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaVanzariAuto
{
    class AsociereDotare
    {
        int DotareID;
        int MasinaId;

        public int GetDotareId()
        {
            return DotareID;
        }

        public int GetMasinaId()
        {
            return MasinaId;
        }

        public void SetDotareId(int dot)
        {
            DotareID = dot;
        }

        public void SetMasinaId(int mas)
        {
            MasinaId = mas;
        }
    }
}
