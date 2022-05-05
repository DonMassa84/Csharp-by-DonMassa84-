using System.Data;
using System.Data.SqlClient;

namespace Datenzugriff
{
    static class Dzgrf
    {
        public static DataTable ExecuteDataTable(string storedProcedureName, params SqlParameter[] arrParam)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(@"Data Source=HH-100; Initial Catalog=dbPersonalverwaltung; Integrated Security=sspi"))
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
                        {
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

        }
    }
}