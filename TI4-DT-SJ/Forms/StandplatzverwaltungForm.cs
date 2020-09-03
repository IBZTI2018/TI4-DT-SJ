using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class StandplatzverwaltungForm : Form
  {
    public StandplatzverwaltungForm()
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
      TerminForm f15 = new TerminForm();
      f15.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      RechnungForm f16 = new RechnungForm();
      f16.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      StandortForm f17 = new StandortForm();
      f17.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      StandplatzForm f18 = new StandplatzForm();
      f18.Show();
    }
  }
}
