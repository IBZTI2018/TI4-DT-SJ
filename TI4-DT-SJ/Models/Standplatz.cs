using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Standplatz
  {
    public int id;
    public int standort_id;
    public int standplatz_nr;

    public Standort standort;

    public Standplatz(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.standort_id = reader.GetInt32(1);
      this.standplatz_nr = reader.GetInt32(2);
    }

    public Standplatz(int standort_id, int standplatz_nr)
    {
      this.standort_id = standort_id;
      this.standplatz_nr = standplatz_nr;
    }

    public Standplatz(int id, int standort_id, int standplatz_nr)
    {
      this.id = id;
      this.standort_id = standort_id;
      this.standplatz_nr = standplatz_nr;
    }

    public int Insert()
    {
      return Database.Instance.insertCommand("standplatz", new Dictionary<String, dynamic>() {
        {"standort_id", this.standort_id},
        {"standplatz_nr", this.standplatz_nr}
      });
    }

    public static Standplatz Select(int id)
    {
      Standplatz model = (Standplatz)Database.Instance.selectCommand("standplatz", id, typeof(Standplatz));
      model.standort = Standort.Select(model.standort_id);
      return model;
    }
  }
}
