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
  public partial class GenericOrtForm : Form {
    private Ort ort;

    public Action<Ort> onSave;

    public GenericOrtForm(Ort ort)
    {
      InitializeComponent();
      this.ort = ort;
    }

    public GenericOrtForm()
    {
      InitializeComponent();
      this.ort = new Ort();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      this.ort.plz = Convert.ToInt32(this.plzSelector.Value);
      this.ort.ort = this.ortsname.Text;

      if (this.onSave != null) this.onSave(this.ort);
    }
  }
}
