using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
class Sortieren
{
    #region Delegate und Lambda Expression
    /// <summary>
    /// Deklaration des Delegaten
    /// Zeigt auf die Funktionen "SortAufsteigend" oder "SortAbsteigend"
    /// deren Signatur zum Delgaten passen muss.
    /// </summary>
    /// <param name="x"></param> Vergleichsparameter
    /// <param name="y"></param> Vergleichsparameter
    /// <returns></returns>
    public delegate bool CompareDelegate(int x, int y);
    /// <summary>
    /// Vergleichs-Lambda-Expression für Aufsteigende Sortierung
    /// </summary>
    public CompareDelegate Aufsteigend = (x, y) => y < x;
    /// <summary>
    /// Vergleichs-Lambda-Expression für Absteigende Sortierung
    /// </summary>
    public CompareDelegate Absteigend  = (x, y) => y > x;
       /// <summary>
    /// Sortiert wahlweise auf- oder absteigend mit Hilfe eines Delegaten.
    /// </summary>
    /// <param name="compareDelegate"></param> Delegate für Vergleichsmethode
    /// <param name="X"></param> zu sortierendes Feld
    /// <returns></returns>
    public int[] bubbleSortWithDelegate(CompareDelegate compareDelegate, int[] X)
    {
        int n = X.Length;  //Länge des Feldes
        int tausch;  //zum Tauschen der Werte zweier Feldelemente
        for (int i = n - 1; i >= 0; i--) //Feldelemente
        {
            for (int j = 1; j <= i; j++) //unsortierte Feldelemente
            {
                //if (X[j - 1] > X[j]) //Tauschbedingung
                if (compareDelegate(X[j - 1], X[j]))
                {
                    tausch = X[j - 1]; //Tauschen
                    X[j - 1] = X[j];
                    X[j] = tausch;
                }
            }
        }
        return X;
    }
    #endregion Delegate und Lambda Expression
}
}
