using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class Rechnung : Form
  {
    public Rechnung()
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
      Rechnungerstellen f19 = new Rechnungerstellen();
      f19.Show();
    }
  }
}
