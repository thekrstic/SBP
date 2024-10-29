//CREATE TABLE SPOLJNI_RADNIK (
// ID INT PRIMARY KEY,
// BROJ_TELEFONA VARCHAR(20),
// IME VARCHAR(255),
// DATUM_ANGAZOVANJA DATE,
// PROCENAT DECIMAL(5,2)
//);

namespace StanNaDan.Entiteti;

public class SpoljniRadnik { 
    public virtual int Id { get; set; } 

    public virtual string BrojTelefona { get; set; }

    public virtual string Ime { get; set; }

    public virtual DateTime DatumAngazovanja { get; set; }

    public virtual float Procenat { get; set; }

    public virtual IList<Angazuje> Angazovanja { get; set; }


    public SpoljniRadnik()
    {
        Angazovanja = new List<Angazuje>();

       
    }




}
