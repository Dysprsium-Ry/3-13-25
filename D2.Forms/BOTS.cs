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
            refresh();
        }
        private void refresh()
        {
            #region StudentRelated
            SubjectsReload();

            #endregion

            #region TutorRelated
            TutorClass.ShowTutor(dataGridViewTutorManagement);
            #endregion

            #region SubjectRelated
            SubjectClass.ShowSubjects(dataGridViewSubjects);
            #endregion

            #region BillingRelated
            BillingClass.ShowBilling(dataGridViewPendingBilling);
            BillingClass.ShowPaidilling(dataGridViewPayedBilling);
            #endregion
        }
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
        private void SubjectsReload()
        {
            comboBoxPreferredSubjects.Items.Clear();
            SubjectClass.FetchSubjects();
            comboBoxPreferredSubjects.Items.AddRange(SubjectObjects.Subject);
            comboBoxExpertise.DataSource = SubjectObjects.Subject;
        }
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
        private void buttonRegisterTutor_Click(object sender, EventArgs e)
        {
            TutorObjects.TutorName = textBoxTutorName.Text;
            TutorObjects.TutorEmail = textBoxTutorEmail.Text;
            TutorObjects.Expertise = comboBoxExpertise.Text;
            TutorObjects.HourlyRate = int.Parse(textBoxTutorHourlyRate.Text);

            TutorClass.ManageTutor();
            refresh();
        }
        private void buttonRegisterPrefSub_Click(object sender, EventArgs e)
        {
            StudentObjects.PreferredSubjects = comboBoxPreferredSubjects.Text;
            StudentObjects.SessionDuration = int.Parse(textBoxSessionDuration.Text);

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
        private void dataGridViewTutorInSubject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StudentClass.SelectedValue(dataGridViewTutorInSubject);
        }

        private void textBoxTutorinServiceLib_TextChanged(object sender, EventArgs e)
        {
            SubjectObjects.SubjectName = textBoxSubjectInSubjectLib.Text;
            SubjectClass.ShowTutorOfTheSubject(dataGridViewTutorInSubject);
        }

        private void buttonPaid_Click(object sender, EventArgs e)
        {
            BillingObject.pay = int.Parse(textBoxPayment.Text);
            BillingClass.Payment();
            refresh();
        }

        private void dataGridViewPendingBilling_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BillingClass.SelectedValue(dataGridViewPendingBilling);
        }
    }
}
