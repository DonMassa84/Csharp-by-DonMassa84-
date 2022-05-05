using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezugskalkulation
{
    class Lagerverwaltung

    {
        private int menge;
        private Decimal einzelpreis;
        private Decimal rabattproz;
        private Decimal skontoproz;
        private Decimal bezugskosten;

        public int Menge { get => menge; set => menge = value; }
        public decimal Einzelpreis { get => einzelpreis; set => einzelpreis = value; }
        public decimal Rabattproz { get => rabattproz; set => rabattproz = value; }
        public decimal Skontoproz { get => skontoproz; set => skontoproz = value; }
        public decimal Bezugskosten { get => bezugskosten; set => bezugskosten = value; }
    }
}
