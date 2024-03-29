﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Standort : Dictionaryable
  {
    public int id;
    public string bezeichnung;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"bezeichnung", this.bezeichnung}
        };
      }
    }

    public Standort() { }

    public Standort(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.bezeichnung = reader.GetString(1);
      }
    }

    public Standort(string bezeichnung)
    {
      this.bezeichnung = bezeichnung;
    }

    public Standort(int id, string bezeichnung)
    {
      this.id = id;
      this.bezeichnung = bezeichnung;
    }

    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id = Database.Instance.insertCommand("standort", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      Database.Instance.updateCommand("standort", this.id, values);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("standort", this.id);
    }

    public static Standort Select(int id)
    {
      return (Standort)Database.Instance.selectCommand("standort", id, typeof(Standort));
    }

    public static List<Standort> List()
    {
      List<Standort> models = new List<Standort>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM standort ").ExecuteReader();
      while (reader.Read())
      {
        models.Add(new Standort(reader));
      }
      reader.Close();
      return models;
    }
  }
}
