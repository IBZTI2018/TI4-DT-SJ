using System;
using System.Data.SqlClient;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ
{
  class DatabaseTests
  {
    public static void testCanInsertNewAnredeWithoutAnError()
    {
      Anrede anredeM = new Anrede(1, "Herr");
      Anrede anredeW = new Anrede(2, "Frau");
      anredeM.Insert();
      anredeW.Insert();
    }

    public static void testCanCreateANewOrtAndGetItsId()
    {
      Ort ort1 = new Ort(8804, "Au ZH");
      Ort ort2 = new Ort(8000, "Zueri City");
      Ort ort3 = new Ort(8840, "Einsiedeln");

      if (ort1.Insert() != 1) throw new Exception("Failed to insert or generate ID");
      if (ort2.Insert() != 2) throw new Exception("Failed to insert or generate ID");
      if (ort3.Insert() != 3) throw new Exception("Failed to insert or generate ID");
    }

    /*
    public static bool testCreatingANewOrtWorksFine()
    {
      bool success = true;

      // Arrange
      Database.Instance.runCommand("INSERT INTO ort (plz, ort) VALUES(8804, 'Au')");
      
      // Act+Assert
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM ort").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(1) != 8804) success = false;
        if (reader.GetString(2) != "Au") success = false;
      }
      reader.Close();

      return success;
    }
    public static bool teststrasse()
    {
      bool success = true;
      Database.Instance.runCommand("INSERT INTO adresse (ort_id, strassenname, hausnummer) VALUES(1, 'Seestrasse', 241)");
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM strasse LEFT JOIN ort ON strasse.ort_id=ort.id").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(1) != 1) success = false;
        if (reader.GetString(2) != "Seestrasse") success = false;
        if (reader.GetInt32(3) != 241) success = false;
      }
      reader.Close();

      return success;
    }

    public static bool testanrede()
    {
      bool success = true;
      Database.Instance.runCommand("INSERT INTO anrede (bezeichnung) VALUES(Herr)");
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM anrede").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetString(1) != "Herr") success = false;
      }
      reader.Close();

      return success;
    }

    public static bool testperson()
    {
      bool success = true;
      Database.Instance.runCommand("INSERT INTO person (anrede_id, strasse_id, vorname, nachname, geburtsdatum, email) VALUES(1, 1, 'Fritz', 'Meyer', 01.03.1975, fritz.meyer@hotmail.com)");
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM person LEFT JOIN strasse ON person.strasse_id=strasse.id LEFT JOIN anrede ON person.anrede_id=anrede.id").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(1) != 1) success = false;
        if (reader.GetInt32(2) != 1) success = false;
        if (reader.GetString(3) != "Fritz") success = false;
        if (reader.GetString(4) != "Meyer") success = false;
        //if (reader.GetDateTime(5) != "01.03.1975") success = false;
        if (reader.GetString(6) != "fritz.meyer@hotmail.com") success = false;
      }
      reader.Close();

      return success; 
    }

    public static bool testnachfrager()
    {
      bool success = true;
      Database.Instance.runCommand("INSERT INTO nachfrager (person_id) VALUES (1)");
      SqlDataReader reader = Database.Instance.getCommand("SELECT * FROM nachfrager LEFT JOIN person ON nachfrager.person_id=person.id").ExecuteReader();
      while (reader.Read())
      {
        if (reader.GetInt32(1) != 1) success = false;
      }
      reader.Close();

      return success;
    }*/
  }
}
