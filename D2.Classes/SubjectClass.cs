using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace _3_13_25.D2.Classes
{
    public class SubjectClass
    {
        #region function
        public static void FetchSubjects()
        {
            using (SqlConnection con = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT Subject FROM D2.Subject", con))
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
        public static void FetchId()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT SubjectId FROM D2.Subject WHERE Subject = @subject", connection))
                {
                    command.Parameters.AddWithValue("@subject", TemporalData.Subject);

                    SubjectObjects.SubjectId = Convert.ToInt64(command.ExecuteScalar());
                }
            }
        }
        public static void AddSub()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Subject (Subject) VALUES(@subject)", connection))
                {
                    command.Parameters.AddWithValue("@subject", subjectLib.subject);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteSub()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM D2.Subject WHERE Subject = @subject", connection))
                {
                    command.Parameters.AddWithValue("@subject", subjectLib.subject);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region DataGridViewProvider
        public static void ShowSubjects(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT Subject FROM D2.Subject", connection))
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
        public static void ShowTutorOfTheSubject(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT TutorName, HourlyRate FROM D2.Tutor WHERE Expertise = @expertise", connection))
                {
                    command.Parameters.AddWithValue("@expertise", SubjectObjects.SubjectName);

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