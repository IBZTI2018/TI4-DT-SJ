using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  internal class Person : Dictionaryable
  {
    public int id;
    public int anrede_id;
    public int adresse_id;
    public string vorname;
    public string nachname;
    public string email;
    public DateTime geburtsdatum;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"anrede_id", this.anrede_id},
          {"adresse_id", this.adresse_id},
          {"vorname", this.vorname},
          {"nachname", this.nachname},
          {"email", this.email},
          {"geburtsdatum", this.geburtsdatum}
        };
      }
    }

    public Anrede anrede;
    public Adresse adresse;

    public Person(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.anrede_id = reader.GetInt32(1);
      this.adresse_id = reader.GetInt32(2);
      this.vorname = reader.GetString(3);
      this.nachname = reader.GetString(4);
      this.email = reader.GetString(5);
      this.geburtsdatum = reader.GetDateTime(6);
    }

    public Person(int anrede_id, int adresse_id, string vorname, string nachname, string email, DateTime geburtsdatum)
    {
      this.anrede_id = anrede_id;
      this.adresse_id = adresse_id;
      this.vorname = vorname;
      this.nachname = nachname;
      this.email = email;
      this.geburtsdatum = geburtsdatum;
    }

    public Person(int id, int anrede_id, int adresse_id, string vorname, string nachname, string email, DateTime geburtsdatum)
    {
      this.id = id;
      this.anrede_id = anrede_id;
      this.adresse_id = adresse_id;
      this.vorname = vorname;
      this.nachname = nachname;
      this.email = email;
      this.geburtsdatum = geburtsdatum;
    }

    public int Insert()
    {
      this.id = Database.Instance.insertCommand("person", new Dictionary<String, dynamic>() {
        {"id", this.id},
        {"anrede_id", this.anrede_id},
        {"adresse_id", this.adresse_id},
        {"vorname", this.vorname},
        {"nachname", this.nachname},
        {"email", this.email},
        {"geburtsdatum", this.geburtsdatum}
      });
      return this.id;
    }

    public void Update()
    {
      Database.Instance.updateCommand("person", this.id, this.ValuesAsDict);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("person", this.id);
    }

    public static Person Select(int id)
    {
      Person model = (Person)Database.Instance.selectCommand("person", id, typeof(Person));
      model.anrede = Anrede.Select(model.anrede_id);
      model.adresse = Adresse.Select(model.adresse_id);
      return model;
    }

    public static List<Person> List(string where = "")
    {
      List<Person> models = new List<Person>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM person " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new Person(reader));
      }
      reader.Close();
      return models;
    }
  }
}
