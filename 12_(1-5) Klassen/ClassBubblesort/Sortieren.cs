using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
class Sortieren
{
/// <summary>
/// Sortiert die Feldelemente aufsteigend
/// </summary>
/// <param name="X"></param> unsortiertes Feld
/// <returns></returns> sortiertes Feld
public int[] bubbleSort(int[] X)
{
    int n = X.Length;  //Länge des Feldes
    int tausch;  //zum Tauschen der Werte zweier Feldelemente
    for (int i = n - 1; i >= 0; i--) //Feldelemente
    {
        for (int j = 1; j <= i; j++) //unsortierte Feldelemente
        {
            if (X[j - 1] > X[j]) //Tauschbedingung
            {
                tausch = X[j - 1]; //Tauschen
                X[j-1]= X[j];
                X[j]=tausch;
            }
        }
    }
    return X;
}
}
}
