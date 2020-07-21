using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Bewertung
  {
    public int id;
    public int anbieter_id;
    public int nachfrager_id;
    public string bezeichnung;
    public float score;

    private Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
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
      this.id = reader.GetInt32(0);
      this.anbieter_id = reader.GetInt32(1);
      this.nachfrager_id = reader.GetInt32(2);
      this.bezeichnung = reader.GetString(3);
      this.score = reader.GetFloat(4);
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
      this.id = Database.Instance.insertCommand("bewertung",  this.ValuesAsDict);
      return this.id;
    }

    public void Update()
    {
      Database.Instance.updateCommand("bewertung", this.id, this.ValuesAsDict);
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
