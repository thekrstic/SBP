//CREATE TABLE BROJ_TELEFONA(
// ID_VLASNIKA INT,
// BROJ VARCHAR(255),
// PRIMARY KEY(ID_VLASNIKA, BROJ),
// FOREIGN KEY(ID_VLASNIKA) REFERENCES VLASNIK(ID)
//);


namespace StanNaDan.Entiteti;

public class BrojTelefona
{

    public virtual int ID { get; set; }
    public virtual Vlasnik Vlasnik { get; set; }

    public virtual string Broj { get; set; }


}