using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models {
  public class PersonView : Dictionaryable {
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
          {"email", this.email}
        };
      }
    }

    public PersonView() { }

    public PersonView(SqlDataReader reader)
    {
      if (reader.HasRows)
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
      }
    }


    public static List<PersonView> List(string where = "")
    {
      List<PersonView> models = new List<PersonView>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM view_person " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new PersonView(reader));
      }
      reader.Close();
      return models;
    }
  }
}
