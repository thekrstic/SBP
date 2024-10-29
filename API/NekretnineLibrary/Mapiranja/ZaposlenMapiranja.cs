using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan.Mapiranja;

public class ZaposlenMapiranja : ClassMap<StanNaDan.Entiteti.Zaposlen>
{

    public ZaposlenMapiranja()
    {
        Table("ZAPOSLEN");

        Id(x => x.JMBG).Column("JMBG").GeneratedBy.Assigned();

        Map(x => x.Ime, "IME");
        Map(x => x.DatumZaposlenja, "DATUM_ZAPOSLENJA");

        References(x => x.Poslovnica).Column("ADRESA_POSLOVNICE").LazyLoad();

        //strani kljuc ka poslovnici

        //    CREATE TABLE ZAPOSLEN(
        // IME VARCHAR(255),
        // JMBG VARCHAR(13) PRIMARY KEY,
        // ADRESA_POSLOVNICE VARCHAR(255),
        // DATUM_ZAPOSLENJA DATE,
        // FOREIGN KEY(ADRESA_POSLOVNICE) REFERENCES POSLOVNICA(ADRESA)
        //);
    }
}
