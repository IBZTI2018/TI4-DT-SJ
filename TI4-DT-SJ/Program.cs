using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

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
          break;
        case "drop":
          Program.runDatabaseScript("DatabaseDrop");
          break;
        case "seed":
          Program.runDatabaseScript("DatabaseSeed");
          break;
        default:
          Database.Instance.connect(withDatabase: true);

          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new Form1());
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
          string cleanQuery = query.Trim().ToLower();
          if (cleanQuery == "" || cleanQuery == "go") continue;

          SqlCommand command = Database.Instance.command(cleanQuery);
          command.ExecuteNonQuery();
        } catch (Exception e)
        {
          MessageBox.Show($"Failed to run script query {query} with error {e.Message}");
          break;
        }
      }

      MessageBox.Show($"Successfully ran script {scriptName}.");
    }
  }
}
