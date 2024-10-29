using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan.Mapiranja;

//CREATE TABLE BROJ_TELEFONA(
// ID_VLASNIKA INT,
// BROJ VARCHAR(255),
// PRIMARY KEY(ID_VLASNIKA, BROJ),
// FOREIGN KEY(ID_VLASNIKA) REFERENCES VLASNIK(ID)
//);

public class BrojTelefonaMapiranja : ClassMap<StanNaDan.Entiteti.BrojTelefona>
{

    public BrojTelefonaMapiranja()
    {
        Table("BROJ_TELEFONA");

        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Broj).Column("BROJ");

        References(x => x.Vlasnik).Column("ID_VLASNIKA").LazyLoad();
    }
}
