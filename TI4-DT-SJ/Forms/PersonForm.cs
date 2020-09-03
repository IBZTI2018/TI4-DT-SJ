using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class PersonForm : Form
  {
    public PersonForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      PersonerstellenForm f9 = new PersonerstellenForm();
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
      PersonalleanzeigenForm f14 = new PersonalleanzeigenForm();
      f14.Show();
    }
  }
}
