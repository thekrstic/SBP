using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan.Mapiranja;

//CREATE TABLE SAJTOVI(
// ID_NEKRETNINA INT,
// SAJTOVI VARCHAR(255),
// PRIMARY KEY(ID_NEKRETNINA, SAJTOVI),
// FOREIGN KEY(ID_NEKRETNINE) REFERENCES NEKRETNINA(ID)
//);

public class SajtoviMapiranja : ClassMap<StanNaDan.Entiteti.Sajtovi>
{
    public SajtoviMapiranja()
    {
        Table("SAJTOVI");

        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();


        Map(x => x.Sajt, "SAJTOVI");

        References(x => x.Nekretnina).Column("ID_NEKRETNINA").Not.Nullable();

    }
}