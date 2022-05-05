
using System.Text;
using clArbeitnehmer;

namespace clFahrtenbuch
{
    class Fahrtenbuch : Arbeitnehmer
    {
        private int id;
        private string fahrtdatum;
        private decimal kmabf;
        private decimal kmank;
        private decimal gefkm;
        private string geschpriva;
        private string privat;
        private string zweck;
        private string reiseweg;

        public int Id { get => id; set => id = value; }
        public string Fahrtdatum { get => fahrtdatum; set => fahrtdatum = value; }
        public decimal Kmabf { get => kmabf; set => kmabf = value; }
        public decimal Kmank { get => kmank; set => kmank = value; }
        public decimal Gefkm { get => gefkm; set => gefkm = value; }
        public string Geschpriva { get => geschpriva; set => geschpriva = value; }
        public string Privat { get => privat; set => privat = value; }
        public string Zweck { get => zweck; set => zweck = value; }
        public string Reiseweg { get => reiseweg; set => reiseweg = value; }

    }
}
