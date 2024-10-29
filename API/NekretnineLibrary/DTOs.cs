using StanNaDan.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StanNaDan;

#region Nekretnina
public class NekretninaBasic

{
    public int ID { get; set; }
    public string TipNekretnine { get; set; }

    public int KucniBroj { get; set; }

    public string ImeUlice { get; set; }
    public decimal Kvadratura { get; set; }

    public int BrojKupatila { get; set; }
    public int BrojTerasa { get; set; }
    public int BrojSoba { get; set; }
    public int Internet { get; set; } // 0 ili 1
    public int TV { get; set; } // 0 ili 1

    public int Kuhinja { get; set; } // 0 ili 1
    public string Dimenzije { get; set; }

    public string TipKreveta { get; set; }

    public VlasnikBasic Vlasnik { get; set; }

    public KvartBasic Kvart { get; set; }

    public IList<ImaNajamBasic> ListaNajmova { get; set; }
    public IList<DodatnaOpremaBasic> ListaDodatneOpreme { get; set; }
    public IList<ParkingBasic> ListaParkinga { get; set; }
    public IList<SajtoviBasic> ListaSajtova { get; set; }


    public NekretninaBasic()
    {
        ListaNajmova = new List<ImaNajamBasic>();
        ListaDodatneOpreme = new List<DodatnaOpremaBasic>();
        ListaParkinga = new List<ParkingBasic>();
        ListaSajtova = new List<SajtoviBasic>();
    }
    public NekretninaBasic(int ID1, string TipNekretnine1, int KucniBroj1, string ImeUlice1, decimal Kvadratura1, int BrojKupatila1,
                            int BrojTerasa1, int BrojSoba1, int Internet1, int T, int Kuhinj1a, string Dimenzije1, string TipKreveta1, VlasnikBasic v, KvartBasic k)
    {
        this.ID = ID1;
        this.TipNekretnine = TipNekretnine1;
        this.KucniBroj = KucniBroj1;
        this.ImeUlice = ImeUlice1;
        this.Kvadratura = Kvadratura1;
        this.BrojKupatila = BrojKupatila1;
        this.BrojTerasa = BrojTerasa1;
        this.BrojSoba = BrojSoba1;
        this.Internet = Internet1;
        this.TV = T;
        this.Kuhinja = Kuhinj1a;
        this.Dimenzije = Dimenzije1;
        this.TipKreveta = TipKreveta1;
        this.Vlasnik = v;
        this.Kvart = k;


    }

}
public class KucaBasic : NekretninaBasic
{
    public int Spratnost { get; set; }

    public int Dvoriste { get; set; } // 0 ili 1

    public KucaBasic() : base()
    {

    }
    public KucaBasic(int ID1, string TipNekretnine1, int KucniBroj1, string ImeUlice1, decimal Kvadratura1, int BrojKupatila1,
                    int BrojTerasa1, int BrojSoba1, int Internet1, int T, int Kuhinj1a, string Dimenzije1, string TipKreveta1,
                    int Spratnost1, int Dvoriste1, VlasnikBasic v, KvartBasic k)
                    : base(ID1, TipNekretnine1, KucniBroj1, ImeUlice1, Kvadratura1, BrojKupatila1, BrojTerasa1,
                          BrojSoba1, Internet1, T, Kuhinj1a, Dimenzije1, TipKreveta1, v, k)
    {
        this.Spratnost = Spratnost1;
        this.Dvoriste = Dvoriste1;
    }
}
public class StanBasic : NekretninaBasic
{
    public int Sprat { get; set; }

    public int Lift { get; set; } // 0 ili 1

