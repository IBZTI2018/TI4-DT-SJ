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
  public partial class GenericStandplatzForm : Form {
    private Standplatz standplatz;

    public Action<Standplatz> onSave;

    public GenericStandplatzForm(Standplatz standplatz)
    {
      InitializeComponent();
      this.standplatz = standplatz;
      this.inputNumber.Value = this.standplatz.standplatz_nr;
      this.labelStandort.Text = this.standplatz.standort.bezeichnung;
    }

    public GenericStandplatzForm()
    {
      InitializeComponent();
      this.standplatz = new Standplatz();
    }

    private void standortPicker_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Standort standort in Standort.List()) models.Add(standort);
        return models;
      };

      opts.onSelect = (int id) =>
      {
        this.standplatz.standort = Standort.Select(id);
        this.labelStandort.Text = this.standplatz.standort.bezeichnung;
      };

      GenericListForm listStandorte = new GenericListForm("Standorte", opts);
      listStandorte.Show();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (this.standplatz.standort == null)
      {
        MessageBox.Show("Es muss ein Standort zugewiesen werden!");
        return;
      }

      this.standplatz.standplatz_nr = Convert.ToInt32(this.inputNumber.Value);
      if (this.standplatz.standort != null) this.standplatz.standort_id = this.standplatz.standort.id;

      if (this.onSave != null)
      {
        try
        {
          this.onSave(this.standplatz);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\n\n" + ex.Message);
        }
      }
    }
  }
}
