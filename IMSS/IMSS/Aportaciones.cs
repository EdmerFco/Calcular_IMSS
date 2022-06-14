using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    public struct Aportaciones
    {
        public Aportaciones( decimal EnfermedadMaternidad, decimal InvalidezVida, decimal Retiro, decimal Cesantia, decimal Infonavit)
        {
            EnFer = EnfermedadMaternidad;
            Inc = InvalidezVida;
            Ret = Retiro;
            Ces = Cesantia;
            InF = Infonavit;

        }
        public decimal EnFer{ get; set; }
        public decimal Inc{ get; set; }
        public decimal Ret{ get; set; }
        public decimal Ces{ get; set; }
        public decimal InF{ get; set; }

    }
}
