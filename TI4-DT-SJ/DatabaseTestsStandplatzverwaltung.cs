using System;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ {
  class DatabaseTestsStandplatzverwaltung {
    // Ein neuer Ort kann nur von der Administration oder der Mitgliederverwaltung in die Datenbank eingetragen werden. 
    public static void testCanCreateANewOrtAndGetItsId()
    {
      Ort ort = new Ort(8804, "Au ZH");

      try
      {
        ort.Insert();
      }
      catch { return; }
      throw new Exception("Standplatzverwalter konnte Ort einfügen");
    }

    public static void testCanCreateANewStandortAndGetItsID()
    {
      Standort standort1 = new Standort("Lindenplatz");
      Standort standort2 = new Standort("Zentrumsplatz_Davos");

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



  }
}
