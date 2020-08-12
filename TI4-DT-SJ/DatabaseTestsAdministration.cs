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
      DateTime dateTime1 = new DateTime(1965, 10, 12);
      DateTime dateTime2 = new DateTime(1975, 01, 07);

      Person person1 = new Person(1, 2, "Hans", "Mueller", "hans.mueller@gmail.com", dateTime1);
      Person person2 = new Person(2, 3, "Frida", "Bachmann", "frida.b@hotmail.com", dateTime2);

      if (person1.Insert() == 0) throw new Exception("Administration konnte Person nicht einfügen");
      if (person2.Insert() == 0) throw new Exception("Administration konnte Person nicht einfügen");

    }
    public static void testCanCreateANewPersonWithoutAnrede()
    {
      DateTime datetime = new DateTime(1997, 01, 01);
      Person person = new Person(2, "albert", "einstein", "albert.einstein@bluewin.ch", datetime);
      try
      {
        Database.Instance.getCommand("INSERT INTO person (adresse_id, vorname, nachname, email, geburtsdatum) VALUES ('2', 'albert', 'einstein', 'albert.einstein@bluewin.ch', datetime);").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Aministration konnte Person ohne Anrede einfügen");
    }

    public static void testCanCreateANewPersonWithoutAddress()
    {
      DateTime datetime = new DateTime(1992, 04, 10);
      Person person = new Person(1, "Ruedi", "Peter", "ruedi.peter@gmail.com",datetime);
      try
      {
        Database.Instance.getCommand("INSERT INTP person (anrede_id, vorname, nachname, email, geburtsdatum) VALUES('1', 'Ruedi', 'Peter', 'ruedi.peter@gmail.com', 'datetime');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte Person ohne Adresse einfügen");
    }

    public static void testCanCreateANewPersonWithoutVorname()
    {
      DateTime datetime = new DateTime(1994, 03, 20);
      Person person = new Person(1, 4, "Baum", "a.baum@gmail.com", datetime);
      try
      {
        Database.Instance.getCommand("INSERT INTO person(anrede_id, adresse_id, nachname, email, geburtsdatum) VALUES ('1', '4', 'Baum', 'a.baum@gmail.com', 'datetime');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte Person ohne Vorname einfügen");
    }

    public static void testCanCreateANewPersonWithoutNachname()
    {
      DateTime datetime = new DateTime(1993, 05, 10);
      Person person = new Person(2, 5, datetime, "Lara", "lara.a@hotmail.com");
      try
      {
        Database.Instance.getCommand("INSERT INTO person(anrede_id, adresse_id, geburtsdatum, vorname, email) VALUES ('2', '5', 'datetime', 'Lara', 'lara.a@hotmail.com');").ExecuteNonQuery();
      }
      catch { return; }
      throw new Exception("Administration konnte Person ohne Nachname einfügen");
    }

    public static void testCanCreateANewPersonWithoutEmail()
    {
      DateTime datetime = new DateTime(1995, 10, 11);
      Person person = new Person(21, "rudolf", "rednose", datetime, 1);
      try
      {
        Database.Instance.getCommand("INSERT INTO person(adresse_id, vorname, nachname, geburtsdatum, anrede_id) VALUES ('21', 'rudolf', 'rednose', 'datetime', '1');").ExecuteNonQuery();
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



  }
}
