using System;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ {
  class DatabaseTestsQualitaetsverantwortliche {
    // Ein neuer Ort kann nur von der Administration oder der Mitgliederverwaltung in die Datenbank eingetragen werden. 
    public static void testCanCreateANewOrtAndGetItsId()
    {
      Models.Ort ort = new Models.Ort(8804, "Au ZH");

      try
      {
        ort.Insert();
      } catch { return;  }
      throw new Exception("Qualitätsverantwortlicher konnte Ort einfügen");
    }
  }
}
