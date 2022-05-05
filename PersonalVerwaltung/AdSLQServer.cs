using System;
using System.Data;
using System.Data.SqlClient;

namespace KundenVerwaltung
{

    public static class Datenzugriff
    {
        static string conStrg = (@"Data Source = DESKTOP-JOG43N6\DEVELOPING;  Initial Catalog=dbPersonalVerwaltung; Integrated Security=sspi");
        public static SqlConnection cn = new SqlConnection(conStrg);

        public static string strSQL = "Insert into tblArtikel(ArtikelBezeichnung, Einkaufspreis, Verkaufspreis, Lagerbestand) " +
                                       "values (@ArtikelBezeichnung, @Einkaufspreis, @Verkaufspreis, @Lagerbestand)"; //Parameter für den SQL Server

        //für das Insert -> SQLCommand
        public static SqlCommand cmd = new SqlCommand(strSQL, cn);
    }
}
