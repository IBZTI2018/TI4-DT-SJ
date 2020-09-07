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
  public partial class GenericAboArtForm : Form {

    private Aboart aboart;

    public Action<Aboart> onSave;

    public GenericAboArtForm(Aboart aboart)
    {
      InitializeComponent();
      this.aboart = aboart;
      this.inputName.Text = this.aboart.bezeichnung;
      this.inputPrice.Value = Convert.ToDecimal(this.aboart.gebuehr);
    }

    public GenericAboArtForm()
    {
      InitializeComponent();
      this.aboart = new Aboart();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      this.aboart.bezeichnung = this.inputName.Text;
      this.aboart.gebuehr  = Convert.ToDouble(this.inputPrice.Value);

      if (this.onSave != null) this.onSave(this.aboart);
    }
  }
}