    public StanBasic() : base()
    {

    }
    public StanBasic(int ID1, string TipNekretnine1, int KucniBroj1, string ImeUlice1, decimal Kvadratura1, int BrojKupatila1,
                    int BrojTerasa1, int BrojSoba1, int Internet1, int T, int Kuhinj1a, string Dimenzije1, string TipKreveta1,
                    int Sprat1, int Lift1, VlasnikBasic v, KvartBasic k)
                    : base(ID1, TipNekretnine1, KucniBroj1, ImeUlice1, Kvadratura1, BrojKupatila1, BrojTerasa1,
                          BrojSoba1, Internet1, T, Kuhinj1a, Dimenzije1, TipKreveta1, v, k)
    {
        this.Sprat = Sprat1;
        this.Lift = Lift1;

    }
}
public class SobaBasic : NekretninaBasic
{
    public string Objekat { get; set; }

    public SobaBasic() : base()
    {

    }
    public SobaBasic(int ID1, string TipNekretnine1, int KucniBroj1, string ImeUlice1, decimal Kvadratura1, int BrojKupatila1,
                    int BrojTerasa1, int BrojSoba1, int Internet1, int T, int Kuhinj1a, string Dimenzije1, string TipKreveta1,
                    string obj, VlasnikBasic v, KvartBasic k)
                    : base(ID1, TipNekretnine1, KucniBroj1, ImeUlice1, Kvadratura1, BrojKupatila1, BrojTerasa1,
                          BrojSoba1, Internet1, T, Kuhinj1a, Dimenzije1, TipKreveta1, v, k)
    {
        this.Objekat = obj;
    }
}
public class NekretninaPregled
{
    public int ID { get; set; }
    public string TipNekretnine { get; set; }
    public int KucniBroj { get; set; }
    public string ImeUlice { get; set; }
    public decimal Kvadratura { get; set; }
    public int BrojKupatila { get; set; }
    public int BrojTerasa { get; set; }
    public int BrojSoba { get; set; }
    public int Internet { get; set; } // 0 ili 1
    public int TV { get; set; } // 0 ili 1
    public int Kuhinja { get; set; } // 0 ili 1
    public string Dimenzije { get; set; }
    public string TipKreveta { get; set; }

    //konstruktori
    public NekretninaPregled() { }
    public NekretninaPregled(int ID1, string TipNekretnine1, int KucniBroj1, string ImeUlice1, decimal Kvadratura1, int BrojKupatila1,
                            int BrojTerasa1, int BrojSoba1, int Internet1, int T, int Kuhinj1a, string Dimenzije1, string TipKreveta1)
    {
        this.ID = ID1;
        this.TipNekretnine = TipNekretnine1;
        this.KucniBroj = KucniBroj1;
        this.ImeUlice = ImeUlice1;
        this.Kvadratura = Kvadratura1;
        this.BrojKupatila = BrojKupatila1;
        this.BrojTerasa = BrojTerasa1;
        this.BrojSoba = BrojSoba1;
        this.Internet = Internet1;
        this.TV = T;
        this.Kuhinja = Kuhinj1a;
        this.Dimenzije = Dimenzije1;
        this.TipKreveta = TipKreveta1;
    }

}
public class KucaPregled : NekretninaPregled
{
    public int Spratnost { get; set; }

    public int Dvoriste { get; set; } // 0 ili 1

    public KucaPregled() : base()
    {

    }
    public KucaPregled(int ID1, string TipNekretnine1, int KucniBroj1, string ImeUlice1, decimal Kvadratura1, int BrojKupatila1,
                    int BrojTerasa1, int BrojSoba1, int Internet1, int T, int Kuhinj1a, string Dimenzije1, string TipKreveta1,
                    int Spratnost1, int Dvoriste1)
                    : base(ID1, TipNekretnine1, KucniBroj1, ImeUlice1, Kvadratura1, BrojKupatila1, BrojTerasa1,
                          BrojSoba1, Internet1, T, Kuhinj1a, Dimenzije1, TipKreveta1)
    {
        this.Spratnost = Spratnost1;
        this.Dvoriste = Dvoriste1;
    }
}
public class StanPregled : NekretninaPregled
{
    public int Sprat { get; set; }

    public int Lift { get; set; } // 0 ili 1

