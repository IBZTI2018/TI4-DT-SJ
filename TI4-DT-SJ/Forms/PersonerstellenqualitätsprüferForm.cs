using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class PersonerstellenqualitätsprüferForm : Form
  {
    public PersonerstellenqualitätsprüferForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      PersonForm person = new PersonForm();
      QualitätsprüferForm q = new QualitätsprüferForm();

    }
  }
}
