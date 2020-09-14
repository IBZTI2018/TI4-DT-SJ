using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TI4_DT_SJ.Components;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ
{
  public partial class StandplatzverwaltungForm : Form
  {
    public StandplatzverwaltungForm()
    {
      InitializeComponent();
    }

    private void Form3_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      TerminForm f15 = new TerminForm();
      f15.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      RechnungForm f16 = new RechnungForm();
      f16.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      StandortForm f17 = new StandortForm();
      f17.Show();
    }

    private void standortButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Standort standort in Standort.List()) models.Add(standort);
        return models;
      };
      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericStandortForm standortForm = new GenericStandortForm();
        standortForm.Show();
        standortForm.onSave = (Standort newStandort) =>
        {
          int id = newStandort.Insert();
          standortForm.Close();
          listForm.reload();
        };
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Standort standort = Standort.Select(id);
        GenericStandortForm standortForm = new GenericStandortForm(standort);
        standortForm.Show();
        standortForm.onSave = (Standort newStandort) =>
        {
          newStandort.Update();
          standortForm.Close();
          listForm.reload();
        };
      };
      opts.onDelete = (GenericListForm listForm, int id) =>
      {
        Standort standort = Standort.Select(id);
        standort.Delete();
        listForm.reload();
      };

      GenericListForm nachfragerViewList = new GenericListForm("Nachfrager", opts);
      nachfragerViewList.Show();
    }
  }
}
