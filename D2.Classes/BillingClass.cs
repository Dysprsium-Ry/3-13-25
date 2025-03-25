using BOTS.Database_Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace _3_13_25.D2.Classes
{
    public class BillingClass
    {
        #region function
        public static void TransactionRegistration()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.TransactionLog (TutorId, Tutor, SubjectId, Subject, StudentId, Student, SessionScheduleDate, SessionScheduleTime, SessionDuration, SessionEndSchedule, HourlyRate, TotalFee, RemainingBalance, PayFee, PaymentStatus) VALUES (@tutorId, @tutor, @subjectId, @subject, @studentId, @student, @sessionScheduleDate, @sessionScheduleTime, @sessionDuration, @sessionEndSchedule, @hourlyRate, @totalFee, @remainingBalance, @paidFee, @paymentStatus);", connection))
                {
                    command.Parameters.AddWithValue("@tutorId", Enrollment.TutorId);
                    command.Parameters.AddWithValue("@tutor", Enrollment.TutorName);
                    command.Parameters.AddWithValue("@subjectId", Enrollment.SubjectId);
                    command.Parameters.AddWithValue("@subject", Enrollment.Subject);
                    command.Parameters.AddWithValue("@studentId", Enrollment.StudentId);
                    command.Parameters.AddWithValue("@student", Enrollment.StudentName);
                    command.Parameters.AddWithValue("@sessionScheduleDate", Enrollment.SessionScheduleDate);
                    command.Parameters.AddWithValue("@sessionScheduleTime", Enrollment.SessionScheduleTime);
                    command.Parameters.AddWithValue("@sessionDuration", Enrollment.SessionDuration);
                    command.Parameters.AddWithValue("@sessionEndSchedule", Enrollment.SessionEndSchedule);
                    command.Parameters.AddWithValue("@hourlyRate", Enrollment.HourlyRate);
                    command.Parameters.AddWithValue("@totalFee", Enrollment.TotalFee);
                    command.Parameters.AddWithValue("@remainingBalance", Enrollment.RemainingFee);
                    command.Parameters.AddWithValue("@paidFee", Enrollment.PaymentFee);
                    command.Parameters.AddWithValue("@paymentStatus", Enrollment.PaymentStatus);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void Payment()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("UPDATE D2.Billing SET PaidFee = @payFee, RemainingBalance = @remaining, PaymentStatus = @paymentstatus WHERE SessionSchedule = @sessionSchedule AND Tutor = @tutor AND Subject = @subject AND Student = @student", connection))
                {
                    command.Parameters.AddWithValue("@sessionSchedule", TransactionAndBilling.SessionSchedule);
                    command.Parameters.AddWithValue("@payFee", OpsAndCalcs.SumPaidFee(TransactionAndBilling.PaidFee, TransactionAndBilling.Pay));
                    command.Parameters.AddWithValue("@remaining", OpsAndCalcs.CalculateRemainingFee(TransactionAndBilling.TotalFee, OpsAndCalcs.SumPaidFee(TransactionAndBilling.PaidFee, TransactionAndBilling.Pay)));
                    command.Parameters.AddWithValue("@paymentstatus", OpsAndCalcs.PaymentStatus(TransactionAndBilling.RemainingBalance, TransactionAndBilling.PaidFee));
                    command.Parameters.AddWithValue("@tutor", TransactionAndBilling.Tutor);
                    command.Parameters.AddWithValue("@subject", TransactionAndBilling.Subject);
                    command.Parameters.AddWithValue("@student", TransactionAndBilling.Student);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region DataGridViewProvider
        public static void ShowBilling(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.TransactionBilling", connection))
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
        public static void ShowPaidBilling(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.TransactionBillingPaid", connection))
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
                TransactionAndBilling.SessionSchedule = Convert.ToDateTime(selectedRow.Cells[0].Value ?? 0);
                TransactionAndBilling.Tutor = Convert.ToString(selectedRow.Cells[1].Value ?? null);
                TransactionAndBilling.Subject = Convert.ToString(selectedRow.Cells[2].Value ?? null);
                TransactionAndBilling.Student = Convert.ToString(selectedRow.Cells[3].Value ?? null);
                TransactionAndBilling.TotalFee = Convert.ToDecimal(selectedRow.Cells[5].Value ?? 0);
                TransactionAndBilling.PaidFee = Convert.ToDecimal(selectedRow.Cells[6].Value ?? 0);
                TransactionAndBilling.RemainingBalance = Convert.ToDecimal(selectedRow.Cells[7].Value ?? 0);
            }
        }
        #endregion
    }
}
