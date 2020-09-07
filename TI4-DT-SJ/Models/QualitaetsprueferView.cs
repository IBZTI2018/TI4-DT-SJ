using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models {
  public class QualitaetsprueferView : Dictionaryable {
    public int id;
    public string anrede;
    public string vorname;
    public string nachname;
    public double lohn;
    public string strassenname;
    public int hausnummer;
    public int plz;
    public string ort;
    public DateTime geburtsdatum;
    public string email;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id},
          {"anrede", this.anrede},
          {"vorname", this.vorname},
          {"nachname", this.nachname},
          {"lohn", this.lohn},
          {"strassenname", this.strassenname},
          {"hausnummer", this.hausnummer},
          {"plz", this.plz},
          {"ort", this.ort},
          {"geburtsdatum", this.geburtsdatum},
          {"email", this.email}
        };
      }
    }

    public QualitaetsprueferView() { }

    public QualitaetsprueferView(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.anrede = reader.GetString(1);
        this.vorname = reader.GetString(2);
        this.nachname = reader.GetString(3);
        this.lohn = reader.GetDouble(4);
        this.strassenname = reader.GetString(5);
        this.hausnummer = reader.GetInt32(6);
        this.plz = reader.GetInt32(7);
        this.ort = reader.GetString(8);
        this.geburtsdatum = reader.GetDateTime(9);
        this.email = reader.GetString(10);
      }
    }


    public static List<QualitaetsprueferView> List(string where = "")
    {
      List<QualitaetsprueferView> models = new List<QualitaetsprueferView>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM view_qualitaetspruefer " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new QualitaetsprueferView(reader));
      }
      reader.Close();
      return models;
    }
  }
}
