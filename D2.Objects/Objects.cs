using System;
using System.Collections.Generic;

namespace BienvenidoOnlineTutorServices.D2.Objects
{
    public class Objects
    {
        public class SubjectObjects()
        {
            public static string[] Subject { get; set; }
        }

        public class StudentObjects
        {
            public static string StudName { get; set; }
            public static string StudEmail { get; set; }
            public static string PreferredSubjects { get; set; }
            public static int SessionDuration { get; set; }
        }

        public class TutorObjects
        {
            public static string TutorName { get; set; }
            public static string TutorEmail { get; set; }
            public static string Expertise { get; set; }
            public static int HourlyRate { get; set; }
        }

        public class PreferredSubject
        {
            public string Subject { get; set; }
            public int SessionDuration { get; set; }
            public int HourlyRate { get; set; }
            public int TotalFee { get; set; }
            public string Tutor { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                PreferredSubject other = (PreferredSubject)obj;

                return Subject == other.Subject;
                //&& BookedDate == other.BookedDate; && RentedDuration == other.RentedDuration && HourlyRate == other.HourlyRate && TotalFee == other.TotalFee;
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int hash = 17;
                    hash = hash * 23 + (Subject?.GetHashCode() ?? 0);
                    //hash = hash * 23 + BookedDate.GetHashCode();
                    //hash = hash * 23 + RentedDuration.GetHashCode();
                    //hash = hash * 23 + HourlyRate.GetHashCode();
                    //hash = hash * 23 + TotalFee.GetHashCode();
                    return hash;
                }
            }
        }

        public class RegisteredSubject
        {
            public static List<PreferredSubject> SubjectList = new List<PreferredSubject>();
            public static string Subject { get; set; }
            public static int SessionDuration { get; set; }
            public static int HourlyRate { get; set; }
            public static int TotalFee { get; set; }
            public static string Tutor { get; set; }
        }
    }
}
