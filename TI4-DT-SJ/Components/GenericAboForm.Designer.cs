namespace TI4_DT_SJ.Components {
  partial class GenericAboForm {
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
      this.labelAboart = new System.Windows.Forms.Label();
      this.saveButton = new System.Windows.Forms.Button();
      this.anbieterPicker = new System.Windows.Forms.Button();
      this.aboartPicker = new System.Windows.Forms.Button();
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
      this.label2.Location = new System.Drawing.Point(12, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Abo-Typ";
      // 
      // labelAnbieter
      // 
      this.labelAnbieter.AutoSize = true;
      this.labelAnbieter.Location = new System.Drawing.Point(88, 9);
      this.labelAnbieter.Name = "labelAnbieter";
      this.labelAnbieter.Size = new System.Drawing.Size(0, 13);
      this.labelAnbieter.TabIndex = 2;
      // 
      // labelAboart
      // 
      this.labelAboart.AutoSize = true;
      this.labelAboart.Location = new System.Drawing.Point(88, 35);
      this.labelAboart.Name = "labelAboart";
      this.labelAboart.Size = new System.Drawing.Size(0, 13);
      this.labelAboart.TabIndex = 3;
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(91, 65);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(113, 23);
      this.saveButton.TabIndex = 4;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // anbieterPicker
      // 
      this.anbieterPicker.Location = new System.Drawing.Point(205, 4);
      this.anbieterPicker.Name = "anbieterPicker";
      this.anbieterPicker.Size = new System.Drawing.Size(37, 23);
      this.anbieterPicker.TabIndex = 5;
      this.anbieterPicker.Text = "...";
      this.anbieterPicker.UseVisualStyleBackColor = true;
      this.anbieterPicker.Click += new System.EventHandler(this.anbieterPicker_Click);
      // 
      // aboartPicker
      // 
      this.aboartPicker.Location = new System.Drawing.Point(205, 30);
      this.aboartPicker.Name = "aboartPicker";
      this.aboartPicker.Size = new System.Drawing.Size(37, 23);
      this.aboartPicker.TabIndex = 6;
      this.aboartPicker.Text = "...";
      this.aboartPicker.UseVisualStyleBackColor = true;
      this.aboartPicker.Click += new System.EventHandler(this.aboartPicker_Click);
      // 
      // GenericAboForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(247, 95);
      this.Controls.Add(this.aboartPicker);
      this.Controls.Add(this.anbieterPicker);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.labelAboart);
      this.Controls.Add(this.labelAnbieter);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "GenericAboForm";
      this.Text = "Abonnement";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAnbieter;
        private System.Windows.Forms.Label labelAboart;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button anbieterPicker;
        private System.Windows.Forms.Button aboartPicker;
    }
}