    public StanPregled() : base()
    {

    }
    public StanPregled(int ID1, string TipNekretnine1, int KucniBroj1, string ImeUlice1, decimal Kvadratura1, int BrojKupatila1,
                    int BrojTerasa1, int BrojSoba1, int Internet1, int T, int Kuhinj1a, string Dimenzije1, string TipKreveta1,
                    int Sprat1, int Lift1)
                    : base(ID1, TipNekretnine1, KucniBroj1, ImeUlice1, Kvadratura1, BrojKupatila1, BrojTerasa1,
                          BrojSoba1, Internet1, T, Kuhinj1a, Dimenzije1, TipKreveta1)
    {
        this.Sprat = Sprat1;
        this.Lift = Lift1;

    }
}

public class SobaPregled : NekretninaPregled
{
    public string Objekat { get; set; }

    public SobaPregled() : base()
    {

    }
    public SobaPregled(int ID1, string TipNekretnine1, int KucniBroj1, string ImeUlice1, decimal Kvadratura1, int BrojKupatila1,
                    int BrojTerasa1, int BrojSoba1, int Internet1, int T, int Kuhinj1a, string Dimenzije1, string TipKreveta1,
                    string obj)
                    : base(ID1, TipNekretnine1, KucniBroj1, ImeUlice1, Kvadratura1, BrojKupatila1, BrojTerasa1,
                          BrojSoba1, Internet1, T, Kuhinj1a, Dimenzije1, TipKreveta1)
    {
        this.Objekat = obj;
    }

    #endregion

    #region Poslovnica

    public class PoslovnicaBasic
    {
        public string Adresa { get; set; }

        public string RadnoVreme { get; set; }

        public IList<KvartBasic> Kvartovi { get; set; }

        public IList<ZaposlenBasic> Zaposleni { get; set; }

        public PoslovnicaBasic()
        {
            Kvartovi = new List<KvartBasic>();

            Zaposleni = new List<ZaposlenBasic>();

        }
        public PoslovnicaBasic(string adresa, string radnovreme)
        {
            Adresa = adresa;
            RadnoVreme = radnovreme;


        }



    }

    public class PoslovnicaPregled
    {
        public string Adresa { get; set; }

        public string RadnoVreme { get; set; }



        public PoslovnicaPregled(string adresa, string radnovreme)
        {
            Adresa = adresa;
            RadnoVreme = radnovreme;


        }

    }

}


#endregion

#region Poslovnica

public class PoslovnicaBasic
{
    public string Adresa { get; set; }

    public string RadnoVreme { get; set; }

    public IList<KvartBasic> Kvartovi { get; set; }

    public IList<ZaposlenBasic> Zaposleni { get; set; }

    public PoslovnicaBasic()
    {
        Kvartovi = new List<KvartBasic>();

        Zaposleni = new List<ZaposlenBasic>();

    }
    public PoslovnicaBasic(string adresa, string radnovreme)
    {
        Adresa = adresa;
        RadnoVreme = radnovreme;


    }



}

public class PoslovnicaPregled
{
    public string Adresa { get; set; }

    public string RadnoVreme { get; set; }



    public PoslovnicaPregled(string adresa, string radnovreme)
    {
        Adresa = adresa;
        RadnoVreme = radnovreme;


    }

}

#endregion


#region Kvart
public class KvartBasic
{
    public string Naziv { get; set; }
    public string Zona { get; set; }
    public PoslovnicaBasic Poslovnica { get; set; }
    public virtual IList<NekretninaBasic> Nekretnine { get; set; }

    public KvartBasic()
    {
        Nekretnine = new List<NekretninaBasic>();

    }

    public KvartBasic(string naziv, string zona)
    {
        this.Naziv = naziv;
        this.Zona = zona;
    }

}

public class KvartPregled
{
    public string Naziv { get; set; }
    public string Zona { get; set; }
    public KvartPregled(string naziv, string zona)
    {
        this.Naziv = naziv;
        this.Zona = zona;
    }

    public KvartPregled() { }

}

#endregion


