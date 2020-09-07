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
  public partial class GenericNachfragerForm : Form {
    private Nachfrager nachfrager;

    public Action<Nachfrager> onSave;

    public GenericNachfragerForm(Nachfrager nachfrager)
    {
      InitializeComponent();
      this.nachfrager = nachfrager;
      this.personLabel.Text = this.nachfrager.person.vorname + " " + this.nachfrager.person.nachname;
    }

    public GenericNachfragerForm()
    {
      InitializeComponent();
      this.nachfrager = new Nachfrager();
    }

    private void personSelector_Click(object sender, EventArgs e)
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
        this.nachfrager.person = Person.Select(id);
        this.personLabel.Text = this.nachfrager.person.vorname + " " + this.nachfrager.person.nachname;
      };

      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericPersonForm personForm = new GenericPersonForm();
        personForm.Show();
        personForm.onSave = (Person person) =>
        {
          int id = person.Insert();
          this.nachfrager.person = person;
          personForm.Close();
          listForm.reload();
        };
      };

      GenericListForm listPersonen = new GenericListForm("Personenliste", opts);
      listPersonen.Show();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (this.nachfrager.person == null)
      {
        MessageBox.Show("Es muss eine Person zugewiesen werden!");
        return;
      }

      this.nachfrager.person_id = this.nachfrager.person.id;

      if (this.onSave != null)
      {
        try
        {
          this.onSave(this.nachfrager);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\n\n" + ex.Message);
        }
      }
    }
  }
}
