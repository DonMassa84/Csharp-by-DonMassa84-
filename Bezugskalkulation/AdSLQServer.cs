using System;
//Datenbankklassen:
using System.Data;
//Klassen
using System.Data.SqlClient;


namespace Bezugskalkulation
{
    public static class Datenzugriff
    {
        //für die Datensätze die vom SQL gefunden werden -->
        public static SqlDataAdapter daBezugKal = new SqlDataAdapter(strSQL, cn);

        //für die Anzeige der DS in der Konsole: DataTable
        public static DataTable dBezugKal = new DataTable();

        //für das Insert -> SQLCommand
        public static SqlCommand cmd = new SqlCommand(strSQL, cn);

        public static SqlCommand cmd2 = new SqlCommand(strSQL2, cn2);

        //Zugriff auf den SQL-Server: Name des SQL-Servers: Name des SQL-Servers, Name der Datenbank,
        //Security(mit welchem Konto) - Verbindungsstring
        static string conStrg = (@"Data Source = DESKTOP-JOG43N6\DEVELOPING;  Initial Catalog=dbLagerverwaltung; Integrated Security=sspi");

        //SqlConnection mit Übergabe des Verindungsstrings
        public static SqlConnection cn = new SqlConnection(conStrg);

        //SqlConnection mit Übergabe des Verindungsstrings
        public static SqlConnection cn2 = new SqlConnection2(conStrg2);

        //SQL-Server ->Sichten -> Neue Sicht(Generiert Select Befehle/Commands
        public static string strSQL = "SELECT KalListeneinkaufspreis, KalRabattP, KalRabattE, KalZieleinkaufspreis, KalSkontoP, KalSkontoE, " +
                                        "KalBareinkaufspreis, KalBezugskostenP, KalBezugskostenE, KalBezugspreis " +
                                        "FROM tblBezugskalklation";

        public static string strSQL2 = "INSERT INTO tblBezugskalkulation(" + "KalListeneinkaufspreis" + "KalRabattP" + "KalRabattE" + "KalZieleinkaufspreis" + "KalSkontoP" + "KalSkontoE" +
                                         "KalBareinkaufspreis" + "KalBezugskostenP" + "KalBezugskostenE" + "KalBezugspreis" +
                                         "VALUES " + ",@menge" + ",@einzelpreis" + ",@rabattproz" + ",@skontoproz" + ",@bezugkosten";



    }
}