#region Vlasnik
public class VlasnikBasic
{
    public int Id { get; set; }
    public string TipVlasnika { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }

    public string Adresa { get; set; }

    public string Mesto { get; set; }

    public string Drzava { get; set; }

    public IList<BankovniRacunBasic>? BankovniRacuni { get; set; }

    public IList<BrojTelefonaBasic>? BrojeviTelefona { get; set; }

    public IList<EmailBasic>? Emailovi { get; set; }

    public IList<NekretninaBasic>? Nekretnine { get; set; }


    public VlasnikBasic()
    {
        BankovniRacuni = new List<BankovniRacunBasic>();

        BrojeviTelefona = new List<BrojTelefonaBasic>();

        Emailovi = new List<EmailBasic>();

        Nekretnine = new List<NekretninaBasic>();
    }

    public VlasnikBasic(int id, string tip, string ime, string prezime, string adresa, string mesto, string drzava)
    {
        Id = id;
        TipVlasnika = tip;
        Ime = ime;
        Prezime = prezime;
        Adresa = adresa;
        Mesto = mesto;
        Drzava = drzava;


    }

}

public class PravnoLiceBasic : VlasnikBasic
{

    public string Naziv { get; set; }

    public string PIB { get; set; }

    public PravnoLiceBasic() { }

    public PravnoLiceBasic(int id, string tip, string ime, string prezime, string adresa, string mesto, string drzava, string PIB, string naziv) : base(id, tip, ime, prezime, adresa, mesto, drzava)
    {
        this.PIB = PIB;
        this.Naziv = naziv;

    }

}

public class FizickoLiceBasic : VlasnikBasic
{
    public string ImeRoditelja { get; set; }
    public DateTime DatumRodjenja { get; set; }

    public string JMBG { get; set; }


    public FizickoLiceBasic() { }

    public FizickoLiceBasic(int id, string tip, string ime, string prezime, string adresa, string mesto, string drzava, string imerod, string jmbg, DateTime datumrodjenja) : base(id, tip, ime, prezime, adresa, mesto, drzava)
    {
        this.ImeRoditelja = imerod;
        this.JMBG = jmbg;
        this.DatumRodjenja = datumrodjenja;

    }

}


public class VlasnikPregled
{
    public int Id { get; set; }
    public string TipVlasnika { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }

    public string Adresa { get; set; }

    public string Mesto { get; set; }

    public string Drzava { get; set; }
    public VlasnikPregled() { }

    public VlasnikPregled(int id, string tip, string ime, string prezime, string adresa, string mesto, string drzava)
    {
        Id = id;
        TipVlasnika = tip;
        Ime = ime;
        Prezime = prezime;
        Adresa = adresa;
        Mesto = mesto;
        Drzava = drzava;

    }

}

public class FizickoLicePregled : VlasnikPregled
{
    public string ImeRoditelja { get; set; }
    public DateTime DatumRodjenja { get; set; }

    public string JMBG { get; set; }


    public FizickoLicePregled():base(){}
    public FizickoLicePregled(int id, string tip, string ime, string prezime, string adresa, string mesto, string drzava, string imerod, string jmbg, DateTime datumrodjenja) : base(id, tip, ime, prezime, adresa, mesto, drzava)
    {
        this.ImeRoditelja = imerod;
        this.JMBG = jmbg;
        this.DatumRodjenja = datumrodjenja;

    }

}
public class PravnoLicePregled : VlasnikPregled
{

    public string Naziv { get; set; }

    public string PIB { get; set; }
    public PravnoLicePregled():base(){}
    public PravnoLicePregled(int id, string tip, string ime, string prezime, string adresa, string mesto, string drzava, string PIB, string naziv) : base(id, tip, ime, prezime, adresa, mesto, drzava)
    {
        this.PIB = PIB;
        this.Naziv = naziv;

    }

}





#endregion


#region BankovniRacun
public class BankovniRacunBasic
{
    public int ID { get; set; }
    public int BrojRacuna { get; set; }

