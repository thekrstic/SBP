//CREATE TABLE POSLOVNICA (
// ADRESA VARCHAR(255) PRIMARY KEY,
// RADNO_VREME VARCHAR(100)
//);

namespace StanNaDan.Entiteti;

public class Poslovnica
{
    public virtual string Adresa { get; set; }

    public virtual string RadnoVreme { get; set; }

    public virtual IList<Kvart> Kvartovi { get; set; }

    public virtual IList<Zaposlen> Zaposleni { get; set; }

    public Poslovnica()
    {
        Kvartovi = new List<Kvart>();

        Zaposleni = new List<Zaposlen>();


    }


}