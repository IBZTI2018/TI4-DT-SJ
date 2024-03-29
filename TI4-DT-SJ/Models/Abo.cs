﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Abo : Dictionaryable
  {
    public int id;
    public int anbieter_id;
    public int aboart_id;
    public DateTime abschlussdatum;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          { "anbieter_id", this.anbieter_id },
          { "aboart_id", this.aboart_id },
          { "abschlussdatum", this.abschlussdatum }
        };
      }
    }

    public Anbieter anbieter;
    public Aboart aboart;

    public Abo() { }

    public Abo(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.anbieter_id = reader.GetInt32(1);
        this.aboart_id = reader.GetInt32(2);
        this.abschlussdatum = reader.GetDateTime(3);
      }
    }

    public Abo(int anbieter_id, int aboart_id, DateTime abschlussdatum)
    {
      this.anbieter_id = anbieter_id;
      this.aboart_id = aboart_id;
      this.abschlussdatum = abschlussdatum;
    }

    public Abo(int id, int anbieter_id, int aboart_id, DateTime abschlussdatum)
    {
      this.id = id;
      this.anbieter_id = anbieter_id;
      this.aboart_id = aboart_id;
      this.abschlussdatum = abschlussdatum;
    }

    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id = Database.Instance.insertCommand("abo", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      Database.Instance.updateCommand("abo", this.id, values);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("abo", this.id);
    }

    public static Abo Select(int id)
    {
      Abo model = (Abo)Database.Instance.selectCommand("abo", id, typeof(Abo));
      model.anbieter = Anbieter.Select(model.anbieter_id);
      model.aboart = Aboart.Select(model.aboart_id);
      return model;
    }

    public static List<Abo> List()
    {
      List<Abo> models = new List<Abo>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM abo;").ExecuteReader();
      while (reader.Read()) models.Add(new Abo(reader));
      reader.Close();
      return models;
    }
  }
}
