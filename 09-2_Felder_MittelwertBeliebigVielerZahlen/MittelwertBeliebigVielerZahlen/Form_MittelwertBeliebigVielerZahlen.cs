using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MittelwertBeliebigVielerZahlen
{
  public partial class Form_MittelwertBeliebigVielerZahlen : Form
  {
    public Form_MittelwertBeliebigVielerZahlen()
    {
      InitializeComponent();
    }

/// <summary>
///  Feld und zwischensumme müssen global vereinbart werden
/// </summary>
// Ein Feld mit keinem Element
double[] werte = new double[0];
// Summe für Mittelwertberechnung
double summe = 0;
/// <summary>
/// Berechnet Button-Klick kumulativ den Mittelwert.
/// Das Feld wird jeweils um ein Element erweitert.
/// Sämtliche Eingabewerte sind dortabgespeichert.
/// </summary>
private void button_Uebernahme_Click(object sender, EventArgs e)
{
  // Ein Element wird an das Feld angehängt
  Array.Resize(ref werte, werte.Length + 1);
  // Wert wird per Formulareingabe übernommen
  werte[werte.Length - 1] = Convert.ToDouble(textBox_Eingabewert.Text);
  // Summe wird kumulativ berechnet
  summe += werte[werte.Length - 1];
  //Mittelwertberechnung und Ausgabe
  textBox_Mittelwert.Text = (summe / werte.Length).ToString();
  // Augabe der Anzahl der Feldelemente
  textBox_Anzahl.Text = werte.Length.ToString();
}

private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
{
  Close();
}
  }
}
