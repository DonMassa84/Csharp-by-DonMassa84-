using System;


namespace Kundenklasse
{
    class Kunde
    {
        private string strFirma;
        private string strAnsprechPartner;
        private string strMobil;
        private string strMail;

        public string firma { get => strFirma; set => strFirma = value; }
        public string ansprechPartner { get => strAnsprechPartner; set => strAnsprechPartner = value; }
        public string mobil { get => strMobil; set => strMobil = value; }
        public string mail { get => strMail; set => strMail = value; }
    }
}
