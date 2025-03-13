using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
        }

        public class TutorObjects
        {
            public static string TutorName { get; set; }
            public static string TutorEmail { get; set; }
            public static string Expertise { get; set; }
            public static int HourlyRate { get; set; }
        }

        public class ScheduleObjects
        {

        }
    }
}
