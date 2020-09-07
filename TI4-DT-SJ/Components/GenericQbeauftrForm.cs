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
  public partial class GenericQbeauftrForm : Form {
    private Qualitaetspruefer qpruefer;

    public Action<Qualitaetspruefer> onSave;

    public GenericQbeauftrForm(Qualitaetspruefer qpruefer)
    {
      InitializeComponent();
      this.qpruefer = qpruefer;
      this.lohnPicker.Value = Convert.ToDecimal(this.qpruefer.lohn);
      this.labelPerson.Text = this.qpruefer.person.vorname + " " + this.qpruefer.person.nachname;
    }

    public GenericQbeauftrForm()
    {
      InitializeComponent();
      this.qpruefer = new Qualitaetspruefer();
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
        this.qpruefer.person = Person.Select(id);
        this.labelPerson.Text = this.qpruefer.person.vorname + " " + this.qpruefer.person.nachname;
      };

      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericPersonForm personForm = new GenericPersonForm();
        personForm.Show();
        personForm.onSave = (Person person) =>
        {
          int id = person.Insert();
          this.qpruefer.person = person;
          personForm.Close();
          listForm.reload();
        };
      };

      GenericListForm listPersonen = new GenericListForm("Personenliste", opts);
      listPersonen.Show();
    }

    private void saveButton_Click_1(object sender, EventArgs e)
    {
      if (this.qpruefer.person == null)
      {
        MessageBox.Show("Es muss eine Person zugewiesen werden!");
        return;
      }

      this.qpruefer.person_id = this.qpruefer.person.id;
      this.qpruefer.lohn = Convert.ToDouble(this.lohnPicker.Value);

      if (this.onSave != null) this.onSave(this.qpruefer);
    }
  }
}
