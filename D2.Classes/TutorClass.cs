using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace BienvenidoOnlineTutorServices.D2.Classes
{
    public class TutorClass
    {
        public static void RegisterTutor()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Tutor (TutorName, Expertise, HourlyRate, Email) VALUES(@name, @expertise, @hourlyRate, @email)", connection))
                {
                    command.Parameters.AddWithValue("@name", TutorObjects.TutorName);
                    command.Parameters.AddWithValue("@email", TutorObjects.TutorEmail);
                    command.Parameters.AddWithValue("@hourlyRate", TutorObjects.HourlyRate);
                    command.Parameters.AddWithValue("@expertise", TutorObjects.Expertise);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
