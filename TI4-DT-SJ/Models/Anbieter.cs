﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Anbieter
  {
    public int id;
    public int person_id;
    public DateTime aufnahmedatum;
    public DateTime prov_aufnahmedatum;
    public bool bonitaet;
    public bool unterschrift;

    public Person person;

    public Anbieter(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.person_id = reader.GetInt32(1);
      this.aufnahmedatum = reader.GetDateTime(2);
      this.prov_aufnahmedatum = reader.GetDateTime(3);
      this.bonitaet = reader.GetBoolean(4);
      this.unterschrift = reader.GetBoolean(5);
    }

    public Anbieter(int person_id, DateTime aufnahmedatum, DateTime prov_aufnahmedatum, bool bonitaet, bool unterschrift)
    {
      this.person_id = person_id;
      this.aufnahmedatum = aufnahmedatum;
      this.prov_aufnahmedatum = prov_aufnahmedatum;
      this.bonitaet = bonitaet;
      this.unterschrift = unterschrift;
    }

    public Anbieter(int id, int person_id, DateTime aufnahmedatum, DateTime prov_aufnahmedatum, bool bonitaet, bool unterschrift)
    {
      this.id = id;
      this.person_id = person_id;
      this.aufnahmedatum = aufnahmedatum;
      this.prov_aufnahmedatum = prov_aufnahmedatum;
      this.bonitaet = bonitaet;
      this.unterschrift = unterschrift;
    }

    public int Insert()
    {
      return Database.Instance.insertCommand("anbieter", new Dictionary<String, dynamic>() {
        {"id", this.id},
        {"person_id", this.person_id},
        {"aufnahmedatum", this.aufnahmedatum},
        {"prov_aufnahmedatum", this.prov_aufnahmedatum},
        {"bonitaetspruefung", this.bonitaet},
        {"unterschrift", this.unterschrift}
      });
    }

    public static Anbieter Select(int id)
    {
      return (Anbieter)Database.Instance.selectCommand("anbieter", id, typeof(Anbieter));
    }
  }
}