using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class Person : Form
  {
    public Person()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Personerstellen f9 = new Personerstellen();
      f9.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
      Personalleanzeigen f14 = new Personalleanzeigen();
      f14.Show();
    }
  }
}
