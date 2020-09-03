using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class MitgliederverwaltungForm : Form
  {
    public MitgliederverwaltungForm()
    {
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      AdresseForm f6 = new AdresseForm();
      f6.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OrtForm f7 = new OrtForm();
      f7.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      PersonForm f8 = new PersonForm();
      f8.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      RechnungForm f16 = new RechnungForm();
      f16.Show();
    }
  }
}
