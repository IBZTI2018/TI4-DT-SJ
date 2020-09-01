using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class Personerstellen : Form
  {
    public Personerstellen()
    {
      InitializeComponent();
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Personerstellenanbieter f10 = new Personerstellenanbieter();
      f10.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Personerstellennachfrager f11 = new Personerstellennachfrager();
      f11.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Personerstellenqualitätsprüfer f12 = new Personerstellenqualitätsprüfer();
      f12.Show();
    }
  }
}
