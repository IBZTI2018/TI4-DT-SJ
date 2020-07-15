using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class MainForm : Form
  {
    private string role = "";
    private ManagementForm form = null;

    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.role = "administration";
      this.openManagementForm();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.role = "mitgliederverwaltung";
      this.openManagementForm();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.role = "standplatzverwaltung";
      this.openManagementForm();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.role = "qualitaetsbeauftragter";
      this.openManagementForm();
    }

    private void openManagementForm()
    {
      if (this.form != null)
      {
        this.form.Hide();
        this.form.Dispose();
      }

      this.form = new ManagementForm(this.role);
      this.form.Show();
    }
  }
}
