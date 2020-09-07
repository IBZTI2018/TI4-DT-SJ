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
  public partial class GenericListForm : Form {
    private List<Dictionaryable> dataSource;
    private int dataIndex;
    private int dataId;

    public int selectedId;

    public GenericListForm(string formTitle, List<Dictionaryable> values,  GenericListFormOptions options)
    {
      InitializeComponent();

      // Change window title, if applicable
      if (formTitle != null) this.Text = formTitle;

      // Apply button permissions
      if (!options.showSelectButton) this.selectButton.Visible = false;
      if (!options.showCreateButton) this.createButton.Visible = false;
      if (!options.showUpdateButton) this.updateButton.Visible = false;
      if (!options.showDeleteButton) this.deleteButton.Visible = false;

      // Automatically fill dataGridView with data
      if (values.Count == 0) return;
      this.dataSource = values;
      List<string> keyList = values[0].ValuesAsDict.Keys.ToList();
      keyList.Remove("id");
      String[] keys = keyList.ToArray();
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

    private void selectButton_Click(object sender, EventArgs e)
    {
      this.selectedId = this.dataId;
      this.Close();
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {

    }

    private void GenericListForm_Load(object sender, EventArgs e)
    {

    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
      this.dataIndex = this.dataGridView1.CurrentRow.Index;
      Dictionary<string, dynamic> data = this.dataSource[this.dataIndex].ValuesAsDict;
      if (data.ContainsKey("id")) this.dataId = data["id"];
    }

    private void createButton_Click(object sender, EventArgs e)
    {

    }

    private void updateButton_Click(object sender, EventArgs e)
    {

    }
  }

  public class GenericListFormOptions {
    public bool showSelectButton;
    public bool showCreateButton;
    public bool showUpdateButton;
    public bool showDeleteButton;

    public Form modelForm;

    public GenericListFormOptions(bool select, bool create, bool update, bool delete)
    {
      this.showSelectButton = select;
      this.showCreateButton = create;
      this.showUpdateButton = update;
      this.showDeleteButton = delete;
    }
  }
}
