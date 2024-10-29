using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan.Mapiranja;

//CREATE TABLE EMAIL(
// ID_VLASNIKA INT,
// EMAIL VARCHAR(255),
// PRIMARY KEY(ID_VLASNIKA, EMAIL),
// FOREIGN KEY(ID_VLASNIKA) REFERENCES VLASNIK(ID)
//);

public class EmailMapiranja : ClassMap<StanNaDan.Entiteti.Email>
{
    public EmailMapiranja()
    {
        Table("EMAIL");

        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

        Map(x => x.EMAIL, "EMAIL");

        References(x => x.Vlasnik).Column("ID_VLASNIKA").LazyLoad();


    }
}
