using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Anrede
  {
    public int id;
    public string bezeichnung;

    private Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id},
          {"bezeichnung", this.bezeichnung}
        };
      }
    }

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
      this.id = Database.Instance.insertCommand("anrede", this.ValuesAsDict);
      return this.id;
    }

    public void Update()
    {
      Database.Instance.updateCommand("anrede", this.id, this.ValuesAsDict);
    }

    public static Anrede Select(int id)
    {
      return (Anrede)Database.Instance.selectCommand("anrede", id, typeof(Anrede));
    }
  }
}
