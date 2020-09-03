using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class PersonerstellenForm : Form
  {
    public PersonerstellenForm()
    {
      InitializeComponent();
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      PersonerstellenanbieterForm f10 = new PersonerstellenanbieterForm();
      f10.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      PersonerstellennachfragerForm f11 = new PersonerstellennachfragerForm();
      f11.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      PersonerstellenqualitätsprüferForm f12 = new PersonerstellenqualitätsprüferForm();
      f12.Show();
    }
  }
}
