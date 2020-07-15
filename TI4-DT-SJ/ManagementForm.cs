using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI4_DT_SJ
{
  public partial class ManagementForm : Form
  {
    private string role;

    public ManagementForm(string role)
    {
      this.role = role;
      InitializeComponent();
    }

    private void ManagementForm_Load(object sender, EventArgs e)
    {
      this.Text = "Freier Markt im Kleinen Management: " + this.role;
    }
  }
}
