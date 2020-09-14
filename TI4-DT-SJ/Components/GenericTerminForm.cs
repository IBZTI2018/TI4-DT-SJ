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
  public partial class GenericTerminForm : Form {
    private Termin termin;

    public Action<Termin> onSave;

    public GenericTerminForm(Termin termin)
    {
      InitializeComponent();
      this.termin = termin;
      this.datePicker.Value = this.termin.datum;
      this.labelAnbieter.Text = this.termin.anbieter.person.vorname + " " + this.termin.anbieter.person.nachname;
      this.labelStandplatz.Text = this.termin.standplatz.standort.bezeichnung + " " + this.termin.standplatz.standplatz_nr;
    }

    public GenericTerminForm()
    {
      InitializeComponent();
      this.termin = new Termin();
    }

    private void anbieterPicker_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (AnbieterView anbieterView in AnbieterView.List()) models.Add(anbieterView);
        return models;
      };

      opts.onSelect = (int id) =>
      {
        this.termin.anbieter = Anbieter.Select(id);
        this.labelAnbieter.Text = this.termin.anbieter.person.vorname + " " + this.termin.anbieter.person.nachname;
      };

      GenericListForm listAnbieter = new GenericListForm("Anbieterliste", opts);
      listAnbieter.Show();
    }

    private void standplatzPicker_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (StandplatzView standplatzView in StandplatzView.List()) models.Add(standplatzView);
        return models;
      };

      opts.onSelect = (int id) =>
      {
        this.termin.standplatz = Standplatz.Select(id);
        this.labelStandplatz.Text = this.termin.standplatz.standort.bezeichnung + " " + this.termin.standplatz.standplatz_nr;
      };

      GenericListForm listAnbieter = new GenericListForm("Anbieterliste", opts);
      listAnbieter.Show();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (this.termin.anbieter == null)
      {
        MessageBox.Show("Es muss ein Anbieter zugewiesen werden!");
        return;
      }

      if (this.termin.standplatz == null)
      {
        MessageBox.Show("Es muss ein Standplatz zugewiesen werden!");
        return;
      }

      this.termin.datum = this.datePicker.Value;
      if (this.termin.anbieter != null) this.termin.anbieter_id = this.termin.anbieter.id;
      if (this.termin.standplatz != null) this.termin.standplatz_id = this.termin.standplatz.id;

      if (this.onSave != null)
      {
        try
        {
          this.onSave(this.termin);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\n\n" + ex.Message);
        }
      }
    }
  }
}
