using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Ort
  {
    public int id;
    public int plz;
    public string ort;

    private Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
        { "plz", this.plz },
        { "ort", this.ort }
        };
      }
    }

    public Ort(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.plz = reader.GetInt32(1);
      this.ort = reader.GetString(2);
    }

    public Ort(int plz, string ort)
    {
      this.plz = plz;
      this.ort = ort;
    }

    public Ort(int id, int plz, string ort)
    {
      this.id = id;
      this.plz = plz;
      this.ort = ort;
    }

    public int Insert()
    {
      this.id = Database.Instance.insertCommand("ort", this.ValuesAsDict);
      return this.id;
    }

    public void Update()
    {
      Database.Instance.updateCommand("ort", this.id, this.ValuesAsDict);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("ort", this.id);
    }

    public static Ort Select(int id)
    {
      return (Ort)Database.Instance.selectCommand("ort", id, typeof(Ort));
    }
  }
}
