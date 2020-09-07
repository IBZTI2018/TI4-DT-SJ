using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Anrede : Dictionaryable
  {
    public int id;
    public string bezeichnung;

    public Dictionary<String, dynamic> ValuesAsDict
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
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.bezeichnung = reader.GetString(1);
      }
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

    public void Delete()
    {
      Database.Instance.deleteCommand("anrede", this.id);
    }

    public static Anrede Select(int id)
    {
      return (Anrede)Database.Instance.selectCommand("anrede", id, typeof(Anrede));
    }

    public static List<Anrede> List()
    {
      List<Anrede> models = new List<Anrede>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM anrede;").ExecuteReader();
      while (reader.Read()) models.Add(new Anrede(reader));
      reader.Close();
      return models;
    }
  }
}
