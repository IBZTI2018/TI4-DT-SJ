using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI4_DT_SJ.Components;
using TI4_DT_SJ.Models;
using System.Configuration;

namespace TI4_DT_SJ
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      string databaseName = ConfigurationManager.AppSettings["databaseUserAdm"];
      string databasePass = ConfigurationManager.AppSettings["databasePassAdm"];
      Database.Instance.connect(true, databaseName, databasePass);
      AdministrationsForm administrationForm = new AdministrationsForm();
      administrationForm.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string databaseName = ConfigurationManager.AppSettings["databaseUserMgv"];
      string databasePass = ConfigurationManager.AppSettings["databasePassMgv"];
      Database.Instance.connect(true, databaseName, databasePass);
      MitgliederverwaltungForm mitgliederForm = new MitgliederverwaltungForm();
      mitgliederForm.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      string databaseName = ConfigurationManager.AppSettings["databaseUserStv"];
      string databasePass = ConfigurationManager.AppSettings["databasePassStv"];
      Database.Instance.connect(true, databaseName, databasePass);
      StandplatzverwaltungForm standplatzForm = new StandplatzverwaltungForm();
      standplatzForm.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      string databaseName = ConfigurationManager.AppSettings["databaseUserQav"];
      string databasePass = ConfigurationManager.AppSettings["databasePassQav"];
      Database.Instance.connect(true, databaseName, databasePass);
      QualitätsprüferForm qprueferForm = new QualitätsprüferForm();
      qprueferForm.Show();
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
  }
}
