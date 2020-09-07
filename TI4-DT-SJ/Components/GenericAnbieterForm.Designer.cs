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
      this.personSelector = new System.Windows.Forms.Button();
      this.labelPerson = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.checkBoni = new System.Windows.Forms.CheckBox();
      this.checkUnter = new System.Windows.Forms.CheckBox();
      this.saveButton = new System.Windows.Forms.Button();
      this.personLabel = new System.Windows.Forms.Label();
      this.labelProvAufn = new System.Windows.Forms.Label();
      this.labelAufn = new System.Windows.Forms.Label();
      this.provAufnehmButton = new System.Windows.Forms.Button();
      this.aufnehmButton = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.checkBesuch = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Person";
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
      // personSelector
      // 
      this.personSelector.Location = new System.Drawing.Point(285, 4);
      this.personSelector.Name = "personSelector";
      this.personSelector.Size = new System.Drawing.Size(34, 23);
      this.personSelector.TabIndex = 3;
      this.personSelector.Text = "...";
      this.personSelector.UseVisualStyleBackColor = true;
      this.personSelector.Click += new System.EventHandler(this.personselect_Click);
      // 
      // labelPerson
      // 
      this.labelPerson.AutoSize = true;
      this.labelPerson.Location = new System.Drawing.Point(62, 9);
      this.labelPerson.Name = "labelPerson";
      this.labelPerson.Size = new System.Drawing.Size(0, 13);
      this.labelPerson.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 37);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Prov. Aufn.";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 63);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Aufnahme";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 90);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Bonität";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 115);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(61, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Unterschrift";
      // 
      // checkBoni
      // 
      this.checkBoni.AutoSize = true;
      this.checkBoni.Location = new System.Drawing.Point(79, 90);
      this.checkBoni.Name = "checkBoni";
      this.checkBoni.Size = new System.Drawing.Size(41, 17);
      this.checkBoni.TabIndex = 11;
      this.checkBoni.Text = "OK";
      this.checkBoni.UseVisualStyleBackColor = true;
      // 
      // checkUnter
      // 
      this.checkUnter.AutoSize = true;
      this.checkUnter.Location = new System.Drawing.Point(79, 113);
      this.checkUnter.Name = "checkUnter";
      this.checkUnter.Size = new System.Drawing.Size(41, 17);
      this.checkUnter.TabIndex = 12;
      this.checkUnter.Text = "OK";
      this.checkUnter.UseVisualStyleBackColor = true;
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(79, 160);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(200, 23);
      this.saveButton.TabIndex = 13;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // personLabel
      // 
      this.personLabel.AutoSize = true;
      this.personLabel.Location = new System.Drawing.Point(79, 9);
      this.personLabel.Name = "personLabel";
      this.personLabel.Size = new System.Drawing.Size(0, 13);
      this.personLabel.TabIndex = 14;
      // 
      // labelProvAufn
      // 
      this.labelProvAufn.AutoSize = true;
      this.labelProvAufn.Location = new System.Drawing.Point(82, 37);
      this.labelProvAufn.Name = "labelProvAufn";
      this.labelProvAufn.Size = new System.Drawing.Size(0, 13);
      this.labelProvAufn.TabIndex = 15;
      // 
      // labelAufn
      // 
      this.labelAufn.AutoSize = true;
      this.labelAufn.Location = new System.Drawing.Point(79, 63);
      this.labelAufn.Name = "labelAufn";
      this.labelAufn.Size = new System.Drawing.Size(0, 13);
      this.labelAufn.TabIndex = 16;
      // 
      // provAufnehmButton
      // 
      this.provAufnehmButton.Location = new System.Drawing.Point(285, 32);
      this.provAufnehmButton.Name = "provAufnehmButton";
      this.provAufnehmButton.Size = new System.Drawing.Size(73, 23);
      this.provAufnehmButton.TabIndex = 17;
      this.provAufnehmButton.Text = "aufnehmen";
      this.provAufnehmButton.UseVisualStyleBackColor = true;
      this.provAufnehmButton.Click += new System.EventHandler(this.provAufnehmButton_Click);
      // 
      // aufnehmButton
      // 
      this.aufnehmButton.Location = new System.Drawing.Point(285, 58);
      this.aufnehmButton.Name = "aufnehmButton";
      this.aufnehmButton.Size = new System.Drawing.Size(73, 23);
      this.aufnehmButton.TabIndex = 18;
      this.aufnehmButton.Text = "aufnehmen";
      this.aufnehmButton.UseVisualStyleBackColor = true;
      this.aufnehmButton.Click += new System.EventHandler(this.aufnehmButton_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 138);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(43, 13);
      this.label6.TabIndex = 19;
      this.label6.Text = "Besuch";
      // 
      // checkBesuch
      // 
      this.checkBesuch.AutoSize = true;
      this.checkBesuch.Location = new System.Drawing.Point(79, 137);
      this.checkBesuch.Name = "checkBesuch";
      this.checkBesuch.Size = new System.Drawing.Size(41, 17);
      this.checkBesuch.TabIndex = 20;
      this.checkBesuch.Text = "OK";
      this.checkBesuch.UseVisualStyleBackColor = true;
      // 
      // GenericAnbieterForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(364, 190);
      this.Controls.Add(this.checkBesuch);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.aufnehmButton);
      this.Controls.Add(this.provAufnehmButton);
      this.Controls.Add(this.labelAufn);
      this.Controls.Add(this.labelProvAufn);
      this.Controls.Add(this.personLabel);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.checkUnter);
      this.Controls.Add(this.checkBoni);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.labelPerson);
      this.Controls.Add(this.personSelector);
      this.Controls.Add(this.nachname);
      this.Controls.Add(this.vorname);
      this.Controls.Add(this.label1);
      this.Name = "GenericAnbieterForm";
      this.Text = "Anbieter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label vorname;
    private System.Windows.Forms.Label nachname;
    private System.Windows.Forms.Button personSelector;
    private System.Windows.Forms.Label labelPerson;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox checkBoni;
    private System.Windows.Forms.CheckBox checkUnter;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Label personLabel;
    private System.Windows.Forms.Label labelProvAufn;
    private System.Windows.Forms.Label labelAufn;
    private System.Windows.Forms.Button provAufnehmButton;
    private System.Windows.Forms.Button aufnehmButton;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckBox checkBesuch;
  }
}