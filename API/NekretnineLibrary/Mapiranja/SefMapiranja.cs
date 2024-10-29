using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan.Mapiranja;
//CREATE TABLE SEF(
// DATUM_POSTAVLJANJA DATE,
// JMBG VARCHAR(13),
// PRIMARY KEY(JMBG),
// FOREIGN KEY(JMBG) REFERENCES ZAPOSLEN(JMBG)
//);

public class SefMapiranja : SubclassMap<StanNaDan.Entiteti.Sef>
{
    public SefMapiranja()
    {
        Table("SEF");

        KeyColumn("JMBG");

        Map(x => x.DatumPostavljanja, "DATUM_POSTAVLJANJA");





    }
}