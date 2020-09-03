using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace TI4_DT_SJ
{
  static class Program {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      string mode = "interface";

      // If a mode parameter is given, the default mode is overwritten
      if (args.Length == 1) mode = args[0];

      switch (mode)
      {
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

      foreach (String query in scriptData)
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
        }
        catch (Exception e)
        {
          MessageBox.Show($"Failed to run script query {query} with error {e.Message}\n\n There might be leftovers in the database, please clean it using the drop script in the management studio!");
          break;
        }
      }

      Database.Instance.disconnect();
    }
  }
}
