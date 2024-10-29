//CREATE TABLE VLASNIK (
// ID INT PRIMARY KEY,
// IME VARCHAR(255),
// PREZIME VARCHAR(255),
// ADRESA VARCHAR(255),
// MESTO VARCHAR(255),
// DRZAVA VARCHAR(255),
// DATUM_RODJENJA DATE,
// JMBG VARCHAR(13) UNIQUE,
// IME_RODITELJA VARCHAR(255),
// NAZIV VARCHAR(255),
// PIB VARCHAR(20) UNIQUE
//);

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StanNaDan.Entiteti;

public class Vlasnik
{
    public virtual int Id { get; set; }
    public virtual string TipVlasnika { get; set; }
    public virtual string Ime { get; set; }
    public virtual string Prezime { get; set; }

    public virtual string Adresa { get; set; }

    public virtual string Mesto { get; set; }

    public virtual string Drzava { get; set; }



    public virtual IList<BankovniRacun>? BankovniRacuni { get; set; }

    public virtual IList<BrojTelefona>? BrojeviTelefona { get; set; }

    public virtual IList<Email>? Emailovi { get; set; }

    public virtual IList<Nekretnina>? Nekretnine { get; set; }


    public Vlasnik()
    {
        BankovniRacuni = new List<BankovniRacun>();

        BrojeviTelefona = new List<BrojTelefona>();

        Emailovi = new List<Email>();

        Nekretnine = new List<Nekretnina>();
    }

}


public class FizickoLice : Vlasnik
{
    public virtual string JMBG { get; set; }
    public virtual string ImeRoditelja { get; set; }

    public virtual DateTime DatumRodjenja { get; set; }

    public FizickoLice() : base() { }

}

public class PravnoLice : Vlasnik
{
    public virtual string PIB { get; set; }
    public virtual string Naziv { get; set; }

    public PravnoLice() : base() { }

}


