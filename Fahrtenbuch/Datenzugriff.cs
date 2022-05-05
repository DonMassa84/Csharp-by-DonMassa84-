using System.Data;
using System.Data.SqlClient;
using System;

namespace Datenzugriff
{
    class DZgrf
    {
        public static DataTable ExecuteDataTable(string storedProcedureName, params SqlParameter[] arrParam)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(@"Data Source=HHK-MOBIL\DEVELOPING; Initial Catalog=dbVerwaltung; Integrated Security=sspi"))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedureName;

                    if (arrParam != null)
                    {
                        foreach (SqlParameter param in arrParam)
                            cmd.Parameters.Add(param);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;

        }
        public static void WriteDataBase(string storedProcedureName, params SqlParameter[] arrParam)
        {

            using (SqlConnection cnn = new SqlConnection(@"Data Source=SQLServerInstanzName; Initial Catalog=Datenbank; Integrated Security=sspi"))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedureName;

                    if (arrParam != null)
                    {
                        foreach (SqlParameter param in arrParam)
                            cmd.Parameters.Add(param);
                    }

                    int anzRecord = cmd.ExecuteNonQuery();
                    if (anzRecord > 0)
                    {
                        Console.WriteLine("Datensatz erfolgreich gespeichert!");
                    }
                    else
                    {
                        Console.WriteLine("Datensatz konte nicht gespeichert werden!");
                    }

                }
            }

        }

    }
}