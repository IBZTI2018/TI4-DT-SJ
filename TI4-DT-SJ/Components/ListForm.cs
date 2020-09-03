using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ.Components {
  public partial class ListForm : Form {
    public ListForm(List<Dictionaryable> values)
    {
      InitializeComponent();

      if (values.Count == 0) return;

      String[] keys = values[0].ValuesAsDict.Keys.ToArray();
      DataTable table = new DataTable();
      foreach (string key in keys) table.Columns.Add(key, typeof(string));
      foreach (Dictionaryable value in values) {
        object[] fields = new object[keys.Length];
        for (int i = 0; i < keys.Length; i++) {
          fields[i] = value.ValuesAsDict[keys[i]];
        }
        table.Rows.Add(fields);
      }

      dataGridView1.DataSource = table;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }
  }
}
