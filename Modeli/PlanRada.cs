using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NISsoftver.Modeli
{
    public class PlanRada
    {
        public DateOnly datum { get; set; }
        public List<string> aktivnost { get; set; }

        public PlanRada()
        {

        }
        public PlanRada(DateOnly datum, List<string> aktivnost)
        {
            this.datum = datum;
            this.aktivnost = aktivnost;
        }
    }
}

