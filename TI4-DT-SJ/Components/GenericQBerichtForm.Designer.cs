﻿namespace TI4_DT_SJ.Components {
  partial class GenericQBerichtForm {
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.inputText = new System.Windows.Forms.TextBox();
      this.labelAnbieter = new System.Windows.Forms.Label();
      this.labelPruefer = new System.Windows.Forms.Label();
      this.anbieterSelector = new System.Windows.Forms.Button();
      this.prueferSelector = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Anbieter";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 31);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Qualitätsprüfer";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 54);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Bewertung";
      // 
      // inputText
      // 
      this.inputText.Location = new System.Drawing.Point(99, 51);
      this.inputText.Multiline = true;
      this.inputText.Name = "inputText";
      this.inputText.Size = new System.Drawing.Size(183, 139);
      this.inputText.TabIndex = 3;
      // 
      // labelAnbieter
      // 
      this.labelAnbieter.AutoSize = true;
      this.labelAnbieter.Location = new System.Drawing.Point(96, 9);
      this.labelAnbieter.Name = "labelAnbieter";
      this.labelAnbieter.Size = new System.Drawing.Size(0, 13);
      this.labelAnbieter.TabIndex = 4;
      // 
      // labelPruefer
      // 
      this.labelPruefer.AutoSize = true;
      this.labelPruefer.Location = new System.Drawing.Point(96, 31);
      this.labelPruefer.Name = "labelPruefer";
      this.labelPruefer.Size = new System.Drawing.Size(0, 13);
      this.labelPruefer.TabIndex = 5;
      // 
      // anbieterSelector
      // 
      this.anbieterSelector.Location = new System.Drawing.Point(285, 4);
      this.anbieterSelector.Name = "anbieterSelector";
      this.anbieterSelector.Size = new System.Drawing.Size(29, 23);
      this.anbieterSelector.TabIndex = 6;
      this.anbieterSelector.Text = "...";
      this.anbieterSelector.UseVisualStyleBackColor = true;
      this.anbieterSelector.Click += new System.EventHandler(this.anbieterSelector_Click);
      // 
      // prueferSelector
      // 
      this.prueferSelector.Location = new System.Drawing.Point(285, 26);
      this.prueferSelector.Name = "prueferSelector";
      this.prueferSelector.Size = new System.Drawing.Size(29, 23);
      this.prueferSelector.TabIndex = 7;
      this.prueferSelector.Text = "...";
      this.prueferSelector.UseVisualStyleBackColor = true;
      this.prueferSelector.Click += new System.EventHandler(this.prueferSelector_Click);
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(99, 196);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(183, 23);
      this.saveButton.TabIndex = 8;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // GenericQBerichtForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(327, 232);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.prueferSelector);
      this.Controls.Add(this.anbieterSelector);
      this.Controls.Add(this.labelPruefer);
      this.Controls.Add(this.labelAnbieter);
      this.Controls.Add(this.inputText);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "GenericQBerichtForm";
      this.Text = "Qualitätsbericht";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label labelAnbieter;
        private System.Windows.Forms.Label labelPruefer;
        private System.Windows.Forms.Button anbieterSelector;
        private System.Windows.Forms.Button prueferSelector;
        private System.Windows.Forms.Button saveButton;
    }
}