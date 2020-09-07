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
  public partial class GenericAdresseForm : Form {
    private Adresse adresse;

    public Action<Adresse> onSave;

    public GenericAdresseForm(Adresse adresse)
    {
      InitializeComponent();
      this.adresse = adresse;
      this.strasseInput.Text = this.adresse.strassenname;
      this.hausNrSelector.Value = Convert.ToDecimal(this.adresse.hausnummer);
      this.ortLabel.Text = this.adresse.ort.plz + " " + this.adresse.ort.ort;
    }

    public GenericAdresseForm()
    {
      InitializeComponent();
      this.adresse = new Adresse();
    }

    private void selectOrtButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Ort ort in Ort.List("")) models.Add(ort);
        return models;
      };

      opts.onSelect = (int id) =>
      {
        this.adresse.ort = Ort.Select(id);
        this.ortLabel.Text = this.adresse.ort.plz + " " + this.adresse.ort.ort;
      };

      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericOrtForm ortForm = new GenericOrtForm();
        ortForm.Show();
        ortForm.onSave = (Ort ort) =>
        {
          int id = ort.Insert();
          ortForm.Close();
          listForm.reload();
        };
      };

      GenericListForm listOrte = new GenericListForm("Ortsliste", opts);
      listOrte.Show();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
      if (this.adresse.ort == null)
      {
        MessageBox.Show("Es muss ein Ort zugewiesen werden!");
        return;
      }

      this.adresse.strassenname = this.strasseInput.Text;
      this.adresse.hausnummer = Convert.ToInt32(this.hausNrSelector.Value);
      this.adresse.ort_id = this.adresse.ort.id;

      if (this.onSave != null)
      {
        try
        {
          this.onSave(this.adresse);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\n\n" + ex.Message);
        }
      }
    }
  }
}
