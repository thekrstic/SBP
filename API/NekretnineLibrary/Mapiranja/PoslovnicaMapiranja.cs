using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;

namespace StanNaDan.Mapiranja;

public class PoslovnicaMapiranja : ClassMap<StanNaDan.Entiteti.Poslovnica>
{
    public PoslovnicaMapiranja()
    {

        Table("POSLOVNICA");

        //da li ovako ide za svaki id ?

        Id(x => x.Adresa).Column("ADRESA").GeneratedBy.Assigned();

        Map(x => x.RadnoVreme, "RADNO_VREME");

        HasMany(x => x.Kvartovi).KeyColumn("ADRESA").LazyLoad().Cascade.All().Inverse();

        HasMany(x => x.Zaposleni).KeyColumn("ADRESA").LazyLoad().Cascade.All().Inverse();


        //   CREATE TABLE POSLOVNICA(
        //ADRESA VARCHAR(255) PRIMARY KEY,
        //RADNO_VREME VARCHAR(100)

    }

}
