using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDan.Entiteti;

//CREATE TABLE SEF (
// DATUM_POSTAVLJANJA DATE,
// JMBG VARCHAR(13),
// PRIMARY KEY(JMBG),
// FOREIGN KEY(JMBG) REFERENCES ZAPOSLEN(JMBG)
//);


public class Sef : Zaposlen
{
    public virtual DateTime DatumPostavljanja { get; set; }




}