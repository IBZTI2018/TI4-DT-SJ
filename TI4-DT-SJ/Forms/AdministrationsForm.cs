using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TI4_DT_SJ.Models;

namespace TI4_DT_SJ
{
  public partial class AdministrationsForm : Form
  {
    public AdministrationsForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OrtForm f7 = new OrtForm();
      f7.Show();
    }
    private void button2_Click(object sender, EventArgs e)
    {
      AdresseForm f6 = new AdresseForm();
      f6.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      PersonForm f8 = new PersonForm();
      f8.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      //this.openManagementForm();
      List<Dictionaryable> list = new List<Dictionaryable>();
      foreach (Models.Anrede anrede in Models.Anrede.List()) list.Add(anrede);
      Components.ListForm x = new Components.ListForm(list);
      x.Show();

      //Anrede f5 = new Anrede();
      //f5.Show();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      AboArtForm f13 = new AboArtForm();
      f13.Show();
    }


  }
}
