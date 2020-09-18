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
    public double betrag;

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

    public Rechnung() { }

    public Rechnung(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        if (!reader.IsDBNull(1)) this.abo_id = reader.GetInt32(1);
        this.anbieter_id = reader.GetInt32(2);
        if (!reader.IsDBNull(3)) this.termin_id = reader.GetInt32(3);
        this.rechnungs_nr = reader.GetString(4);
        this.betrag = reader.GetDouble(5);
      }
    }

    public Rechnung(int abo_id, int anbieter_id, string rechnungs_nr, double betrag)
    {
      this.abo_id = abo_id;
      this.anbieter_id = anbieter_id;
      this.rechnungs_nr = rechnungs_nr;
      this.betrag = betrag;
    }

    public Rechnung(int anbieter_id, int termin_id, double betrag, string rechnungs_nr)
    {
      this.anbieter_id = anbieter_id;
      this.termin_id = termin_id;
      this.rechnungs_nr = rechnungs_nr;
      this.betrag = betrag;
    }

    public Rechnung(int id, int abo_id, int anbieter_id, int termin_id, string rechnungs_nr, double betrag)
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
      if (this.betrag == 0.0) values.Remove("betrag");
      values.Remove("id");
      if (values["termin_id"] == 0) values.Remove("termin_id");
      if (values["abo_id"] == 0) values.Remove("abo_id");
      this.id = Database.Instance.insertCommand("rechnung", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      if (this.betrag == 0.0) values.Remove("betrag");
      values.Remove("id");
      if (values["termin_id"] == 0) values.Remove("termin_id");
      if (values["abo_id"] == 0) values.Remove("abo_id");

      Database.Instance.updateCommand("rechnung", this.id, values);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("rechnung", this.id);
    }

    public static Rechnung Select(int id)
    {
      Rechnung model = (Rechnung)Database.Instance.selectCommand("rechnung", id, typeof(Rechnung));
      model.anbieter = Anbieter.Select(model.anbieter_id);
      if (model.abo_id != 0) model.abo = Abo.Select(model.abo_id);
      if (model.termin_id != 0) model.termin = Termin.Select(model.termin_id);
      return model;
    }

    public static List<Rechnung> List()
    {
      List<Rechnung> models = new List<Rechnung>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM rechnung ").ExecuteReader();
      while (reader.Read())
      {
        models.Add(new Rechnung(reader));
      }
      reader.Close();
      return models;
    }
  }
}