    public string ImeBanke { get; set; }

    //strani kljuc
    public VlasnikBasic Vlasnik { get; set; }

    public BankovniRacunBasic(int id, int br, string ime, VlasnikBasic v)
    {
        ID = id;
        BrojRacuna = br;
        ImeBanke = ime;
        Vlasnik = v;
    }

    public BankovniRacunBasic()
    {

    }

}
public class BankovniRacunPregled
{
    public int ID { get; set; }
    public int BrojRacuna { get; set; }

    public string ImeBanke { get; set; }

    public BankovniRacunPregled(int id, int br, string ime)
    {
        ID = id;
        BrojRacuna = br;
        ImeBanke = ime;

    }

    public BankovniRacunPregled()
    {

    }

}

#endregion


#region SpoljniRadnik
public class SpoljniRadnikBasic
{
    public int Id { get; set; }

    public string BrojTelefona { get; set; }

    public string Ime { get; set; }

    public DateTime DatumAngazovanja { get; set; }

    public float Procenat { get; set; }

    public IList<AngazujeBasic> Angazovanja { get; set; }

    public SpoljniRadnikBasic(int id, string brtel, string ime, DateTime datum, float procemat)
    {
        Id = id;
        BrojTelefona = brtel;
        Ime = ime;
        DatumAngazovanja = datum;
        Procenat = procemat;

    }
    public SpoljniRadnikBasic()
    {
        Angazovanja = new List<AngazujeBasic>();

    }

}
public class SpoljniRadnikPregled
{
    public int Id { get; set; }

    public string BrojTelefona { get; set; }

    public string Ime { get; set; }

    public DateTime DatumAngazovanja { get; set; }

    public float Procenat { get; set; }

    public SpoljniRadnikPregled(){}
    public SpoljniRadnikPregled(int id, string brtel, string ime, DateTime datum, float procemat)
    {
        Id = id;
        BrojTelefona = brtel;
        Ime = ime;
        DatumAngazovanja = datum;
        Procenat = procemat;

    }


}


#endregion

#region Zaposlen
public class ZaposlenBasic
{
    public string Ime { get; set; }

    public string JMBG { get; set; }


    public PoslovnicaBasic Poslovnica { get; set; }

    public DateTime DatumZaposlenja { get; set; }

    public ZaposlenBasic() { }

    public ZaposlenBasic(string ime, string jmbg, PoslovnicaBasic p, DateTime datum)
    {
        Ime = ime;
        JMBG = jmbg;
        Poslovnica = p;
        DatumZaposlenja = datum;
    }
}

public class ZaposlenPogled
{
    public string Ime { get; set; }

    public string JMBG { get; set; }


    public PoslovnicaBasic Poslovnica { get; set; }

    public DateTime DatumZaposlenja { get; set; }
    public ZaposlenPogled(){}

    public ZaposlenPogled(string ime, string jmbg, DateTime datum)
    {
        Ime = ime;
        JMBG = jmbg;
        DatumZaposlenja = datum;
    }
}

#endregion

#region Sef
public class SefBasic : ZaposlenBasic
{
    public DateTime DatumPostavljanja { get; set; }

    public SefBasic(string ime, string jmbg, PoslovnicaBasic p, DateTime datum, DateTime datumpost) : base(ime, jmbg, p, datum)
    {

        DatumPostavljanja = datumpost;
    }

    public SefBasic():base() { }

    public SefBasic(string ime, string jMBG, DateTime datumZaposlenja, DateTime datumPostavljanja)
    {
        Ime = ime;
        JMBG = jMBG;
        DatumZaposlenja = datumZaposlenja;
        DatumPostavljanja = datumPostavljanja;
    }
}

public class SefPregled : ZaposlenPogled
{
    public DateTime DatumPostavljanja { get; set; }
    public SefPregled():base(){}
    public SefPregled(string ime, string jmbg, DateTime datum, DateTime datumpost) : base(ime, jmbg, datum)
    {
        DatumPostavljanja = datumpost;
    }
}


