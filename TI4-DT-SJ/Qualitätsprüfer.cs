using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class Qualitätsprüfer : Form
  {
    public Qualitätsprüfer()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Qualiberichterstellen f21 = new Qualiberichterstellen();
      f21.Show();
    }
  }
}
