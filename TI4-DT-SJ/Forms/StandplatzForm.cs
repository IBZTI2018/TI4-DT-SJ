using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class StandplatzForm : Form
  {
    public StandplatzForm()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      StandplatzlöschenForm f20 = new StandplatzlöschenForm();
      f20.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
  }
}
