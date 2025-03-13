using _3_13_25.D2.Classes;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
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
        }

        private void buttonEnrollStudent_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageEnroll.Controls)
            {
                if (control is TextBox textbox && !string.IsNullOrWhiteSpace(textbox.Text))
                {
                    StudentObjects.StudName = TextBox_StudentName.Text;
                    StudentObjects.StudEmail = TextBox_StudentEmail.Text;


                    StudentClass.EnrollStudent();
                    MessageBox.Show("Student Enrolled Successfully", "Enrollment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Fields cannot be empty", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
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
            if (RegisteredSubject.SubjectList.Count > 0)
            {
                foreach (var transaction in RegisteredSubject.SubjectList)
                {
                    RegisteredSubject.Subject = transaction.Subject;
                    RegisteredSubject.SessionDuration = transaction.SessionDuration;
                    RegisteredSubject.HourlyRate = transaction.HourlyRate;
                    RegisteredSubject.TotalFee = transaction.TotalFee;
                    RegisteredSubject.Tutor = transaction.Tutor;

                    StudentClass.EnrollStudent(); MessageBox.Show($"Subject {RegisteredSubject.Subject} has been registered Succesfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Student enrolled successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            refresh();
        }

        private void comboBoxPreferredSubjects_SelectedValueChanged(object sender, EventArgs e)
        {
            StudentObjects.PreferredSubjects = comboBoxPreferredSubjects.Text;
            StudentClass.ShowTutor(dataGridViewTutorInSubject);
        }
    }
}
