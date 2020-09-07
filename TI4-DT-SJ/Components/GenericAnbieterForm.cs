using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ.Components {
  public partial class GenericAnbieterForm : Form {
    private AnbieterView anbieterView;

    public GenericAnbieterForm(AnbieterView anbieterView)
    {
      InitializeComponent();
      this.anbieterView = anbieterView;
    }

    public GenericAnbieterForm()
    {
      InitializeComponent();
      this.anbieterView = new AnbieterView();
    }

    private void personselect_Click(object sender, EventArgs e)
    {

    }
  }
}
