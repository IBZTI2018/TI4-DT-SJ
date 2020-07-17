using System;
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

      if (ort1.Insert() != 1) throw new Exception("Administration konnte Ort nicht einfügen");
      if (ort2.Insert() != 2) throw new Exception("Administration konnte Ort nicht einfügen");
    }
  }
}
