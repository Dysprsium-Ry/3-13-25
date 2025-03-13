using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace BienvenidoOnlineTutorServices.D2.Classes
{
    public class StudentClass
    {
        public static void EnrollStudent()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using(SqlCommand command = new SqlCommand("INSERT INTO D2.Students (StudentName, StudentEmail, PreferredSubject) VALUES(@name, @email, @preferredSubject)", connection))
                {
                    command.Parameters.AddWithValue("@name", StudentObjects.StudName);
                    command.Parameters.AddWithValue("@email", StudentObjects.StudEmail);
                    command.Parameters.AddWithValue("@preferredSubject", StudentObjects.PreferredSubjects);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
