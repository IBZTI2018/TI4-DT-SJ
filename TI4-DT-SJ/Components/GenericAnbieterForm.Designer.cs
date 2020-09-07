namespace TI4_DT_SJ.Components {
  partial class GenericAnbieterForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.vorname = new System.Windows.Forms.Label();
      this.nachname = new System.Windows.Forms.Label();
      this.personselect = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Person:";
      // 
      // vorname
      // 
      this.vorname.AutoSize = true;
      this.vorname.Location = new System.Drawing.Point(76, 9);
      this.vorname.Name = "vorname";
      this.vorname.Size = new System.Drawing.Size(0, 13);
      this.vorname.TabIndex = 1;
      // 
      // nachname
      // 
      this.nachname.AutoSize = true;
      this.nachname.Location = new System.Drawing.Point(183, 9);
      this.nachname.Name = "nachname";
      this.nachname.Size = new System.Drawing.Size(0, 13);
      this.nachname.TabIndex = 2;
      // 
      // personselect
      // 
      this.personselect.Location = new System.Drawing.Point(301, 4);
      this.personselect.Name = "personselect";
      this.personselect.Size = new System.Drawing.Size(75, 23);
      this.personselect.TabIndex = 3;
      this.personselect.Text = "ändern";
      this.personselect.UseVisualStyleBackColor = true;
      this.personselect.Click += new System.EventHandler(this.personselect_Click);
      // 
      // GenericAnbieterForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(394, 403);
      this.Controls.Add(this.personselect);
      this.Controls.Add(this.nachname);
      this.Controls.Add(this.vorname);
      this.Controls.Add(this.label1);
      this.Name = "GenericAnbieterForm";
      this.Text = "GenericAnbieterForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label vorname;
    private System.Windows.Forms.Label nachname;
    private System.Windows.Forms.Button personselect;
  }
}