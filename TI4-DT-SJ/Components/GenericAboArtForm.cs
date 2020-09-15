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
      this.inputMonate.Value = Convert.ToDecimal(this.aboart.monate);
      this.inputStandorte.Value = Convert.ToDecimal(this.aboart.standorte);
    }

    public GenericAboArtForm()
    {
      InitializeComponent();
      this.aboart = new Aboart();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      this.aboart.bezeichnung = this.inputName.Text;
      this.aboart.gebuehr = Convert.ToDouble(this.inputPrice.Value);
      this.aboart.monate = Convert.ToInt32(this.inputMonate.Value);
      this.aboart.standorte = Convert.ToInt32(this.inputStandorte.Value);

      if (this.onSave != null)
      {
        try
        {
          this.onSave(this.aboart);
        } catch(Exception ex)
        {
          MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\n\n" + ex.Message);
        }
      }
    }

    private void inputMonate_ValueChanged(object sender, EventArgs e)
    {

    }

    private void inputPrice_ValueChanged(object sender, EventArgs e)
    {

    }

    private void inputStandorte_ValueChanged(object sender, EventArgs e)
    {

    }

    private void inputName_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
