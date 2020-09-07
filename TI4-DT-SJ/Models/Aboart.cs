using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Aboart : Dictionaryable
  {
    public int id;
    public string bezeichnung;
    public float gebuehr;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"bezeichnung", this.bezeichnung},
          {"gebuehr", this.gebuehr}
        };
      }
    }

    public Aboart(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.bezeichnung = reader.GetString(1);
        this.gebuehr = reader.GetFloat(2);
      }
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
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id = Database.Instance.insertCommand("aboart", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      Database.Instance.updateCommand("aboart", this.id, values);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("aboart", this.id);
    }

    public static Aboart Select(int id)
    {
      return (Aboart)Database.Instance.selectCommand("aboart", id, typeof(Aboart));
    }
  }
}
