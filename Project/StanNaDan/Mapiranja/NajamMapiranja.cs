using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan.Mapiranja;

public class NajamMapiranja : ClassMap<StanNaDan.Entiteti.Najam>
{

    public NajamMapiranja()
    {
        Table("NAJAM");


        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

        Map(x => x.DatumDo, "DATUM_DO");
        Map(x => x.DatumOd, "DATUM_OD");
        Map(x => x.BrojDana, "BROJ_DANA");
        Map(x => x.CenaPoDanu, "CENA_PO_DANU");
        Map(x => x.Popust, "POPUST");
        Map(x => x.Provizija, "PROVIZIJA");

        HasMany(x => x.ListaNajmova).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();

        References(x => x.Agent).Column("JMBG_AGENTA").LazyLoad();

    }
    // CREATE TABLE NAJAM(
    // ID INT PRIMARY KEY,
    // DATUM_DO DATE,
    // DATUM_OD DATE,
    // BROJ_DANA INT,
    // CENA_PO_DANU DECIMAL(10,2),
    // POPUST DECIMAL(5,2),
    // PROVIZIJA DECIMAL(10,2),
    // JMBG_AGENTA VARCHAR(13),
    // FOREIGN KEY(JMBG_AGENTA) REFERENCES AGENT(JMBG)
    //);
}
