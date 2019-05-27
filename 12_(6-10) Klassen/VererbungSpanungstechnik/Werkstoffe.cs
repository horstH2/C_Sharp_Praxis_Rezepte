namespace Spanungstechnik
{
    class Werkstoffe
    {
        /// <summary>
        /// Spezifische Schnittkräfte [Degner, Lutze, Smejkal: "Spanende Formung", Tabelle 3.1
        /// HANSER 2002,  ISBN 3-446-22138-7
        /// </summary>
        string[] name = {"S185", "S355", "E335", "E360", "C15", "C35", "C45E", "C60E"};
        double[]    m = { 0.17,    0.26,   0.17,   0.30,  0.22,  0.20,   0.14,  0.18 };
        double[] kc11 = { 1780,    1990,   2110,   2260,   1820,  1860,   2220, 2130 };
        /// <summary>
        /// Index des aktuellen Werkstoffs
        /// </summary>
        int i;
        /// <summary>
        /// Setst den Index auf einen Wekstoff => aktueller Wst
        /// </summary>
        public int seti
        {
            set {this.i = value;}
        }
        /// <summary>
        /// Liefert die Anzahl der Werkstoffe
        /// </summary>
        public int getLength
        {
            get { return this.name.Length; }
        }
        /// <summary>
        /// Liefert den Namen des aktuellen Werkstoffs
        /// </summary>
        public string getName
        {
                get {return this.name[i];}
        }
        /// <summary>
        /// Liefert den Anstiegswert m der Schnittkraft
        /// </summary>
        public double getm
        {
            get { return this.m[i]; }
        }
        /// <summary>
        /// Liefert den spezifischen Schnittwert kc11 in N/mm²
        /// </summary>
        public double getKc11
        {
            get { return this.kc11[i]; }
        }
    }
}
