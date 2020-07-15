﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Adresse
  {
    public int id;
    public int ort_id;
    public string strassenname;
    public int hausnummer;

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

    public int Insert()
    {
      return Database.Instance.insertCommand("adresse", new Dictionary<String, dynamic>() {
        {"id", this.id},
        {"ort_id", this.ort_id},
        {"strassenname", this.strassenname},
        {"hausnummer", this.hausnummer}
      });
    }

    public static Adresse Select(int id)
    {
      return (Adresse)Database.Instance.selectCommand("adresse", id, typeof(Adresse));
    }
  }
}
