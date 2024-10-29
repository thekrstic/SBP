using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan;

public class BankovniRacunMapiranja : ClassMap<StanNaDan.Entiteti.BankovniRacun>
{

    public BankovniRacunMapiranja()
    {
        Table("BANKOVNI_RACUN");

        // kompozitni kljuc
        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

        Map(x => x.BrojRacuna, "BROJ_RACUNA");

        Map(x => x.ImeBanke, "IME_BANKE");



        References(x => x.Vlasnik).Column("ID_VLASNIKA");




        //    CREATE TABLE BANKOVNI_RACUN(
        // BROJ_RACUNA VARCHAR(255),
        // IME_BANKE VARCHAR(255),
        // ID_VLASNIKA INT,
        // PRIMARY KEY(BROJ_RACUNA, IME_BANKE, ID_VLASNIKA),    
        // FOREIGN KEY(ID_VLASNIKA) REFERENCES VLASNIK(ID)
        //);
    }
}
