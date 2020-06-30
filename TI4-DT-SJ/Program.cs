using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

      // We connect to the database when starting right away
      Database.Instance.connect();

      switch (mode) {
        case "create":

          break;
        case "drop":
          break;
        default:
          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new Form1());
          break;
      }
    }
  }
}
