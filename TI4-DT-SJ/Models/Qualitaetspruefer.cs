using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Qualitaetspruefer
  {
    public int id;
    public int person_id;
    public float lohn;

    public Person person;

    public Qualitaetspruefer(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.person_id = reader.GetInt32(1);
      this.lohn = reader.GetFloat(2);
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
      this,id = Database.Instance.insertCommand("qualitaetspruefer", new Dictionary<String, dynamic>() {
        {"id", this.id},
        {"person_id", this.person_id},
        {"lohn", this.lohn}
      });
      return this.id;
    }

    public static Qualitaetspruefer Select(int id)
    {
      Qualitaetspruefer model = (Qualitaetspruefer)Database.Instance.selectCommand("qualitaetspruefer", id, typeof(Qualitaetspruefer));
      model.person = Person.Select(model.person_id);
      return model;
    }
  }
}
