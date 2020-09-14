using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models {
  public class TerminView : Dictionaryable {
    public int id;
    public DateTime datum;
    public string vorname;
    public string nachname;
    public string standort;
    public int standplatz_nr;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id},
          {"datum", this.datum},
          {"vorname", this.vorname},
          {"nachname", this.nachname},
          {"standort", this.standort},
          {"standplatz_nr", this.standplatz_nr}
        };
      }
    }

    public TerminView() { }

    public TerminView(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.datum = reader.GetDateTime(1);
        this.vorname = reader.GetString(2);
        this.nachname = reader.GetString(3);
        this.standort = reader.GetString(4);
        this.standplatz_nr = reader.GetInt32(5);
      }
    }


    public static List<TerminView> List(string where = "")
    {
      List<TerminView> models = new List<TerminView>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM view_termin " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new TerminView(reader));
      }
      reader.Close();
      return models;
    }
  }
}
