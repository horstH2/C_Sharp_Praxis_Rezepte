namespace VerzweigteFelder
{
  partial class Form_VerzweigtesFeld
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.erzeugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Feld = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erzeugeToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(21, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1340, 102);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Mehrfachfelder";
            // 
            // erzeugeToolStripMenuItem
            // 
            this.erzeugeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erzeugeToolStripMenuItem.Name = "erzeugeToolStripMenuItem";
            this.erzeugeToolStripMenuItem.Size = new System.Drawing.Size(272, 90);
            this.erzeugeToolStripMenuItem.Text = "Erzeuge";
            this.erzeugeToolStripMenuItem.Click += new System.EventHandler(this.erzeugeToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(295, 90);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // textBox_Feld
            // 
            this.textBox_Feld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Feld.Location = new System.Drawing.Point(0, 102);
            this.textBox_Feld.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_Feld.Multiline = true;
            this.textBox_Feld.Name = "textBox_Feld";
            this.textBox_Feld.Size = new System.Drawing.Size(1340, 526);
            this.textBox_Feld.TabIndex = 1;
            // 
            // Form_VerzweigtesFeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(37F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 628);
            this.Controls.Add(this.textBox_Feld);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form_VerzweigtesFeld";
            this.Text = "Verzweigtes Feld";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem erzeugeToolStripMenuItem;
    private System.Windows.Forms.TextBox textBox_Feld;
  }
}

