using BOTS.Database_Connection;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.Classes
{
    public class ReceiptReportClass
    {
        public static void ReceiptSetup(ReportViewer receipt)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.PresentPaidBilling WHERE TransactionId = @transactionId", connection))
                {
                    command.Parameters.AddWithValue("@transactionId", BillingObj.EnrollmentId);

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    receipt.LocalReport.DataSources.Clear();

                    ReportDataSource reportDataSource = new ReportDataSource("PresentPaidPayment", dataTable);
                    ReportParameter StudName = new ReportParameter("StudentName", BillingObj.Student);

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
