namespace TI4_DT_SJ.Components {
  partial class GenericRechnungForm {
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
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.anbieterLabel = new System.Windows.Forms.Label();
      this.terminLabel = new System.Windows.Forms.Label();
      this.aboLabel = new System.Windows.Forms.Label();
      this.nrInput = new System.Windows.Forms.TextBox();
      this.betragInput = new System.Windows.Forms.NumericUpDown();
      this.anbieterSelector = new System.Windows.Forms.Button();
      this.terminSelector = new System.Windows.Forms.Button();
      this.abonnementSelector = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.dummyButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.betragInput)).BeginInit();
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
      this.label2.Location = new System.Drawing.Point(12, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Termin";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 55);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(67, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Abonnement";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 77);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(79, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Rechnungs-Nr.";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 100);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(38, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Betrag";
      // 
      // anbieterLabel
      // 
      this.anbieterLabel.AutoSize = true;
      this.anbieterLabel.Location = new System.Drawing.Point(106, 9);
      this.anbieterLabel.Name = "anbieterLabel";
      this.anbieterLabel.Size = new System.Drawing.Size(0, 13);
      this.anbieterLabel.TabIndex = 5;
      // 
      // terminLabel
      // 
      this.terminLabel.AutoSize = true;
      this.terminLabel.Location = new System.Drawing.Point(106, 32);
      this.terminLabel.Name = "terminLabel";
      this.terminLabel.Size = new System.Drawing.Size(0, 13);
      this.terminLabel.TabIndex = 6;
      // 
      // aboLabel
      // 
      this.aboLabel.AutoSize = true;
      this.aboLabel.Location = new System.Drawing.Point(106, 55);
      this.aboLabel.Name = "aboLabel";
      this.aboLabel.Size = new System.Drawing.Size(0, 13);
      this.aboLabel.TabIndex = 7;
      // 
      // nrInput
      // 
      this.nrInput.Location = new System.Drawing.Point(109, 74);
      this.nrInput.Name = "nrInput";
      this.nrInput.Size = new System.Drawing.Size(100, 20);
      this.nrInput.TabIndex = 8;
      // 
      // betragInput
      // 
      this.betragInput.DecimalPlaces = 2;
      this.betragInput.Location = new System.Drawing.Point(109, 100);
      this.betragInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.betragInput.Name = "betragInput";
      this.betragInput.Size = new System.Drawing.Size(100, 20);
      this.betragInput.TabIndex = 9;
      // 
      // anbieterSelector
      // 
      this.anbieterSelector.Location = new System.Drawing.Point(219, 4);
      this.anbieterSelector.Name = "anbieterSelector";
      this.anbieterSelector.Size = new System.Drawing.Size(25, 23);
      this.anbieterSelector.TabIndex = 10;
      this.anbieterSelector.Text = "...";
      this.anbieterSelector.UseVisualStyleBackColor = true;
      this.anbieterSelector.Click += new System.EventHandler(this.anbieterSelector_Click);
      // 
      // terminSelector
      // 
      this.terminSelector.Location = new System.Drawing.Point(219, 27);
      this.terminSelector.Name = "terminSelector";
      this.terminSelector.Size = new System.Drawing.Size(25, 23);
      this.terminSelector.TabIndex = 11;
      this.terminSelector.Text = "...";
      this.terminSelector.UseVisualStyleBackColor = true;
      this.terminSelector.Click += new System.EventHandler(this.terminSelector_Click);
      // 
      // abonnementSelector
      // 
      this.abonnementSelector.Location = new System.Drawing.Point(219, 50);
      this.abonnementSelector.Name = "abonnementSelector";
      this.abonnementSelector.Size = new System.Drawing.Size(25, 23);
      this.abonnementSelector.TabIndex = 12;
      this.abonnementSelector.Text = "...";
      this.abonnementSelector.UseVisualStyleBackColor = true;
      this.abonnementSelector.Click += new System.EventHandler(this.abonnementSelector_Click);
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(109, 126);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(100, 23);
      this.saveButton.TabIndex = 13;
      this.saveButton.Text = "Speichern";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // dummyButton
      // 
      this.dummyButton.Location = new System.Drawing.Point(109, 155);
      this.dummyButton.Name = "dummyButton";
      this.dummyButton.Size = new System.Drawing.Size(100, 23);
      this.dummyButton.TabIndex = 14;
      this.dummyButton.Text = "Ist Bezahlt";
      this.dummyButton.UseVisualStyleBackColor = true;
      this.dummyButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // GenericRechnungForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(250, 182);
      this.Controls.Add(this.dummyButton);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.abonnementSelector);
      this.Controls.Add(this.terminSelector);
      this.Controls.Add(this.anbieterSelector);
      this.Controls.Add(this.betragInput);
      this.Controls.Add(this.nrInput);
      this.Controls.Add(this.aboLabel);
      this.Controls.Add(this.terminLabel);
      this.Controls.Add(this.anbieterLabel);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "GenericRechnungForm";
      this.Text = "Rechnung";
      ((System.ComponentModel.ISupportInitialize)(this.betragInput)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label anbieterLabel;
        private System.Windows.Forms.Label terminLabel;
        private System.Windows.Forms.Label aboLabel;
        private System.Windows.Forms.TextBox nrInput;
        private System.Windows.Forms.NumericUpDown betragInput;
        private System.Windows.Forms.Button anbieterSelector;
        private System.Windows.Forms.Button terminSelector;
        private System.Windows.Forms.Button abonnementSelector;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button dummyButton;
    }
}