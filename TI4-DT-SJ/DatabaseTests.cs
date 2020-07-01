using System;
using System.Data.SqlClient;

namespace TI4_DT_SJ
{
  class DatabaseTests
  {
    public static bool testCreatingANewOrtWorksFine()
    {
      bool success = true;

      // Arrange
      Database.Instance.runCommand("INSERT INTO ort (id, plz, ort) VALUES(1, 8804, 'Au')");
      
      // Act+Assert
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM ort").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(0) != 1) success = false;
        if (reader.GetInt32(1) != 8804) success = false;
        if (reader.GetString(2) != "Au") success = false;
      }
      reader.Close();

      return success;
    }
    public static bool teststrasse()
    {
      bool success = true;
      Database.Instance.runCommand("INSERT INTO strasse (id, ort_id, strassenname, hausnummer) VALUES(1, 1, 'Seestrasse', 241)").ExecuteNonQuery();
      SQLDataReader reader = Database.Instance.getCommand("SELECT * FROM strasse LEFT JOIN ort ON strasse.ort_id=ort.id").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(0) != 1) success = false;
        if (reader.GetInt32(1) != 1) success = false;
        if (reader.GetVarchar255(2) != "Seestrasse") success = false;
        if (reader.GetInt32(3) != 241) success = false;
      }
      reader.Close();

      return success;
    }

    public static bool testanrede()
    {
      bool success = true;
      Database.Instance.runCommand("INSERT INTO anrede (id, bezeichnung) VALUES(1, Herr)").ExecuteNonQuery();
      SQLDataReader reader = Database.Instance.getCommand("SELECT * FROM anrede").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(0) !=1) success = false;
        if (reader.GetVarchar20(1) != "Herr") success = false,
      }
      reader.close();

      return success;
    }

  }
}
