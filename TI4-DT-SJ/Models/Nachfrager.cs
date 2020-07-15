using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Nachfrager
  {
    public int id;
    public int person_id;

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
      return Database.Instance.insertCommand("nachfrager", new Dictionary<String, dynamic>() {
        {"id", this.id},
        {"person_id", this.person_id}
      });
    }

    public static Nachfrager Select(int id)
    {
      return (Nachfrager)Database.Instance.selectCommand("nachfrager", id, typeof(Nachfrager));
    }
  }
}
