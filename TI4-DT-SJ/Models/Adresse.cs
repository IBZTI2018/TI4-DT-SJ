using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TI4_DT_SJ.Models
{
  public class Adresse : Dictionaryable
  {
    public int id;
    public int ort_id;
    public string strassenname;
    public int hausnummer;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id },
          {"ort_id", this.ort_id},
          {"strassenname", this.strassenname},
          {"hausnummer", this.hausnummer}
        };
      }
    }

    public Ort ort;

    public Adresse() { }

    public Adresse(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.ort_id = reader.GetInt32(1);
        this.strassenname = reader.GetString(2);
        this.hausnummer = reader.GetInt32(3);
      }
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
    public int Insert()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      this.id =  Database.Instance.insertCommand("adresse", values);
      return this.id;
    }

    public void Update()
    {
      Dictionary<string, dynamic> values = this.ValuesAsDict;
      values.Remove("id");
      Database.Instance.updateCommand("adresse", this.id, values);
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

    public static List<Adresse> List()
    {
      List<Adresse> models = new List<Adresse>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM adresse;").ExecuteReader();
      while (reader.Read()) models.Add(new Adresse(reader));
      reader.Close();
      return models;
    }
  }
}
