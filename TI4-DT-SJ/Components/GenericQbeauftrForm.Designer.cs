﻿namespace TI4_DT_SJ.Components {
  partial class GenericQbeauftrForm {
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
      this.labelPerson = new System.Windows.Forms.Label();
      this.personSelector = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
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
      // labelPerson
      // 
      this.labelPerson.AutoSize = true;
      this.labelPerson.Location = new System.Drawing.Point(66, 9);
      this.labelPerson.Name = "labelPerson";
      this.labelPerson.Size = new System.Drawing.Size(0, 13);
      this.labelPerson.TabIndex = 1;
      // 
      // personSelector
      // 
      this.personSelector.Location = new System.Drawing.Point(171, 4);
      this.personSelector.Name = "personSelector";
      this.personSelector.Size = new System.Drawing.Size(30, 23);
      this.personSelector.TabIndex = 2;
      this.personSelector.Text = "...";
      this.personSelector.UseVisualStyleBackColor = true;
      this.personSelector.Click += new System.EventHandler(this.personSelector_Click);
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(69, 42);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(103, 23);
      this.saveButton.TabIndex = 3;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
      // 
      // GenericQbeauftrForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(213, 72);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.personSelector);
      this.Controls.Add(this.labelPerson);
      this.Controls.Add(this.label1);
      this.Name = "GenericQbeauftrForm";
      this.Text = "Qualitätsbeauftragter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.Button personSelector;
        private System.Windows.Forms.Button saveButton;
    }
}