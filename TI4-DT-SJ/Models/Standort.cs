using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Standort
  {
    public int id;
    public string bezeichnung;

    public Standort(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.bezeichnung = reader.GetString(1);
    }

    public Standort(string bezeichnung)
    {
      this.bezeichnung = bezeichnung;
    }

    public Standort(int id, string bezeichnung)
    {
      this.id = id
      this.bezeichnung = bezeichnung;
    }

    public int Insert()
    {
      return Database.Instance.insertCommand("standort", new Dictionary<String, dynamic>() {
        {"bezeichnung", this.bezeichnung}
      });
    }

    public static Standort Select(int id)
    {
      return (Standort)Database.Instance.selectCommand("standort", id, typeof(Standort));
    }
  }
}
