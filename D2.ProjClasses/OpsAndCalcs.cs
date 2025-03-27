using _3_13_25.D2.IdFetcherClasses;
using BienvenidoOnlineTutorServices.D2.Classes;
using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace _3_13_25.D2.Classes
{
    public class OpsAndCalcs
    {
        public static decimal CalculateTotalFee(decimal sessionDuration, decimal hourlyRate)
        {
            return sessionDuration * hourlyRate;
        }
        public static decimal CalculateRemainingFee(decimal RemainingFee, decimal paidFee)
        {
            decimal result = RemainingFee - paidFee;

            if (result >= 0) { return result; }
            else if (result < 0) { return 0; }
            else { return 0; }
        }
        public static decimal SumPaidFee(decimal PaidFee, decimal PayFee)
        {
            return PaidFee + PayFee;
        }
        public static string PaymentStatus(decimal payfee, decimal remainingfee)
        {
            if (payfee == 0 && remainingfee == 0) { return "Pending"; }

            decimal result = payfee - remainingfee;

            if (result == 0) { return "Paid"; }
            else if (result != 0 ) { return "Partial"; }
            else { return "Pending"; }
        }
        public static DateTime CalculatedScheduleSession(DateTime StartPeriod, int SessionDuration)
        {
            TimeSpan workStart = TemporalData.InTime;
            TimeSpan workEnd = TemporalData.OutTime;

            DateTime result = StartPeriod;

            while (SessionDuration > 0)
            {
                DateTime endOfDay = result.Date + workEnd;

                TimeSpan remainingTimeToday = endOfDay - result;

                if (remainingTimeToday.TotalHours > 0)
                {
                    if (remainingTimeToday.TotalHours >= SessionDuration)
                    {
                        result = result.AddHours(SessionDuration);
                        break;
                    }
                    else
                    {
                        result = result.Add(remainingTimeToday);
                        SessionDuration -= (int)remainingTimeToday.TotalHours;
                    }
                }

                result = result.Date.AddDays(1) + workStart;
            }

            return result;
        }
        public static bool IfScheduleExist(DateTime date, TimeSpan time)
        {
            DateTime scheduleTime = date.Date + time;

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM D2.TransactionLog WHERE SessionEndSchedule >= @scheduleDate AND TutorId = @tutorId;", connection))
                {
                    command.Parameters.Add("@scheduleDate", SqlDbType.DateTime).Value = scheduleTime;
                    command.Parameters.AddWithValue("@tutorId", IdFetcher.TutorId());

                    int count = (command.ExecuteScalar() as int?) ?? 0;
                    return count > 0;
                }
            }
        }
        public static DateTime SessessionEndSchedule(DateTime date, TimeSpan time, int sessionDuration)
        {
            DateTime calculatedTime = date + time;
            TimeSpan sessionTimeSpan = TimeSpan.FromHours(sessionDuration);

            TimeSpan workStart = new TimeSpan(8, 0, 0);
            TimeSpan workEnd = new TimeSpan(17, 0, 0);

            if (calculatedTime.TimeOfDay < workStart)
            {
                calculatedTime = calculatedTime.Date.Add(workStart);
            }
            else if (calculatedTime.TimeOfDay >= workEnd)
            {
                calculatedTime = calculatedTime.Date.AddDays(1).Add(workStart);
            }

            TimeSpan remainingToday = workEnd - calculatedTime.TimeOfDay;

            if (sessionTimeSpan <= remainingToday)
            {
                calculatedTime = calculatedTime.Add(sessionTimeSpan);
            }
            else
            {
                calculatedTime = calculatedTime.Add(remainingToday);

                TimeSpan remainingSession = sessionTimeSpan - remainingToday;

                calculatedTime = calculatedTime.Date.AddDays(1).Add(workStart);

                calculatedTime = calculatedTime.Add(remainingSession);
            }
            return calculatedTime;
        }


        #region SearchBox

        public static void SearchBar(DataGridView dt, string query, string item)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@item", "%" + item + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dt.AutoGenerateColumns = true;
                        dt.DataSource = table;
                    }
                }
            }
        }

        public static void SearchingBilling(DataGridView dt, string Tutor)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("D2.SearchTransactionLogsForPending", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SearchText", "%" + Tutor + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dt.AutoGenerateColumns = true;
                        dt.DataSource = table;
                    }
                }
            }
        }
        
        #endregion
    }
}
