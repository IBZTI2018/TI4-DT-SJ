using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models {
  public class RechnungView : Dictionaryable {
    public int id;
    public string rechnungs_nr;
    public double betrag;
    public string vorname;
    public string nachname;
    public string bezeichnung;
    public DateTime datum;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id},
          {"rechnungs_nr", this.rechnungs_nr},
          {"betrag", this.betrag},
          {"vorname", this.vorname},
          {"nachname", this.nachname},
          {"bezeichnung", this.bezeichnung},
          {"datum", this.datum}
        };
      }
    }

    public RechnungView() { }

    public RechnungView(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.rechnungs_nr = reader.GetString(1);
        this.betrag = reader.GetDouble(2);
        this.vorname = reader.GetString(3);
        this.nachname = reader.GetString(4);
        this.bezeichnung = reader.GetString(5);
        if (!reader.IsDBNull(6)) this.datum = reader.GetDateTime(6);
      }
    }


    public static List<RechnungView> List(string where = "")
    {
      List<RechnungView> models = new List<RechnungView>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM view_rechnung " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new RechnungView(reader));
      }
      reader.Close();
      return models;
    }
  }
}
