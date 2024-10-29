using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;


namespace StanNaDan;

public class SpoljniRadnikMapiranja : ClassMap<StanNaDan.Entiteti.SpoljniRadnik>
{
    public SpoljniRadnikMapiranja()
    {
        Table("SPOLJNI_RADNIK");


        Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

        Map(x => x.BrojTelefona, "BROJ_TELEFONA");
        Map(x => x.Ime, "IME");
        Map(x => x.DatumAngazovanja, "DATUM_ANGAZOVANJA");
        Map(x => x.Procenat, "PROCENAT");


        HasMany(x => x.Angazovanja).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
 




 
    }
}
