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

    private Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"standplatz_id", this.standplatz_id},
          {"anbieter_id", this.anbieter_id},
          {"datum", this.datum}
        };
      }
    }

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
      this.id = Database.Instance.insertCommand("termin", this.ValuesAsDict);
      return this.id;
    }

    public void Update()
    {
      Database.Instance.updateCommand("termin", this.id, this.ValuesAsDict);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("termin", this.id);
    }

    public static Termin Select(int id)
    {
      Termin model = (Termin)Database.Instance.selectCommand("termin", id, typeof(Termin));
      model.anbieter = Anbieter.Select(model.anbieter_id);
      model.standplatz = Standplatz.Select(model.standplatz_id);
      return model;
    }
  }
}
