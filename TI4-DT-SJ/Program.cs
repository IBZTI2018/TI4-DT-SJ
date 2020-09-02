using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace TI4_DT_SJ
{
  static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      string mode = "interface";

      // If a mode parameter is given, the default mode is overwritten
      if (args.Length == 1) mode = args[0];

      switch (mode) {
        case "create":
          Program.runDatabaseScript("DatabaseCreate");
          MessageBox.Show("Finished running script DatabaseCreate");
          break;
        case "drop":
          Program.runDatabaseScript("DatabaseDrop");
          MessageBox.Show("Finished running script DatabaseDrop");
          break;
        case "seed":
          Program.runDatabaseScript("DatabaseSeed");
          MessageBox.Show("Finished running script DatabaseSeed");
          break;
        case "test":
          Program.runDatabaseScript("DatabaseCreate");
          Program.runDatabaseTests();
          Program.runDatabaseScript("DatabaseDrop");
          break;
        case "testonly":
          Program.runDatabaseTests();
          break;
        default:
          Database.Instance.connect(withDatabase: true);
          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new MainForm());
          Database.Instance.disconnect();
          break;
      }
    }

    /// <summary>
    /// Run a specific database script from the '/DB-Scripts' directory
    /// </summary>
    /// <param name="scriptName">The name of the script to run</param>
    static void runDatabaseScript(String scriptName)
    {
      Database.Instance.connect(withDatabase: false);

      // This is using relative paths from the debug directory on purpose, since this application is intended
      // as a demonstration and will never be distributed as a packed executable.
      String scriptPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\..\\DB-Scripts\\{scriptName}.sql";
      String[] scriptData = File.ReadAllText(scriptPath).Split(';');
    
      foreach(String query in scriptData)
      {
        try
        {
          string cleanQuery = query.Trim().Trim('\r', '\n');
          if (cleanQuery == "" || cleanQuery.ToLower() == "go") continue;
          if (cleanQuery.ToLower().StartsWith("go"))
          {
            // TODO: Make this less hacky and ensure it cannot interfere with proper lines!
            cleanQuery = cleanQuery.Replace("go", "").Replace("GO", "").Replace("Go", "");
          }

          Database.Instance.runCommand(cleanQuery);
        } catch (Exception e)
        {
          MessageBox.Show($"Failed to run script query {query} with error {e.Message}");
          break;
        }
      }

      Database.Instance.disconnect();
    }

    /// <summary>
    /// Drop the existing database, create it without seeding, then run all tests in isolated transactions.
    /// In the end, close database connection to clean up. This is a very pragmatic setup.
    /// </summary>
    static void runDatabaseTests()
    {
      Database.Instance.connect(true);

      // Per documentation, these always exist!
      // TODO: How do we do this?
      //(new Models.Anrede(1, "Herr")).Insert();
      //(new Models.Anrede(2, "Frau")).Insert();

      int testErrors = 0;
      Database.Instance.disconnect();
      Database.Instance.connect(true, "casestudy_administration", "password");
      testErrors += Program.runDatabaseTestsFromFile(typeof(DatabaseTestsAdministration));
      Database.Instance.disconnect();
      Database.Instance.connect(true, "casestudy_mitgliederverwalter", "password");
      testErrors += Program.runDatabaseTestsFromFile(typeof(DatabaseTestsMitgliederverwaltung));
      Database.Instance.disconnect();
      Database.Instance.connect(true, "casestudy_standplatzverwalter", "password");
      testErrors += Program.runDatabaseTestsFromFile(typeof(DatabaseTestsStandplatzverwaltung));
      Database.Instance.disconnect();
      Database.Instance.connect(true, "casestudy_qualitaetsverantwortlicher", "password");
      testErrors += Program.runDatabaseTestsFromFile(typeof(DatabaseTestsQualitaetsverantwortliche));
      Database.Instance.disconnect();
      Database.Instance.connect(true);


      if (testErrors == 0) {
        MessageBox.Show($"Successfully ran tests with 0 errors.");
      } else {
        MessageBox.Show($"Failed tests with {testErrors} errors. Use the debugger to debug!");
      }
    }

    static int runDatabaseTestsFromFile(Type fileType)
    {
      Type tests = fileType;
      MethodInfo[] methods = tests.GetMethods();
      Int32 testErrors = 0;;

      foreach (MethodInfo method in methods)
      {
        if (method.Name.StartsWith("test"))
        {
          Database.Instance.runCommand("USE casestudy");
          Database.Instance.runCommand("BEGIN TRANSACTION");

          try
          {
            Convert.ToBoolean(method.Invoke(null, new object[] { }));
          } catch
          {
            /// To debug a failing test, put a breakpoint on the next line!
            testErrors++;
          }

          Database.Instance.runCommand("ROLLBACK");
        }
      }

      return testErrors;
    }
  }
}
