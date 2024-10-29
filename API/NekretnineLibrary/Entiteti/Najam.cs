//CREATE TABLE NAJAM (
// ID INT PRIMARY KEY,
// DATUM_DO DATE,
// DATUM_OD DATE,
// BROJ_DANA INT,
// CENA_PO_DANU DECIMAL(10,2),
// POPUST DECIMAL(5,2),
// PROVIZIJA DECIMAL(10,2),
// JMBG_AGENTA VARCHAR(13),
// FOREIGN KEY(JMBG_AGENTA) REFERENCES AGENT(JMBG)
//);

namespace StanNaDan.Entiteti;

public class Najam
{
    public virtual int ID { get; set; }

    public virtual DateTime DatumOd { get; set; }

    public virtual DateTime DatumDo { get; set; }

    public virtual decimal CenaPoDanu { get; set; }

    public virtual int BrojDana { get; set; }

    public virtual decimal Popust { get; set; }

    //public virtual string JmbgAgenta { get; set; }

    public virtual Agent Agent { get; set; }
    public virtual decimal Provizija { get; set; }

    public virtual IList<ImaNajam> ListaNajmova { get; set; } //malo nelogicno

    public Najam()
    {
        ListaNajmova = new List<ImaNajam>();
    }
}