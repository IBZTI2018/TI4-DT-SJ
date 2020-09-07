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
  public partial class GenericPersonForm : Form {
    private Person person;

    public Action<Person> onSave;

    public GenericPersonForm(Person person)
    {
      InitializeComponent();
      this.person = person;
    }

    public GenericPersonForm()
    {
      InitializeComponent();
      this.person = new Person();
    }

    private void anredeSelector_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Anrede anrede in Anrede.List()) models.Add(anrede);
        return models;
      };
      opts.onSelect = (int id) =>
      {
        this.person.anrede = Anrede.Select(id);
        this.anredeLabel.Text = this.person.anrede.bezeichnung;
      };

      GenericListForm form = new GenericListForm("Anrede", opts);
      form.Show();
    }

    private void adresseSelector_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Adresse adresse in Adresse.List()) models.Add(adresse);
        return models;
      };
      opts.onSelect = (int id) =>
      {
        this.person.adresse = Adresse.Select(id);
        this.adresseLabel.Text = this.person.adresse.strassenname + " in " + this.person.adresse.ort.ort;
      };
      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericAdresseForm adresseForm = new GenericAdresseForm();
        adresseForm.Show();
        adresseForm.onSave = (Adresse adresse) =>
        {
          int id = adresse.Insert();
          adresseForm.Close();
          listForm.reload();
        };
      };

      GenericListForm form = new GenericListForm("Anrede", opts);
      form.Show();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      this.person.vorname = this.inputVorname.Text;
      this.person.nachname = this.inputNachname.Text;
      this.person.email = this.inputEmail.Text;
      this.person.geburtsdatum = this.dateTimePicker1.Value;

      if (this.onSave != null) this.onSave(this.person);
    }
  }
}