#endregion

#region Agent

public class AgentBasic : ZaposlenBasic
{
    public string StrucnaSprema { get; set; }

    public IList<AngazujeBasic> Angazovanja { get; set; }
    public AgentBasic():base(){}

    public AgentBasic(string ime, string jmbg, PoslovnicaBasic p, DateTime datum, string s) : base(ime, jmbg, p, datum)
    {
        StrucnaSprema = s;
    }

    //public AgentBasic()
    //{
    //    Angazovanja = new List<AngazujeBasic>();

    //}


}

public class AgentPregled : ZaposlenPogled
{
    public string StrucnaSprema { get; set; }


    public AgentPregled():base(){}
    public AgentPregled(string ime, string jmbg, DateTime datum, string s) : base(ime, jmbg, datum)
    {
        StrucnaSprema = s;
    }
}

#endregion


#region Najam

public class NajamBasic
{
    public int ID { get; set; }

    public DateTime DatumOd { get; set; }

    public DateTime DatumDo { get; set; }

    public decimal CenaPoDanu { get; set; }

    public int BrojDana { get; set; }

    public decimal Popust { get; set; }

    //public virtual string JmbgAgenta { get; set; }

    public Agent Agent { get; set; }
    public decimal Provizija { get; set; }

    public IList<ImaNajamBasic> ListaNajmova { get; set; } //malo nelogicno

    public NajamBasic()
    {
        ListaNajmova = new List<ImaNajamBasic>();


    }

    public NajamBasic(int id, DateTime datumOd, DateTime datumDo, decimal cenaPoDanu, int brojDana, decimal popust, Agent agent, decimal provizija)
    {
        ID = id;
        DatumOd = datumOd;
        DatumDo = datumDo;
        CenaPoDanu = cenaPoDanu;
        BrojDana = brojDana;
        Popust = popust;
        Agent = agent;
        Provizija = provizija;

    }



}
public class NajamPregled
{
    public int ID { get; set; }

    public DateTime DatumOd { get; set; }

    public DateTime DatumDo { get; set; }

    public decimal CenaPoDanu { get; set; }

    public int BrojDana { get; set; }

    public decimal Popust { get; set; }


    public decimal Provizija { get; set; }


    public NajamPregled(int id, DateTime datumOd, DateTime datumDo, decimal cenaPoDanu, int brojDana, decimal popust, decimal provizija)
    {
        ID = id;
        DatumOd = datumOd;
        DatumDo = datumDo;
        CenaPoDanu = cenaPoDanu;
        BrojDana = brojDana;
        Popust = popust;
        Provizija = provizija;

    }



}




#endregion

#region DodatnaOprema
public class DodatnaOpremaBasic
{
    public int ID { get; set; }
    public string Tip { get; set; }
    public decimal Cena { get; set; }
    public NekretninaBasic? Nekretnina { get; set; }

    public DodatnaOpremaBasic()
    {
    }

    public DodatnaOpremaBasic(int id, string tip, decimal cena, NekretninaBasic? nekretnina)
    {
        ID = id;
        Tip = tip;
        Cena = cena;
        Nekretnina = nekretnina;
    }
}

public class DodatnaOpremaPregled
{
    public int ID { get; set; }
    public string Tip { get; set; }
    public decimal Cena { get; set; }


    public DodatnaOpremaPregled()
    {
    }

    public DodatnaOpremaPregled(int id, string tip, decimal cena)
    {
        ID = id;
        Tip = tip;
        Cena = cena;
    }
}

#endregion

#region Parking

public class ParkingBasic
{
    public int ID { get; set; }
    public decimal Cena { get; set; }
    public string Javni { get; set; }
    public NekretninaBasic Nekretnina { get; set; }

    public ParkingBasic()
    {
    }

    public ParkingBasic(int id, decimal cena, string javni, NekretninaBasic nekretnina)
    {
        ID = id;
        Cena = cena;
        Javni = javni;
        Nekretnina = nekretnina;
    }
}

