using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace _3_13_25.D2.Classes
{
    public class SubjectClass
    {
        public static void FetchSubjects()
        {
            using (SqlConnection con = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.Subject", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> items = new List<string>();

                        while (reader.Read())
                        {
                            items.Add(reader["Subject"].ToString());
                        }
                        SubjectObjects.Subject = items.ToArray();
                    }
                }
            }
        }
    }
}
