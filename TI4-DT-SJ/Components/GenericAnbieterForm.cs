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
      this.checkBoni.Checked = this.anbieter.bonitaet;
      this.checkUnter.Checked = this.anbieter.unterschrift;
      this.checkBesuch.Checked = this.anbieter.mitarbeiterbesuch;
      this.personLabel.Text = this.anbieter.person.vorname + " " + this.anbieter.person.nachname;

      if (this.anbieter.prov_aufnahmedatum.Year > 1)
      {
        this.labelProvAufn.Text = this.anbieter.prov_aufnahmedatum.ToString();
        this.provAufnehmButton.Visible = false;
      } else
      {
        this.labelProvAufn.Text = "nie";
      }

      if (this.anbieter.aufnahmedatum.Year > 1)
      {
        this.labelAufn.Text = this.anbieter.aufnahmedatum.ToString();
        this.aufnehmButton.Visible = false;
      }
      else
      {
        this.labelAufn.Text = "nie";
      }
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

      this.anbieter.bonitaet = this.checkBoni.Checked;
      this.anbieter.unterschrift = this.checkUnter.Checked;
      this.anbieter.mitarbeiterbesuch = this.checkBesuch.Checked;
      this.anbieter.person_id = this.anbieter.person.id;

      if (this.onSave != null)
      {
        try
        {
          this.onSave(this.anbieter);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\n\n" + ex.Message);
        }
      }
    }

    private void provAufnehmButton_Click(object sender, EventArgs e)
    {
      // Provisorische Aufnahme ist nur unter Bedingungen möglich
      if (this.anbieter.bonitaet && this.anbieter.unterschrift && this.anbieter.mitarbeiterbesuch)
      {
        this.anbieter.prov_aufnahmedatum = DateTime.Now;
      } else
      {
        MessageBox.Show("Anbieter erfüllt die Bedingungen für eine provisorische Aufnahme nicht!");
      }
    }

    private void aufnehmButton_Click(object sender, EventArgs e)
    {
      // Finale Aufnahme ist nur unter Bedingungen möglich
      // Provisorische Aufnahme ist nur unter Bedingungen möglich
      if (this.anbieter.bonitaet && this.anbieter.unterschrift && this.anbieter.mitarbeiterbesuch && this.anbieter.prov_aufnahmedatum.Year > 1)
      {
        int c = (int)Database.Instance.getCommand("SELECT COUNT(*) FROM qualitaetsbewertung WHERE anbieter_id = " + this.anbieter.id).ExecuteScalar();
        this.anbieter.prov_aufnahmedatum = DateTime.Now;
      }
      else
      {
        MessageBox.Show("Anbieter erfüllt die Bedingungen für eine finale Aufnahme nicht!");
      }
    }
  }
}
