namespace Matritzen
{
  partial class Form_Matritzen
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dataGridView_A = new System.Windows.Forms.DataGridView();
      this.dataGridView_B = new System.Windows.Forms.DataGridView();
      this.dataGridView_C = new System.Windows.Forms.DataGridView();
      this.button_Addition = new System.Windows.Forms.Button();
      this.label_Result = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_B)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_C)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView_A
      // 
      this.dataGridView_A.BackgroundColor = System.Drawing.Color.LightBlue;
      this.dataGridView_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView_A.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView_A.Location = new System.Drawing.Point(13, 14);
      this.dataGridView_A.Margin = new System.Windows.Forms.Padding(4);
      this.dataGridView_A.Name = "dataGridView_A";
      this.dataGridView_A.RowHeadersWidth = 60;
      this.dataGridView_A.Size = new System.Drawing.Size(380, 97);
      this.dataGridView_A.TabIndex = 0;
      // 
      // dataGridView_B
      // 
      this.dataGridView_B.BackgroundColor = System.Drawing.Color.LightBlue;
      this.dataGridView_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView_B.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView_B.Location = new System.Drawing.Point(13, 152);
      this.dataGridView_B.Margin = new System.Windows.Forms.Padding(4);
      this.dataGridView_B.Name = "dataGridView_B";
      this.dataGridView_B.RowHeadersWidth = 60;
      this.dataGridView_B.Size = new System.Drawing.Size(380, 97);
      this.dataGridView_B.TabIndex = 1;
      // 
      // dataGridView_C
      // 
      this.dataGridView_C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView_C.DefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridView_C.Location = new System.Drawing.Point(13, 279);
      this.dataGridView_C.Margin = new System.Windows.Forms.Padding(4);
      this.dataGridView_C.Name = "dataGridView_C";
      this.dataGridView_C.RowHeadersWidth = 60;
      this.dataGridView_C.Size = new System.Drawing.Size(380, 97);
      this.dataGridView_C.TabIndex = 2;
      // 
      // button_Addition
      // 
      this.button_Addition.Location = new System.Drawing.Point(13, 118);
      this.button_Addition.Name = "button_Addition";
      this.button_Addition.Size = new System.Drawing.Size(91, 27);
      this.button_Addition.TabIndex = 3;
      this.button_Addition.Text = "Additition +";
      this.button_Addition.UseVisualStyleBackColor = true;
      this.button_Addition.Click += new System.EventHandler(this.button_Addition_Click);
      // 
      // label_Result
      // 
      this.label_Result.AutoSize = true;
      this.label_Result.Location = new System.Drawing.Point(13, 257);
      this.label_Result.Name = "label_Result";
      this.label_Result.Size = new System.Drawing.Size(63, 18);
      this.label_Result.TabIndex = 4;
      this.label_Result.Text = "Result =";
      // 
      // Form_Matritzen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(401, 389);
      this.Controls.Add(this.label_Result);
      this.Controls.Add(this.button_Addition);
      this.Controls.Add(this.dataGridView_C);
      this.Controls.Add(this.dataGridView_B);
      this.Controls.Add(this.dataGridView_A);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form_Matritzen";
      this.Text = "Matritzen";
      this.Load += new System.EventHandler(this.Form_Matritzen_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_A)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_B)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_C)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView_A;
    private System.Windows.Forms.DataGridView dataGridView_B;
    private System.Windows.Forms.DataGridView dataGridView_C;
    private System.Windows.Forms.Button button_Addition;
    private System.Windows.Forms.Label label_Result;
  }
}

