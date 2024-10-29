using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanNaDan.Entiteti;
using FluentNHibernate.Mapping;

namespace StanNaDan.Mapiranja;

public class AgentMapiranja : SubclassMap<StanNaDan.Entiteti.Agent>
{
    public AgentMapiranja()
    {
        Table("AGENT"); //FOREIGN KEY(JMBG) REFERENCES ZAPOSLEN(JMBG) && JMBG VARCHAR(13) PRIMARY KEY,

        KeyColumn("JMBG");



        Map(x => x.StrucnaSprema, "STRUCNA_SPREMA");


        //strani kljuc ka zaposlenoom
        HasMany(x => x.Angazovanja).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();

        HasMany(x => x.Najmovi).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();






        //        CREATE TABLE AGENT(
        // JMBG VARCHAR(13) PRIMARY KEY,
        // STRUCNA_SPREMA VARCHAR(255),
        // FOREIGN KEY(JMBG) REFERENCES ZAPOSLEN(JMBG)
        //);

    }

}
