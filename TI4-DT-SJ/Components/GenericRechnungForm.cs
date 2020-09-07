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
  public partial class GenericRechnungForm : Form {
    private Rechnung rechnung;

    public Action<Rechnung> onSave;

    public GenericRechnungForm(Rechnung rechnung)
    {
      InitializeComponent();
      this.rechnung = rechnung;

      if (this.rechnung.abo != null) this.aboLabel.Text = this.rechnung.abo.aboart.bezeichnung;
      if (this.rechnung.termin != null) this.terminLabel.Text = this.rechnung.termin.datum.ToString();
      // TODO: Does not currently work, need to figure out how to create conditional bindings for views
      this.anbieterLabel.Text = this.rechnung.anbieter.person.vorname + " " + this.rechnung.anbieter.person.nachname;
      this.nrInput.Text = this.rechnung.rechnungs_nr;
      this.betragInput.Value = Convert.ToDecimal(this.rechnung.betrag);
    }

    public GenericRechnungForm()
    {
      InitializeComponent();
      this.rechnung = new Rechnung();
    }

    private void anbieterSelector_Click(object sender, EventArgs e)
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
        this.rechnung.anbieter = Anbieter.Select(id);
        this.anbieterLabel.Text = this.rechnung.anbieter.person.vorname + " " + this.rechnung.anbieter.person.nachname;
      };

      GenericListForm listAnbieter = new GenericListForm("Anbieterliste", opts);
      listAnbieter.Show();
    }

    private void terminSelector_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Termin termin in Termin.List()) models.Add(termin);
        return models;
      };

      opts.onSelect = (int id) =>
      {
        this.rechnung.termin = Termin.Select(id);
        this.terminLabel.Text = this.rechnung.termin.datum.ToString();
      };

      GenericListForm listTermine = new GenericListForm("Terminliste", opts);
      listTermine.Show();
    }

    private void abonnementSelector_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Abo abo in Abo.List()) models.Add(abo);
        return models;
      };

      opts.onSelect = (int id) =>
      {
        this.rechnung.abo = Abo.Select(id);
        this.aboLabel.Text = this.rechnung.abo.aboart.bezeichnung;
      };

      GenericListForm listAbo = new GenericListForm("Aboliste", opts);
      listAbo.Show();
    }

    private void button1_Click(object sender, EventArgs e)
        {
      MessageBox.Show("Diese Funktionalität wird noch mit dem Betreiber abgeklärt...");
        }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (this.rechnung.anbieter == null)
      {
        MessageBox.Show("Es muss ein Anbieter zugewiesen werden!");
        return;
      }

      if (this.rechnung.termin == null && this.rechnung.abo == null)
      {
        MessageBox.Show("Es muss ein Termin oder ein Abo zugewiesen werden!");
        return;
      }

      if (this.rechnung.termin != null && this.rechnung.abo != null)
      {
        MessageBox.Show("Es darf nur ein Termin oder ein Abo zugewiesen werden!");
        return;
      }

      this.rechnung.rechnungs_nr = this.nrInput.Text;
      this.rechnung.betrag = Convert.ToDouble(this.betragInput.Value);
      this.rechnung.anbieter_id = this.rechnung.anbieter.id;
      if (this.rechnung.termin != null) this.rechnung.termin_id = this.rechnung.termin.id;
      if (this.rechnung.abo != null) this.rechnung.abo_id = this.rechnung.abo.id;

      if (this.onSave != null)
      {
        try
        {
          this.onSave(this.rechnung);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\n\n" + ex.Message);
        }
      }
    }
  }
}
