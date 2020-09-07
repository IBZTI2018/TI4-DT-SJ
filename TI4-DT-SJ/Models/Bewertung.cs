using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Bewertung : Dictionaryable
  {
    public int id;
    public int anbieter_id;
    public int nachfrager_id;
    public string bezeichnung;
    public float score;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"anbieter_id", this.anbieter_id},
          {"nachfrager_id", this.nachfrager_id},
          {"bezeichnung", this.bezeichnung},
          {"score", this.score}
        };
      }
    }

    public Anbieter anbieter;
    public Nachfrager nachfrager;

    public Bewertung(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.anbieter_id = reader.GetInt32(1);
        this.nachfrager_id = reader.GetInt32(2);
        this.bezeichnung = reader.GetString(3);
        this.score = reader.GetFloat(4);
      }
    }

    public Bewertung(int anbieter_id, int nachfrager_id, string bezeichnung, float score)
    {
      this.anbieter_id = anbieter_id;
      this.nachfrager_id = nachfrager_id;
      this.bezeichnung = bezeichnung;
      this.score = score;
    }

    public Bewertung(int id, int anbieter_id, int nachfrager_id, string bezeichnung, float score)
    {
      this.id = id;
      this.anbieter_id = anbieter_id;
      this.nachfrager_id = nachfrager_id;
      this.bezeichnung = bezeichnung;
      this.score = score;
    }

    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id = Database.Instance.insertCommand("bewertung", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      Database.Instance.updateCommand("bewertung", this.id, values);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("bewertung", this.id);
    }

    public static Bewertung Select(int id)
    {
      Bewertung model = (Bewertung)Database.Instance.selectCommand("bewertung", id, typeof(Bewertung));
      model.anbieter = Anbieter.Select(model.anbieter_id);
      model.nachfrager = Nachfrager.Select(model.nachfrager_id);
      return model;
    }
  }
}
