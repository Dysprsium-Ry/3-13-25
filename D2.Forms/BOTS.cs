using _3_13_25.D2.Classes;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
using System.Linq;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace BienvenidoOnlineTutorServices.D2.Forms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            dateTimeValueSetter();
            refresh();
        }

        private void refresh()
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView dataGridView)
                {
                    dataGridView.DataSource = null;
                }

                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }

            #region StudentRelated
            SubjectClass.FetchSubjects();
            SubjectsReload();
            #endregion

            #region TutorRelated
            TutorClass.ShowTutor(dataGridViewTutorManagement);
            #endregion

            #region SubjectRelated

            SubjectClass.ShowSubjects(dataGridViewSubjects);
            //TutorClass.DispaySubjectTutor(dataGridViewTutorInSubject);
            #endregion

            #region BillingRelated
            BillingClass.ShowBilling(dataGridViewPendingBilling);
            BillingClass.ShowPaidilling(dataGridViewPayedBilling);
            #endregion
        }

        #region Methods

        #region enrollment
        private void SubjectsReload()
        {
            comboBoxPreferredSubjects.DataSource = SubjectObjects.Subject;
            comboBoxExpertise.DataSource = SubjectObjects.Subject;
        }
        private void dateTimeValueSetter()
        {
            // Get today's date (ignored in this case)
            DateTime today = DateTime.Now.Date;

            // Define the minimum and maximum hours
            int minimumHour = 8;
            int maximumHour = 17;

            // Define the minimum and maximum times as TimeSpan
            TimeSpan minTime = new TimeSpan(minimumHour, 0, 0); // 08:00:00
            TimeSpan maxTime = new TimeSpan(maximumHour, 0, 0); // 17:00:00

            // Set the minimum and maximum times for the DateTimePicker controls
            dateTimePickerBeginTime.Format = DateTimePickerFormat.Time; // Show only time
            dateTimePickerBeginTime.ShowUpDown = true; // Use up/down arrows for time selection
            dateTimePickerBeginTime.MinDate = today + minTime; // Set minimum time
            dateTimePickerBeginTime.MaxDate = today + maxTime; // Set maximum time

            dateTimePickerEndTime.Format = DateTimePickerFormat.Time; // Show only time
            dateTimePickerEndTime.ShowUpDown = true; // Use up/down arrows for time selection
            dateTimePickerEndTime.MinDate = today + minTime; // Set minimum time
            dateTimePickerEndTime.MaxDate = today + maxTime; // Set maximum time

            // Handle the BeginTime value change
            dateTimePickerBeginTime.ValueChanged += (sender, e) =>
            {
                // Get the selected time from BeginTime
                TimeSpan beginTime = dateTimePickerBeginTime.Value.TimeOfDay;

                // Set the minimum time for EndTime
                if (beginTime < maxTime.Add(TimeSpan.FromHours(-1))) // If BeginTime is before 16:00
                {
                    dateTimePickerEndTime.MinDate = today + beginTime.Add(TimeSpan.FromHours(1)); // EndTime must be at least 1 hour after BeginTime
                }
                else
                {
                    dateTimePickerEndTime.MinDate = today + maxTime; // EndTime cannot be earlier than 17:00
                }
            };
        }
        #endregion

        #endregion

        #region EventHandlers

        #region UniversalEventHandlers
        private void textBoxNumericalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
            HandleInputDisplay(e);
        }
        private void HandleInputDisplay(KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTutorHourlyRate.Text))
            {
                textBoxTutorHourlyRate.Text = "0";
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                textBoxTutorHourlyRate.Text = "0";
                e.Handled = true;
                return;
            }

            if (textBoxTutorHourlyRate.Text == "0")
            {
                if (e.KeyChar != '0')
                {
                    textBoxTutorHourlyRate.Text = e.KeyChar.ToString();
                }
                e.Handled = true;
            }
            textBoxTutorHourlyRate.SelectionStart = textBoxTutorHourlyRate.Text.Length;
        }
        #endregion

        #region enrollment
        private void buttonEnrollStudent_Click(object sender, EventArgs e)
        {
            StudentObjects.StudName = TextBox_StudentName.Text;
            StudentObjects.StudEmail = TextBox_StudentEmail.Text;

            if (TemporalData.SubjectList.Count > 0)
            {
                foreach (var transaction in TemporalData.SubjectList)
                {
                    TemporalData.Subject = transaction.Subject;
                    TemporalData.SessionDuration = transaction.SessionDuration;
                    TemporalData.HourlyRate = transaction.HourlyRate;
                    TemporalData.TotalFee = transaction.TotalFee;
                    TemporalData.Tutor = transaction.Tutor;

                    StudentClass.EnrollStudent(); MessageBox.Show($"Subject {TemporalData.Subject} has been registered Succesfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TutorClass.FetchId();
                    StudentClass.FetchId();
                    SubjectClass.FetchId();
                    BillingClass.TransactionRegistration();
                }
                MessageBox.Show("Student enrolled successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information); refresh();
            }
            else { MessageBox.Show("Empty registry aborting operation.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void buttonRegisterPrefSub_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageEnroll.Controls)
            {
                if (control is TextBox textbox && string.IsNullOrWhiteSpace(textbox.Text))
                {
                    MessageBox.Show("Field cannot be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }

            StudentObjects.PreferredSubjects = comboBoxPreferredSubjects.Text;
            StudentObjects.SessionDuration = int.Parse(textBoxSessionDuration.Text);
            StudentClass.SelectedValue(dataGridViewTutorInSubject);

            var transactions = new PreferredSubject
            {
                Subject = StudentObjects.PreferredSubjects,
                Tutor = StudentObjects.Tutor,
                SessionDuration = StudentObjects.SessionDuration,
                HourlyRate = StudentObjects.HourlyRate,
                TotalFee = StudentObjects.SessionDuration * StudentObjects.HourlyRate
            };

            if (!TemporalData.SubjectList.Contains(transactions))
            {
                TemporalData.SubjectList.Add(transactions);

                dataGridViewPreferredSubjects.DataSource = null;
                dataGridViewPreferredSubjects.DataSource = TemporalData.SubjectList;

                var overallTotal = TemporalData.SubjectList.Sum(transactions => transactions.TotalFee);
                textBoxOverallTotalFee.Text = overallTotal.ToString();
            }
            refresh();
        }
        private void comboBoxPreferredSubjects_SelectedValueChanged(object sender, EventArgs e)
        {
            StudentObjects.PreferredSubjects = comboBoxPreferredSubjects.Text;
            StudentClass.ShowTutor(dataGridViewTutorInSubject);
        }
        #endregion

        #region SubjectManagement
        private void buttonAddToolInventory_Click(object sender, EventArgs e)
        {
            subjectLib.subject = textBoxSubjectLib.Text;
            SubjectClass.AddSub();
            refresh();
        }
        private void buttonDeleteToolInventory_Click(object sender, EventArgs e)
        {
            subjectLib.subject = textBoxSubjectLib.Text;
            SubjectClass.DeleteSub();
            refresh();
        }
        #endregion

        #region TutorManagement
        private void buttonRegisterTutor_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageTutorRegistration.Controls)
            {
                if (control is TextBox textbox && string.IsNullOrWhiteSpace(textbox.Text))
                {
                    MessageBox.Show("Field cannot be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }

            TutorObjects.TutorName = textBoxTutorName.Text;
            TutorObjects.TutorEmail = textBoxTutorEmail.Text;
            TutorObjects.Expertise = comboBoxExpertise.Text;
            TutorObjects.HourlyRate = int.Parse(textBoxTutorHourlyRate.Text);
            TutorObjects.InTime = dateTimePickerBeginTime.Value;
            TutorObjects.OutTime = dateTimePickerEndTime.Value;

            if (TutorClass.CheckTutor()) { MessageBox.Show("Tutor already Exist", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

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
            if (MessageBox.Show("Do you wish to proceed? \nAction cannot be undone", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) { TutorClass.DeleteTutor(); }
        }
        private void dateTimePickerEndTime_Leave(object sender, EventArgs e)
        {
            dateTimeValueSetter();
        }
        #endregion

        #region BillingManagement
        private void buttonPaid_Click(object sender, EventArgs e)
        {
            BillingClass.SelectedValue(dataGridViewPendingBilling);
            BillingObject.pay = int.Parse(textBoxPayment.Text);
            BillingClass.Payment();
            refresh();
        }
        #endregion

        #endregion
    }
}
