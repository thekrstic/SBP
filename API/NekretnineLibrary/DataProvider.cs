using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using StanNaDan.Entiteti;

using StanNaDan.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan;
using static System.Collections.Specialized.BitVector32;

namespace StanNaDan;



public class DataProvider
{
    #region Nekretnina

    public static Result<List<NekretninaPregled>, ErrorMessage> GetNekretninaPregled()
    {
        List<NekretninaPregled> nekretninaInfo = new List<NekretninaPregled>();

        try
        {
            ISession session = DataLayer.GetSession();

            IEnumerable<Nekretnina> nekretnine = from k in session.Query<Nekretnina>() select k;

            foreach (Nekretnina k in nekretnine)
            {
                //MessageBox.Show(k.TipNekretnine);

                nekretninaInfo.Add(new NekretninaPregled(k.ID, k.TipNekretnine, k.KucniBroj, k.ImeUlice, k.Kvadratura,
                                                           k.BrojKupatila, k.BrojTerasa, k.BrojSoba, k.Internet, k.TV,
                                                           k.Kuhinja, k.Dimenzije, k.TipKreveta));
            }

            session?.Close();

        }
        catch (Exception ex)
        {
            return "Nemoguće vratiti sve nekretnine.".ToError(400);
        }

        return nekretninaInfo;
    }
    public static NekretninaBasic GetNekretninaPregled(int nekretninaID)
    {
        NekretninaBasic nb = new NekretninaBasic();

        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Nekretnina n = session.Load<Nekretnina>(nekretninaID);

            Kvart k = session.Load<Kvart>(n.Kvart.Naziv);
            Vlasnik v = session.Load<Vlasnik>(n.Vlasnik.Id);

            KvartBasic kb = new KvartBasic(k.Naziv, k.Zona);
            VlasnikBasic vb = new VlasnikBasic(v.Id, v.TipVlasnika, v.Ime, v.Prezime,
                                                v.Adresa, v.Mesto, v.Drzava
                                                );

            nb = new NekretninaBasic(n.ID, n.TipNekretnine, n.KucniBroj, n.ImeUlice,
                                                     n.Kvadratura, n.BrojKupatila, n.BrojTerasa,
                                                    n.BrojSoba, n.Internet, n.TV, n.Kuhinja,
                                                     n.Dimenzije, n.TipKreveta, vb, kb);
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

        return nb;
    }
    public static KucaPregled GetKucaPregled(int nekretninaID)
    {
        KucaPregled nb = new KucaPregled();

        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Kuca n = session.Load<Kuca>(nekretninaID);



            nb = new KucaPregled(n.ID, "KUCA", n.KucniBroj, n.ImeUlice,
                                                     n.Kvadratura, n.BrojKupatila, n.BrojTerasa,
                                                    n.BrojSoba, n.Internet, n.TV, n.Kuhinja,
                                                     n.Dimenzije, n.TipKreveta, n.Spratnost, n.Dvoriste);
        }
        catch (Exception ex)
        {
            return null;
        }
        finally
        {
            session.Close();
        }

