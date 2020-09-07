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
  public partial class GenericQBerichtForm : Form {
    private Qualitaetsbewertung bewertung;

    public Action<Qualitaetsbewertung> onSave;

    public GenericQBerichtForm(Qualitaetsbewertung bewertung)
    {
      InitializeComponent();
      this.bewertung = bewertung;
      this.labelAnbieter.Text = this.bewertung.anbieter.person.vorname + " " + this.bewertung.anbieter.person.nachname;
      this.labelPruefer.Text = this.bewertung.qualitaetspruefer.person.vorname + " " + this.bewertung.qualitaetspruefer.person.nachname;
      this.inputText.Text = this.bewertung.bezeichnung;
    }

    public GenericQBerichtForm()
    {
      InitializeComponent();
      this.bewertung = new Qualitaetsbewertung();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      this.bewertung.bezeichnung = this.inputText.Text;
      this.bewertung.anbieter_id = this.bewertung.anbieter.id;
      this.bewertung.qualitaetspruefer_id = this.bewertung.qualitaetspruefer.id;

      if (this.onSave != null) this.onSave(this.bewertung);
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
        this.bewertung.anbieter = Anbieter.Select(id);
        this.labelAnbieter.Text = this.bewertung.anbieter.person.vorname + " " + this.bewertung.anbieter.person.nachname;
      };

      GenericListForm listPersonen = new GenericListForm("Anbieterliste", opts);
      listPersonen.Show();
    }

    private void prueferSelector_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (QualitaetsprueferView prueferView in QualitaetsprueferView.List()) models.Add(prueferView);
        return models;
      };

      opts.onSelect = (int id) =>
      {
        this.bewertung.qualitaetspruefer = Qualitaetspruefer.Select(id);
        this.labelPruefer.Text = this.bewertung.qualitaetspruefer.person.vorname + " " + this.bewertung.qualitaetspruefer.person.nachname;
      };

      GenericListForm listPersonen = new GenericListForm("Qualitätsprüferliste", opts);
      listPersonen.Show();
    }
  }
}
