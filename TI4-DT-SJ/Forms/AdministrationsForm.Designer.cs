namespace TI4_DT_SJ
{
  partial class AdministrationsForm
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
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(435, 9);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(157, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Jennifer Mentner; Sven Gehring";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 9);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "TI4-ZH DT3 Case-Study";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(278, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Administration";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(234, 68);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(142, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "Was wollen Sie bearbeiten...";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(265, 88);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(123, 68);
      this.button1.TabIndex = 16;
      this.button1.Text = "Ort";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.ortButton_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(136, 88);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(123, 68);
      this.button2.TabIndex = 17;
      this.button2.Text = "Adresse";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.adresseButton_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(394, 88);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(123, 68);
      this.button3.TabIndex = 18;
      this.button3.Text = "Q-Beauftragte";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.qBeauftragteButton_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(7, 88);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(123, 68);
      this.button4.TabIndex = 19;
      this.button4.Text = "Person";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.personButton_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(523, 88);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(122, 68);
      this.button5.TabIndex = 20;
      this.button5.Text = "AboArt";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.aboartButton_Click);
      // 
      // AdministrationsForm
      // 
      this.ClientSize = new System.Drawing.Size(656, 175);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label3);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "AdministrationsForm";
      this.Text = "Freier Markt im Kleinen";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
  }
}
