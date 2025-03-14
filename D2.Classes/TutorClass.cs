using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace BienvenidoOnlineTutorServices.D2.Classes
{
    public class TutorClass
    {
        public static void ManageTutor()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Tutor (TutorName, Expertise, HourlyRate, Email) VALUES(@name, @expertise, @hourlyRate, @email)", connection))
                {
                    command.Parameters.AddWithValue("@name", TutorObjects.TutorName);
                    command.Parameters.AddWithValue("@email", TutorObjects.TutorEmail);
                    command.Parameters.AddWithValue("@expertise", TutorObjects.Expertise);
                    command.Parameters.AddWithValue("@hourlyRate", TutorObjects.HourlyRate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void ShowTutor(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT TutorName, Expertise, HourlyRate FROM D2.Tutor", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView.AutoGenerateColumns = true;
                        dataGridView.DataSource = table;
                    }
                }
            }
        }

        public static void FetchId()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT TutorId FROM D2.Tutor WHERE TutorName = @tutorname", connection))
                {
                    command.Parameters.AddWithValue("@tutorname", TemporalData.Tutor);

                    TutorObjects.TutorId = Convert.ToInt64(command.ExecuteScalar());
                }
            }
        }
    }
}
