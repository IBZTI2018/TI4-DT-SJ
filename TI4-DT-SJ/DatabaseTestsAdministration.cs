using System;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ
{
  class DatabaseTestsAdministration
  {
    public static void testCanCreateANewOrtAndGetItsId()
    {
      Ort ort1 = new Ort(8804, "Au ZH");
      Ort ort2 = new Ort(8000, "Zueri City");
      Ort ort3 = new Ort(8840, "Einsiedeln");

      if (ort1.Insert() != 1) throw new Exception("Failed to insert or generate ID");
      if (ort2.Insert() != 2) throw new Exception("Failed to insert or generate ID");
      if (ort3.Insert() != 3) throw new Exception("Failed to insert or generate ID");
    }
  }
}
