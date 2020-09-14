using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models {
  public class StandplatzView : Dictionaryable {
    public int id;
    public int standplatz_nr;
    public string standort;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id},
          {"standplatz_nr", this.standplatz_nr},
          {"standort", this.standort}
        };
      }
    }

    public StandplatzView() { }

    public StandplatzView(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.standplatz_nr = reader.GetInt32(1);
        this.standort = reader.GetString(2);
      }
    }


    public static List<StandplatzView> List(string where = "")
    {
      List<StandplatzView> models = new List<StandplatzView>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM view_standplatz " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new StandplatzView(reader));
      }
      reader.Close();
      return models;
    }
  }
}
