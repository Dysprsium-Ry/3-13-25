using BienvenidoOnlineTutorServices.D2.Classes;
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
    public class OpsAndCalcs
    {
        public static decimal CalculateTotalFee(decimal sessionDuration, decimal hourlyRate)
        {
            return sessionDuration * hourlyRate;
        }
        public static decimal CalculateRemainingFee(decimal RemainingFee, decimal paidFee)
        {
            return RemainingFee - paidFee;
        }
        public static decimal SumPaidFee(decimal PaidFee, decimal PayFee)
        {
            return PaidFee + PayFee;
        }
        public static string PaymentStatus(decimal RemainingFee, decimal PaidFee)
        {
            decimal result = RemainingFee - PaidFee;

            if (result == 0)
                return "Paid";
            else if (RemainingFee > 0 && PaidFee > 0)
                return "Partial";
            else
                return "Pending";
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
        public static bool IfScheduleExist(DateTime dateTime)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(@" SELECT COUNT(*) FROM D2.Billing WHERE CAST(SessionEndSchedule AS DATE) = @dateOnly AND DATEPART(HOUR, SessionEndSchedule) = @hourOnly AND TutorId = @tutorId;", connection))
                {
                    command.Parameters.AddWithValue("@dateOnly", dateTime.Date);
                    command.Parameters.AddWithValue("@hourOnly", dateTime.Hour);
                    command.Parameters.AddWithValue("@tutorId", TemporalData.TutorId);

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
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
        public static void StudentList(DataGridView dt, string studname)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT StudentName, StudentEmail FROM D2.Students WHERE (@studName IS NULL OR @studName = '' OR @studName = ' ') OR StudentName LIKE @studName", connection))
                {
                    command.Parameters.AddWithValue("@studName", "%" + studname + "%");

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
