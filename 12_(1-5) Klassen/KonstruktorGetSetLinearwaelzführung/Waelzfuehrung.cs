using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linearwaelzführung
{
class Waelzfuehrung
{
#region Instanzvariablen
private 
double[] v ;      //Geschwindigkeiten
double[] tAnteil; //Zeitanteil
double[] sAnteil; //Wegabteil
double[] Fy;      //Kräfte vertikal
double[] Fz;      // Kräfte horizontal
int n;            //Anzahl der Betriebsarten
#endregion Instanzvariablen

#region Konstruktoren
/// <summary>
/// Initialisiert die Variablen
/// Schlüsselwort "this" kennzeichent die Variablen in der Klasse
/// Grundsätzlich kann "this" weggelassen werden. Es besteht aber
/// dann die gefahr der Verwechslung.
/// </summary>
public Waelzfuehrung()
{
    this.n = 1;
    felderDimensionieren(n);
    this.v[0] = 0;
    this.tAnteil[0] = 0;
    this.sAnteil[0] = 0;
    this.Fy[0] = 0;
    this.Fz[0] = 0;
}
/// <summary>
/// Initialisrt die Variablen entsprechend der Parameterliste
/// </summary>
/// <param name="v"></param>
/// <param name="tAnteil"></param>
/// <param name="sAnteil"></param>
/// <param name="Fy"></param>
/// <param name="Fz"></param>
public Waelzfuehrung(double v, double tAnteil, double sAnteil, double Fy, double Fz)
{
           
    this.n=1;
    felderDimensionieren(n);
    this.v[0] = v;
    this.tAnteil[0] = tAnteil;
    this.sAnteil[0] = sAnteil;
    this.Fy[0] = Fy;
    this.Fz[0] = Fz;
}
#endregion Konstruktoren

#region INSTANZMETHODEN
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
/// <summary>
/// Berechnet die Lebensdauer in Stunden
/// </summary>
/// <param name="Cdyn"></param> dynamische Tragzahl
/// <param name="F"></param> Äquivalente Kraft
/// <param name="p"></param> Wälzkörperbeiwert Kugel p=3, Rolle p=10/3
/// <param name="vMittel"></param> gewichtete Mittlere Geschwindigkeit
/// <param name="Lb"></param> nominelle Lebensdauer Lb=100000 m
/// <returns></returns>
public double LebensdauerStunden(double Cdyn, double F, double p, double vMittel, int Lb = 100000)
{
    return LebensdauerMeter(Cdyn, F, p, Lb) / vMittel / 60;
}
/// <summary>
/// Berechnet die Lebensdauer in Stunden
/// </summary>
/// <param name="Lmeter"></param> Lebensdauer in Metern
/// <param name="vMittel"></param> gewichtetet mittlere Geschwindigkeit
/// <returns></returns>
public double LebensdauerStunden(double Lmeter, double vMittel)
{
    return Lmeter / vMittel / 60;
}
#endregion Lenensdauer
#endregion INSTANZMETHODEN

/// <summary>
/// Gültigkeitsbereich ist diese Klasse
/// </summary>
#region lokale Methoden

/// <summary>
/// Vereinbart die Feldgrößen
/// </summary>
/// <param name="n"></param>
private void felderDimensionieren(int n)
{
    this.v = new double[n];
    this.tAnteil = new double[n];
    this.sAnteil = new double[n];
    this.Fy = new double[n];
    this.Fz = new double[n];
}
#endregion lokale Methoden

/// <summary>
/// Eigenschaftsmethoden greifen lesend oder/und schreiben auf die
/// Attribute bzw. Variablen zu.
/// Namenskonvention:
/// Nur Lesen:              Variablen beginnen mit get...
/// Nur Schreiben:          Variablen beginnen mit set...
/// Lesen und Schreinben:   Variablen beginnen mit ist...
/// </summary>
#region Eigenschaftsmethoden
/// <summary>
/// Anzahl der Betriebsarten
/// </summary>
public int istn
{
    get { return this.n; }
    set 
    { 
        this.n = value;
        if (this.n<=0) this.n=1;
        felderDimensionieren(n);
    }
}
/// <summary>
/// Geschwindigkeiten v
/// </summary>
public double[] istv
{
    get { return v; }
    set { this.v = value; }
}
/// <summary>
/// Zeitanteile ti/t
/// </summary>
public double[] istt
{
    get { return this.tAnteil; }
    set { this.tAnteil = value;}
}
/// <summary>
/// Weganteile si/s
/// </summary>
public double[] ists
{
    get { return this.sAnteil; }
    set { this.sAnteil = value; }
}
/// <summary>
/// Kräfte Fy
/// </summary>
public double[] istFy
{
    get { return this.Fy; }
    set { this.Fy = value; }
}
/// <summary>
/// Kräfte Fz
/// </summary>
public double[] istFz
{
    get { return this.Fz; }
    set { this.Fz = value; }
}
#endregion Eigenschaftsmethoden
}
}
