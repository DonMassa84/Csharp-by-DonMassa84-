
using System;
using System.Data;
using System.Data.SqlClient;
using Datenzugriff;
using c = System.Console;

namespace clArbeitnehmer
{
    public static class ArbeitnehmerBL
    {
        public static void neuerArbeitnehmer()
        {
            Arbeitnehmer neuerAN = new Arbeitnehmer();
            c.Write("Zuname: ");
            neuerAN.ZuName = (Convert.ToString(c.ReadLine()));
            c.Write("Vorname: ");
            neuerAN.VorName = (Convert.ToString(c.ReadLine()));
            c.Write("Pol-Kz: ");
            neuerAN.PolKz = (Convert.ToString(c.ReadLine()));
            c.Write("KM-Stand Beginn: ");
            neuerAN.KmStandBeg = (Convert.ToDecimal(c.ReadLine()));
            c.Write("Datum Beginn: ");
            neuerAN.AufzBeg = (Convert.ToString(c.ReadLine()));

            DZgrf.WriteDataBase("usp_Arbeitnehmer",
                new SqlParameter("@Auswahl", "saveArbeitnehmer"),
                new SqlParameter("@ZuName", neuerAN.ZuName),
                new SqlParameter("@VorName", neuerAN.VorName),
                new SqlParameter("@PolKz", neuerAN.PolKz),
                new SqlParameter("@KmStandBeg", neuerAN.KmStandBeg),
                new SqlParameter("@AufzBeg", neuerAN.AufzBeg));
        }

    }
}