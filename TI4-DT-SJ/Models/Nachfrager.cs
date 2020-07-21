using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Nachfrager
  {
    public int id;
    public int person_id;

    private Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"person_id", this.person_id}
        };
      }
    }

    public Person person;

    public Nachfrager(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.person_id = reader.GetInt32(1);
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
      this.id = Database.Instance.insertCommand("nachfrager", this.ValuesAsDict);
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
