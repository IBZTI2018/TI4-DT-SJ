using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class QualitätsprüferForm : Form
  {
    public QualitätsprüferForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      QualiberichterstellenForm f21 = new QualiberichterstellenForm();
      f21.Show();
    }
  }
}