public class ParkingPregled
{
    public int ID { get; set; }
    public decimal Cena { get; set; }
    public string Javni { get; set; }


    public ParkingPregled()
    {
    }

    public ParkingPregled(int id, decimal cena, string javni, NekretninaPregled nekretnina)
    {
        ID = id;
        Cena = cena;
        Javni = javni;
    }
}

#endregion 



#region Angazuje
public class AngazujeBasic
{
    public AngazujeID Id { get; set; }

    public AngazujeBasic()
    {
        Id = new AngazujeID();
    }

}

public class AngazujePogled
{
    public AngazujeID Id { get; set; }

    public AngazujePogled()
    {
        Id = new AngazujeID();
    }

}

#endregion

#region ImaNajam
public class ImaNajamBasic
{
    public int Id { get;}
     public  Najam Najam { get; set; }
    public  Nekretnina Nekretnina { get; set; }

    public ImaNajamBasic(){}
    public  ImaNajamBasic(Najam n,Nekretnina ne){
        this.Najam=n;
        this.Nekretnina=ne;
    }
    

}
public class ImaNajamPregled
{
    public int Id { get;}
     public  Najam Najam { get; set; }
    public  Nekretnina Nekretnina { get; set; }

    public ImaNajamPregled(){}
   /* public  ImaNajamPregled(Najam n,Nekretnina ne){
        this.Najam=n;
        this.Nekretnina=ne;
    }
    */

}
#endregion

#region Sajtovi
public class SajtoviBasic
{
    public int ID { get; set; }
    public string Sajt { get; set; }
    public NekretninaBasic Nekretnina { get; set; }
    public SajtoviBasic() { }
    public SajtoviBasic(int id, string s, NekretninaBasic n)
    {
        this.ID = id;
        this.Sajt = s;
        this.Nekretnina = n;
    }
}
public class SajtoviPregled
{
    public int ID { get; set; }
    public string Sajt { get; set; }

    public SajtoviPregled() { }
    public SajtoviPregled(int id, string s)
    {
        this.ID = id;
        this.Sajt = s;

    }

}

#endregion


#region Email

public class EmailBasic
{
    public int ID { get; set; }
    public string EMAIL { get; set; }

    public Vlasnik Vlasnik { get; set; }

    public EmailBasic()
    {

    }
    public EmailBasic(int Id, string e, Vlasnik v)
    {
        this.ID = Id;
        this.EMAIL = e;
        this.Vlasnik = v;
    }

}
public class EmailPogled
{
    public int Id { get; set; }
    public string EMAIL { get; set; }

    public EmailPogled()
    {

    }
    public EmailPogled(int id, string e)
    {
        this.EMAIL = e;
        this.Id = id;
    }
}
#endregion


#region BrojTelefona

public class BrojTelefonaBasic
{
    public int ID { get; set; }
    public VlasnikBasic Vlasnik { get; set; }
    public string Broj { get; set; }

    public BrojTelefonaBasic()
    {

    }
    public BrojTelefonaBasic(int id, VlasnikBasic v, string b)
    {
        this.ID = id;
        this.Vlasnik = v;
        this.Broj = b;
    }


}
public class BrojTelefonaPregled
{
    public int ID { get; set; }
    public string Broj { get; set; }

    public BrojTelefonaPregled()
    {

    }
    public BrojTelefonaPregled(int id, Vlasnik v, string b)
    {
        this.ID = id;
        this.Broj = b;
    }

}

#endregion




#region AngazujeIDBasic

public class AngazujeIDBasic
{
    public SpoljniRadnikBasic SpoljniRadnikBasic { get; set; }

    public AgentBasic Agent { get; set; }
    public AngazujeIDBasic() { }

    public AngazujeIDBasic(SpoljniRadnikBasic s, AgentBasic a)
    {
        SpoljniRadnikBasic = s;
        Agent = a;
    }
}
public class AngazujeIDPregled
{
    public AngazujeIDPregled() { }
}
#endregion AngazujeID








