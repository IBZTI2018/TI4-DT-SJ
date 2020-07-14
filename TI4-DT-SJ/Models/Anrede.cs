using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Anrede
  {
    public int id;
    public string bezeichnung;

    public Anrede(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.bezeichnung = reader.GetString(1);
    }

    public Anrede(int id, string bezeichnung)
    {
      this.id = id;
      this.bezeichnung = bezeichnung;
    }

    public int Insert()
    {
      return Database.Instance.insertCommand("anrede", new Dictionary<String, dynamic>() {
        {"id", this.id},
        {"bezeichnung", this.bezeichnung}
      });
    }
  }
}
