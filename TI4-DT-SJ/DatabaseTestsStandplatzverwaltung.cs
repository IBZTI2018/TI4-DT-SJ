using System;
using System.CodeDom;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ {
  class DatabaseTestsStandplatzverwaltung {
    // Ein neuer Ort kann nur von der Administration oder der Mitgliederverwaltung in die Datenbank eingetragen werden. 
    public static void testCanCreateANewOrtAndGetItsId()
    {
      Models.Ort ort = new Models.Ort(8804, "Au ZH");

      try
      {
        ort.Insert();
      }
      catch { return; }
      throw new Exception("Standplatzverwalter konnte Ort einfügen");
    }

    public static void testCanCreateANewStandortAndGetItsID()
    {
      Models.Standort standort1 = new Models.Standort("Lindenplatz");
      Models.Standort standort2 = new Models.Standort("Zentrumsplatz_Davos");

      if (standort1.Insert() == 0) throw new Exception("Standplatzverwalter konnte Standort nicht einfügen");
      if (standort2.Insert() == 0) throw new Exception("Standplatzverwalter konnte Standort nicht einfügen");

    }

    public static void testCanCreateANewStandortWithoutBezeichnung()
    {
      try
      {
        Database.Instance.getCommand("INSERT INTO standort (id) VALUES ('1');").ExecuteNonQuery();
      } catch { return; }
      throw new Exception("Standplatzverwalter konnte Standort ohne Bezeichnung einfügen");
    }

    public static void testCanCreateANewStandplatzAndGetItsID()
    {
      Models.Standplatz standplatz1 = new Models.Standplatz(1, 1);
      Models.Standplatz standplatz2 = new Models.Standplatz(1, 2);

      if (standplatz1.Insert() == 0) throw new Exception("Standplatzverwalter konnte standplatz nicht einfügen");
      if (standplatz2.Insert() == 0) throw new Exception("Standplatzverwalter konnte standplatz nicht einfügen");
    }

    public static void testCanCreateANewStandplatzWithoutStandort()
    {
      try
      {
        Database.Instance.getCommand("INSERT INTO standplatz (standplatz_nr) VALUES ('3');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Standplatzverwalter konnte Standplatz ohne Standort einfügen");
    }

    public static void testCanCreateaStandplatzWithoutStandpatzNR()
    {
      try
      {
        Database.Instance.getCommand("INSERT INTO standplatz (standort_id) VALUES ('1');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Standlatzerwalter konnte Standlatz ohne Standplatz_NR einfügen");
    }

    public static void testCanCreateTerminAndGetItsID()
    { 
      DateTime datetime1 = new DateTime(1995, 01, 01);
      DateTime datetime2 = new DateTime(1997, 01, 10);
      Models.Termin termin1 = new Models.Termin(1, 2, datetime1);
      Models.Termin termin2 = new Models.Termin(1, 3, datetime2);

      if (termin1.Insert() == 0) throw new Exception("Standplatzverwalter konnte Termin nicht einfügen");
      if (termin2.Insert() == 0) throw new Exception("Standplatzverwalter konnte Termin nicht einfügen");

    }



  }
}
