namespace TI4_DT_SJ.Components {
  partial class GenericTerminForm {
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
      this.labelAnbieter = new System.Windows.Forms.Label();
      this.labelStandplatz = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.datePicker = new System.Windows.Forms.DateTimePicker();
      this.anbieterPicker = new System.Windows.Forms.Button();
      this.standplatzPicker = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Anbieter";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Standplatz";
      // 
      // labelAnbieter
      // 
      this.labelAnbieter.AutoSize = true;
      this.labelAnbieter.Location = new System.Drawing.Point(86, 13);
      this.labelAnbieter.Name = "labelAnbieter";
      this.labelAnbieter.Size = new System.Drawing.Size(0, 13);
      this.labelAnbieter.TabIndex = 2;
      // 
      // labelStandplatz
      // 
      this.labelStandplatz.AutoSize = true;
      this.labelStandplatz.Location = new System.Drawing.Point(86, 40);
      this.labelStandplatz.Name = "labelStandplatz";
      this.labelStandplatz.Size = new System.Drawing.Size(0, 13);
      this.labelStandplatz.TabIndex = 3;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 65);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(38, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Datum";
      // 
      // datePicker
      // 
      this.datePicker.Location = new System.Drawing.Point(78, 59);
      this.datePicker.Name = "datePicker";
      this.datePicker.Size = new System.Drawing.Size(176, 20);
      this.datePicker.TabIndex = 5;
      // 
      // anbieterPicker
      // 
      this.anbieterPicker.Location = new System.Drawing.Point(259, 8);
      this.anbieterPicker.Name = "anbieterPicker";
      this.anbieterPicker.Size = new System.Drawing.Size(30, 23);
      this.anbieterPicker.TabIndex = 6;
      this.anbieterPicker.Text = "...";
      this.anbieterPicker.UseVisualStyleBackColor = true;
      this.anbieterPicker.Click += new System.EventHandler(this.anbieterPicker_Click);
      // 
      // standplatzPicker
      // 
      this.standplatzPicker.Location = new System.Drawing.Point(259, 35);
      this.standplatzPicker.Name = "standplatzPicker";
      this.standplatzPicker.Size = new System.Drawing.Size(30, 23);
      this.standplatzPicker.TabIndex = 7;
      this.standplatzPicker.Text = "...";
      this.standplatzPicker.UseVisualStyleBackColor = true;
      this.standplatzPicker.Click += new System.EventHandler(this.standplatzPicker_Click);
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(78, 85);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(176, 23);
      this.saveButton.TabIndex = 8;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // GenericTerminForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(297, 110);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.standplatzPicker);
      this.Controls.Add(this.anbieterPicker);
      this.Controls.Add(this.datePicker);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.labelStandplatz);
      this.Controls.Add(this.labelAnbieter);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "GenericTerminForm";
      this.Text = "Termin";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAnbieter;
        private System.Windows.Forms.Label labelStandplatz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button anbieterPicker;
        private System.Windows.Forms.Button standplatzPicker;
        private System.Windows.Forms.Button saveButton;
    }
}