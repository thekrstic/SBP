//CREATE TABLE DODATNA_OPREMA (
// ID_OPREME INT,
// TIP VARCHAR(255),
// CENA DECIMAL(10,2),
// ID_NEKRETNINE INT,
// CONSTRAINT PK_DODATNA_OPREMA PRIMARY KEY (ID_OPREME, ID_NEKRETNINE),
// CONSTRAINT FK_NEKRETNINA FOREIGN KEY (ID_NEKRETNINE) REFERENCES
//NEKRETNINA(ID)
//);

namespace StanNaDan.Entiteti;

public class DodatnaOprema
{
    public virtual int ID { get; set; }
    public virtual string Tip { get; set; }

    public virtual decimal Cena { get; set; }

    //public idnekretnine

    public virtual Nekretnina? Nekretnina { get; set; }












}