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

      switch (mode) {
        case "create":
          Database.Instance.connect(withDatabase: false);

          break;
        case "drop":
          Database.Instance.connect(withDatabase: false);
          break;
        default:
          Database.Instance.connect(withDatabase: true);

          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new Form1());
          break;
      }
    }
  }
}
