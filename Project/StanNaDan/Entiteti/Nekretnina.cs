//CREATE TABLE NEKRETNINA (
// ID INT PRIMARY KEY,
// TIP_NEKRETNINE VARCHAR(255),
// KUCNI_BROJ INT,
// IME_ULICE VARCHAR(255),
// KVADRATURA DECIMAL(10,2),
// BROJ_KUPATILA INT,
// BROJ_TERASA INT,
// BROJ_SOBA INT,
// INTERNET NUMBER(1) CHECK(INTERNET IN(0, 1)),
// TV NUMBER(1) CHECK(TV IN(0, 1)),
// KUHINJA NUMBER(1) CHECK(KUHINJA IN(0, 1)),
// DIMENZIJE VARCHAR(255),
// TIP_KREVETA VARCHAR(255),
// SPRATNOST INT,
// DVORISTE NUMBER(1) CHECK(DVORISTE IN(0, 1)),
// SPRAT INT,
// LIFT NUMBER(1) CHECK(LIFT IN(0, 1)),
// OBJEKAT VARCHAR(255),
// ID_VLASNIKA INT,
// NAZIV_KVARTA VARCHAR(255),
// FOREIGN KEY(ID_VLASNIKA) REFERENCES VLASNIK(ID),
// FOREIGN KEY(NAZIV_KVARTA) REFERENCES KVART(NAZIV)
//);

namespace StanNaDan.Entiteti;

public class Nekretnina
{

    //Nekretnine mogu stanovi ili kuće.Za svaki stan se pamti i sprat na kome se nalazi i da li zgrada poseduje
    //lift.Za kuće se pamti da li poseduje dvorište i spratnost kuće.Za svaku nekretninu se pamte informacije o
    //krevetima koje poseduje: tip kreveta i njegove dimenzije.Pamti se i da li nekretnina poseduje internet I
    //TV priključak, kuhinju sa raspoloživim posuđem i dodatnu opremu(tip opreme (daska za peglanje, sauna,
    //bicikla i sl.) i da li je korišćenje besplatno ili zahteva naknadu i cenu korišćenja u tom slučaju). Nekretnina
    //može da uključuje i parking mesto.Za parking mesto se pamti da li je u sastavu same nekretnine ili je deo
    //nekog javnog parking/garaže, da li je besplatno parkiranje ili zahteva dodatno plaćanje I cenu parkiranaj
    //u tom slučaju. (Neki vlasnici nekretnina ne izdaju kompletnu nekretninu već izdaju deo nekretnine(sobu
    //u stanu ili kući). U tom slučaju treba pamtiti informacije o tome koji zajednički delovi nekretnine su na
    //raspolaganju prilikom iznajmljivanja.Za svaku nekretninu se pamte sajtovi na kojima je oglašena
    public virtual int ID { get; set; }
    public virtual string TipNekretnine { get; set; }

    public virtual int KucniBroj { get; set; }

    public virtual string ImeUlice { get; set; }
    public virtual decimal Kvadratura { get; set; }

    public virtual int BrojKupatila { get; set; }
    public virtual int BrojTerasa { get; set; }
    public virtual int BrojSoba { get; set; }
    public virtual int Internet { get; set; }
    public virtual int TV { get; set; }

    public virtual int Kuhinja { get; set; }
    public virtual string Dimenzije { get; set; }

    public virtual string TipKreveta { get; set; }


    public virtual Vlasnik Vlasnik { get; set; }

    public virtual Kvart Kvart { get; set; }

    public virtual IList<DodatnaOprema>? DodatnaOprema { get; set; }

    public virtual IList<ImaNajam> ListaNajmova { get; set; }

    public virtual IList<Parking> Parkinzi { get; set; }

    public virtual IList<Sajtovi> Sajtovi { get; set; }


    public Nekretnina()
    {
        DodatnaOprema = new List<DodatnaOprema>();

        ListaNajmova = new List<ImaNajam>();

        Parkinzi = new List<Parking>();

        Sajtovi = new List<Sajtovi>();
    }





}

public class Soba : Nekretnina
{
    public virtual string Objekat { get; set; }

}

public class Kuca : Nekretnina
{
    public virtual int Spratnost { get; set; }

    public virtual int Dvoriste { get; set; }

}

public class Stan : Nekretnina
{
    public virtual int Lift { get; set; }
    public virtual int Sprat { get; set; }

}
