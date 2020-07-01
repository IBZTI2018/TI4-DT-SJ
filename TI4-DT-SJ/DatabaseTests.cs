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
        if (reader.GetVarchar20(1) != "Herr") success = false;
      }
      reader.close();

      return success;
    }

    public static bool testperson()
    {
      bool success = true;
      DatabaseTests.Instance.runCommand("INSERT INTO person (id, anrede_id, strasse_id, vorname, nachname, geburtsdatum, email) VALUES(1, 1, 1, 'Fritz', 'Meyer', 01.03.1975, fritz.meyer@hotmail.com)").ExecuteNonQuery();
      SQLDataReader reader = DatabaseTests.Instance.getCommand("SELECT * FROM person LEFT JOIN strasse ON person.strasse_id=strasse.id LEFT JOIN anrede ON person.anrede_id=anrede.id").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(0) != 1) success = false;
        if (reader.GetInt32(1) != 1) success = false;
        if (reader.GetInt32(2) != 1) success = false;
        if (reader.GetVarchar255(3) != "Fritz") success = false;
        if (reader.GetVarchar255(4) != "Meyer") success = false;
        if (reader.GetDate(5) != "01.03.1975") success = false;
        if (reader.GetVarchar255(6) != "fritz.meyer@hotmail.com") success = false;
      }
      reader.Close();

      return success; 
    }

    public static bool testnachfrager()
    {
      bool success = true;
      DatabaseTests.Instance.runCommand("INSERT INTO nachfrager (id, person_id) VALUES (1, 1)").ExecuteNonQuery();
      SQLDataReader reader = DatabaseTests.Instance.getCommand("SELECT * FROM nachfrager LEFT JOIN person ON nachfrager.person_id=person.id"). ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(0) != 1) success = false;
        if (reader.GetInt32(1) != 1) success = false;
      }
      reader.Close();

      return success;
    }
  }
}
