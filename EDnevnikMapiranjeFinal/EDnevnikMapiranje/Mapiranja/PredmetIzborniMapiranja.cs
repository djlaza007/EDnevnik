﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.Mapiranja
{
    class PredmetIzborniMapiranja:SubclassMap<PredmetIzborni>
    {
        public PredmetIzborniMapiranja()
        {
            DiscriminatorValue("Izborni");
        }
    }
}
