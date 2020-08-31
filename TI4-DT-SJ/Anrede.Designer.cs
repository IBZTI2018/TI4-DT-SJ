namespace TI4_DT_SJ
{
  partial class Anrede
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 9);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(160, 17);
      this.label2.TabIndex = 10;
      this.label2.Text = "TI4-ZH DT3 Case-Study";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(391, 9);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(210, 17);
      this.label3.TabIndex = 11;
      this.label3.Text = "Jennifer Mentner; Sven Gehring";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(267, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 17);
      this.label1.TabIndex = 12;
      this.label1.Text = "Anrede";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 51);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(250, 17);
      this.label4.TabIndex = 13;
      this.label4.Text = "Welche Anrede wollen sie bearbeiten?";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(26, 80);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 14;
      this.button1.Text = "Herr";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(119, 80);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 15;
      this.button2.Text = "Frau";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(13, 130);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(134, 17);
      this.label5.TabIndex = 16;
      this.label5.Text = "Anrede Hinzufügen:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(154, 130);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 22);
      this.textBox1.TabIndex = 17;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(270, 127);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(154, 25);
      this.button3.TabIndex = 18;
      this.button3.Text = "Neu Anrede einfügen";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form5
      // 
      this.ClientSize = new System.Drawing.Size(600, 177);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form5";
      this.Text = "Freier Markt im Kleinen";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button3;
  }
}
