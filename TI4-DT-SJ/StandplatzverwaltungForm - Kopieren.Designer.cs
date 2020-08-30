namespace TI4_DT_SJ
{
  partial class AdministrationForm 
  {
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);

      this.tabControl1.Location = new System.Drawing.Point(16, 15);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1035, 524);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.textBox2);
      this.tabPage1.Controls.Add(this.textBox1);
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabPage1.Size = new System.Drawing.Size(1027, 495);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Orte";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabPage2.Size = new System.Drawing.Size(1027, 495);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Adressen";
      this.tabPage2.UseVisualStyleBackColor = true;

      // 
      // ManagementForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 554);
      this.Controls.Add(this.tabControl1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "ManagementForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.ManagementForm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
  }

}