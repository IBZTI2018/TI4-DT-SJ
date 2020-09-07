﻿using System;
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
  public partial class MitgliederverwaltungForm : Form
  {
    delegate void deleteDelegate(int id);

    public MitgliederverwaltungForm()
    {
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void anbieterButtonClick(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (AnbieterView anbieter in AnbieterView.List("")) models.Add(anbieter);
        return models;
      };
      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericAnbieterForm anbieterForm = new GenericAnbieterForm();
        anbieterForm.Show();
        anbieterForm.onSave = (Anbieter anbieter) =>
        {
          int id = anbieter.Insert();
          anbieterForm.Close();
          listForm.reload();
        };
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Anbieter anbieter = Anbieter.Select(id);
        GenericAnbieterForm anbieterForm = new GenericAnbieterForm(anbieter);
        anbieterForm.Show();
        anbieterForm.onSave = (Anbieter anbieterNeu) =>
        {
          anbieterNeu.Update();
          anbieterForm.Close();
          listForm.reload();
        };
      };

      GenericListForm anbieterViewList = new GenericListForm("Anbieter", opts);
      anbieterViewList.Show();
    }

    private void nachfragerButton_Click(object sender, EventArgs e)
    {
      GenericListFormOptions opts = new GenericListFormOptions();
      opts.dataLoader = () =>
      {
        List<Dictionaryable> models = new List<Dictionaryable>();
        foreach (NachfragerView nachfrager in NachfragerView.List("")) models.Add(nachfrager);
        return models;
      };
      opts.onCreate = (GenericListForm listForm) =>
      {
        GenericNachfragerForm nachfragerForm = new GenericNachfragerForm();
        nachfragerForm.Show();
        nachfragerForm.onSave = (Nachfrager nachfrager) =>
        {
          int id = nachfrager.Insert();
          nachfragerForm.Close();
          listForm.reload();
        };
      };
      opts.onUpdate = (GenericListForm listForm, int id) =>
      {
        Nachfrager nachfrager = Nachfrager.Select(id);
        GenericNachfragerForm nachfragerForm = new GenericNachfragerForm(nachfrager);
        nachfragerForm.Show();
        nachfragerForm.onSave = (Nachfrager nachfragerNeu) =>
        {
          nachfragerNeu.Update();
          nachfragerForm.Close();
          listForm.reload();
        };
      };

      GenericListForm nachfragerViewList = new GenericListForm("Nachfrager", opts);
      nachfragerViewList.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      PersonForm f8 = new PersonForm();
      f8.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      RechnungForm f16 = new RechnungForm();
      f16.Show();
    }
  }
}
