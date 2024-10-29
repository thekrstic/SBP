using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan.Mapiranja;

//CREATE TABLE DODATNA_OPREMA(
// ID_OPREME INT,
// TIP VARCHAR(255),
// CENA DECIMAL(10,2),
// ID_NEKRETNINE INT,
// CONSTRAINT PK_DODATNA_OPREMA PRIMARY KEY(ID_OPREME, ID_NEKRETNINE),
// CONSTRAINT FK_NEKRETNINA FOREIGN KEY(ID_NEKRETNINE) REFERENCES
//NEKRETNINA(ID)
//);

public class DodatnaOpremaMapiranja : ClassMap<StanNaDan.Entiteti.DodatnaOprema>
{
    public DodatnaOpremaMapiranja()
    {
        Table("DODATNA_OPREMA");

        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Tip, "TIP");
        Map(x => x.Cena, "CENA");
        //strani kljucevi
        // CONSTRAINT PK_DODATNA_OPREMA PRIMARY KEY(ID_OPREME, ID_NEKRETNINE), //Mislim da ovo nema potrebe samo komplikujemo


        References(x => x.Nekretnina).Column("ID_NEKRETNINE").Not.Nullable();

    }
}
