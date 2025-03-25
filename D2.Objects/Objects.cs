using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BienvenidoOnlineTutorServices.D2.Objects
{
    public class Objects
    {
        public class SubjectObjects
        {
            public static string SubjectName { get; set; }
        }
        public class DataId
        {
            public static long StudentId { get; set; }
            public static long TutorId { get; set; }
            public static long SubjectId { get; set; }
        }
        public class Enrollment 
        {
            public static string StudentName { get; set; }
            public static long StudentId { get; set; }
            public static string TutorName { get; set; }
            public static long TutorId { get; set; }
            public static string Subject { get; set; }
            public static long SubjectId { get; set; }
            public static DateTime SessionScheduleDate { get; set; }
            public static TimeSpan SessionScheduleTime { get; set; }
            public static int SessionDuration { get; set; }
            public static DateTime SessionEndSchedule { get; set; }
            public static decimal HourlyRate { get; set; }
            public static decimal TotalFee { get; set; }
            public static decimal RemainingFee { get; set; }
            public static decimal PaymentFee { get; set; }
            public static string PaymentStatus { get; set; }
        }
        public class PreferredSubject
        {
            public string StudentName { get; set; }
            public long StudentId { get; set; }
            public string TutorName { get; set; }
            public long TutorId { get; set; }
            public string Subject { get; set; }
            public long SubjectId { get; set; }
            public DateTime SessionScheduleDate { get; set; }
            public TimeSpan SessionScheduleTime { get; set; }
            public int SessionDuration { get; set; }
            public DateTime SessionEndSchedule { get; set; }
            public decimal HourlyRate { get; set; }
            public decimal TotalFee { get; set; }
            public decimal PaymentFee { get; set; }
            public decimal RemainingFee { get; set; }
            public string PaymentStatus { get; set; }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                PreferredSubject other = (PreferredSubject)obj;

                return Subject == other.Subject && SessionScheduleDate == other.SessionScheduleDate;
                //&& BookedDate == other.BookedDate; && RentedDuration == other.RentedDuration && HourlyRate == other.HourlyRate && TotalFee == other.TotalFee;
            }
            public override int GetHashCode()
            {
                unchecked
                {
                    int hash = 17;
                    hash = hash * 23 + (Subject?.GetHashCode() ?? 0);
                    hash = hash * 23 + SessionScheduleDate.GetHashCode();
                    //hash = hash * 23 + BookedDate.GetHashCode();
                    //hash = hash * 23 + RentedDuration.GetHashCode();
                    //hash = hash * 23 + HourlyRate.GetHashCode();
                    //hash = hash * 23 + TotalFee.GetHashCode();
                    return hash;
                }
            }
        }
        public class TemporalData
        {
            public static List<PreferredSubject> SubjectList = new List<PreferredSubject>();
            public static string StudentName { get; set; }
            public static long StudentId { get; set; }
            public static string StudentEmail { get; set; }
            public static string TutorName { get; set; }
            public static long TutorId { get; set; }
            public static string TutorEmail { get; set; }
            public static string Subject { get; set; }
            public static long SubjectId { get; set; }
            public static DateTime SessionScheduleDate { get; set; }
            public static TimeSpan SessionScheduleTime { get; set; }
            public static int SessionDuration { get; set; }
            public static DateTime SessionEndSchedule { get; set; }
            public static decimal HourlyRate { get; set; }
            public static decimal TotalFee { get; set; }
            public static decimal PaymentFee { get; set; }
            public static decimal RemainingFee { get; set; }
            public static string PaymentStatus { get; set; }
            public static TimeSpan InTime { get; set; }
            public static TimeSpan OutTime { get; set; }
        }
        public class TransactionAndBilling
        {
            public static long EnrollmentId { get; set; }
            public static long SubjectId { get; set; }
            public static decimal Pay { get; set; }
            public static decimal PaidFee { get; set; }
            public static decimal RemainingBalance { get; set; }
            public static decimal TotalFee { get; set; }
            public static String Tutor { get; set; }
            public static String Subject { get; set; }
            public static String Student { get; set; } 
            public static DateTime SessionSchedule { get; set; }
        }
    }
}
