using System;
using System.Data;
using System.Data.SqlClient;



namespace dbZugriff
{
    public static class Datenzugriff
    {
        static string conStrg = (@"Data Source = DESKTOP-JOG43N6\DEVELOPING;  Initial Catalog=dbArtikelVerwaltung; Integrated Security=sspi");
        public static SqlConnection cn = new SqlConnection(conStrg);

        public static string strSQL = "Insert into dbArtikel(ArtikelBezeichnung, Einkaufspreis, Verkaufspreis, Lagerbestand) " +
                                       "values (@artikelBezeichnung, @einkaufspreis, @verkaufspreis, @lagerbestand)"; //Parameter für den SQL Server

        //für das Insert -> SQLCommand
        public static SqlCommand cmd = new SqlCommand(strSQL, cn);
    }
}
