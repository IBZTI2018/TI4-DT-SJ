namespace TI4_DT_SJ.Components {
  partial class GenericStandplatzForm {
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
      this.labelStandort = new System.Windows.Forms.Label();
      this.standortPicker = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.inputNumber = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Standort";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Standplatz-Nr.";
      // 
      // labelStandort
      // 
      this.labelStandort.AutoSize = true;
      this.labelStandort.Location = new System.Drawing.Point(108, 9);
      this.labelStandort.Name = "labelStandort";
      this.labelStandort.Size = new System.Drawing.Size(0, 13);
      this.labelStandort.TabIndex = 2;
      // 
      // standortPicker
      // 
      this.standortPicker.Location = new System.Drawing.Point(213, 4);
      this.standortPicker.Name = "standortPicker";
      this.standortPicker.Size = new System.Drawing.Size(28, 23);
      this.standortPicker.TabIndex = 3;
      this.standortPicker.Text = "...";
      this.standortPicker.UseVisualStyleBackColor = true;
      this.standortPicker.Click += new System.EventHandler(this.standortPicker_Click);
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(111, 66);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(100, 23);
      this.saveButton.TabIndex = 4;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // inputNumber
      // 
      this.inputNumber.Location = new System.Drawing.Point(111, 35);
      this.inputNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.inputNumber.Name = "inputNumber";
      this.inputNumber.Size = new System.Drawing.Size(100, 20);
      this.inputNumber.TabIndex = 5;
      // 
      // GenericStandplatzForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(247, 96);
      this.Controls.Add(this.inputNumber);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.standortPicker);
      this.Controls.Add(this.labelStandort);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "GenericStandplatzForm";
      this.Text = "Standplatz";
      ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label labelStandort;
    private System.Windows.Forms.Button standortPicker;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.NumericUpDown inputNumber;
  }
}