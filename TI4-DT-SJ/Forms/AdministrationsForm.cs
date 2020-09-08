using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TI4_DT_SJ.Models;
using TI4_DT_SJ.Components;

namespace TI4_DT_SJ
{
  public partial class AdministrationsForm : Form
  {
    public AdministrationsForm()
    {
      InitializeComponent();
    }

    private void ortButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Ort ort in Ort.List()) models.Add(ort);
        return models;
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Ort ort = Ort.Select(id);
        GenericOrtForm ortForm = new GenericOrtForm(ort);
        ortForm.Show();
        ortForm.onSave = (Ort ortNeu) =>
        {
          ortNeu.Update();
          ortForm.Close();
          listForm.reload();
        };
      };
      opts.onDelete = (GenericListForm listForm, int id) =>
      {
        Ort ort = Ort.Select(id);
        ort.Delete();
        listForm.reload();
      };

      GenericListForm ortList = new GenericListForm("Orte", opts);
      ortList.Show();
    }
    private void adresseButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (AdresseView adresseView in AdresseView.List()) models.Add(adresseView);
        return models;
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Adresse adresse = Adresse.Select(id);
        GenericAdresseForm adresseForm = new GenericAdresseForm(adresse);
        adresseForm.Show();
        adresseForm.onSave = (Adresse adresseNeu) =>
        {
          adresseNeu.Update();
          adresseForm.Close();
          listForm.reload();
        };
      };
      opts.onDelete = (GenericListForm listForm, int id) =>
      {
        Adresse adresse = Adresse.Select(id);
        adresse.Delete();
        listForm.reload();
      };

      GenericListForm adressList = new GenericListForm("Adressen", opts);
      adressList.Show();
    }

    private void qBeauftragteButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (QualitaetsprueferView qprueferView in QualitaetsprueferView.List()) models.Add(qprueferView);
        return models;
      };
      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericQbeauftrForm qbeauftrForm = new GenericQbeauftrForm();
        qbeauftrForm.Show();
        qbeauftrForm.onSave = (Qualitaetspruefer qpr) =>
        {
          int id = qpr.Insert();
          qbeauftrForm.Close();
          listForm.reload();
        };
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Qualitaetspruefer qpruefer = Qualitaetspruefer.Select(id);
        GenericQbeauftrForm qbeauftrForm = new GenericQbeauftrForm(qpruefer);
        qbeauftrForm.Show();
        qbeauftrForm.onSave = (Qualitaetspruefer qprueferNeu) =>
        {
          qprueferNeu.Update();
          qbeauftrForm.Close();
          listForm.reload();
        };
      };
      opts.onDelete = (GenericListForm listForm, int id) =>
      {
        Qualitaetspruefer qpruefer = Qualitaetspruefer.Select(id);
        qpruefer.Delete();
        listForm.reload();
      };

      GenericListForm qPrueferList = new GenericListForm("Qualitätsprüfer", opts);
      qPrueferList.Show();
    }

    private void personButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (PersonView personView in PersonView.List("")) models.Add(personView);
        return models;
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Person person = Person.Select(id);
        GenericPersonForm personForm = new GenericPersonForm(person);
        personForm.Show();
        personForm.onSave = (Person personNeu) =>
        {
          personNeu.Update();
          personForm.Close();
          listForm.reload();
        };
      };
      opts.onDelete = (GenericListForm listForm, int id) =>
      {
        Person person = Person.Select(id);
        person.Delete();
        listForm.reload();
      };

      GenericListForm personList = new GenericListForm("Personen", opts);
      personList.Show();
    }

    private void aboartButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Aboart aboart in Aboart.List()) models.Add(aboart);
        return models;
      };
      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericAboArtForm aboartForm = new GenericAboArtForm();
        aboartForm.Show();
        aboartForm.onSave = (Aboart aboartNeu) =>
        {
          int id = aboartNeu.Insert();
          aboartForm.Close();
          listForm.reload();
        };
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Aboart aboart = Aboart.Select(id);
        GenericAboArtForm aboartForm = new GenericAboArtForm(aboart);
        aboartForm.Show();
        aboartForm.onSave = (Aboart aboartNeu) =>
        {
          aboartNeu.Update();
          aboartForm.Close();
          listForm.reload();
        };
      };
      opts.onDelete = (GenericListForm listForm, int id) =>
      {
        Aboart aboart = Aboart.Select(id);
        aboart.Delete();
        listForm.reload();
      };

      GenericListForm aboartList = new GenericListForm("Abonnements-Typen", opts);
      aboartList.Show();
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
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Rechnung rechnung = Rechnung.Select(id);
        GenericRechnungForm rechnungForm = new GenericRechnungForm(rechnung);
        rechnungForm.Show();
        rechnungForm.onSave = (Rechnung rechnungNeu) =>
        {
          rechnungNeu.Update();
          rechnungForm.Close();
          listForm.reload();
        };
      };
      opts.onDelete = (GenericListForm listForm, int id) =>
      {
        Rechnung rechnung = Rechnung.Select(id);
        rechnung.Delete();
        listForm.reload();
      };

      GenericListForm rechnungList = new GenericListForm("Rechnungen", opts);
      rechnungList.Show();
    }
  }
}
