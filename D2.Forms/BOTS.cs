using _3_13_25.D2.Classes;
using _3_13_25.D2.IdFetcherClasses;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
using System.Linq;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace BienvenidoOnlineTutorServices.D2.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dateTimeValueSetter();
            refresh();
        }

        #region Initialization and Refresh
        private void refresh()
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView dataGridView)
                {
                    dataGridView.DataSource = null;
                }
            }

            ComboBoxEnrollmentSubject.DataSource = SubjectClass.FetchSubjects();
            OpsAndCalcs.StudentList(DataGridViewStudentList, TextBoxEnrollmentStudName.Text);
            comboBoxExpertise.DataSource = SubjectClass.FetchSubjects();
            SubjectClass.FetchSubjects();
            TutorClass.ShowTutor(dataGridViewTutorManagement);
            SubjectClass.ShowSubjects(dataGridViewSubjects);
            BillingClass.ShowBilling(dataGridViewPendingBilling);
            BillingClass.ShowPaidBilling(dataGridViewPayedBilling);

            if (TemporalData.SubjectList.Count > 0) { ButtonEnrollStudent.Enabled = true; } else { ButtonEnrollStudent.Enabled = false; }
        }

        private void dateTimeValueSetter()
        {
            DateTime today = DateTime.Now.Date;
            int minimumHour = 8;
            int maximumHour = 17;
            DateTime minDateTime = new DateTime(today.Year, today.Month, today.Day, minimumHour, 0, 0);
            DateTime maxDateTime = new DateTime(today.Year, today.Month, today.Day, maximumHour, 0, 0);

            DatePickerSessionSchedule.MinDate = DateTime.Today;
            TimePickerSessionSchedule.MinDate = new DateTime(today.Year, today.Month, today.Day, minimumHour, 0, 0);
            TimePickerSessionSchedule.MaxDate = new DateTime(today.Year, today.Month, today.Day, maximumHour, 0, 0);

            DatePickerSessionSchedule.ValueChanged += (s, e) =>
            {
                if (DatePickerSessionSchedule.Value > DateTime.Now) { TimePickerSessionSchedule.MinDate = new DateTime(today.Year, today.Month, today.Day, minimumHour, 0, 0); }
                else { TimePickerSessionSchedule.MinDate = DateTime.Now; }
            };

            dateTimePickerBeginTime.Value = minDateTime;
            dateTimePickerEndTime.Value = maxDateTime;

            dateTimePickerBeginTime.ValueChanged += (s, e) =>
            {
                DateTime selectedTime = dateTimePickerBeginTime.Value;

                if (selectedTime < minDateTime)
                {
                    dateTimePickerBeginTime.Value = minDateTime;
                    return;
                }

                if (selectedTime >= maxDateTime)
                {
                    dateTimePickerBeginTime.Value = maxDateTime.AddHours(-1);
                }

                DateTime newEndTime = selectedTime.AddHours(1);
                dateTimePickerEndTime.Value = newEndTime <= maxDateTime ? newEndTime : maxDateTime;
            };

            dateTimePickerEndTime.ValueChanged += (s, e) =>
            {
                DateTime beginTime = dateTimePickerBeginTime.Value;
                DateTime endTime = dateTimePickerEndTime.Value;

                if (endTime <= beginTime)
                {
                    dateTimePickerEndTime.Value = beginTime.AddHours(1);
                }

                if (dateTimePickerEndTime.Value > maxDateTime)
                {
                    dateTimePickerEndTime.Value = maxDateTime;
                }
            };
        }
        #endregion

        #region Event Handlers

        #region Universal Event Handlers
        private void TextBoxNumerical_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            HandleInputDisplay(e);
        }

        private void HandleInputDisplay(KeyPressEventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && textBox.Focused)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = "0";
                    }

                    if (e.KeyChar == '\b')
                    {
                        textBox.Text = "0";
                        e.Handled = true;
                        return;
                    }

                    if (textBox.Text == "0")
                    {
                        if (e.KeyChar != '0')
                        {
                            textBox.Text = e.KeyChar.ToString();
                        }
                        e.Handled = true;
                    }
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }
        #endregion

        #region Enrollment Event Handlers
        private void buttonEnrollStudent_Click(object sender, EventArgs e) //purpose of this is to pass the data to the class that will handle the enrollment
        {
            if (TemporalData.SubjectList.Count > 0)
            {
                foreach (var transaction in TemporalData.SubjectList)
                {
                    Enrollment.StudentName = transaction.StudentName;
                    EnrollmentClass.EnrollStudent();
                    Enrollment.StudentId = IdFetcher.StudentId();
                    Enrollment.TutorName = transaction.TutorName;
                    Enrollment.TutorId = transaction.TutorId;
                    Enrollment.Subject = transaction.Subject;
                    Enrollment.SubjectId = transaction.SubjectId;
                    Enrollment.SessionScheduleDate = transaction.SessionScheduleDate;
                    Enrollment.SessionScheduleTime = transaction.SessionScheduleTime;
                    Enrollment.SessionDuration = transaction.SessionDuration;
                    Enrollment.SessionEndSchedule = transaction.SessionEndSchedule;
                    Enrollment.HourlyRate = transaction.HourlyRate;
                    Enrollment.TotalFee = transaction.TotalFee;
                    Enrollment.RemainingFee = transaction.RemainingFee;
                    Enrollment.PaymentFee = transaction.PaymentFee;
                    Enrollment.PaymentStatus = transaction.PaymentStatus;

                    MessageBox.Show($"Subject {TemporalData.Subject} has been registered successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BillingClass.TransactionRegistration();
                }
                MessageBox.Show("Student enrolled successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Empty registry, aborting operation.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRegisterPrefSub_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageEnroll.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text) && textBox != textBoxOverallTotalFee)
                {
                    MessageBox.Show("Field cannot be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (OpsAndCalcs.IfScheduleExist(TimePickerSessionSchedule.Value))
            {
                MessageBox.Show("Date and Time is occupied, pick another schedule date.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TemporalData.StudentName = TextBoxEnrollmentStudName.Text;
            TemporalData.StudentEmail = TextBoxStudEmail.Text;
            TemporalData.Subject = ComboBoxEnrollmentSubject.Text;
            TemporalData.SessionScheduleDate = DatePickerSessionSchedule.Value.Date;
            TemporalData.SessionScheduleTime = TimePickerSessionSchedule.Value.TimeOfDay;
            TemporalData.SessionDuration = int.Parse(textBoxSessionDuration.Text);

            EnrollmentClass.TemporalDataSelectedValue(dataGridViewTutorInSubject);

            var transactions = new PreferredSubject
            {
                StudentName = TemporalData.StudentName,
                Subject = TemporalData.Subject,
                SubjectId = IdFetcher.SubjectId(),
                TutorName = TemporalData.TutorName,
                TutorId = IdFetcher.TutorId(),
                SessionScheduleDate = TemporalData.SessionScheduleDate,
                SessionScheduleTime = TemporalData.SessionScheduleTime,
                SessionDuration = TemporalData.SessionDuration,
                SessionEndSchedule = OpsAndCalcs.SessessionEndSchedule(DatePickerSessionSchedule.Value.Date, TimePickerSessionSchedule.Value.TimeOfDay, int.Parse(textBoxSessionDuration.Text)),
                HourlyRate = TemporalData.HourlyRate,
                TotalFee = OpsAndCalcs.CalculateTotalFee(int.Parse(textBoxSessionDuration.Text), TemporalData.HourlyRate),
                PaymentFee = 0,
                RemainingFee = OpsAndCalcs.CalculateRemainingFee(TemporalData.HourlyRate, TemporalData.SessionDuration),
                PaymentStatus = OpsAndCalcs.PaymentStatus(TransactionAndBilling.RemainingBalance, TransactionAndBilling.PaidFee)
            };

            if (!TemporalData.SubjectList.Contains(transactions))
            {
                bool exist = TemporalData.SubjectList.Any(b => b.SessionScheduleDate >= TimePickerSessionSchedule.Value.Date);

                if (exist)
                {
                    MessageBox.Show("This Schedule date is already occupied", "Schedule Occupied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                TemporalData.SubjectList.Add(transactions);

                dataGridViewPreferredSubjects.DataSource = null;
                dataGridViewPreferredSubjects.DataSource = TemporalData.SubjectList.Select(s => new { s.StudentName, s.Subject, s.TutorName, s.SessionDuration, s.SessionEndSchedule, s.TotalFee }).ToList();

                textBoxOverallTotalFee.Text = TemporalData.SubjectList.Sum(transactions => transactions.TotalFee).ToString();
            }
            refresh();
        }

        private void comboBoxPreferredSubjects_SelectedValueChanged(object sender, EventArgs e)
        {
            TemporalData.Subject = ComboBoxEnrollmentSubject.Text;
            EnrollmentClass.ShowTutor(dataGridViewTutorInSubject);
        }

        private void buttonRemoveSub_Click(object sender, EventArgs e)
        {
            if (TemporalData.SubjectList.Count > 0)
            {
                foreach (Control control in tabPageEnroll.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }
                dataGridViewPreferredSubjects.DataSource = null;
                TemporalData.SubjectList.Clear();
            }
            refresh();
        }
        #endregion

        #region Subject Management Event Handlers
        private void buttonAddISubject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSubjectLib.Text))
            {
                TemporalData.Subject = textBoxSubjectLib.Text;
                SubjectClass.AddSub();
                refresh();
            }
            else
            {
                MessageBox.Show("Textbox Value is invalid. Action aborted.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDeleteToolInventory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSubjectLib.Text))
            {
                TemporalData.Subject = textBoxSubjectLib.Text;
                SubjectClass.DeleteSub();
                refresh();
            }
            else
            {
                MessageBox.Show("Textbox Value is invalid. Action aborted.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Tutor Management Event Handlers
        private void buttonRegisterTutor_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageTutorRegistration.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Field cannot be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            TemporalData.TutorName = textBoxTutorName.Text;
            TemporalData.TutorEmail = textBoxTutorEmail.Text;
            TemporalData.Subject = comboBoxExpertise.Text;
            TemporalData.HourlyRate = int.Parse(textBoxTutorHourlyRate.Text);
            TemporalData.InTime = dateTimePickerBeginTime.Value.TimeOfDay;
            TemporalData.OutTime = dateTimePickerEndTime.Value.TimeOfDay;

            if (TutorClass.CheckTutor())
            {
                MessageBox.Show("Tutor already exists", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TutorClass.ManageTutor();
            refresh();
        }

        private void textBoxTutorinServiceLib_TextChanged(object sender, EventArgs e)
        {
            SubjectObjects.SubjectName = textBoxSubjectLib.Text;
            SubjectClass.ShowTutorOfTheSubject(dataGridViewTutorInSubject);
        }

        private void buttonTutorDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to proceed? \nAction cannot be undone", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                TutorClass.DeleteTutor();
            }
        }
        #endregion

        #region Billing Management Event Handlers
        private void buttonPaid_Click(object sender, EventArgs e)
        {
            BillingClass.SelectedValue(dataGridViewPendingBilling);
            TransactionAndBilling.Pay = decimal.Parse(textBoxPayment.Text);
            BillingClass.Payment();
            refresh();

            ReceiptReportClass.ReceiptSetup(reportViewerReceipt);
        }
        #endregion

        #endregion

        private void mainForm_Load(object sender, EventArgs e)
        {
            reportViewerReceipt.RefreshReport();
        }

        private void TextBoxEnrollmentStudName_TextChanged(object sender, EventArgs e)
        {
            OpsAndCalcs.StudentList(DataGridViewStudentList, TextBoxEnrollmentStudName.Text);
        }

        private void DataGridViewStudentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EnrollmentClass.SelectRowDTVStudentList(DataGridViewStudentList);
            TextBoxEnrollmentStudName.Text = DataGridViewStudentList.Rows[e.RowIndex].Cells["StudentName"].Value.ToString();
            TextBoxStudEmail.Text = DataGridViewStudentList.Rows[e.RowIndex].Cells["StudentEmail"].Value.ToString();
        }
    }
}