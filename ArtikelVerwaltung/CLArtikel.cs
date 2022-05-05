using System;


namespace ArtikelVerwaltung
{
    class Artikel

    {
        private string strArtikelBezeichnung;
        private string strEinkaufspreis;
        private string strVerkaufspreis;
        private string strLagerbestand;

        public string artikelBezeichnung { get => strArtikelBezeichnung; set => strArtikelBezeichnung = value; }
        public string einkaufspreis { get => strEinkaufspreis; set => strEinkaufspreis = value; }
        public string verkaufspreis { get => strVerkaufspreis; set => strVerkaufspreis = value; }
        public string lagerbestand { get => strLagerbestand; set => strLagerbestand = value; }
    }
}
