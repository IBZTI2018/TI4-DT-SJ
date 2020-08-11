using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TI4_DT_SJ.Models
{
  class Adresse
  {
    public int id;
    public int ort_id;
    public string strassenname;
    public int hausnummer;

    private Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"ort_id", this.ort_id},
          {"strassenname", this.strassenname},
          {"hausnummer", this.hausnummer}
        };
      }
    }

    public Ort ort;

    public Adresse(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.ort_id = reader.GetInt32(1);
      this.strassenname = reader.GetString(2);
      this.hausnummer = reader.GetInt32(3);
    }

    public Adresse(int ort_id, string strassenname, int hausnummer)
    {
      this.ort_id = ort_id;
      this.strassenname = strassenname;
      this.hausnummer = hausnummer;
    }

    public Adresse(int id, int ort_id, string strassenname, int hausnummer)
    {
      this.id = id;
      this.ort_id = ort_id;
      this.strassenname = strassenname;
      this.hausnummer = hausnummer;
    }

    public Adresse(int ort_id, int hausnummer)
    {
      this.ort_id = ort_id;
      this.hausnummer = hausnummer;
    }

    public Adresse(int ort_id, string strassenname)
    {
      this.ort_id = ort_id;
      this.strassenname = strassenname;
    }

    public int Insert()
    {
      this.id =  Database.Instance.insertCommand("adresse", this.ValuesAsDict);
      return this.id;
    }

    public void Update()
    {
      Database.Instance.updateCommand("adresse", this.id, this.ValuesAsDict);
    }

    public void Delete()
    {
      Database.Instance.deleteCommand("adresse", this.id);
    }

    public static Adresse Select(int id)
    {
      Adresse model = (Adresse)Database.Instance.selectCommand("adresse", id, typeof(Adresse));
      model.ort = Ort.Select(model.ort_id);
      return model;
    }
  }
}
