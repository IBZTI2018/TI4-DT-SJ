using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models {
  public class AboView : Dictionaryable {
    public int id;
    public string vorname;
    public string nachname;
    public string abotyp;
    public DateTime abschlussdatum;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id},
          {"vorname", this.vorname},
          {"nachname", this.nachname},
          {"abotyp", this.abotyp},
          {"abschlussdatum", this.abschlussdatum}
        };
      }
    }

    public AboView() { }

    public AboView(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.vorname = reader.GetString(1);
        this.nachname = reader.GetString(2);
        this.abotyp = reader.GetString(3);
        this.abschlussdatum = reader.GetDateTime(4);
      }
    }


    public static List<AboView> List(string where = "")
    {
      List<AboView> models = new List<AboView>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM view_abo " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new AboView(reader));
      }
      reader.Close();
      return models;
    }
  }
}
