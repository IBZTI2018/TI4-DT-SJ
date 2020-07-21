using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TI4_DT_SJ.Models
{
  class Abo
  {
    public int id;
    public int anbieter_id;
    public int aboart_id;

    public Anbieter anbieter;
    public Aboart aboart;

    public Abo(SqlDataReader reader)
    {
      this.id = reader.GetInt32(0);
      this.anbieter_id = reader.GetInt32(1);
      this.aboart_id = reader.GetInt32(2);
    }

    public Abo(int anbieter_id, int aboart_id)
    {
      this.anbieter_id = anbieter_id;
      this.aboart_id = aboart_id;
    }

    public Abo(int id, int anbieter_id, int aboart_id)
    {
      this.id = id;
      this.anbieter_id = anbieter_id;
      this.aboart_id = aboart_id;
    }

    public int Insert()
    {
      this.id = Database.Instance.insertCommand("abo", new Dictionary<String, dynamic>() {
        {"id", this.id},
        {"anbieter_id", this.anbieter_id},
        {"aboart_id", this.aboart_id}
      });
      return this.id;
    }

    public static Abo Select(int id)
    {
      Abo model = (Abo)Database.Instance.selectCommand("abo", id, typeof(Abo));
      model.anbieter = Anbieter.Select(model.anbieter_id);
      model.aboart = Aboart.Select(model.aboart_id);
      return model;
    }
  }
}
