using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using c = System.Console;


namespace StudentenListe
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Datenzugriff.cn.Open();
                int inRecords = Datenzugriff.daStudent.Fill(Datenzugriff.dtStudent);

                if (inRecords > 0)
                {
                    c.WriteLine("Unsere alphabetische Studenten-Liste ...\n\n");
                    c.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-20} {5,-20} {6,-15}\n",
                        "Nachname", "Vorname", "Geb.Datum", "geb.in", "Mail-Adresse", "Universität", "Ort");

                    foreach (DataRow dr in Datenzugriff.dtStudent.Rows)
                    {
                        string repeated = new String('-', 95).Replace("-", "-");
                        c.WriteLine(repeated);
                        c.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-20} {5,-20} {6,-15}", dr[0], dr[1],
                            dr[2] = DateTime.Parse((dr[2].ToString())).ToShortDateString(), dr[3], dr[4], dr[5], dr[6]);
                    }
                    c.WriteLine(String.Join("", Enumerable.Repeat("-", 95)));
                    c.Write("\nAnzahl der Studenten: {0}", inRecords);
                    c.ReadKey();
                }

                else
                {
                    c.WriteLine("Leider wurden keine Studenten gefunden!");
                    c.ReadKey();
                }
            }

            catch (SqlException e)
            {
                string msg = "";
                for (int i = 0; i < e.Errors.Count; i++)
                {
                    msg += "Error #" + i + " Message: " + e.Errors[i].Message + "\n";
                }
                c.WriteLine(msg);
                c.ReadKey();
            }

            finally
            {
                if (Datenzugriff.cn.State != ConnectionState.Closed)
                {
                    Datenzugriff.cn.Close();
                }

            }

        }
    }
}
