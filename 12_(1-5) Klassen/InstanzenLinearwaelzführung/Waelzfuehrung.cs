using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linearwaelzführung
{
    class Waelzfuehrung
    {
#region Geschwindigkeit, Zeit und Weg
/// <summary>
/// Berechnet den gewichteten Mittelwert
/// </summary>
/// <param name="x"></param> Einzelwerte
/// <param name="wichte"></param> Wichtungsfaktoren
/// <returns></returns>
public double MittelwertGewichtet(double[] x, double[] wichte)
{
    double mittelwertGewichtet=0;
    for (int i = 0; i < x.Length; i++) mittelwertGewichtet += x[i] * wichte[i];
    return mittelwertGewichtet;
}
/// <summary>
/// Berechnet die Weganteile der Belastungsfälle
/// </summary>
/// <param name="v"></param> Geschwindigkeiten
/// <param name="tAnteil"></param> Zeitanteile
/// <returns></returns>
public double[] ToWegAnteil(double[] v, double[] tAnteil)
{
    double[] sAnteil=new double[v.Length];
    double vMittel = MittelwertGewichtet(v, tAnteil);
    for (int i = 0; i < v.Length; i++) sAnteil[i] = v[i] * tAnteil[i]/vMittel;
    return sAnteil;
}
#endregion Geschwindigkeit, Zeit und Weg
#region Kraft
/// <summary>
/// Liefert die Betragskraft der Einzelkräfte quer zur Lufrichtung
/// </summary>
/// <param name="F1"></param> verikale Kraft
/// <param name="F2"></param> horizontale Kraft
/// <returns></returns>
public double BetragsKraft(double F1, double F2)
{
    return Math.Abs(F1) + Math.Abs(F2);
}
/// <summary>
/// Liefert die Betragskraft der Einzelkräfte quer zur Lufrichtung
/// für alle Belastungsfälle
/// </summary>
/// <param name="F1"></param> verikale Kraft als Feld
/// <param name="F2"></param> horizontale Kraft als Feld
/// <returns></returns>
public double[] BetragsKraft(double[] F1, double[] F2)
{
    double[] F = new double[F1.Length];
    for (int i = 0; i < F.Length; i++) F[i]=Math.Abs(F1[i]) + Math.Abs(F2[i]);
    return F;
}
/// <summary>
///  Liefert die Betragskraft der Einzelkräfte quer zur Lufrichtung
///  unter Berücksichtigung eines wirkenden Momentes
/// </summary>
/// <param name="F1"></param> vertikale Kraft
/// <param name="F2"></param> horizontale Kraft
/// <param name="M"></param>  Moment
/// <param name="Mzul"></param> zulässiges Moment
/// <param name="Cdyn"></param> dynamische Tragzahl
/// <returns></returns>
public double BetragsKraft(double F1, double F2, double M, double Mzul, double Cdyn)
{
    return Math.Abs(F1) + Math.Abs(F2) + Math.Abs(Cdyn * M/Mzul);
}
/// <summary>
/// Berechnet die Äquivalente Kraft gewichtet entsprechend der Weganteile
/// </summary>
/// <param name="F"></param> Einzelkräfte
/// <param name="sAnteil"></param> Weganteile der einzelnen Kräfte s[i]/sges
/// <returns></returns>
public double AequivalentKraft(double[] F, double[] sAnteil)
{
    double sum = 0;
    for (int i = 0; i < F.Length; i++)
    {
        sum += F[i] * F[i] * F[i] * sAnteil[i];
    }
    const double EXPONENT =  1.0 / 3.0; //mit Kommastelle angeben --> Datentyp
    return Math.Pow(sum, EXPONENT);
}
/// <summary>
/// Berechnet die Äquivalente Kraft gewichtet entsprechend der Weganteile
/// </summary>
/// <param name="F"></param> Einzelkräfte
/// <param name="v"></param> Geschwindigkeit in Bezug zur Einzelkraft
/// <param name="tAnteil"></param> Zeitantei t[i]/tges
/// <returns></returns>
public double AequivalentKraft(double[] F, double[] v, double[] tAnteil)
{
    double summe = 0;
   // double vMittel = Statistik.Mittelwert(v);
    double vMittel = MittelwertGewichtet(v, tAnteil);
    for (int i = 0; i < F.Length; i++)
    {
        summe += F[i] * F[i] * F[i] * v[i] *tAnteil[i]/vMittel;
    }
    const double EXPONENT = 1 / 3;
    return Math.Pow(summe, EXPONENT);
}
#endregion Kraft

#region Lenensdauer
/// <summary>
/// Berechnet die Lebensdauer in Metern
/// </summary>
/// <param name="Cdyn"></param> dynamische Tragzahl
/// <param name="F"></param> Äquivalente Kraft
/// <param name="p"></param> Wälzkörperbeiwert Kugel p=3, Rolle p=10/3 [optional]
/// <param name="Lb"></param> nominelle Lebensdauer Lb=100000 m
/// <returns></returns>
public double LebensdauerMeter(double Cdyn, double F, double p=3, int Lb = 100000)
{
    //Damit Ergebnisse unterschiedlicher Hersteller vergleichbar sind!
    if (Lb == 50000 && p == 3)  Cdyn *= 0.79; //Kugelumlaufeinheit
    else                        Cdyn *= 0.81; //Rollenumlaufeinheit
    return Math.Pow((Cdyn / F), p) * Lb;
}
public double LebensdauerStunden(double Cdyn, double F, double p, double vMittel, int Lb = 100000)
{
    return LebensdauerMeter(Cdyn, F, p, Lb) / vMittel / 60;
}
public double LebensdauerStunden(double Lmeter, double vMittel)
{
    return Lmeter / vMittel / 60;
}
#endregion Lenensdauer

    }
}
