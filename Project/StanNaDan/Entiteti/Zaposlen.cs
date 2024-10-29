//CREATE TABLE ZAPOSLEN (
// IME VARCHAR(255),
// JMBG VARCHAR(13) PRIMARY KEY,
// ADRESA_POSLOVNICE VARCHAR(255),
// DATUM_ZAPOSLENJA DATE,
// FOREIGN KEY (ADRESA_POSLOVNICE) REFERENCES POSLOVNICA(ADRESA)
//);

namespace StanNaDan.Entiteti;

public class Zaposlen
{
    public virtual string Ime { get; set; }

    public virtual string JMBG { get; set; }


    public virtual Poslovnica Poslovnica { get; set; }

    public virtual DateTime DatumZaposlenja { get; set; }

}