using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class Mitgliederverwaltung : Form
  {
    public Mitgliederverwaltung()
    {
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      Adresse f6 = new Adresse();
      f6.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Ort f7 = new Ort();
      f7.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Person f8 = new Person();
      f8.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Rechnung f16 = new Rechnung();
      f16.Show();
    }
  }
}
