//CREATE TABLE SAJTOVI (
// ID_NEKRETNINA INT,
// SAJTOVI VARCHAR(255),
// PRIMARY KEY(ID_NEKRETNINA, SAJTOVI),
// FOREIGN KEY(ID_NEKRETNINE) REFERENCES NEKRETNINA(ID)
//);

namespace StanNaDan.Entiteti;

public class Sajtovi
{

    public virtual int ID { get; set; }
    public virtual Nekretnina Nekretnina { get; set; }

    public virtual string Sajt { get; set; }


}