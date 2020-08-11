using System;
using System.CodeDom;
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
    
    public static void testCanCreateANewOrtwithoutplz()
    {
      Ort ort = new Ort("uster");
      try
      {
        Database.Instance.getCommand("INSERT INTO ort (ort) VALUES ('Uster');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte ort ohne plz einfügen");
    }

    public static void testCanCreateANewOrtwithoutOrtname()
    {
      Ort ort = new Ort(8904);
      try
      {
        Database.Instance.getCommand("INSERT INTO ort (plz) VALUES ('8904');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte ort ohne ortname einfügen");
    }

    // Eine neue Adresse kann nur von der Administration und der Mietgliederverwaltung in die Datenbank eingetragen werden.
    public static void testCanCreateANewAddressAndGetItsID()
    {
      Adresse adresse1 = new Adresse(1, "untermoos", 17);
      Adresse adresse2 = new Adresse(2, "zürichstrasse", 21);

      if (adresse1.Insert() == 0) throw new Exception("Administration konnte Adresse nicht einfügen");
      if (adresse2.Insert() == 0) throw new Exception("Administration konnte Adresse nicht einfügen");
        
    }
    public static void testCanCreateANewAddresswithoutStrassenname()
    {
      Adresse adresse = new Adresse(1, 15);
      try
      {
        Database.Instance.getCommand("INSERT INTO adresse (ort_id, hausnummer) VALUES ('1', '15');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte adresse ohne strassenname einfügen");
    }

    public static void testCanCreateANewAdressWithoutHausnummer()
    {
      Adresse adresse = new Adresse(12, "schlierestrass");
      try
      {
        Database.Instance.getCommand("INSERT INTO adresse (ort_id, strassenname) VALUES ('12', 'schlierestrass');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte adresse ohne hausnummer einfügen");
    }
    // Eine neue Person kann nur von der Administration und der Mietgliederverwaltung in die Datenbank eingetragen werden.

    public static void testCanCreateANewPersonAndGetItsID()
    {
      Person person1 = new Person(1, 2, "Hans", "Mueller", "hans.mueller@gmail.com", '1965-10-12' ); // datetime isch eifach kakke drum gaht das etz nonig
      Person person2 = new Person(2, 3, "Frida", "Bachmann", "frida.b@hotmail.com", );

      if (person1.Insert() == 0) throw new Exception("Administration konnte Person nicht einfügen");
      if (person2.Insert() == 0) throw new Exception("Administration konnte Person nicht einfügen");

    }


  }
}
