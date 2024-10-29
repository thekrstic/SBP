using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan.Mapiranja;
//CREATE TABLE ANGAZUJE(
// ID_SPOLJNOG_RADNIKA INT,
// JMBG_AGENTA VARCHAR(13),
// PRIMARY KEY(ID_SPOLJNOG_RADNIKA, JMBG_AGENTA),
// FOREIGN KEY(ID_SPOLJNOG_RADNIKA) REFERENCES SPOLJNI_RADNIK(ID),
// FOREIGN KEY(JMBG_AGENTA) REFERENCES AGENT(JMBG)
//);

public class AngazujeMapiranja : ClassMap<StanNaDan.Entiteti.Angazuje>
{
    public AngazujeMapiranja()
    {
        Table("ANGAZUJE");

        CompositeId(x => x.Id)
                 .KeyReference(x => x.SpoljniRadnik, "ID_SPOLJNOG_RADNIKA")
                 .KeyReference(x => x.Agent, "JMBG_AGENTA");


    }
}
