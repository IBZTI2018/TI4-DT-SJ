﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Qualitaetspruefer : Dictionaryable
  {
    public int id;
    public int person_id;
    public double lohn;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"person_id", this.person_id},
          {"lohn", this.lohn}
        };
      }
    }

    public Person person;

    public Qualitaetspruefer() { }

    public Qualitaetspruefer(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.person_id = reader.GetInt32(1);
        this.lohn = reader.GetDouble(2);
      }
    }

    public Qualitaetspruefer(int person_id, float lohn)
    {
      this.person_id = person_id;
      this.lohn = lohn;
    }

    public Qualitaetspruefer(int id, int person_id, float lohn)
    {
      this.id = id;
      this.person_id = person_id;
      this.lohn = lohn;
    }

    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      if (this.lohn == 0.0) values.Remove("lohn");
      values.Remove("id");
      this.id = Database.Instance.insertCommand("qualitaetspruefer", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      if (this.lohn == 0.0) values.Remove("lohn");
      values.Remove("id");
      Database.Instance.updateCommand("qualitaetspruefer", this.id, values);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("qualitaetspruefer", this.id);
    }

    public static Qualitaetspruefer Select(int id)
    {
      Qualitaetspruefer model = (Qualitaetspruefer)Database.Instance.selectCommand("qualitaetspruefer", id, typeof(Qualitaetspruefer));
      model.person = Person.Select(model.person_id);
      return model;
    }

    public static List<Qualitaetspruefer> List(string where = "")
    {
      List<Qualitaetspruefer> models = new List<Qualitaetspruefer>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM qualitaetspruefer " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new Qualitaetspruefer(reader));
      }
      reader.Close();
      return models;
    }
  }
}
