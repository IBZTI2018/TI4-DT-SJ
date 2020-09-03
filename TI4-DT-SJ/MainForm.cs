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

namespace TI4_DT_SJ
{
  public partial class MainForm : Form
  {
    private string role = "";
    //private AdministrationForm form = null;
    
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
      AdministrationsForm f1 = new AdministrationsForm();
      f1.Show();

    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.role = "mitgliederverwaltung";
      MitgliederverwaltungForm f2 = new MitgliederverwaltungForm();
      f2.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.role = "standplatzverwaltung";
      StandplatzverwaltungForm f3 = new StandplatzverwaltungForm();
      f3.Show();
     
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.role = "qualitaetsbeauftragter";
      QualitätsprüferForm f4 = new QualitätsprüferForm();
      f4.Show();

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
  }
}
