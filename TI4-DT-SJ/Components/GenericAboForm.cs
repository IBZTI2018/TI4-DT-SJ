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
  public partial class GenericAboForm : Form {
    private Abo abo;

    public Action<Abo> onSave;

    public GenericAboForm(Abo abo)
    {
      InitializeComponent();
      this.abo = abo;
      this.labelAnbieter.Text = this.abo.anbieter.person.vorname + " " + this.abo.anbieter.person.nachname;
      this.labelAboart.Text = this.abo.aboart.bezeichnung;
    }

    public GenericAboForm()
    {
      InitializeComponent();
      this.abo = new Abo();
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
        this.abo.anbieter = Anbieter.Select(id);
        this.labelAnbieter.Text = this.abo.anbieter.person.vorname + " " + this.abo.anbieter.person.nachname;
      };

      GenericListForm listAnbieter = new GenericListForm("Anbieterliste", opts);
      listAnbieter.Show();
    }

    private void aboartPicker_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Aboart aboart in Aboart.List()) models.Add(aboart);
        return models;
      };

      opts.onSelect = (int id) =>
      {
        this.abo.aboart = Aboart.Select(id);
        this.labelAboart.Text = this.abo.aboart.bezeichnung;
      };

      GenericListForm listAboarten = new GenericListForm("Abotypen-Liste", opts);
      listAboarten.Show();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (this.abo.anbieter== null)
      {
        MessageBox.Show("Es muss ein Anbieter zugewiesen werden!");
        return;
      }

      if (this.abo.aboart == null)
      {
        MessageBox.Show("Es muss eine Abo-Art zugewiesen werden!");
        return;
      }

      this.abo.abschlussdatum = DateTime.Now;
      this.abo.anbieter_id = this.abo.anbieter.id;
      this.abo.aboart_id = this.abo.aboart.id;

      if (this.onSave != null) this.onSave(this.abo);
    }
  }
}
