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

    private Anbieter anbieter;

    public Action<Anbieter> onSave;

    public GenericAnbieterForm(Anbieter anbieter)
    {
      InitializeComponent();
      this.anbieter = anbieter;
      if (this.anbieter.prov_aufnahmedatum.Year > 1) this.provAufnPicker.Value = this.anbieter.prov_aufnahmedatum;
      if (this.anbieter.aufnahmedatum.Year > 1) this.aufnPicker.Value = this.anbieter.aufnahmedatum;
      this.checkBoni.Checked = this.anbieter.bonitaet;
      this.checkUnter.Checked = this.anbieter.unterschrift;
      this.personLabel.Text = this.anbieter.person.vorname + " " + this.anbieter.person.nachname;

      this.labelProvAufn.Text = (this.anbieter.prov_aufnahmedatum.Year > 1) ? this.anbieter.prov_aufnahmedatum.ToString() : "nie";
      this.labelAufn.Text = (this.anbieter.aufnahmedatum.Year > 1) ? this.anbieter.aufnahmedatum.ToString() : "nie";
    }

    public GenericAnbieterForm()
    {
      InitializeComponent();
      this.anbieter = new Anbieter();
    }

    private void personselect_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Person person in Person.List("")) models.Add(person);
        return models;
      };

      opts.onSelect = (int id) =>
      {
        this.anbieter.person = Person.Select(id);
        this.personLabel.Text = this.anbieter.person.vorname + " " + this.anbieter.person.nachname;
      };

      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericPersonForm personForm = new GenericPersonForm();
        personForm.Show();
        personForm.onSave = (Person person) =>
        {
          int id = person.Insert();
          this.anbieter.person = person;
          personForm.Close();
          listForm.reload();
        };
      };

      GenericListForm listPersonen = new GenericListForm("Personenliste", opts);
      listPersonen.Show();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (this.anbieter.person == null)
      {
        MessageBox.Show("Es muss eine Person zugewiesen werden!");
        return;
      }

      this.anbieter.prov_aufnahmedatum = this.provAufnPicker.Value;
      this.anbieter.aufnahmedatum = this.aufnPicker.Value;
      this.anbieter.bonitaet = this.checkBoni.Checked;
      this.anbieter.unterschrift = this.checkUnter.Checked;
      this.anbieter.person_id = this.anbieter.person.id;

      if (this.onSave != null) this.onSave(this.anbieter);
    }
  }
}