        return nb;
    }
    public static StanPregled GetStanPregled(int nekretninaID)
    {
        StanPregled nb = new StanPregled();

        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Stan n = session.Load<Stan>(nekretninaID);

            nb = new StanPregled(n.ID, "STAN", n.KucniBroj, n.ImeUlice,
                                                     n.Kvadratura, n.BrojKupatila, n.BrojTerasa,
                                                    n.BrojSoba, n.Internet, n.TV, n.Kuhinja,
                                                     n.Dimenzije, n.TipKreveta, n.Sprat, n.Lift);

        }
        catch (Exception ex)
        {
            return null;
        }
        finally
        {
            session.Close();
        }

        return nb;
    }
    public static SobaPregled GetSobaPregled(int nekretninaID)
    {
        SobaPregled nb = new SobaPregled();

        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Soba n = session.Load<Soba>(nekretninaID);



            nb = new SobaPregled(n.ID, "SOBA", n.KucniBroj, n.ImeUlice,
                                                     n.Kvadratura, n.BrojKupatila, n.BrojTerasa,
                                                    n.BrojSoba, n.Internet, n.TV, n.Kuhinja,
                                                     n.Dimenzije, n.TipKreveta, n.Objekat);
        }
        catch (Exception ex)
        {
            return null;
        }
        finally
        {
            session.Close();
        }

        return nb;
    }

    public async static Task<Result<KucaBasic, ErrorMessage>> AzurirajKucuAsync(KucaBasic nb, int nID)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();


            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);
            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);




            Kuca n = session.Load<Kuca>(nb.ID);


            n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Spratnost = nb.Spratnost;
            n.Dvoriste = nb.Dvoriste;

            n.Vlasnik = v;
            n.Kvart = k;

            await session.UpdateAsync(n);
            await session.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati kucu.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return nb;
    }

    public async static Task<Result<StanBasic, ErrorMessage>> AzurirajStanAsync(StanBasic nb, int nID)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();


            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);
            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);




            Stan n = session.Load<Stan>(nb.ID);


            n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Sprat = nb.Sprat;
            n.Lift = nb.Lift;

            n.Vlasnik = v;
            n.Kvart = k;

            await session.UpdateAsync(n);
            await session.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati stan.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return nb;
    }

    public async static Task<Result<SobaBasic, ErrorMessage>> AzurirajSobuAsync(SobaBasic nb, int nID)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();


            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);
            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);

            Soba n = session.Load<Soba>(nb.ID);


            n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Objekat = nb.Objekat;

            n.Vlasnik = v;
            n.Kvart = k;

            await session.UpdateAsync(n);
            await session.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće ažurirati sobu.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return nb;
    }
    
    public async static Task<Result<bool, ErrorMessage>> DodajKucuAsync(KucaBasic kb)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            Kvart k = session.Load<Kvart>(kb.Kvart.Naziv);
            Vlasnik v = session.Load<Vlasnik>(kb.Vlasnik.Id);

            Kuca n = new Kuca();
            //n.ID = kb.ID; //ID stavlja null?
            n.TipNekretnine = kb.TipNekretnine;
            n.KucniBroj = kb.KucniBroj;
            n.ImeUlice = kb.ImeUlice;
            n.Kvadratura = kb.Kvadratura;
            n.BrojKupatila = kb.BrojKupatila;
            n.BrojTerasa = kb.BrojTerasa;
            n.BrojSoba = kb.BrojSoba;
            n.Internet = kb.Internet;
            n.TV = kb.TV;
            n.Kuhinja = kb.Kuhinja;
            n.Dimenzije = kb.Dimenzije;
            n.TipKreveta = kb.TipKreveta;
            n.Spratnost = kb.Spratnost;
            n.Dvoriste = kb.Dvoriste;
            n.Vlasnik = v;
            n.Kvart = k;

            session.SaveOrUpdate(n);
            session.Flush();

            session.Close();

            await session.SaveOrUpdateAsync(n);
            await session.FlushAsync();
        }
        catch (Exception ex)
        {
            return ("Nemoguće dodati kucu zbog" + ex.ToString()).ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajStanAsync(StanBasic nb)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);
            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);



            Stan n = new Stan();
            //n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Sprat = nb.Sprat;
            n.Lift = nb.Lift;
            n.Vlasnik = v;
            n.Kvart = k;

            await session.SaveOrUpdateAsync(n);
            await session.FlushAsync();
        }
        catch (Exception ex)
        {
            return ("Nemoguće dodati stan zbog" + ex.ToString()).ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajSobuAsync(SobaBasic nb)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            Kvart k = session.Load<Kvart>(nb.Kvart.Naziv);
            Vlasnik v = session.Load<Vlasnik>(nb.Vlasnik.Id);

            Soba n = new Soba();
            //n.ID = nb.ID;
            n.TipNekretnine = nb.TipNekretnine;
            n.KucniBroj = nb.KucniBroj;
            n.ImeUlice = nb.ImeUlice;
            n.Kvadratura = nb.Kvadratura;
            n.BrojKupatila = nb.BrojKupatila;
            n.BrojTerasa = nb.BrojTerasa;
            n.BrojSoba = nb.BrojSoba;
            n.Internet = nb.Internet;
            n.TV = nb.TV;
            n.Kuhinja = nb.Kuhinja;
            n.Dimenzije = nb.Dimenzije;
            n.TipKreveta = nb.TipKreveta;
            n.Objekat = nb.Objekat;
            n.Vlasnik = v;
            n.Kvart = k;

            await session.SaveOrUpdateAsync(n);
            await session.FlushAsync();
        }
        catch (Exception ex)
        {
            return ("Nemoguće dodati sobu zbog" + ex.ToString()).ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiNekretninuAsync(int id)
    {
        ISession? session = null;

        try
        {
            session = DataLayer.GetSession();

            if (!(session?.IsConnected ?? false))
            {
                return "Nemoguće otvoriti sesiju.".ToError(403);
            }

            Nekretnina n = await session.LoadAsync<Nekretnina>(id);

            if(n == null)
            {
                return "Nema nekretnine sa tim ID-jem.".ToError(403);
            }

            await session.DeleteAsync(n);
            await session.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguće obrisati nekretninu.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }

    public static Result<VlasnikPregled, ErrorMessage> GetPregledVlasnikNekretnine(int idNekretnine)
    {
        ISession session = null;
        VlasnikPregled vp = null;

        try
        {
            session = DataLayer.GetSession();

            Nekretnina nekretnina = session.Load<Nekretnina>(idNekretnine);

            IEnumerable<Vlasnik> vlasnik = from o in session.Query<Vlasnik>()
                                           where o.Nekretnine.Contains(nekretnina)
                                           select o;
            Vlasnik vl = vlasnik.FirstOrDefault();

            if (vl == null)
                return new VlasnikPregled();


            vp = new VlasnikPregled(vl.Id, vl.TipVlasnika, vl.Ime, vl.Prezime, vl.Adresa, vl.Mesto, vl.Drzava);
            session.Close();
        }
        catch (Exception ec)
        {
            throw;
        }
        return vp;
    }
    public static Result<KvartPregled, ErrorMessage> GetPregledKvartNekretnine(int idNekretnine)
    {
        ISession session = null;
        KvartPregled kp = null;

        try
        {
            session = DataLayer.GetSession();

            Nekretnina nekretnina = session.Load<Nekretnina>(idNekretnine);

            IEnumerable<Kvart> kvart = from o in session.Query<Kvart>()
                                       where o.Nekretnine.Contains(nekretnina)
                                       select o;

            Kvart kv = kvart.FirstOrDefault();

            if (kv == null)
            {
                return new KvartPregled();
                session.Close();
            }

            kp = new KvartPregled(kv.Naziv, kv.Zona);
            session.Close();
        }
        catch (Exception ec)
        {
            throw;
        }
        return kp;
    }


    #endregion

    #region Vlasnik

    public static Result<List<VlasnikPregled>, ErrorMessage> GetVlasnikePregled()
    {
        List<VlasnikPregled> vlasnikInfo = new List<VlasnikPregled>();

        try
        {
            ISession session = DataLayer.GetSession();

            IEnumerable<Vlasnik> vlasnici = from v in session.Query<Vlasnik>() select v;

            foreach (Vlasnik v in vlasnici)
            {
                vlasnikInfo.Add(new VlasnikPregled(v.Id, v.TipVlasnika, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava));
            }

            session.Close();
        }
        catch (Exception ex)
        {
            throw;
        }

        return vlasnikInfo;
    }
    public static VlasnikPregled GetVlasnikPregled(int vID)
    {
        ISession session = null;
        VlasnikPregled vlasnikinfo = new VlasnikPregled();

        try
        {
            session = DataLayer.GetSession();

            Vlasnik v = session.Load<Vlasnik>(vID);

            vlasnikinfo = new VlasnikPregled(v.Id, v.TipVlasnika, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava);
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

        return vlasnikinfo;
    }
    public static PravnoLicePregled GetPravnoLicePregled(int pID)
    {
        ISession session = null;
        PravnoLicePregled vlasnikinfo = new PravnoLicePregled();

        try
        {
            session = DataLayer.GetSession();

            PravnoLice v = session.Load<PravnoLice>(pID);

            vlasnikinfo = new PravnoLicePregled(v.Id, v.TipVlasnika, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava, v.PIB, v.Naziv);
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

        return vlasnikinfo;
    }
    public static FizickoLicePregled GetFizickoLicePregled(int pID)
    {
        ISession session = null;
        FizickoLicePregled vlasnikinfo = new FizickoLicePregled();

        try
        {
            session = DataLayer.GetSession();

            FizickoLicePregled v = session.Load<FizickoLicePregled>(pID);

            vlasnikinfo = new FizickoLicePregled(v.Id, v.TipVlasnika, v.Ime, v.Prezime, v.Adresa, v.Mesto, v.Drzava, v.ImeRoditelja, v.JMBG, v.DatumRodjenja);
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

        return vlasnikinfo;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajPravnoLiceAsync(PravnoLiceBasic vb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            PravnoLice vl = new PravnoLice();


            vl.Id = vb.Id;
            vl.Ime = vb.Ime;
            vl.Prezime = vb.Prezime;
            vl.Adresa = vb.Adresa;
            vl.Mesto = vb.Mesto;
            vl.Drzava = vb.Drzava;
            vl.Naziv = vb.Naziv;
            vl.PIB = vb.PIB;

            await session.SaveOrUpdateAsync(vl);
            await session.FlushAsync();

            session.Close();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }
    public async static Task<Result<bool, ErrorMessage>> DodajFizickoLiceAsync(FizickoLiceBasic vb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            FizickoLice vl = new FizickoLice();

            vl.Id = vb.Id;
            vl.Ime = vb.Ime;
            vl.Prezime = vb.Prezime;
            vl.Adresa = vb.Adresa;
            vl.Mesto = vb.Mesto;
            vl.Drzava = vb.Drzava;
            vl.ImeRoditelja = vb.ImeRoditelja;
            vl.DatumRodjenja = vb.DatumRodjenja;
            vl.JMBG = vb.JMBG;

            await session.SaveOrUpdateAsync(vl);
            await session.FlushAsync();

            session.Flush();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }

    public async static Task<Result<PravnoLiceBasic, ErrorMessage>> AzurirajPravnoLiceAsync(PravnoLiceBasic vb, int vId)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();


            PravnoLice p = session.Load<PravnoLice>(vb.Id);
            if (p != null)
            {

                p.Adresa = vb.Adresa;
                p.PIB = vb.PIB;
                p.Naziv = vb.Naziv;
                p.Drzava = vb.Drzava;
                p.BankovniRacuni = (IList<BankovniRacun>?)vb.BankovniRacuni;
                p.BrojeviTelefona = (IList<BrojTelefona>?)vb.BrojeviTelefona;
                p.Ime = vb.Ime;
                p.Prezime = vb.Prezime;
                p.Mesto = vb.Mesto;
                p.Emailovi = (IList<Email>?)vb.Emailovi;


            }

            await session.UpdateAsync(p);
            await session.FlushAsync();
        }
        catch (Exception ex)
        {
            return "Nemoguće ažurirati pravno lice.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return vb;
    }
    public async static Task<Result<FizickoLiceBasic, ErrorMessage>> AzurirajFizickoLiceAsync(FizickoLiceBasic vb, int vId)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();


            FizickoLice p = session.Load<FizickoLice>(vb.Id);
            if (p != null)
            {

                p.Adresa = vb.Adresa;
                p.ImeRoditelja = vb.ImeRoditelja;
                p.JMBG = vb.JMBG;
                p.DatumRodjenja = vb.DatumRodjenja;
                p.Drzava = vb.Drzava;
                p.BankovniRacuni = (IList<BankovniRacun>?)vb.BankovniRacuni;
                p.BrojeviTelefona = (IList<BrojTelefona>?)vb.BrojeviTelefona;
                p.Ime = vb.Ime;
                p.Prezime = vb.Prezime;
                p.Mesto = vb.Mesto;
                p.Emailovi = (IList<Email>?)vb.Emailovi;


            }

            await session.UpdateAsync(p);
            await session.FlushAsync();
        }
        catch (Exception ex)
        {
            return "Nemoguće ažurirati fizicko lice.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return vb;
    }
    public async static Task<Result<bool, ErrorMessage>> ObrisiPravnoLiceAsync(int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            //sad da li ovde ide za sve ili cascade all nama to omogucava??
            await session.DeleteAsync(p);
            await session.FlushAsync();
        }
        catch (Exception ex)
        {
            return "Nemoguće obrisati pravno lice.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }
    public async static Task<Result<bool, ErrorMessage>> ObrisiFizickoLiceAsync(int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            //sad da li ovde ide za sve ili cascade all nama to omogucava??
            await session.DeleteAsync(p);
            await session.FlushAsync();
        }
        catch (Exception ex)
        {
            return "Nemoguće obrisati fizicko lice.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }
    public async static Task<Result<bool, ErrorMessage>> DodajBankovniRacunPravnoLiceAsync(BankovniRacunBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            BankovniRacun banka = session.Load<BankovniRacun>(brb.ID);
            p.BankovniRacuni.Add(banka);
            banka.Vlasnik = p;

            await session.SaveOrUpdateAsync(p);
            await session.SaveOrUpdateAsync(banka);
            await session.FlushAsync();
        }
        catch (Exception ex)
        {
            return "Nemoguće dodati bankovni racun.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;

    }

    public async static Task<Result<bool, ErrorMessage>> DodajBankovniRacunFizickoLiceAsync(BankovniRacunBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            BankovniRacun banka = session.Load<BankovniRacun>(brb.ID);
            p.BankovniRacuni.Add(banka);
            banka.Vlasnik = p;

            await session.SaveOrUpdateAsync(p);
            await session.SaveOrUpdateAsync(banka);
            await session.FlushAsync();
        }
        catch (Exception ex)
        {
            return "Nemoguće dodati bankovni racun.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;

    }
    public static void DodajEmailPravnoLice(EmailBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            Email email = session.Load<Email>(brb.ID);
            p.Emailovi.Add(email);
            email.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(email);

            session.Flush();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajEmailFizickoLice(EmailBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            Email email = session.Load<Email>(brb.ID);
            p.Emailovi.Add(email);
            email.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(email);

            session.Flush();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajBrTelPravnoLice(BrojTelefonaBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            BrojTelefona brtel = session.Load<BrojTelefona>(brb.ID);
            p.BrojeviTelefona.Add(brtel);
            brtel.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(brtel);

            session.Flush();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajBrTelFizickoLice(BrojTelefonaBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            BrojTelefona brtel = session.Load<BrojTelefona>(brb.ID);
            p.BrojeviTelefona.Add(brtel);
            brtel.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(brtel);

            session.Flush();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajNekretninuPravnoLice(NekretninaBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            PravnoLice p = session.Load<PravnoLice>(id);
            Nekretnina nekretnina = session.Load<Nekretnina>(brb.ID);
            p.Nekretnine.Add(nekretnina);
            nekretnina.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(nekretnina);

            session.Flush();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

    }
    public static void DodajNekretninuFizickoLice(NekretninaBasic brb, int id)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            FizickoLice p = session.Load<FizickoLice>(id);
            Nekretnina nekretnina = session.Load<Nekretnina>(brb.ID);
            p.Nekretnine.Add(nekretnina);
            nekretnina.Vlasnik = p;

            session.SaveOrUpdate(p);
            session.SaveOrUpdate(nekretnina);

            session.Flush();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

    }


    #endregion


    #region Poslovnica i Kvart
    public static void DodajPoslovnicu(PoslovnicaBasic p)
    {
        ISession session = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Poslovnica o = new Poslovnica();

            o.Adresa = p.Adresa;
            o.RadnoVreme= p.RadnoVreme;
            

            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }
    }

    public static List<PoslovnicaPregled> GetPoslovnicaPregled()
    {
        ISession session = null;
        List<PoslovnicaPregled> poslovnicainfo = new List<PoslovnicaPregled>();

        try
        {
            session = DataLayer.GetSession();

            IEnumerable<Poslovnica> poslovnice = from v in session.Query<Poslovnica>() select v;

            foreach (Poslovnica v in poslovnice)
            {
                poslovnicainfo.Add(new PoslovnicaPregled(v.Adresa, v.RadnoVreme));
            }

        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

        return poslovnicainfo;
    }


    public static void DodajKvart(KvartBasic k)
    {   ISession session = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Kvart o = new Kvart();

            o.Zona = k.Zona;
            o.Naziv = k.Naziv;


            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }
    }

    public static List<NekretninaPregled> VratiNekretnineKvarta(string naziv)
    {
        List<NekretninaPregled> vp = new List<NekretninaPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Nekretnina> nekretnine = from v in s.Query<Nekretnina>()
                                         where v.Kvart.Naziv == naziv
                                         select v;

            foreach (var n in nekretnine)
            {
                vp.Add(new NekretninaPregled(n.ID, n.TipNekretnine, n.KucniBroj, n.ImeUlice, n.Kvadratura, n.BrojKupatila, n.BrojTerasa,
                    n.BrojSoba, n.Internet, n.TV, n.Kuhinja, n.Dimenzije, n.TipKreveta));
                   
            }


            s.Close();

        }
        catch (Exception ec)
        {
            throw;
        }

        return vp;
    }


    public static List<KvartPregled> GetKvartPregled()
    {
        ISession session = null;
        List<KvartPregled> kvartinfo = new List<KvartPregled>();

        try
        {
            session = DataLayer.GetSession();

            IEnumerable<Kvart> kvartovi = from v in session.Query<Kvart>() select v;

            foreach (Kvart v in kvartovi)
            {
                kvartinfo.Add(new KvartPregled(v.Naziv, v.Zona));
            }

        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

        return kvartinfo;
    }



    #endregion

    #region Najam

    //dodaj najam, da li moze ovako?

    public async static Task<Result<bool, ErrorMessage>> DodajNajamAsync(NajamBasic nb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            // Učitavanje agenta iz baze podataka
            //Agent a = session.Load<Agent>(nb.AgentId);

            // Kreiranje instance najma
            Najam n = new Najam
            {
                ID = nb.ID,
                DatumOd = nb.DatumOd,
                DatumDo = nb.DatumDo,
                CenaPoDanu = nb.CenaPoDanu,
                BrojDana = nb.BrojDana,
                Popust = nb.Popust,
                Provizija = nb.Provizija,
                //Agent = a
            };

            // Spremanje najma u bazu podataka
            await session.SaveOrUpdateAsync(n);
            await session.FlushAsync();
        }
        catch (Exception ec)
        {
            return "Nemoguće dodati najam.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> DodajImaNajamAsync(ImaNajamBasic inb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            // Učitavanje najma i nekretnine iz baze podataka
            Najam najam = session.Load<Najam>(inb.Najam.ID);
            Nekretnina nekretnina = session.Load<Nekretnina>(inb.Nekretnina.ID);

            // Kreiranje instance ImaNajam
            ImaNajam inajam = new ImaNajam
            {
                Najam = najam,
                Nekretnina = nekretnina
            };

            // Spremanje ili ažuriranje ImaNajam u bazi podataka
            await session.SaveOrUpdateAsync(inajam);
            await session.FlushAsync();
        }
        catch (Exception ec)
        {
            return "Nemoguće dodati ImaNajam.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return true;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiNajamAsync(int najamId)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Najam najam = session.Load<Najam>(najamId);

            najam.ListaNajmova.Clear(); //???? treba

            /*ImaNajam imanajam = (from im in session.Query<ImaNajam>()
                                 where im.Najam.ID == najamId
                                 select im).FirstOrDefault();*/

            //ImaNajam imn = session.Load<ImaNajam>(najam.ListaNajmova);

            //imn.Najam = null;
            //imn.Nekretnine = null;
            //session.SaveOrUpdate(imn);
            //session.Flush();

            await session.DeleteAsync(najam);
            await session.FlushAsync();
        }
        catch (Exception ec)
        {
            //throw;
            return "Nemoguće obrisati najam sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }

    public async static Task<Result<NajamBasic, ErrorMessage>> AzurirajNajamAsync(NajamBasic nb)
    {
        ISession session = null;

        try
        {
            session = DataLayer.GetSession();

            Najam najam = session.Load<Najam>(nb.ID);
            Agent agent = session.Load<Agent>(nb.Agent);
          
          

            najam.DatumOd = nb.DatumOd;
            najam.DatumDo = nb.DatumDo;
            najam.CenaPoDanu = nb.CenaPoDanu;
            najam.BrojDana = nb.BrojDana;
            najam.Popust = nb.Popust;
            najam.Provizija = nb.Provizija;
            najam.Agent = agent;

            await session.UpdateAsync(najam);
            await session.FlushAsync();
        }
        catch (Exception)
        {
            //throw;
            return "Nemoguće ažurirati Najam.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return nb;
    }
    public static Result<List<NajamPregled>, ErrorMessage> GetNajamPregled()
    {
        ISession session = null;
        List<NajamPregled> najaminfo = new List<NajamPregled>();

        try
        {
            session = DataLayer.GetSession();

            IEnumerable<Najam> najmovi = from v in session.Query<Najam>() select v;

            foreach (Najam v in najmovi)
            {
                najaminfo.Add(new NajamPregled(v.ID, v.DatumDo, v.DatumDo, v.CenaPoDanu, v.BrojDana, v.Popust, v.Provizija));
            }

        }
        catch (Exception ex)
        {
            throw;
        }
        finally
        {
            session.Close();
        }

        return najaminfo;
    }


    #endregion

    #region Sef 
    public static void dodajSefa(SefBasic p)
    {    ISession session = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Sef o = new Sef();

            o.DatumPostavljanja = p.DatumPostavljanja;
            o.DatumZaposlenja = p.DatumZaposlenja;
            o.Ime=p.Ime;
            o.JMBG=p.JMBG;


            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            throw;
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static SefBasic azurirajSefa(SefBasic p)
    {    ISession session = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Sef o = s.Load<Sef>(p.JMBG);
            o.DatumPostavljanja=p.DatumPostavljanja;
            o.DatumZaposlenja=p.DatumZaposlenja;
            o.Ime=p.Ime;
            

           
            s.Update(o);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            throw;
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return p;
    }

    public static SefPregled vratiSefa(string JMBG)
    {    ISession session = null;
         SefPregled pb = new SefPregled();
        try
        {
            ISession s = DataLayer.GetSession();

            Sef o = s.Load<Sef>(JMBG);
            pb = new SefPregled(o.Ime,o.JMBG,o.DatumZaposlenja,o.DatumPostavljanja);

            s.Close();
        }
        catch (Exception ec)
        {
            throw;
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return pb;
    }




    #endregion


    #region Agent

    public static void dodajAgenta(AgentBasic p)
    {   ISession session = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Agent o = new Agent();

            o.StrucnaSprema=p.StrucnaSprema;


        
            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            throw;
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }
    }

    public static AgentBasic azurirajAgenta(AgentBasic p)
    {   ISession session = null;
        try
        {
            ISession s = DataLayer.GetSession();

            Agent o = s.Load<Agent>(p.JMBG);
            o.StrucnaSprema = p.StrucnaSprema;



            s.Update(o);
            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            throw;
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return p;
    }

    public static AgentPregled vratiAgenta(string JMBG)
    {   ISession session = null;
        AgentPregled pb = new AgentPregled();
        try
        {
            ISession s = DataLayer.GetSession();

            Agent o = s.Load<Agent>(JMBG);
            
            pb= new AgentPregled(o.Ime,o.JMBG,o.DatumZaposlenja,o.StrucnaSprema);
            s.Close();
        }
        catch (Exception ec)
        {
            throw;
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return pb;
    }



    #endregion

    #region SpoljniRadnik

    public async static Task<Result<bool, ErrorMessage>> dodajSpoljnogRadnikaAsync(SpoljniRadnikBasic p)
    {   ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            SpoljniRadnik o = new SpoljniRadnik();

            o.DatumAngazovanja = p.DatumAngazovanja;
            o.Procenat=p.Procenat;
            o.BrojTelefona=p.BrojTelefona;
            o.Ime=p.Ime;


            await session.SaveOrUpdateAsync(o);
            await session.FlushAsync();
        }
        catch (Exception ec)
        {
            return "Nemoguće dodati radnika.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return true;
    }

    public async static Task<Result<SpoljniRadnikBasic, ErrorMessage>> azurirajRadnikaAsync(SpoljniRadnikBasic p)
    {   ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            SpoljniRadnik o = session.Load<SpoljniRadnik>(p.Id);
            o.DatumAngazovanja = p.DatumAngazovanja;
            o.Procenat = p.Procenat;
            o.BrojTelefona = p.BrojTelefona;
            o.Ime = p.Ime;


            await session.UpdateAsync(o);
            await session.FlushAsync();
        }
        catch (Exception)
        {
            //throw;
            return "Nemoguće ažurirati radnika.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return p;
    }

    public static Result<SpoljniRadnikPregled, ErrorMessage> vratiRadnika(int id)
    {   ISession session = null;
        SpoljniRadnikPregled pb = new SpoljniRadnikPregled();
        try
        {
            ISession s = DataLayer.GetSession();

            SpoljniRadnik o = s.Load<SpoljniRadnik>(id);
            pb = new SpoljniRadnikPregled(o.Id,o.BrojTelefona,o.Ime,o.DatumAngazovanja,o.Procenat);

            s.Close();
        }
        catch (Exception ec)
        {
            throw;
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return pb;
    }

    public async static Task<Result<bool, ErrorMessage>> ObrisiRadnikaAsync(int radnikId)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            SpoljniRadnik radnik = session.Load<SpoljniRadnik>(radnikId);

            radnik.Angazovanja.Clear();

            await session.DeleteAsync(radnik);
            await session.FlushAsync();
        }
        catch (Exception ec)
        {
            //throw;
            return "Nemoguće obrisati radnika sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }



    #endregion


    #region Parking

    public async static Task<Result<bool, ErrorMessage>> dodajParking(ParkingBasic p, int idnekretnine)
    {   ISession session = null;
        try
        {
            session = DataLayer.GetSession();
            Nekretnina nekretnina = session.Load<Nekretnina>(idnekretnine);

            Parking o = new Parking();

            o.Cena=p.Cena;
            o.Javni=p.Javni;
            o.Nekretnina = nekretnina;


            await session.SaveOrUpdateAsync(o);
            await session.FlushAsync();
        }
        catch (Exception ec)
        {
            return "Nemoguće dodati Parking.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return true;
    }

    public async static Task<Result<ParkingBasic, ErrorMessage>> azurirajParkingAsync(ParkingBasic p)
    {   ISession session = null;
        
        try
        {
            session = DataLayer.GetSession();

            Parking o = session.Load<Parking>(p.ID);
            o.ID=p.ID;
            o.Cena=p.Cena;
            o.Javni=p.Javni;
            Nekretnina n = session.Load<Nekretnina>(p.Nekretnina.ID);
            o.Nekretnina=n;

            await session.UpdateAsync(o);
            await session.FlushAsync();
        }
        catch (Exception)
        {
            //throw;
            return "Nemoguće ažurirati Parking.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return p;
    }

    public static Result<ParkingPregled, ErrorMessage> vratiParking(int id)
    {   ISession session = null;
        ParkingPregled pb = new ParkingPregled();
        try
        {
            session = DataLayer.GetSession();

            Parking o = session.Load<Parking>(id);
            Nekretnina n = session.Load<Nekretnina>(o.Nekretnina.ID);
            //ne pronalazi nekretninu???

            NekretninaPregled nb=new NekretninaPregled(n.ID,n.TipNekretnine,n.KucniBroj,n.ImeUlice,n.Kvadratura,
                                                    n.BrojKupatila,n.BrojTerasa,n.BrojSoba,n.Internet,n.TV,n.Kuhinja,
                                                    n.Dimenzije,n.TipKreveta);
            pb = new ParkingPregled(o.ID, o.Cena,o.Javni, nb);

            session.Close();
        }
        catch (Exception ec)
        {
            return ("Nije moguce vratiti parking zbog: " + ec.ToString()).ToError(400);
        }
        finally
        {
            if (session != null)
            {
                session.Close();
            }
        }

        return pb;
    }

    public async static Task<Result<bool, ErrorMessage>> obrisiParkingAsync(int parkingId)
    {
        ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Parking parking = session.Load<Parking>(parkingId);

            await session.DeleteAsync(parking);
            await session.FlushAsync();
        }
        catch (Exception ec)
        {
            //throw;
            return "Nemoguće obrisati parking sa zadatim ID-jem.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }

        return true;
    }


    #endregion


    #region DodatnaOprema

    public static void obrisiDodatnuOpremu(int id)
    {   ISession session = null;
        try
        {
            ISession s = DataLayer.GetSession();

            DodatnaOprema dodatna = s.Load<DodatnaOprema>(id);

            s.Delete(dodatna);
            s.Flush();



            s.Close();

        }
        catch (Exception ec)
        {
            //handle exceptions
        }


    }

    public static DodatnaOpremaPregled vratiDodatnuOpremu(int id)
    {   ISession session = null;
        DodatnaOpremaPregled o = new DodatnaOpremaPregled();
        try
        {
            ISession s = DataLayer.GetSession();

            DodatnaOprema oprema = s.Load<DodatnaOprema>(id);

            o=new DodatnaOpremaPregled(oprema.ID,oprema.Tip,oprema.Cena);
        


            s.Close();

        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return o;

    }

    public static List<DodatnaOpremaPregled> vratiOpremuNekretnine(int nekretninaid)
    {   ISession session = null;
        List<DodatnaOpremaPregled> info = new List<DodatnaOpremaPregled>();
        try
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<DodatnaOprema> dodatnaoprema = from o in s.Query<DodatnaOprema>()
                                                      where o.Nekretnina.ID == nekretninaid
                                                       select o;

            foreach (DodatnaOprema o in dodatnaoprema)
            {
                info.Add(new DodatnaOpremaPregled(o.ID, o.Tip,o.Cena));
            }

            s.Close();

        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return info;
    }
    public static void izmeniDodatnuOpremu(DodatnaOpremaBasic dodatnaoprema)
    {   ISession session = null;
        try
        {
            ISession s = DataLayer.GetSession();

           DodatnaOprema o = s.Load<DodatnaOprema>(dodatnaoprema.ID);

            o.Cena = dodatnaoprema.Cena;
            o.Tip=dodatnaoprema.Tip;
            



            s.SaveOrUpdate(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }
    }


    public static void sacuvajDodatnuOpremu(DodatnaOpremaBasic dodatnaoprema)
    {   ISession session = null;
        try 
        {
            ISession s = DataLayer.GetSession();

            DodatnaOprema o = new DodatnaOprema();

            o.Cena=dodatnaoprema.Cena;
            o.Tip = dodatnaoprema.Tip;

           Nekretnina p = s.Load<Nekretnina>(dodatnaoprema.Nekretnina.ID);
           

            s.Save(o);

            s.Flush();

            s.Close();
        }
        catch (Exception ec)
        {
            //handle exceptions
        }
    }


    #endregion

    #region Sajtovi
    public static SajtoviPregled VratiSajtoveP(int id)
    {  
         ISession session = null;
        SajtoviPregled o = new SajtoviPregled();
        try
        {
            session = DataLayer.GetSession();

            Sajtovi sajt = session.Load<Sajtovi>(id);
            o = new SajtoviPregled(sajt.ID,sajt.Sajt);


            session.Close();

        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return o;

    }
    
    public async static Task<Result<bool, ErrorMessage>> DodajSajtoveBasic(SajtoviBasic sb)
    {   ISession session = null;
        try 
        {
            session = DataLayer.GetSession();

            Sajtovi o = new Sajtovi();

            o.Sajt=sb.Sajt;
           

           Nekretnina p = session.Load<Nekretnina>(sb.Nekretnina.ID);
           o.ID = sb.ID;
           o.Nekretnina=p;
           p.Sajtovi.Add(o);

            await session.SaveAsync(o);
            await session.SaveOrUpdateAsync(p);
            await session.FlushAsync();
        }
        catch (Exception ec)
        {
            return "Nemoguće dodati sajt.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return true;
        
    }
    public static Result<List<SajtoviPregled>, ErrorMessage>  vratiSajtoveNekretnine(int nekretninaid)
    {   
        ISession session = null;
        List<SajtoviPregled> info = new List<SajtoviPregled>();
        try
        {
            session = DataLayer.GetSession();

            IEnumerable<Sajtovi> sajtovi = from o in session.Query<Sajtovi>()
                                                      where o.Nekretnina.ID == nekretninaid
                                                       select o;

            foreach (Sajtovi o in sajtovi)
            {
                info.Add(new SajtoviPregled(o.ID, o.Sajt));
            }

            session.Close();

        }
        catch (Exception ec)
        {
            //handle exceptions
        }

        return info;
    }
    public async static Task<Result<SajtoviBasic, ErrorMessage>> izmeniSajt(SajtoviBasic sb)
    {   ISession session = null;
        try
        {
            session = DataLayer.GetSession();

           Sajtovi o = session.Load<Sajtovi>(sb.ID);
           Nekretnina n = session.Load<Nekretnina>(sb.Nekretnina.ID);

           o.Sajt=sb.Sajt;
           o.Nekretnina=n;

            await session.UpdateAsync(o);
            await session.UpdateAsync(n);
            await session.FlushAsync();
        }
        catch (Exception ec)
        {
            return "Nemoguće izmeniti sajt.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return sb;
    }
     public async static Task<Result<bool, ErrorMessage>> obrisiSajt(int id)
    {   ISession session = null;
        try
        {
            session = DataLayer.GetSession();

            Sajtovi sajt = session.Load<Sajtovi>(id);

            await session.DeleteAsync(sajt);
            await session.FlushAsync();

        }
        catch (Exception ec)
        {
            return "Nemoguće obrisati sajt.".ToError(400);
        }
        finally
        {
            session?.Close();
            session?.Dispose();
        }
        return true;


    }
 
#endregion
}


