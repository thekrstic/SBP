//CREATE TABLE EMAIL (
// ID_VLASNIKA INT,
// EMAIL VARCHAR(255),
// PRIMARY KEY(ID_VLASNIKA, EMAIL),
// FOREIGN KEY(ID_VLASNIKA) REFERENCES VLASNIK(ID)
//);

namespace StanNaDan.Entiteti;

public class Email
{

    public virtual int ID { get; set; }

    public virtual string EMAIL { get; set; }

    //public idnekretnine

    public virtual Vlasnik Vlasnik { get; set; }












}