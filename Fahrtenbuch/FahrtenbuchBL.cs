using System;
using System.Data;
using System.Data.SqlClient;
using Datenzugriff;

using c = System.Console;

namespace clFahrtenbuch
{
    public static class FahrtenbuchBL
    {
        public static void neuesFahrtenbuch()
        {
            decimal gefKilometer;
            Fahrtenbuch neuesFB = new Fahrtenbuch();

            c.Write("Fahrer ID: ");
            neuesFB.Id = (Convert.ToInt32(c.ReadLine()));
            c.Write("Datum der Fahrt: ");
            neuesFB.Fahrtdatum = (Convert.ToString(c.ReadLine()));
            c.Write("KM-Abfahrt: ");
            neuesFB.Kmabf = (Convert.ToDecimal(c.ReadLine()));
            c.Write("KM-Ankunft: ");
            neuesFB.Kmank = (Convert.ToDecimal(c.ReadLine()));
            gefKilometer = neuesFB.Kmank - neuesFB.Kmabf;
            c.Write("(G)eschäftlich/(P)rivat: ");
            neuesFB.Geschpriva = (Convert.ToString(c.ReadLine()));
            c.Write("Zweck: ");
            neuesFB.Zweck = (Convert.ToString(c.ReadLine()));
            c.Write("Reiseweg: ");
            neuesFB.Reiseweg = (Convert.ToString(c.ReadLine()));

            DZgrf.WriteDataBase("usp_Fahrtenbuch",
                new SqlParameter("@Auswahl", "saveFahrtenbuch"),
                new SqlParameter("@ID", neuesFB.Id),
                new SqlParameter("@FahrtDatum", neuesFB.Fahrtdatum),
                new SqlParameter("@KmAbf", neuesFB.Kmabf),
                new SqlParameter("@KmAnk", neuesFB.Kmank),
                new SqlParameter("@gefKM", gefKilometer),
                new SqlParameter("@geschpriva", neuesFB.Geschpriva),
                new SqlParameter("@Zweck", neuesFB.Zweck),
                new SqlParameter("@Reiseweg", neuesFB.Reiseweg));
        }



    }
}