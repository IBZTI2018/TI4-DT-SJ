using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Qualitaetsbewertung : Dictionaryable
  {
    public int id;
    public int anbieter_id;
    public int qualitaetspruefer_id;
    public string bezeichnung;
    public DateTime datum;
    public double stunden;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"anbieter_id", this.anbieter_id},
          {"qualitaetspruefer_id", this.qualitaetspruefer_id},
          {"bezeichnung", this.bezeichnung},
          {"datum", this.datum},
          {"stunden", this.stunden}
        };
      }
    }

    public Anbieter anbieter;
    public Qualitaetspruefer qualitaetspruefer;

    public Qualitaetsbewertung() { }

    public Qualitaetsbewertung(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.anbieter_id = reader.GetInt32(1);
        this.qualitaetspruefer_id = reader.GetInt32(2);
        this.bezeichnung = reader.GetString(3);
        this.datum = reader.GetDateTime(4);
        this.stunden = reader.GetDouble(5);
      }
    }

    public Qualitaetsbewertung(int anbieter_id, int qualitaetspruefer_id, string bezeichnung, DateTime datum, float stunden)
    {
      this.anbieter_id = anbieter_id;
      this.qualitaetspruefer_id = qualitaetspruefer_id;
      this.bezeichnung = bezeichnung;
      this.datum = datum;
      this.stunden = stunden;
    }

    public Qualitaetsbewertung(int id, int anbieter_id, int qualitaetspruefer_id, string bezeichnung, DateTime datum, float stunden)
    {
      this.id = id;
      this.anbieter_id = anbieter_id;
      this.qualitaetspruefer_id = qualitaetspruefer_id;
      this.bezeichnung = bezeichnung;
      this.datum = datum;
      this.stunden = stunden;
    }

    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id = Database.Instance.insertCommand("qualitaetsbewertung", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      Database.Instance.updateCommand("qualitaetsbewertung", this.id, values);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("qualitaetsbewertung", this.id);
    }

    public static Qualitaetsbewertung Select(int id)
    {
      Qualitaetsbewertung model = (Qualitaetsbewertung)Database.Instance.selectCommand("qualitaetsbewertung", id, typeof(Qualitaetsbewertung));
      model.qualitaetspruefer = Qualitaetspruefer.Select(model.qualitaetspruefer_id);
      model.anbieter = Anbieter.Select(model.anbieter_id);
      return model;
    }
  }
}
