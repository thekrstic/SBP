//CREATE TABLE ANGAZUJE (
// ID_SPOLJNOG_RADNIKA INT,
// JMBG_AGENTA VARCHAR(13),
// PRIMARY KEY(ID_SPOLJNOG_RADNIKA, JMBG_AGENTA),
// FOREIGN KEY(ID_SPOLJNOG_RADNIKA) REFERENCES SPOLJNI_RADNIK(ID),
// FOREIGN KEY(JMBG_AGENTA) REFERENCES AGENT(JMBG)
//);

namespace StanNaDan.Entiteti;
//ovako zbog n prema n veze dodajemo novu klasu samo za id mora da se menja i u bazi ovo?
public class Angazuje
{
    //id spoljnog radnika
    public virtual AngazujeID Id { get; set; }

    public Angazuje()
    {
        Id = new AngazujeID();
    }




}