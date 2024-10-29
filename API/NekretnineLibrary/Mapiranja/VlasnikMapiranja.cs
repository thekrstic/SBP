using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;




namespace StanNaDan.Mapiranja
{

    class VlasnikMapiranja : ClassMap<Vlasnik>
    {
        public VlasnikMapiranja()
        {
            Table("VLASNIK");

            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            DiscriminateSubClassesOnColumn("TIP_VLASNIKA");

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Mesto, "MESTO");
            Map(x => x.Drzava, "DRZAVA");


            HasMany(x => x.BankovniRacuni).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.BrojeviTelefona).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Emailovi).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Nekretnine).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();



        }
    }
    class FizickoLiceMapiranja : SubclassMap<FizickoLice>
    {

        public FizickoLiceMapiranja()
        {
            DiscriminatorValue("FIZICKO_LICE");

            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.JMBG, "JMBG");
            Map(x => x.ImeRoditelja, "IME_RODITELJA");
        }


    }

    class PravnoLiceMapiranja : SubclassMap<PravnoLice>

    {
        public PravnoLiceMapiranja()
        {
            DiscriminatorValue("PRAVNO_LICE");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.PIB, "PIB");

        }


    }
}














