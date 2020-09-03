namespace TI4_DT_SJ
{
  partial class PersonalleanzeigenForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(581, 9);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(210, 17);
      this.label3.TabIndex = 10;
      this.label3.Text = "Jennifer Mentner; Sven Gehring";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 9);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(160, 17);
      this.label2.TabIndex = 11;
      this.label2.Text = "TI4-ZH DT3 Case-Study";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(275, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(211, 17);
      this.label1.TabIndex = 14;
      this.label1.Text = "Person: Alle Personen anzeigen";
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(29, 85);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(82, 21);
      this.radioButton1.TabIndex = 15;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Anbieter";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(137, 85);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(100, 21);
      this.radioButton2.TabIndex = 16;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Nachfrager";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(253, 85);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(123, 21);
      this.radioButton3.TabIndex = 17;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "Qualitätsprüfer";
      this.radioButton3.UseVisualStyleBackColor = true;
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new System.Drawing.Point(391, 85);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(174, 21);
      this.radioButton4.TabIndex = 18;
      this.radioButton4.TabStop = true;
      this.radioButton4.Text = "Alle Personen auflisten";
      this.radioButton4.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 54);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(308, 17);
      this.label4.TabIndex = 19;
      this.label4.Text = "Welche Personen kategorie wolle Sie einsehen:";
      // 
      // Personalleanzeigen
      // 
      this.ClientSize = new System.Drawing.Size(800, 131);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.radioButton4);
      this.Controls.Add(this.radioButton3);
      this.Controls.Add(this.radioButton2);
      this.Controls.Add(this.radioButton1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label3);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Personalleanzeigen";
      this.Text = "Freier Markt im Kleinen";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.Label label4;
  }
}
