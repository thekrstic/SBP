//CREATE TABLE IMA_NAJAM (
// ID_NAJMA INT,
// ID_NEKRETNINE INT,
// PRIMARY KEY (ID_NAJMA, ID_NEKRETNINE),
// FOREIGN KEY(ID_NAJMA) REFERENCES NAJAM(ID),
// FOREIGN KEY(ID_NEKRETNINE) REFERENCES NEKRETNINA(ID)
//);

namespace StanNaDan.Entiteti;

public class ImaNajam
{

    public virtual int ID { get; set; }

    public virtual Najam Najam { get; set; }
    public virtual Nekretnina Nekretnina { get; set; }






}