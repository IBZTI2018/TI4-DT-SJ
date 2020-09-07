namespace TI4_DT_SJ.Components {
  partial class GenericListForm {
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.selectButton = new System.Windows.Forms.Button();
      this.deleteButton = new System.Windows.Forms.Button();
      this.createButton = new System.Windows.Forms.Button();
      this.updateButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(648, 301);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
      // 
      // selectButton
      // 
      this.selectButton.Location = new System.Drawing.Point(12, 319);
      this.selectButton.Name = "selectButton";
      this.selectButton.Size = new System.Drawing.Size(123, 50);
      this.selectButton.TabIndex = 1;
      this.selectButton.Text = "Auswählen";
      this.selectButton.UseVisualStyleBackColor = true;
      this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
      // 
      // deleteButton
      // 
      this.deleteButton.Location = new System.Drawing.Point(538, 319);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(122, 50);
      this.deleteButton.TabIndex = 2;
      this.deleteButton.Text = "Löschen";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // createButton
      // 
      this.createButton.Location = new System.Drawing.Point(180, 319);
      this.createButton.Name = "createButton";
      this.createButton.Size = new System.Drawing.Size(123, 50);
      this.createButton.TabIndex = 3;
      this.createButton.Text = "Erstellen";
      this.createButton.UseVisualStyleBackColor = true;
      this.createButton.Click += new System.EventHandler(this.createButton_Click);
      // 
      // updateButton
      // 
      this.updateButton.Location = new System.Drawing.Point(358, 319);
      this.updateButton.Name = "updateButton";
      this.updateButton.Size = new System.Drawing.Size(123, 50);
      this.updateButton.TabIndex = 4;
      this.updateButton.Text = "Bearbeiten";
      this.updateButton.UseVisualStyleBackColor = true;
      this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
      // 
      // GenericListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(672, 386);
      this.Controls.Add(this.updateButton);
      this.Controls.Add(this.createButton);
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.selectButton);
      this.Controls.Add(this.dataGridView1);
      this.Name = "GenericListForm";
      this.Text = "Auswahlliste";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button selectButton;
    private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
    }
}