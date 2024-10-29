//CREATE TABLE KVART (
// NAZIV VARCHAR(255) PRIMARY KEY,
// ZONA VARCHAR(50),
// ADRESA_POSLOVNICE VARCHAR(255),
// FOREIGN KEY(ADRESA_POSLOVNICE) REFERENCES POSLOVNICA(ADRESA)
//);


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StanNaDan.Entiteti;

public class Kvart
{

    public virtual string Naziv { get; set; }
    public virtual string Zona { get; set; }

    //public virtual string AdresaPoslovnice { get; set; }

    //strani kljucevi prema POSLOVNICI

    public virtual Poslovnica Poslovnica { get; set; }


    public virtual IList<Nekretnina> Nekretnine { get; set; }

    public Kvart()
    {
        Nekretnine = new List<Nekretnina>();

    }










}

