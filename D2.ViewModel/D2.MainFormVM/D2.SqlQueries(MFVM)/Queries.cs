using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_13_25.D2.QueryStorage
{
    public class Queries
    {

        #region SearchBarFunction

        public static string studListSbar
        {
            get => "SELECT StudentName, StudentEmail FROM D2.Students WHERE (@item IS NULL OR @item = '' OR @item = ' ') OR StudentName LIKE @item";
            set { }
        }

        public static string tutSubSBar
        {
            get => "SELECT TutorName, HourlyRate FROM D2.Tutor WHERE (@item IS NULL OR @item = '' OR @item = ' ') OR Expertise LIKE @item";
            set { }
        }

        public static string tutListSbar
        {
            get => "SELECT TutorName, Expertise, HourlyRate, InTime, OutTime FROM D2.Tutor WHERE (@item IS NULL OR @item = '' OR @item = ' ') OR TutorName LIKE @item";
            set { }
        }

        #endregion

        #region DataGridView

        public static string ECDispTut
        {
            get => "SELECT TutorName, HourlyRate, InTime, OutTime FROM D2.Tutor WHERE Expertise = @item";
            set { }
        }

        #endregion
    }
}
