using BOTS.Database_Connection;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace _3_13_25.D2.Classes
{
    public class ReceiptReportClass
    {
        public static void ReceiptSetup(ReportViewer receipt)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.BillingViewPaid WHERE SessionSchedule = @session AND TutorName = @tutor AND Subject = @subject AND StudentName = @student AND TotalFee = @totalFee", connection))
                {
                    command.Parameters.AddWithValue("@session", TransactionAndBilling.SessionSchedule);
                    command.Parameters.AddWithValue("@tutor", TransactionAndBilling.Tutor);
                    command.Parameters.AddWithValue("@subject", TransactionAndBilling.Subject);
                    command.Parameters.AddWithValue("@student", TransactionAndBilling.Student);
                    command.Parameters.AddWithValue("@totalFee", TransactionAndBilling.TotalFee);

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    receipt.LocalReport.DataSources.Clear();

                    ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);
                    ReportParameter StudName = new ReportParameter("StudentName", TransactionAndBilling.Student);

                    receipt.LocalReport.ReportPath = "ReceiptReport.rdlc";
                    receipt.LocalReport.DataSources.Add(reportDataSource);
                    receipt.LocalReport.SetParameters(StudName);

                    receipt.RefreshReport();
                    receipt.Refresh();
                }
            }
        }
    }
}
