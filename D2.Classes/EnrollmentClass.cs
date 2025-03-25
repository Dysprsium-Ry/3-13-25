using BOTS.Database_Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace BienvenidoOnlineTutorServices.D2.Classes
{
    public class EnrollmentClass
    {
        #region function
        public static void TemporalDataSelectedValue(DataGridView dataGridView)
        {
            DataGridViewRow selectedRow = dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex];
            if (selectedRow != null)
            {
                TemporalData.TutorName = selectedRow.Cells["TutorName"].Value.ToString();
                TemporalData.HourlyRate = Convert.ToInt32(selectedRow.Cells["HourlyRate"].Value ?? 0);
                TemporalData.InTime = (TimeSpan)selectedRow.Cells["Intime"].Value;
                TemporalData.OutTime = (TimeSpan)selectedRow.Cells["OutTime"].Value;
            }
        }
        public static void SelectRowDTVStudentList(DataGridView dt)
        {
            DataGridViewRow selectedRow = dt.Rows[dt.SelectedCells[0].RowIndex];
            if (selectedRow != null)
            {
                TemporalData.StudentName = selectedRow.Cells["StudentName"].Value.ToString();
                TemporalData.StudentEmail = selectedRow.Cells["StudentEmail"].Value.ToString();
            }
        }
        public static void EnrollStudent()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Students (StudentName, StudentEmail) SELECT @name, @email WHERE NOT EXISTS ( SELECT 1 FROM D2.Students WHERE StudentName = @name AND StudentEmail = @email );", connection))
                {
                    command.Parameters.AddWithValue("@name", TemporalData.StudentName);
                    command.Parameters.AddWithValue("@email", TemporalData.StudentEmail);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region DataGridViewProvider
        public static void ShowTutor(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT TutorName, HourlyRate, InTime, OutTime FROM D2.Tutor WHERE Expertise = @expertise", connection))
                {
                    command.Parameters.AddWithValue("@expertise", TemporalData.Subject);

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
        public static void ShowStudent(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT StudentName, StudentEmail FROM D2.Students WHERE StudentName = @studName", connection))
                {
                    command.Parameters.AddWithValue("@studName", TemporalData.StudentName);

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
        #endregion
    }
}
