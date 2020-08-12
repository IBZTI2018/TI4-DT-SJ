using System;
using System.CodeDom;
using System.Data.OleDb;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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
      try
      {
        Database.Instance.getCommand("INSERT INTO ort (ort) VALUES ('Uster');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte ort ohne plz einfügen");
    }

    public static void testCanCreateANewOrtwithoutOrtname()
    {
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
      Adresse adresse2 = new Adresse(1, "zürichstrasse", 21);

      if (adresse1.Insert() == 0) throw new Exception("Administration konnte Adresse nicht einfügen");
      if (adresse2.Insert() == 0) throw new Exception("Administration konnte Adresse nicht einfügen");

    }
    public static void testCanCreateANewAddresswithoutStrassenname()
    {
      try
      {
        Database.Instance.getCommand("INSERT INTO adresse (ort_id, hausnummer) VALUES ('1', '15');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte adresse ohne strassenname einfügen");
    }

    public static void testCanCreateANewAdressWithoutHausnummer()
    {
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
      DateTime dateTime1 = new DateTime(1965, 10, 12);
      DateTime dateTime2 = new DateTime(1975, 01, 07);

      Person person1 = new Person(1, 2, "Hans", "Mueller", "hans.mueller@gmail.com", dateTime1);
      Person person2 = new Person(2, 3, "Frida", "Bachmann", "frida.b@hotmail.com", dateTime2);

      if (person1.Insert() == 0) throw new Exception("Administration konnte Person nicht einfügen");
      if (person2.Insert() == 0) throw new Exception("Administration konnte Person nicht einfügen");

    }
    public static void testCanCreateANewPersonWithoutAnrede()
    {
      try
      {
        Database.Instance.getCommand("INSERT INTO person (adresse_id, vorname, nachname, email, geburtsdatum) VALUES ('2', 'albert', 'einstein', 'albert.einstein@bluewin.ch', '1950-01-07');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Aministration konnte Person ohne Anrede einfügen");
    }

    public static void testCanCreateANewPersonWithoutAddress()
    {
      try
      {
        Database.Instance.getCommand("INSERT INTO person (anrede_id, vorname, nachname, email, geburtsdatum) VALUES('1', 'Ruedi', 'Peter', 'ruedi.peter@gmail.com', '1994-10-10');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte Person ohne Adresse einfügen");
    }

    public static void testCanCreateANewPersonWithoutVorname()
    {
      try
      {
        Database.Instance.getCommand("INSERT INTO person(anrede_id, adresse_id, nachname, email, geburtsdatum) VALUES ('1', '4', 'Baum', 'a.baum@gmail.com', '1995-12-21');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte Person ohne Vorname einfügen");
    }

    public static void testCanCreateANewPersonWithoutNachname()
    {
      try
      {
        Database.Instance.getCommand("INSERT INTO person(anrede_id, adresse_id, vorname, email, geburtsdatum) VALUES ('2', '5', 'Lara', 'lara.a@hotmail.com', '1997-01-01');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte Person ohne Nachname einfügen");
    }

    public static void testCanCreateANewPersonWithoutEmail()
    {
      try
      {
        Database.Instance.getCommand("INSERT INTO person(anrede_id, adresse_id, vorname, nachname, geburtsdatum) VALUES ('1', '21', 'rudolf', 'rednose', 'datetime');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte Person ohne Email einfügen");
    }

    // Eine neuer Nachfrager kann nur von der Administration oder der Mitgliederverwaltung in die Datenbank eingetragen werden.
    public static void testCanCreateANachfragerAndGetItsID()
    {
      Nachfrager nachfrager1 = new Nachfrager(1);
      Nachfrager nachfrager2 = new Nachfrager(2);

      if (nachfrager1.Insert() == 0) throw new Exception("Administration konnte Nachfrager nicht einfügen");
      if (nachfrager2.Insert() == 0) throw new Exception("Administration konnte Nachfrager nicht einfügen");
    }

    // Eine neue Aboart kann nur von der Administration in die Datenbank eingetragen werden.
    public static void testCanCreateAAboartAndGetItsID()
    {
      Aboart aboart1 = new Aboart("all_in_one", 2000);
      Aboart aboart2 = new Aboart("love_the_summer", 800);

      if (aboart1.Insert() == 0) throw new Exception("Administration konnte Aboart nicht einfügen");
      if (aboart2.Insert() == 0) throw new Exception("Administration konnte Aboart nicht einfügen");
    }





  }
}
