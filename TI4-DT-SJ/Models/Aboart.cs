using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Aboart : Dictionaryable
  {
    public int id;
    public string bezeichnung;
    public double gebuehr;
    public int monate;
    public int standorte;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"bezeichnung", this.bezeichnung},
          {"gebuehr", this.gebuehr},
          {"monate", this.monate},
          {"standorte", this.standorte}
        };
      }
    }

    public Aboart() { }

    public Aboart(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.bezeichnung = reader.GetString(1);
        this.gebuehr = reader.GetDouble(2);
        this.monate = reader.GetInt32(3);
        this.standorte = reader.GetInt32(4);
      }
    }

    public Aboart(string bezeichnung, float gebuehr, int monate, int standorte)
    {
      this.bezeichnung = bezeichnung;
      this.gebuehr = gebuehr;
      this.monate = monate;
      this.standorte = standorte;
    }

    public Aboart(int id, string bezeichnung, float gebuehr, int monate, int standorte)
    {
      this.id = id;
      this.bezeichnung = bezeichnung;
      this.gebuehr = gebuehr;
      this.monate = monate;
      this.standorte = standorte;
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

    public static List<Aboart> List()
    {
      List<Aboart> models = new List<Aboart>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM aboart;").ExecuteReader();
      while (reader.Read()) models.Add(new Aboart(reader));
      reader.Close();
      return models;
    }
  }
}
