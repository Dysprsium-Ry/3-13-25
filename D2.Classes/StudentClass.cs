using BOTS.Database_Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace BienvenidoOnlineTutorServices.D2.Classes
{
    public class StudentClass
    {
        public static void EnrollStudent()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Students (StudentName, StudentEmail, PreferredSubject) VALUES(@name, @email, @preferredSubject)", connection))
                {
                    command.Parameters.AddWithValue("@name", StudentObjects.StudName);
                    command.Parameters.AddWithValue("@email", StudentObjects.StudEmail);
                    command.Parameters.AddWithValue("@preferredSubject", TemporalData.Subject);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void ShowTutor(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT TutorName, HourlyRate FROM D2.Tutor WHERE Expertise = @expertise", connection))
                {
                    command.Parameters.AddWithValue("@expertise", StudentObjects.PreferredSubjects);

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

        public static void SelectedValue(DataGridView dataGridView)
        {
             DataGridViewRow selectedRow = dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex];

            if (selectedRow != null) 
            {
                StudentObjects.Tutor = selectedRow.Cells[0].Value.ToString();
                StudentObjects.HourlyRate = Convert.ToInt32(selectedRow.Cells[1].Value ?? 0);
            }
        }

        public static void FetchId()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT StudId FROM D2.Students WHERE StudentName = @name", connection))
                {
                    command.Parameters.AddWithValue("@name", StudentObjects.StudName);

                    StudentObjects.StudId = Convert.ToInt64(command.ExecuteScalar());
                }
            }
        }
    }
}
