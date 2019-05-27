using System;
using System.Windows.Forms;
namespace Matritzen
{
public partial class Form_Matritzen : Form
{
  public Form_Matritzen()
  {
    InitializeComponent();
  }

  //Dimension der Matrix
  int M = 2; // Zeilenanzah
  int N = 3; // Spaltenanzahl

  /// <summary>
  /// Einrichten der Eingabetabellen und der Ausgabetabelle
  /// </summary>
  private void Form_Matritzen_Load(object sender, EventArgs e)
  {
    // Beschriftung der Matrix A
    // Die Eigenschaft "RowHeadersWidth" muss entsprechend groß gewählt
    // werden, damit die Zeilennummern angezeigt werden.  
    dataGridView_A.TopLeftHeaderCell.Value = "Matrix A";
    // Spaltenanzahl
    dataGridView_A.ColumnCount = N;
    // Zeilen hinzufügen (eine Zeile existiert bereits)
    dataGridView_A.Rows.Add(M-1);
    // Spaltenbeschriftung
    for (int j=0; j< dataGridView_A.ColumnCount; j++)   dataGridView_A.Columns[j].HeaderText = j.ToString();
    // Zeilenbeschriftung
    for (int i = 0; i < dataGridView_A.RowCount; i++) dataGridView_A.Rows[i].HeaderCell.Value= i.ToString();
    // ...
    dataGridView_B.TopLeftHeaderCell.Value = "Matrix B";
    dataGridView_B.ColumnCount = N;
    dataGridView_B.Rows.Add(M-1);
    for (int j = 0; j < dataGridView_B.ColumnCount; j++) dataGridView_B.Columns[j].HeaderText = j.ToString();
    for (int i = 0; i < dataGridView_B.RowCount; i++) dataGridView_B.Rows[i].HeaderCell.Value = i.ToString();
    // ...
    dataGridView_C.TopLeftHeaderCell.Value = "Matrix C";
    dataGridView_C.ColumnCount = N;
    dataGridView_C.Rows.Add(M-1);
    for (int j = 0; j < dataGridView_C.ColumnCount; j++) dataGridView_C.Columns[j].HeaderText = j.ToString();
    for (int i = 0; i < dataGridView_C.RowCount; i++) dataGridView_C.Rows[i].HeaderCell.Value = i.ToString();
  }

  /// <summary>
  /// Matrixaddition 
  /// </summary>
  private void button_Addition_Click(object sender, EventArgs e)
  {
    // Derklaration,
    Matrix A = new Matrix(M, N);
    Matrix B = new Matrix(M, N);
    Matrix C = new Matrix(M, N);
    // Werteübernahme aus dem Formular
    for (int i=0; i < M; i++)
      for (int j = 0; j < N ; j++)
      {
        A.element[i, j] = Convert.ToDouble(dataGridView_A.Rows[i].Cells[j].Value);
        B.element[i, j] = Convert.ToDouble(dataGridView_B.Rows[i].Cells[j].Value);
      }
    /// MATRIXOPERATION 
    C = A + B;
    /// Ergebnisausgabe über das Formular
    for (int i = 0; i < M; i++)
      for (int j = 0; j <N ; j++)
        dataGridView_C.Rows[i].Cells[j].Value = C.element[i, j];
    }
  }
}
