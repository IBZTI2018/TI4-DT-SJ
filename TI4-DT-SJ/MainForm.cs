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
      Administration f1 = new Administration();
      f1.Show();

    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.role = "mitgliederverwaltung";
      Mitgliederverwaltung f2 = new Mitgliederverwaltung();
      f2.Show();

    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.role = "standplatzverwaltung";
      Standplatzverwaltung f3 = new Standplatzverwaltung();
      f3.Show();
     
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.role = "qualitaetsbeauftragter";
      Qualitaetsbeauftragter f4 = new Qualitaetsbeauftragter();
      f4.Show();

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
  }
}
