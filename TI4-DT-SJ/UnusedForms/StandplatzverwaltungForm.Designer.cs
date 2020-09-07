namespace TI4_DT_SJ
{
  partial class StandplatzverwaltungForm
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(391, 9);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(210, 17);
      this.label3.TabIndex = 7;
      this.label3.Text = "Jennifer Mentner; Sven Gehring";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 9);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(160, 17);
      this.label2.TabIndex = 8;
      this.label2.Text = "TI4-ZH DT3 Case-Study";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(226, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(132, 17);
      this.label1.TabIndex = 9;
      this.label1.Text = "Standplatzverwalter";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // button1
      // 
      this.button1.AccessibleDescription = "button1_Click";
      this.button1.Location = new System.Drawing.Point(456, 96);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(122, 69);
      this.button1.TabIndex = 10;
      this.button1.Text = "Termin";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.AccessibleDescription = "button2_Click";
      this.button2.Location = new System.Drawing.Point(316, 96);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(123, 68);
      this.button2.TabIndex = 11;
      this.button2.Text = "Rechnung";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.AccessibleDescription = "button3_Click";
      this.button3.Location = new System.Drawing.Point(171, 96);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(123, 68);
      this.button3.TabIndex = 12;
      this.button3.Text = "Standort";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.AccessibleDescription = "button4_Click";
      this.button4.Location = new System.Drawing.Point(16, 97);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(123, 68);
      this.button4.TabIndex = 13;
      this.button4.Text = "Standplatz";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(205, 76);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(187, 17);
      this.label4.TabIndex = 14;
      this.label4.Text = "Was wollen Sie bearbeiten...";
      // 
      // Standplatzverwaltung
      // 
      this.ClientSize = new System.Drawing.Size(601, 178);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label3);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Standplatzverwaltung";
      this.Text = "Freier Markt im Kleinen";
      this.Load += new System.EventHandler(this.Form3_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label4;
  }
}
