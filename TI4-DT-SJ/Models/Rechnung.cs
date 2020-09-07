using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Rechnung : Dictionaryable
  {
    public int id;
    public int abo_id;
    public int anbieter_id;
    public int termin_id;
    public string rechnungs_nr;
    public float betrag;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"abo_id", this.abo_id},
          {"anbieter_id", this.anbieter_id},
          {"termin_id", this.termin_id},
          {"rechnungs_nr", this.rechnungs_nr},
          {"betrag", this.betrag}
        };
      }
    }

    public Abo abo;
    public Termin termin;
    public Anbieter anbieter;

    public Rechnung(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.abo_id = reader.GetInt32(1);
        this.anbieter_id = reader.GetInt32(2);
        this.termin_id = reader.GetInt32(3);
        this.rechnungs_nr = reader.GetString(4);
        this.betrag = reader.GetFloat(5);
      }
    }

    public Rechnung(int abo_id, int anbieter_id, int termin_id, string rechnungs_nr, float betrag)
    {
      this.abo_id = abo_id;
      this.anbieter_id = anbieter_id;
      this.termin_id = termin_id;
      this.rechnungs_nr = rechnungs_nr;
      this.betrag = betrag;
    }

    public Rechnung(int id, int abo_id, int anbieter_id, int termin_id, string rechnungs_nr, float betrag)
    {
      this.id = id;
      this.abo_id = abo_id;
      this.anbieter_id = anbieter_id;
      this.termin_id = termin_id;
      this.rechnungs_nr = rechnungs_nr;
      this.betrag = betrag;
    }

    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id = Database.Instance.insertCommand("rechnung", values);
      return this.id;
    }

    public void Update()
    {
      Database.Instance.updateCommand("rechnung", this.id, this.ValuesAsDict);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("rechnung", this.id);
    }

    public static Rechnung Select(int id)
    {
      Rechnung model = (Rechnung)Database.Instance.selectCommand("rechnung", id, typeof(Rechnung));
      model.anbieter = Anbieter.Select(model.id);
      if (model.abo_id != 0) model.abo = Abo.Select(model.abo_id);
      if (model.termin_id != 0) model.termin = Termin.Select(model.termin_id);
      return model;
    }
  }
}
