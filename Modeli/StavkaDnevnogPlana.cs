﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NISsoftver.Modeli
{
    public class StavkaDnevnogPlana
    {
        public DateOnly datum;
        public TimeOnly vreme;
        public string stavka;

        public StavkaDnevnogPlana() {}
        public StavkaDnevnogPlana(DateOnly d, TimeOnly t, string s)
        {
            datum = d;
            vreme = t;
            stavka = s;
        }
    }
}
