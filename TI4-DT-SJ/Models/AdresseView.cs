using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models {
  public class AdresseView : Dictionaryable {
    public int id;
    public string strassenname;
    public int hausnummer;
    public int plz;
    public string ort;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id},
          {"strassenname", this.strassenname},
          {"hausnummer", this.hausnummer},
          {"plz", this.plz},
          {"ort", this.ort}
        };
      }
    }

    public AdresseView() { }

    public AdresseView(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.strassenname = reader.GetString(1);
        this.hausnummer = reader.GetInt32(2);
        this.plz = reader.GetInt32(3);
        this.ort = reader.GetString(4);
      }
    }


    public static List<AdresseView> List(string where = "")
    {
      List<AdresseView> models = new List<AdresseView>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM view_adresse " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new AdresseView(reader));
      }
      reader.Close();
      return models;
    }
  }
}
