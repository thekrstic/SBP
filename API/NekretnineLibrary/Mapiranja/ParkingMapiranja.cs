using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;

namespace StanNaDan.Mapiranja;
//CREATE TABLE PARKING(
// ID_PARKINGA INT,
// CENA DECIMAL(10,2),
// JAVNI NUMBER(1) CHECK(JAVNI IN (0,1)),
// ID_NEKRETNINE INT,
// CONSTRAINT PK_PARKING PRIMARY KEY(ID_PARKINGA, ID_NEKRETNINE),
// CONSTRAINT FK_NEKRETNINA_PARKING FOREIGN KEY(ID_NEKRETNINE)
//REFERENCES NEKRETNINA(ID)
//);
public class ParkingMapiranja : ClassMap<StanNaDan.Entiteti.Parking>
{
    public ParkingMapiranja()
    {
        Table("PARKING");

        Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

        Map(x => x.Cena, "CENA");
        Map(x => x.Javni, "JAVNI");


        // CONSTRAINT PK_PARKING PRIMARY KEY(ID_PARKINGA, ID_NEKRETNINE),
        References(x => x.Nekretnina).Column("ID_NEKRETNINE").Not.Nullable(); //to resava problem da parking ne postoji samostalno nego mora s nekom nekretninom da se ppveze

    }




}
