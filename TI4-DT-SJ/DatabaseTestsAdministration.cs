using System;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ
{
  class DatabaseTestsAdministration
  {
    // Ein neuer Ort kann nur von der Administration oder der Mitgliederverwaltung in die Datenbank eingetragen werden. 
    public static void testCanCreateANewOrtAndGetItsId()
    {
      Ort ort1 = new Ort(8804, "Au ZH");
      Ort ort2 = new Ort(8000, "Zueri City");

      if (ort1.Insert() == 0) throw new Exception("Administration konnte Ort nicht einfügen");
      if (ort2.Insert() == 0) throw new Exception("Administration konnte Ort nicht einfügen");
    }

    // Personal testing
    public static void testSomeTest()
    {
      Ort ort = new Ort(8804, "Au ZH");
      ort.Insert();
      ort.plz = 3000;
      ort.Update();
      Ort ort_new = Ort.Select(ort.id);
      int x = 20
    }
  }
}
