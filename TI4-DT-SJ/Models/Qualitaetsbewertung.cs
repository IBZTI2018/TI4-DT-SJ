using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Qualitaetsbewertung
  {
    public int id;
    public int anbieter_id;
    public int qualitaetspruefer_id;
    public string bezeichnung;

    public Anbieter anbieter;
    public Qualitaetspruefer qualitaetspruefer;

    public Qualitaetsbewertung(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.anbieter_id = reader.GetInt32(1);
      this.qualitaetspruefer_id = reader.GetInt32(2);
      this.bezeichnung = reader.GetString(3);
    }

    public Qualitaetsbewertung(int anbieter_id, int qualitaetspruefer_id, string bezeichnung, float score)
    {
      this.anbieter_id = anbieter_id;
      this.qualitaetspruefer_id = qualitaetspruefer_id;
      this.bezeichnung = bezeichnung;
    }

    public Qualitaetsbewertung(int id, int anbieter_id, int qualitaetspruefer_id, string bezeichnung, float score)
    {
      this.id = id;
      this.anbieter_id = anbieter_id;
      this.qualitaetspruefer_id = qualitaetspruefer_id;
      this.bezeichnung = bezeichnung;
    }

    public int Insert()
    {
      return Database.Instance.insertCommand("qualitaetsbewertungbewertung", new Dictionary<String, dynamic>() {
        {"anbieter_id", this.anbieter_id},
        {"qualitaetspruefer_id", this.qualitaetspruefer_id},
        {"bezeichnung", this.bezeichnung}
      });
    }

    public static Qualitaetsbewertung Select(int id)
    {
      Qualitaetsbewertung model = (Qualitaetsbewertung)Database.Instance.selectCommand("qualitaetsbewertungbewertung", id, typeof(Qualitaetsbewertung));
      model.qualitaetspruefer = Qualitaetspruefer.Select(model.qualitaetspruefer_id);
      model.anbieter = Anbieter.Select(model.anbieter_id);
      return model;
    }
  }
}
