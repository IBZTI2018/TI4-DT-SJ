using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Ort : Dictionaryable
  {
    public int id;
    public int plz;
    public string ort;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
        { "id", this.id },
        { "plz", this.plz },
        { "ort", this.ort }
        };
      }
    }

    public Ort() { }

    public Ort(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.plz = reader.GetInt32(1);
        this.ort = reader.GetString(2);
      }
    }

    public Ort(int plz, string ort)
    {
      this.plz = plz;
      this.ort = ort;
    }

    public Ort(int id, int plz, string ort)
    {
      this.id = id;
      this.plz = plz;
      this.ort = ort;
    }

    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id = Database.Instance.insertCommand("ort", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      Database.Instance.updateCommand("ort", this.id, values);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("ort", this.id);
    }

    public static Ort Select(int id)
    {
      return (Ort)Database.Instance.selectCommand("ort", id, typeof(Ort));
    }

    public static List<Ort> List(string where = "")
    {
      List<Ort> models = new List<Ort>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM ort " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new Ort(reader));
      }
      reader.Close();
      return models;
    }
  }
}
