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
        foreach (Adresse adresse in Adresse.List()) models.Add(adresse);
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

    private void button3_Click(object sender, EventArgs e)
    {
      PersonForm f8 = new PersonForm();
      f8.Show();
    }

    private void personButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (Person person in Person.List("")) models.Add(person);
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

    private void button5_Click(object sender, EventArgs e)
    {
      AboArtForm f13 = new AboArtForm();
      f13.Show();
    }


  }
}
