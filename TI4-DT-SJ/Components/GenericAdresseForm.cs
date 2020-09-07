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

    public GenericAdresseForm(Adresse adresse)
    {
      InitializeComponent();
      this.adresse = adresse;
      this.ortLabel.Text = this.adresse.ort.plz + " " + this.adresse.ort.ort;
    }

    public GenericAdresseForm()
    {
      InitializeComponent();
      this.adresse = new Adresse();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {

    }

    private void selectOrtButton_Click(object sender, EventArgs e)
    {
      List<Dictionaryable> models = new List<Dictionaryable>();
      foreach (Ort ort in Ort.List("")) models.Add(ort);
      GenericListFormOptions opts = new GenericListFormOptions();

      opts.onSelect = (int id) =>
      {
        this.adresse.ort = Ort.Select(id);
        this.ortLabel.Text = this.adresse.ort.plz + " " + this.adresse.ort.ort;
      };

      GenericListForm listOrte = new GenericListForm("Ortsliste", models, opts);
      listOrte.Show();
    }
  }
}
