﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class Standplatz : Form
  {
    public Standplatz()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Standplatzlöschen f20 = new Standplatzlöschen();
      f20.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
  }
}
