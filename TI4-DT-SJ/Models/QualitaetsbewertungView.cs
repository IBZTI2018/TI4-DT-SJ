using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI4_DT_SJ.Models {
  public class QualitaetsbewertungView : Dictionaryable {
    public int id;
    public string vorname;
    public string nachname;
    public string pruefer;
    public string bezeichnung;

    public Dictionary<String, dynamic> ValuesAsDict
    {
      get
      {
        return new Dictionary<String, dynamic>() {
          {"id", this.id},
          {"vorname", this.vorname},
          {"nachname", this.nachname},
          {"pruefer", this.pruefer},
          {"bezeichnung", this.bezeichnung},
        };
      }
    }

    public QualitaetsbewertungView() { }

    public QualitaetsbewertungView(SqlDataReader reader)
    {
      if (reader.HasRows)
      {
        this.id = reader.GetInt32(0);
        this.vorname = reader.GetString(1);
        this.nachname = reader.GetString(2);
        this.pruefer = reader.GetString(3);
        this.bezeichnung = reader.GetString(4);
      }
    }


    public static List<QualitaetsbewertungView> List(string where = "")
    {
      List<QualitaetsbewertungView> models = new List<QualitaetsbewertungView>();
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM view_qbewertung " + where).ExecuteReader();
      while (reader.Read())
      {
        models.Add(new QualitaetsbewertungView(reader));
      }
      reader.Close();
      return models;
    }
  }
}
