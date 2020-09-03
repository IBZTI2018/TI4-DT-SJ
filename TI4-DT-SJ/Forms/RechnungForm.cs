using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class RechnungForm : Form
  {
    public RechnungForm()
    {
      InitializeComponent();
    }

    private void Form16_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      RechnungerstellenForm f19 = new RechnungerstellenForm();
      f19.Show();
    }
  }
}
