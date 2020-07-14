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

    public int Insert()
    {
      return Database.Instance.insertCommand("ort", new Dictionary<String, dynamic>() {
        {"plz", this.plz},
        {"ort", this.ort}
      });
    }
  }
}
