using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Termin
  {
    public int id;
    public int standplatz_id;
    public int anbieter_id;
    public DateTime datum;

    public Standplatz standplatz;
    public Anbieter anbieter;

    public Termin(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.standplatz_id = reader.GetInt32(1);
      this.anbieter_id = reader.GetInt32(2);
      this.datum = reader.GetDateTime(3);
    }

    public Termin(int standplatz_id, int anbieter_id, DateTime datum)
    {
      this.standplatz_id = standplatz_id;
      this.anbieter_id = anbieter_id;
      this.datum = datum;
    }

    public Termin(int id, int standplatz_id, int anbieter_id, DateTime datum)
    {
      this.id = id;
      this.standplatz_id = standplatz_id;
      this.anbieter_id = anbieter_id;
      this.datum = datum;
    }

    public int Insert()
    {
      return Database.Instance.insertCommand("termin", new Dictionary<String, dynamic>() {
        {"standplatz_id", this.standplatz_id},
        {"anbieter_id", this.anbieter_id},
        {"datum", this.datum}
      });
    }

    public static Termin Select(int id)
    {
      return (Termin)Database.Instance.selectCommand("termin", id, typeof(Termin));
    }
  }
}
