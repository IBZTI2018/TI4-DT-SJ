namespace TI4_DT_SJ.Components {
  partial class GenericOrtForm {
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
      this.plzSelector = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.ortsname = new System.Windows.Forms.TextBox();
      this.saveButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.plzSelector)).BeginInit();
      this.SuspendLayout();
      // 
      // plzSelector
      // 
      this.plzSelector.Location = new System.Drawing.Point(108, 7);
      this.plzSelector.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.plzSelector.Name = "plzSelector";
      this.plzSelector.Size = new System.Drawing.Size(120, 20);
      this.plzSelector.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Postleitzahl";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Ortsname";
      // 
      // ortsname
      // 
      this.ortsname.Location = new System.Drawing.Point(108, 41);
      this.ortsname.Name = "ortsname";
      this.ortsname.Size = new System.Drawing.Size(120, 20);
      this.ortsname.TabIndex = 3;
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(108, 77);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(120, 23);
      this.saveButton.TabIndex = 4;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // GenericOrtForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(247, 112);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.ortsname);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.plzSelector);
      this.Name = "GenericOrtForm";
      this.Text = "Ort";
      ((System.ComponentModel.ISupportInitialize)(this.plzSelector)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.NumericUpDown plzSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ortsname;
    private System.Windows.Forms.Button saveButton;
  }
}