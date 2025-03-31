using BOTS.Database_Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

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
                using (SqlCommand command = new SqlCommand("UPDATE D2.TransactionLog SET PayFee = @payFee, RemainingBalance = @remaining, PaymentStatus = @paymentstatus WHERE TransactionId = @transactionId", connection))
                {
                    command.Parameters.AddWithValue("@transactionId", BillingObj.EnrollmentId);
                    command.Parameters.AddWithValue("@payFee", OpsAndCalcs.SumPaidFee(BillingObj.PayFee, BillingObj.Pay));
                    command.Parameters.AddWithValue("@remaining", OpsAndCalcs.CalculateRemainingFee(BillingObj.TotalFee, OpsAndCalcs.SumPaidFee(BillingObj.PayFee, BillingObj.Pay)));
                    command.Parameters.AddWithValue("@paymentstatus", OpsAndCalcs.PaymentStatus(OpsAndCalcs.SumPaidFee(BillingObj.PayFee, BillingObj.Pay), BillingObj.TotalFee));
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.PresentPendingBilling", connection))
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
        public static void ShowPartialBilling(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.PresentPartialBilling", connection))
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
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.PresentPaidBilling", connection))
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
                BillingObj.EnrollmentId = Convert.ToInt64(selectedRow.Cells["TransactionId"].Value ?? 0);
                BillingObj.Student = Convert.ToString(selectedRow.Cells["Student"].Value ?? null);
                BillingObj.Subject = Convert.ToString(selectedRow.Cells["Subject"].Value ?? null);
                BillingObj.Tutor = Convert.ToString(selectedRow.Cells["Tutor"].Value ?? null);
                BillingObj.TotalFee = Convert.ToDecimal(selectedRow.Cells["TotalFee"].Value ?? 0);
                BillingObj.PayFee = Convert.ToDecimal(selectedRow.Cells["PayFee"].Value ?? 0);
                BillingObj.RemainingBalance = Convert.ToDecimal(selectedRow.Cells["RemainingBalance"].Value ?? 0);
            }
        }
        #endregion
    }
}
