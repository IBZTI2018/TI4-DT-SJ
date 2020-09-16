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
  public partial class GenericStandortForm : Form {
    private Standort standort;

    public Action<Standort> onSave;

    public GenericStandortForm(Standort standort)
    {
      InitializeComponent();
      this.standort = standort;
      this.inputName.Text = standort.bezeichnung;
    }

    public GenericStandortForm()
    {
      InitializeComponent();
      this.standort = new Standort();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (!String.IsNullOrWhiteSpace(this.inputName.Text)) this.standort.bezeichnung = this.inputName.Text;

      if (this.onSave != null)
      {
        try
        {
          this.onSave(this.standort);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\n\n" + ex.Message);
        }
      }
    }
  }
}
