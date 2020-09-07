using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ.Components {
  public partial class GenericListForm : Form {
    private List<Dictionaryable> dataSource;
    private int dataIndex;
    private int dataId;

    private GenericListFormOptions options;

    public GenericListForm(string formTitle, List<Dictionaryable> values,  GenericListFormOptions options)
    {
      InitializeComponent();

      // Change window title, if applicable
      if (formTitle != null) this.Text = formTitle;

      // Apply button permissions
      if (options.onSelect == null) this.selectButton.Visible = false;
      if (options.onCreate == null) this.createButton.Visible = false;
      if (options.onUpdate == null) this.updateButton.Visible = false;
      if (options.onDelete == null) this.deleteButton.Visible = false;
      this.options = options;

      // Automatically fill dataGridView with data
      if (values.Count == 0) return;
      this.dataSource = values;
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

      if (this.dataGridView1.Columns["id"] != null)
      {
        this.dataGridView1.Columns["id"].Visible = false;
      }

      this.dataGridView1.DataSource = table;
    }

    private void selectButton_Click(object sender, EventArgs e)
    {
      this.options.onSelect(this.dataId);
      this.Close();
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
      this.options.onDelete(this.dataId);
    }

    private void createButton_Click(object sender, EventArgs e)
    {
      this.options.onCreate();
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
      this.options.onUpdate(this.dataId);
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
      this.dataIndex = this.dataGridView1.CurrentRow.Index;
      Dictionary<string, dynamic> data = this.dataSource[this.dataIndex].ValuesAsDict;
      if (data.ContainsKey("id")) this.dataId = data["id"];
    }
  }

  public class GenericListFormOptions {
    public Action<int> onSelect;
    public Action<int> onUpdate;
    public Action<int> onDelete;
    public Action onCreate;
  }
}
