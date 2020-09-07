using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Termin : Dictionaryable
  {
    public int id;
    public int standplatz_id;
    public int anbieter_id;
    public DateTime datum;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
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
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.standplatz_id = reader.GetInt32(1);
        this.anbieter_id = reader.GetInt32(2);
        this.datum = reader.GetDateTime(3);
      }
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
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id = Database.Instance.insertCommand("termin", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      Database.Instance.updateCommand("termin", this.id, values);
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

    public static List<Termin> List()
    {
      List<Termin> models = new List<Termin>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM termin;").ExecuteReader();
      while (reader.Read()) models.Add(new Termin(reader));
      reader.Close();
      return models;
    }
  }
}
