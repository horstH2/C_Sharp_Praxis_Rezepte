using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matritzen
{
  class MatritzenOperationen
  {

    //Variablen
    public double[,] A;
    public double[,] B;


    public MatritzenOperationen(double[,] A, double[,] B)
    {
      this.A = A;
      this.B = B;

    }

    public static MatritzenOperationen operator +(MatritzenOperationen A, MatritzenOperationen B)
    {
      MatritzenOperationen result =null;





      return result;
    }




  }
}
