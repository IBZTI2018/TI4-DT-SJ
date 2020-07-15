using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Aboart
  {
    public int id;
    public string bezeichnung;
    public float gebuehr;

    public Aboart(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.bezeichnung = reader.GetString(1);
      this.gebuehr = reader.GetFloat(2);
    }

    public Aboart(string bezeichnung, float gebuehr)
    {
      this.bezeichnung = bezeichnung;
      this.gebuehr = gebuehr;
    }

    public Aboart(int id, string bezeichnung, float gebuehr)
    {
      this.id = id;
      this.bezeichnung = bezeichnung;
      this.gebuehr = gebuehr;
    }

    public int Insert()
    {
      return Database.Instance.insertCommand("aboart", new Dictionary<String, dynamic>() {
        {"bezeichnung", this.bezeichnung},
        {"gebuehr", this.gebuehr}
      });
    }

    public static Aboart Select(int id)
    {
      return (Aboart)Database.Instance.selectCommand("aboart", id, typeof(Aboart));
    }
  }
}
