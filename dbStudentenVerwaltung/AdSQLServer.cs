using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentenListe
{
    public static class Datenzugriff
    {
        static string conStrg = (@"Data Source=HHK-MOBIL\DEVELOPING; Initial Catalog=dbStudentenVerwaltung; Integrated Security=sspi");
        public static SqlConnection cn = new SqlConnection(conStrg);

        public static string sCommand = "SELECT s.STU_ZName, s.STU_VName, s.STU_GebDatum, s.STU_GebIn, s.STU_MailAdresse, u.UNI_Name, u.UNI_Ort " +
                                        "FROM tblStudent AS s INNER JOIN tblUniversitaet AS u ON s.UNI_ID = u.UNI_ID ORDER BY s.STU_ZName";

        public static SqlDataAdapter daStudent = new SqlDataAdapter(sCommand, cn);
        public static DataTable dtStudent = new DataTable();
    }
}