//CREATE TABLE PARKING (
// ID_PARKINGA INT,
// CENA DECIMAL(10,2),
// JAVNI NUMBER(1) CHECK(JAVNI IN(0, 1)),
// ID_NEKRETNINE INT,
// CONSTRAINT PK_PARKING PRIMARY KEY (ID_PARKINGA, ID_NEKRETNINE),
// CONSTRAINT FK_NEKRETNINA_PARKING FOREIGN KEY (ID_NEKRETNINE) 
//REFERENCES NEKRETNINA(ID)
//);

namespace StanNaDan.Entiteti;

public class Parking
{
    public virtual int ID { get; set; }

    public virtual decimal Cena { get; set; }

    public virtual string Javni { get; set; }

    //nekretnina id

    public virtual Nekretnina Nekretnina { get; set; }








}