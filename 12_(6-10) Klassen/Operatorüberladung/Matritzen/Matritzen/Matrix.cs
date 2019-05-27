namespace Matritzen
{
class Matrix
{
  //Atribut, Eigenschaft
  public double[,] element;

  #region Konstruktoren
  /// <summary>
  /// Dient der Matrixübernahme
  /// </summary>
  /// <param name="matrix"></param>
  public Matrix(double[,] matrix)
  {
    this.element = matrix;
  }

  /// <summary>
  /// Dient der Speicherplatzreservierung
  /// </summary>
  /// <param name="matrix"></param>
  public Matrix(int m, int n)
  {
    this.element = new double[m,n];
  }
  #endregion Konstruktoren

  /// <summary>
  /// Operatorüberladung zur Matritzenaddition
  /// (muss statisch und öffentlich sein)
  /// </summary>
  /// <param name="X"></param> Matrix X
  /// <param name="Y"></param> Matrix Y
  /// <returns></returns>
  public static Matrix operator +(Matrix X, Matrix  Y)
  {
    Matrix R = new Matrix(X.element); //Ergebnismatrix
    for (int i=0; i<= X.element.GetUpperBound(0)   ; i++)
      for (int j = 0; j <= X.element.GetUpperBound(1); j++)
        R.element[i, j] = X.element[i,j] + Y.element[i,j];
        return R;
  }
  /// <summary>
  /// Operatorüberladung zur Matritzensubtraktio 
  /// </summary>
  /// <param name="X"></param> Matrix X
  /// <param name="Y"></param> Matrix Y
  /// <returns></returns>
  public static Matrix operator -(Matrix X, Matrix Y)
  {
    Matrix R = new Matrix(X.element); //Ergebnismatrix
    for (int i = 0; i <= X.element.GetUpperBound(0); i++)
      for (int j = 0; j <= X.element.GetUpperBound(1); j++)
        R.element[i, j] = X.element[i, j] - Y.element[i, j];
    return R;
  }

  /// hier sind Erweiterungen möglich ...

}
}
