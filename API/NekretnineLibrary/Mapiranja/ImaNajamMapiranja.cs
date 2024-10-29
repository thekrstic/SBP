using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;




namespace StanNaDan.Mapiranja;


public class ImaNajamMapiranja : ClassMap<StanNaDan.Entiteti.ImaNajam>
{
    public ImaNajamMapiranja()
    {
        Table("IMA_NAJAM");

        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();


        References(x => x.Najam).Column("ID_NAJMA");


        References(x => x.Nekretnina).Column("ID_NEKRETNINE").LazyLoad();


    }
}
