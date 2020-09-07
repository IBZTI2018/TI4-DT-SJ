using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  public class Nachfrager : Dictionaryable
  {
    public int id;
    public int person_id;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"person_id", this.person_id}
        };
      }
    }

    public Person person;

    public Nachfrager() { }

    public Nachfrager(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.person_id = reader.GetInt32(1);
      }
    }

    public Nachfrager(int person_id)
    {
      this.person_id = person_id;
    }

    public Nachfrager(int id, int person_id)
    {
      this.id = id;
      this.person_id = person_id;
    }

    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id = Database.Instance.insertCommand("nachfrager", values);
      return this.id;
    }

    public void Update()
    {
      Database.Instance.updateCommand("nachfrager", this.id, this.ValuesAsDict);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("nachfrager", this.id);
    }

    public static Nachfrager Select(int id)
    {
      Nachfrager model = (Nachfrager)Database.Instance.selectCommand("nachfrager", id, typeof(Nachfrager));
      model.person = Person.Select(model.person_id);
      return model;
    }
  }
}
