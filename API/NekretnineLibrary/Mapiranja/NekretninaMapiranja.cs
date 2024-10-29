using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;

#region CreateTable
//mapiranje svojstava
//Map(x => x.Tip, "TIP");
//CREATE TABLE NEKRETNINA (
// ID INT PRIMARY KEY,
// TIP_NEKRETNINE VARCHAR(255),
// KUCNI_BROJ INT,
// IME_ULICE VARCHAR(255),
// KVADRATURA DECIMAL(10,2),
// BROJ_KUPATILA INT,
// BROJ_TERASA INT,
// BROJ_SOBA INT,
// INTERNET NUMBER(1) CHECK(INTERNET IN(0, 1)),
// TV NUMBER(1) CHECK(TV IN(0, 1)),
// KUHINJA NUMBER(1) CHECK(KUHINJA IN(0, 1)),
// DIMENZIJE VARCHAR(255),
// TIP_KREVETA VARCHAR(255),
// SPRATNOST INT,
// DVORISTE NUMBER(1) CHECK(DVORISTE IN(0, 1)),
// SPRAT INT,
// LIFT NUMBER(1) CHECK(LIFT IN(0, 1)),
// OBJEKAT VARCHAR(255),
// ID_VLASNIKA INT,
// NAZIV_KVARTA VARCHAR(255),
// FOREIGN KEY(ID_VLASNIKA) REFERENCES VLASNIK(ID),
// FOREIGN KEY(NAZIV_KVARTA) REFERENCES KVART(NAZIV)

#endregion

namespace StanNaDan.Mapiranja
{
    class NekretninaMapiranja : ClassMap<Nekretnina>
    {
        public NekretninaMapiranja()
        {

            //Mapiranje tabele
            Table("NEKRETNINA");

            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("TIP_NEKRETNINE");

            //mapiranje primarnog kljuca
            // Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity().UnsavedValue(-1);
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.KucniBroj, "KUCNI_BROJ");
            Map(x => x.ImeUlice, "IME_ULICE");
            Map(x => x.Kvadratura, "KVADRATURA");
            Map(x => x.BrojKupatila, "BROJ_KUPATILA");
            Map(x => x.BrojTerasa, "BROJ_TERASA");
            Map(x => x.BrojSoba, "BROJ_SOBA");
            Map(x => x.Internet, "INTERNET");
            Map(x => x.TV, "TV");
            Map(x => x.Kuhinja, "KUHINJA");
            Map(x => x.Dimenzije, "DIMENZIJE");
            Map(x => x.TipKreveta, "TIP_KREVETA");


            References(x => x.Vlasnik).Column("ID_VLASNIKA").LazyLoad();
            //HasMany(x => x.DodatnaOprema).KeyColumn("ID_OPREME").LazyLoad().Cascade.All().Inverse();
            //HasMany(x => x.Parkinzi).KeyColumn("ID_PARKINGA").LazyLoad().Cascade.All().Inverse();
            //HasMany(x => x.ListaNajmova).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();
            //HasMany(x => x.Sajtovi).KeyColumn("ID").LazyLoad().Cascade.All().Inverse();



            //mapiranje veze 1:N Prodavnica-Odeljenje


            References(x => x.Kvart).Column("NAZIV_KVARTA").LazyLoad();


        }
    }

    class SobaMapiranja : SubclassMap<Soba>
    {
        public SobaMapiranja()
        {
            DiscriminatorValue("SOBA");
            Map(x => x.Objekat, "OBJEKAT"); //dodati
        }
    }

    class StanMapiranja : SubclassMap<Stan>
    {
        public StanMapiranja()
        {
            DiscriminatorValue("STAN");
            Map(x => x.Sprat, "SPRAT");
            Map(x => x.Lift, "LIFT");
        }
    }

    class KucaMapiranja : SubclassMap<Kuca>
    {
        public KucaMapiranja()
        {
            DiscriminatorValue("KUCA");
            Map(x => x.Spratnost, "SPRATNOST");
            Map(x => x.Dvoriste, "DVORISTE");
        }
    }
}
