using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class Standplatzverwaltung : Form
  {
    public Standplatzverwaltung()
    {
      InitializeComponent();
    }

    private void Form3_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Termin f15 = new Termin();
      f15.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Rechnung f16 = new Rechnung();
      f16.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Standort f17 = new Standort();
      f17.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Standplatz f18 = new Standplatz();
      f18.Show();
    }
  }
}
