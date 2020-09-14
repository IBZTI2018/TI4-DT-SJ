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

    private void rechnungButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (RechnungView rechnung in RechnungView.List()) models.Add(rechnung);
        return models;
      };

      GenericListForm rechnungList = new GenericListForm("Rechnungen", opts);
      rechnungList.Show();
    }

    private void terminButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (TerminView termin in TerminView.List()) models.Add(termin);
        return models;
      };
      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericTerminForm terminForm = new GenericTerminForm();
        terminForm.Show();
        terminForm.onSave = (Termin newTermin) =>
        {
          int id = newTermin.Insert();
          terminForm.Close();
          listForm.reload();
        };
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Termin termin = Termin.Select(id);
        GenericTerminForm terminForm = new GenericTerminForm(termin);
        terminForm.Show();
        terminForm.onSave = (Termin newTermin) =>
        {
          newTermin.Update();
          terminForm.Close();
          listForm.reload();
        };
      };
      opts.onDelete = (GenericListForm listForm, int id) =>
      {
        Termin termin = Termin.Select(id);
        termin.Delete();
        listForm.reload();
      };

      GenericListForm terminList = new GenericListForm("Termine", opts);
      terminList.Show();
    }

    private void standplatzButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (StandplatzView standplatz in StandplatzView.List()) models.Add(standplatz);
        return models;
      };
      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericStandplatzForm standplatzForm = new GenericStandplatzForm();
        standplatzForm.Show();
        standplatzForm.onSave = (Standplatz newStandplatz) =>
        {
          int id = newStandplatz.Insert();
          standplatzForm.Close();
          listForm.reload();
        };
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Standplatz standplatz = Standplatz.Select(id);
        GenericStandplatzForm standplatzForm = new GenericStandplatzForm(standplatz);
        standplatzForm.Show();
        standplatzForm.onSave = (Standplatz newStandplatz) =>
        {
          newStandplatz.Update();
          standplatzForm.Close();
          listForm.reload();
        };
      };
      opts.onDelete = (GenericListForm listForm, int id) =>
      {
        Standplatz standort = Standplatz.Select(id);
        standort.Delete();
        listForm.reload();
      };

      GenericListForm standplatzList = new GenericListForm("Standplätze", opts);
      standplatzList.Show();
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

      GenericListForm standortList = new GenericListForm("Standorte", opts);
      standortList.Show();
    }
  }
}
