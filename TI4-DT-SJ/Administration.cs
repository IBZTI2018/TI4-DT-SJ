using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class Administration : Form
  {
    public Administration()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
    private void button2_Click(object sender, EventArgs e)
    {
      Adresse f6 = new Adresse();
      f6.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
      Anrede f5 = new Anrede();
      f5.Show();
    }

    private void button5_Click(object sender, EventArgs e)
    {

    }


  }
}
