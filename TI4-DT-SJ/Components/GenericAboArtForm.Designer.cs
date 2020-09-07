namespace TI4_DT_SJ.Components {
  partial class GenericAboArtForm {
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
      this.inputName = new System.Windows.Forms.TextBox();
      this.saveButton = new System.Windows.Forms.Button();
      this.inputPrice = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Gebühr";
      // 
      // inputName
      // 
      this.inputName.Location = new System.Drawing.Point(63, 9);
      this.inputName.Name = "inputName";
      this.inputName.Size = new System.Drawing.Size(100, 20);
      this.inputName.TabIndex = 2;
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(63, 62);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(100, 23);
      this.saveButton.TabIndex = 4;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // inputPrice
      // 
      this.inputPrice.Location = new System.Drawing.Point(63, 36);
      this.inputPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.inputPrice.Name = "inputPrice";
      this.inputPrice.Size = new System.Drawing.Size(100, 20);
      this.inputPrice.TabIndex = 5;
      // 
      // GenericAboArtForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(175, 93);
      this.Controls.Add(this.inputPrice);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.inputName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "GenericAboArtForm";
      this.Text = "AboArt";
      ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown inputPrice;
    }
}