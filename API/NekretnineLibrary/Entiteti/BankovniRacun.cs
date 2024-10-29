//CREATE TABLE BANKOVNI_RACUN (
// BROJ_RACUNA VARCHAR(255),
// IME_BANKE VARCHAR(255),
// ID_VLASNIKA INT,
// PRIMARY KEY (BROJ_RACUNA, IME_BANKE, ID_VLASNIKA),
// FOREIGN KEY(ID_VLASNIKA) REFERENCES VLASNIK(ID)
//);

namespace StanNaDan.Entiteti;

public class BankovniRacun
{
    public virtual int ID { get; set; }
    public virtual int BrojRacuna { get; set; }

    public virtual string ImeBanke { get; set; }

    //strani kljuc
    public virtual Vlasnik Vlasnik { get; set; }

    //primari key kompozitni


}