using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
  class Statistik
  {
    #region Mittelelwert
    /// <summary>
    /// Berechnet den Mittelwert eines Feldes
    /// </summary>
    /// <param name="x"></param> Feld x
    /// <returns></returns> Mittelwert
    public static double Mittelwert(double[] x){
    double mittelwert = 0;
    foreach(double element in x) //Summe
    {
      mittelwert += element;
    }
    mittelwert /= x.Length;
    return mittelwert;
  }
    /// <summary>
    /// Berechnet den Mittelwert und 
    /// zusätzlich die Standardabweichung
    /// --> Methode überladen
    /// </summary>
    /// <param name="x"></param> Feld x
    /// <param name="Standardabweichung"></param> Standardabweichung
    /// <returns></returns> Mittelwert
    public static double Mittelwert(double[] x, out double Standardabweichung)
    {
      double mittelwert = Mittelwert(x);
      Standardabweichung = 0;
      foreach (double element in x) //Summe
      {
          Standardabweichung += (mittelwert - element) * (mittelwert - element);
      }
      Standardabweichung = Math.Sqrt(Standardabweichung / (x.Length - 1));
      return mittelwert;
    }
    #endregion Mittelelwert

    #region Standardabweichung
    // TO DO
    #endregion Standardabweichung
    
    #region MinimumMaximumSpannweite
    // TO DO
    #endregion MinimumMaximumSpannweite
  }
}


