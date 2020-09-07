namespace TI4_DT_SJ.Components {
  partial class GenericAdresseForm {
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
      this.ortLabel = new System.Windows.Forms.Label();
      this.selectOrtButton = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.strasseInput = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.hausNrSelector = new System.Windows.Forms.NumericUpDown();
      this.saveButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.hausNrSelector)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(21, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ort";
      // 
      // ortLabel
      // 
      this.ortLabel.AutoSize = true;
      this.ortLabel.Location = new System.Drawing.Point(71, 9);
      this.ortLabel.Name = "ortLabel";
      this.ortLabel.Size = new System.Drawing.Size(0, 13);
      this.ortLabel.TabIndex = 1;
      // 
      // selectOrtButton
      // 
      this.selectOrtButton.Location = new System.Drawing.Point(179, 4);
      this.selectOrtButton.Name = "selectOrtButton";
      this.selectOrtButton.Size = new System.Drawing.Size(25, 23);
      this.selectOrtButton.TabIndex = 2;
      this.selectOrtButton.Text = "...";
      this.selectOrtButton.UseVisualStyleBackColor = true;
      this.selectOrtButton.Click += new System.EventHandler(this.selectOrtButton_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Strasse";
      // 
      // strasseInput
      // 
      this.strasseInput.Location = new System.Drawing.Point(74, 36);
      this.strasseInput.Name = "strasseInput";
      this.strasseInput.Size = new System.Drawing.Size(100, 20);
      this.strasseInput.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Haus-Nr.";
      // 
      // hausNrSelector
      // 
      this.hausNrSelector.Location = new System.Drawing.Point(74, 72);
      this.hausNrSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.hausNrSelector.Name = "hausNrSelector";
      this.hausNrSelector.Size = new System.Drawing.Size(100, 20);
      this.hausNrSelector.TabIndex = 6;
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(74, 109);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(100, 23);
      this.saveButton.TabIndex = 7;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // GenericAdresseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(238, 144);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.hausNrSelector);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.strasseInput);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.selectOrtButton);
      this.Controls.Add(this.ortLabel);
      this.Controls.Add(this.label1);
      this.Name = "GenericAdresseForm";
      this.Text = "Adresse";
      ((System.ComponentModel.ISupportInitialize)(this.hausNrSelector)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ortLabel;
        private System.Windows.Forms.Button selectOrtButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox strasseInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hausNrSelector;
        private System.Windows.Forms.Button saveButton;
    }
}