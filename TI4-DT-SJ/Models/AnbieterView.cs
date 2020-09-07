using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models {
  class AnbieterView : Dictionaryable {
    public int id;
    public string anrede;
    public string vorname;
    public string nachname;
    public string strassenname;
    public int hausnummer;
    public int plz;
    public string ort;
    public DateTime geburtsdatum;
    public string email;
    public DateTime aufnahmedatum;
    public DateTime provAufnahmedatum;
    public bool bonitaet;
    public bool unterschrift;
    public int qbewertungen;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id},
          {"anrede", this.anrede},
          {"vorname", this.vorname},
          {"nachname", this.nachname},
          {"strassenname", this.strassenname},
          {"hausnummer", this.hausnummer},
          {"plz", this.plz},
          {"ort", this.ort},
          {"geburtsdatum", this.geburtsdatum},
          {"email", this.email},
          {"aufnahmedatum", this.aufnahmedatum},
          {"provAufnahmedatum", this.provAufnahmedatum},
          {"bonitaet", this.bonitaet},
          {"unterschrift", this.unterschrift},
          {"qbewertungen", this.qbewertungen}
        };
      }
    }

    public AnbieterView(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.anrede = reader.GetString(1);
      this.vorname = reader.GetString(2);
      this.nachname = reader.GetString(3);
      this.strassenname = reader.GetString(4);
      this.hausnummer = reader.GetInt32(5);
      this.plz = reader.GetInt32(6);
      this.ort = reader.GetString(7);
      this.geburtsdatum = reader.GetDateTime(8);
      this.email = reader.GetString(9);
      this.aufnahmedatum = reader.GetDateTime(10);
      this.provAufnahmedatum = reader.GetDateTime(11);
      this.bonitaet = reader.GetBoolean(12);
      this.unterschrift = reader.GetBoolean(13);
      this.qbewertungen = reader.GetInt32(14);
    }


    public static List<AnbieterView> List(string where = "")
    {
      List<AnbieterView> models = new List<AnbieterView>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM view_anbieter " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new AnbieterView(reader));
      }
      reader.Close();
      return models;
    }
  }
}
