using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerzweigteFelder
{
  public partial class Form_VerzweigtesFeld : Form
  {
    public Form_VerzweigtesFeld()
    {
      InitializeComponent();
    }
    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }
/// <summary>
/// Erzeugt ein zweidimensionales verzwigtes Feld und
/// füllt es mit Zufallsdaten
/// </summary>
private void erzeugeToolStripMenuItem_Click(object sender, EventArgs e)
{
  // Mehrfachfeld mit 5 Zeilen
  double[][] feld = new double[5][];
  // Jede Zeile erhält seine individulle Elementeanzahl
  Random spalenanzahl = new Random();
  for (int zeile = 0; zeile < 5; zeile++)
  {
    //Eine Zeile mit zufällig 1 bis maximal 6 Elementen
    feld[zeile] = new double[spalenanzahl.Next(1, 7)];
  }
  //Alle Feldelemente sollen jetzt mit Zufallswerten gefüllt werden
  Random zufallswert = new Random(3);
  for (int zeile = 0; zeile < feld.Length; zeile++)
  {
    for (int spalte = 0; spalte < feld[zeile].Length; spalte++)
    {
      // Zufallsewerte liegen zwischen 0 und exclusiv 100
      feld[zeile][spalte] = zufallswert.Next(0, 100);
    }
  }
  // Ausgabe aller Feldelemente in einer Textbox
  for (int zeile = 0; zeile < feld.Length; zeile++)
  {
    textBox_Feld.Text += "\r\n"; //Neue Zeile
    for (int spalte = 0; spalte < feld[zeile].Length; spalte++)
    {
      // Elemente einer Zeile
      textBox_Feld.Text += feld[zeile][spalte].ToString("00") +", ";
    }
  }
    }
  }
}
