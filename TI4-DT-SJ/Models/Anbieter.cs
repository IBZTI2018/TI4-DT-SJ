using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Anbieter : Dictionaryable
  {
    public int id;
    public int person_id;
    public DateTime aufnahmedatum;
    public DateTime prov_aufnahmedatum;
    public bool bonitaet;
    public bool unterschrift;
    public bool mitarbeiterbesuch;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"person_id", this.person_id},
          {"aufnahmedatum", this.aufnahmedatum},
          {"prov_aufnahmedatum", this.prov_aufnahmedatum},
          {"bonitaetspruefung", this.bonitaet},
          {"unterschrift", this.unterschrift},
          {"mitarbeiterbesuch", this.mitarbeiterbesuch}
        };
      }
    }

    public Person person;

    public Anbieter() { }

    public Anbieter(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.person_id = reader.GetInt32(1);
        if (!reader.IsDBNull(2)) this.aufnahmedatum = reader.GetDateTime(2);
        if (!reader.IsDBNull(3)) this.prov_aufnahmedatum = reader.GetDateTime(3);
        this.bonitaet = reader.GetBoolean(4);
        this.unterschrift = reader.GetBoolean(5);
        this.mitarbeiterbesuch = reader.GetBoolean(6);
      }
    }

    public Anbieter(int person_id, DateTime aufnahmedatum, DateTime prov_aufnahmedatum, bool bonitaet, bool unterschrift, bool mitarbeiterbesuch)
    {
      this.person_id = person_id;
      this.aufnahmedatum = aufnahmedatum;
      this.prov_aufnahmedatum = prov_aufnahmedatum;
      this.bonitaet = bonitaet;
      this.unterschrift = unterschrift;
      this.mitarbeiterbesuch = mitarbeiterbesuch;
    }

    public Anbieter(int id, int person_id, DateTime aufnahmedatum, DateTime prov_aufnahmedatum, bool bonitaet, bool unterschrift, bool mitarbeiterbesuch)
    {
      this.id = id;
      this.person_id = person_id;
      this.aufnahmedatum = aufnahmedatum;
      this.prov_aufnahmedatum = prov_aufnahmedatum;
      this.bonitaet = bonitaet;
      this.unterschrift = unterschrift;
      this.mitarbeiterbesuch = mitarbeiterbesuch;
    }

    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      if (((DateTime)values["aufnahmedatum"]).Year < 10) values.Remove("aufnahmedatum");
      if (((DateTime)values["prov_aufnahmedatum"]).Year < 10) values.Remove("prov_aufnahmedatum");
      this.id = Database.Instance.insertCommand("anbieter", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      if (((DateTime)values["aufnahmedatum"]).Year < 10) values.Remove("aufnahmedatum");
      if (((DateTime)values["prov_aufnahmedatum"]).Year < 10) values.Remove("prov_aufnahmedatum");
      Database.Instance.updateCommand("anbieter", this.id, values);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("anbieter", this.id);
    }

    public static Anbieter Select(int id)
    {
      Anbieter model = (Anbieter)Database.Instance.selectCommand("anbieter", id, typeof(Anbieter));
      model.person = Person.Select(model.person_id);
      return model;
    }

    public static List<Anbieter> List(string where = "")
    {
      List<Anbieter> models = new List<Anbieter>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM anbieter " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new Anbieter(reader));
      }
      reader.Close();
      return models;
    }
  }
}
