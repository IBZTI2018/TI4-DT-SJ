using System;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ {
  class DatabaseTestsMitgliederverwaltung {
    // Ein neuer Ort kann nur von der Administration oder der Mitgliederverwaltung in die Datenbank eingetragen werden. 
    public static void testCanCreateANewOrtAndGetItsId()
    {
      Models.Ort ort1 = new Models.Ort(8804, "Au ZH");
      Models.Ort ort2 = new Models.Ort(8000, "Zueri City");

      Database x = Database.Instance;

      if (ort1.Insert() == 0) throw new Exception("Mitgliederverwaltung konnte Ort nicht einfügen");
      if (ort2.Insert() == 0) throw new Exception("Mitgliederverwaltung konnte Ort nicht einfügen");
    }

    public static void testCanConnectAboAndAnbieter()
    {

    }




  }
}
