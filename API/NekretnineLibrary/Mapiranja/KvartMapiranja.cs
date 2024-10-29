using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan.Mapiranja;

public class KvartMapiranja : ClassMap<StanNaDan.Entiteti.Kvart>
{
    public KvartMapiranja()
    {
        Table("KVART");

        Id(x => x.Naziv).Column("NAZIV").GeneratedBy.Assigned();

        Map(x => x.Zona, "ZONA");

        //strani kljuc 1 to n
        References(x => x.Poslovnica).Column("ADRESA_POSLOVNICE").LazyLoad();


        HasMany(x => x.Nekretnine).KeyColumn("NAZIV").LazyLoad().Cascade.All().Inverse();









    }
    //        CREATE TABLE KVART(
    // NAZIV VARCHAR(255) PRIMARY KEY,
    // ZONA VARCHAR(50),
    // ADRESA_POSLOVNICE VARCHAR(255),
    // FOREIGN KEY(ADRESA_POSLOVNICE) REFERENCES POSLOVNICA(ADRESA)
    //);

}
