using _3_13_25.D2.Classes;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.Objects;

namespace BienvenidoOnlineTutorServices.D2.Forms
{
    public partial class mainForm: Form
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
            #endregion
        }

        private void buttonEnrollStudent_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageEnroll.Controls)
            {
                if (control is TextBox textbox && !string.IsNullOrWhiteSpace(textbox.Text) || checkedListBoxSubjects.CheckedItems != null)
                {
                    StudentObjects.StudName = TextBox_StudentName.Text;
                    StudentObjects.StudEmail = TextBox_StudentEmail.Text;
                    SubjectObjects.Subject = checkedListBoxSubjects.CheckedItems.OfType<string>().ToArray();

                    StudentClass.EnrollStudent();
                    MessageBox.Show("Student Enrolled Successfully", "Enrollment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SubjectsReload()
        {
            checkedListBoxSubjects.Items.Clear();
            SubjectClass.FetchSubjects();
            checkedListBoxSubjects.Items.AddRange(SubjectObjects.Subject);
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
    }
}
