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
    public class BillingClass
    {
        public static void TransactionRegistration()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Billing (TutorId, SubjectId, StudentId, SessionDuration, HourlyRate, TotalFee) VALUES(@tutorId, @subjectId, @studId, @sessionDuration, @hourlyRate, @totalFee);", connection))
                {
                    command.Parameters.AddWithValue("@tutorId",  TutorObjects.TutorId);
                    command.Parameters.AddWithValue("@subjectId", SubjectObjects.SubjectId);
                    command.Parameters.AddWithValue("@studId", StudentObjects.StudId);
                    command.Parameters.AddWithValue("@sessionDuration", TemporalData.SessionDuration);
                    command.Parameters.AddWithValue("@hourlyrate", TemporalData.HourlyRate);
                    command.Parameters.AddWithValue("@totalFee", TemporalData.TotalFee);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void ShowBilling(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.Billing", connection))
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
        
        public static void ShowPaidilling(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT TutorId, SubjectId, StudentId, SessionDuration, HourlyRate, TotalFee, PaymentStatus, PayedFee, RemainingBalance FROM D2.Billing WHERE PaymentStatus = 'Paid'", connection))
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

        public static void SelectedValue(DataGridView dataGridView)
        {
            DataGridViewRow selectedRow = dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex];

            if (selectedRow != null)
            {
                BillingObject.TutorId = Convert.ToInt32(selectedRow.Cells[0].Value ?? 0);
                BillingObject.SubjectId = Convert.ToInt32(selectedRow.Cells[1].Value ?? 0);
            }
        }

        public static void Payment()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Billing (PayedFee) VALUES (@payedfee) WHERE HourlyRate != Null;", connection))
                {
                    command.Parameters.AddWithValue("@payedFee", BillingObject.pay);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
