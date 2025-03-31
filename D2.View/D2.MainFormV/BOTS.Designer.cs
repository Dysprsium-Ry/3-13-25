namespace BienvenidoOnlineTutorServices.D2.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageEnroll = new System.Windows.Forms.TabPage();
            this.labelStudentList = new System.Windows.Forms.Label();
            this.DataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.PanelSubjectEnrollment = new System.Windows.Forms.Panel();
            this.ComboBoxEnrollmentSubject = new System.Windows.Forms.ComboBox();
            this.labelSubjects = new System.Windows.Forms.Label();
            this.labelOverallTotalFee = new System.Windows.Forms.Label();
            this.DatePickerSessionSchedule = new System.Windows.Forms.DateTimePicker();
            this.textBoxOverallTotalFee = new System.Windows.Forms.TextBox();
            this.textBoxSessionDuration = new System.Windows.Forms.TextBox();
            this.TimePickerSessionSchedule = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelStudentInfo = new System.Windows.Forms.Panel();
            this.TextBoxEnrollmentStudName = new System.Windows.Forms.TextBox();
            this.TextBoxStudEmail = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelStudentEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lablePreferredSubjects = new System.Windows.Forms.Label();
            this.dataGridViewTutorInTheSubject = new System.Windows.Forms.DataGridView();
            this.buttonRegisterPrefSub = new System.Windows.Forms.Button();
            this.buttonRemoveSub = new System.Windows.Forms.Button();
            this.ButtonEnrollStudent = new System.Windows.Forms.Button();
            this.dataGridViewPreferredSubjects = new System.Windows.Forms.DataGridView();
            this.tabPageTutorRegistration = new System.Windows.Forms.TabPage();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBeginTime = new System.Windows.Forms.DateTimePicker();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelBeginTime = new System.Windows.Forms.Label();
            this.textBoxTutorEmail = new System.Windows.Forms.TextBox();
            this.labelTutorEmail = new System.Windows.Forms.Label();
            this.comboBoxExpertise = new System.Windows.Forms.ComboBox();
            this.labelExpertise = new System.Windows.Forms.Label();
            this.textBoxTutorName = new System.Windows.Forms.TextBox();
            this.textBoxTutorHourlyRate = new System.Windows.Forms.TextBox();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTutorDelete = new System.Windows.Forms.Button();
            this.buttonRegisterTutor = new System.Windows.Forms.Button();
            this.dataGridViewTutorManagement = new System.Windows.Forms.DataGridView();
            this.tabPageSubjectLibrary = new System.Windows.Forms.TabPage();
            this.dataGridViewTutorPerSubject = new System.Windows.Forms.DataGridView();
            this.textBoxSubjectLib = new System.Windows.Forms.TextBox();
            this.buttonDeleteToolInventory = new System.Windows.Forms.Button();
            this.buttonAddToolInventory = new System.Windows.Forms.Button();
            this.labelInventoryService = new System.Windows.Forms.Label();
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.tabPageBilling = new System.Windows.Forms.TabPage();
            this.SearchBoxBilling = new System.Windows.Forms.TextBox();
            this.labelPartialPayment = new System.Windows.Forms.Label();
            this.DataGridViewPartialPayment = new System.Windows.Forms.DataGridView();
            this.labelPayment = new System.Windows.Forms.Label();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.labelPayedPayments = new System.Windows.Forms.Label();
            this.labelPendingPayments = new System.Windows.Forms.Label();
            this.DataGridViewPaidPayment = new System.Windows.Forms.DataGridView();
            this.buttonPaid = new System.Windows.Forms.Button();
            this.DataGridViewPendingPayment = new System.Windows.Forms.DataGridView();
            this.tabPageReceiptReport = new System.Windows.Forms.TabPage();
            this.reportViewerReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControlMain.SuspendLayout();
            this.tabPageEnroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentList)).BeginInit();
            this.PanelSubjectEnrollment.SuspendLayout();
            this.PanelStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorInTheSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreferredSubjects)).BeginInit();
            this.tabPageTutorRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorManagement)).BeginInit();
            this.tabPageSubjectLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorPerSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            this.tabPageBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPartialPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPaidPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPendingPayment)).BeginInit();
            this.tabPageReceiptReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEnroll);
            this.tabControlMain.Controls.Add(this.tabPageTutorRegistration);
            this.tabControlMain.Controls.Add(this.tabPageSubjectLibrary);
            this.tabControlMain.Controls.Add(this.tabPageBilling);
            this.tabControlMain.Controls.Add(this.tabPageReceiptReport);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1110, 568);
            this.tabControlMain.TabIndex = 2;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageEnroll
            // 
            this.tabPageEnroll.Controls.Add(this.labelStudentList);
            this.tabPageEnroll.Controls.Add(this.DataGridViewStudentList);
            this.tabPageEnroll.Controls.Add(this.PanelSubjectEnrollment);
            this.tabPageEnroll.Controls.Add(this.PanelStudentInfo);
            this.tabPageEnroll.Controls.Add(this.label1);
            this.tabPageEnroll.Controls.Add(this.lablePreferredSubjects);
            this.tabPageEnroll.Controls.Add(this.dataGridViewTutorInTheSubject);
            this.tabPageEnroll.Controls.Add(this.buttonRegisterPrefSub);
            this.tabPageEnroll.Controls.Add(this.buttonRemoveSub);
            this.tabPageEnroll.Controls.Add(this.ButtonEnrollStudent);
            this.tabPageEnroll.Controls.Add(this.dataGridViewPreferredSubjects);
            this.tabPageEnroll.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnroll.Name = "tabPageEnroll";
            this.tabPageEnroll.Size = new System.Drawing.Size(1102, 539);
            this.tabPageEnroll.TabIndex = 2;
            this.tabPageEnroll.Text = "Student Enrollment";
            this.tabPageEnroll.UseVisualStyleBackColor = true;
            // 
            // labelStudentList
            // 
            this.labelStudentList.AutoSize = true;
            this.labelStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentList.Location = new System.Drawing.Point(14, 196);
            this.labelStudentList.Name = "labelStudentList";
            this.labelStudentList.Size = new System.Drawing.Size(106, 24);
            this.labelStudentList.TabIndex = 42;
            this.labelStudentList.Text = "Student List";
            // 
            // DataGridViewStudentList
            // 
            this.DataGridViewStudentList.AllowUserToAddRows = false;
            this.DataGridViewStudentList.AllowUserToDeleteRows = false;
            this.DataGridViewStudentList.AllowUserToResizeColumns = false;
            this.DataGridViewStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudentList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewStudentList.Location = new System.Drawing.Point(18, 223);
            this.DataGridViewStudentList.Name = "DataGridViewStudentList";
            this.DataGridViewStudentList.ReadOnly = true;
            this.DataGridViewStudentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStudentList.ShowEditingIcon = false;
            this.DataGridViewStudentList.Size = new System.Drawing.Size(476, 115);
            this.DataGridViewStudentList.TabIndex = 41;
            this.DataGridViewStudentList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewStudentList_RowHeaderMouseClick);
            // 
            // PanelSubjectEnrollment
            // 
            this.PanelSubjectEnrollment.Controls.Add(this.ComboBoxEnrollmentSubject);
            this.PanelSubjectEnrollment.Controls.Add(this.labelSubjects);
            this.PanelSubjectEnrollment.Controls.Add(this.labelOverallTotalFee);
            this.PanelSubjectEnrollment.Controls.Add(this.DatePickerSessionSchedule);
            this.PanelSubjectEnrollment.Controls.Add(this.textBoxOverallTotalFee);
            this.PanelSubjectEnrollment.Controls.Add(this.textBoxSessionDuration);
            this.PanelSubjectEnrollment.Controls.Add(this.TimePickerSessionSchedule);
            this.PanelSubjectEnrollment.Controls.Add(this.label3);
            this.PanelSubjectEnrollment.Controls.Add(this.label2);
            this.PanelSubjectEnrollment.Location = new System.Drawing.Point(311, 18);
            this.PanelSubjectEnrollment.Name = "PanelSubjectEnrollment";
            this.PanelSubjectEnrollment.Size = new System.Drawing.Size(592, 160);
            this.PanelSubjectEnrollment.TabIndex = 40;
            // 
            // ComboBoxEnrollmentSubject
            // 
            this.ComboBoxEnrollmentSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEnrollmentSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxEnrollmentSubject.FormattingEnabled = true;
            this.ComboBoxEnrollmentSubject.Location = new System.Drawing.Point(12, 36);
            this.ComboBoxEnrollmentSubject.Name = "ComboBoxEnrollmentSubject";
            this.ComboBoxEnrollmentSubject.Size = new System.Drawing.Size(234, 33);
            this.ComboBoxEnrollmentSubject.TabIndex = 30;
            this.ComboBoxEnrollmentSubject.SelectedValueChanged += new System.EventHandler(this.comboBoxPreferredSubjects_SelectedValueChanged);
            // 
            // labelSubjects
            // 
            this.labelSubjects.AutoSize = true;
            this.labelSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjects.Location = new System.Drawing.Point(7, 8);
            this.labelSubjects.Name = "labelSubjects";
            this.labelSubjects.Size = new System.Drawing.Size(95, 25);
            this.labelSubjects.TabIndex = 31;
            this.labelSubjects.Text = "Subjects";
            // 
            // labelOverallTotalFee
            // 
            this.labelOverallTotalFee.AutoSize = true;
            this.labelOverallTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverallTotalFee.Location = new System.Drawing.Point(287, 78);
            this.labelOverallTotalFee.Name = "labelOverallTotalFee";
            this.labelOverallTotalFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelOverallTotalFee.Size = new System.Drawing.Size(165, 25);
            this.labelOverallTotalFee.TabIndex = 35;
            this.labelOverallTotalFee.Text = "OverallTotalFee";
            this.labelOverallTotalFee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DatePickerSessionSchedule
            // 
            this.DatePickerSessionSchedule.CustomFormat = "MMM dd yyyy     hh:mm tt";
            this.DatePickerSessionSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerSessionSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerSessionSchedule.Location = new System.Drawing.Point(287, 40);
            this.DatePickerSessionSchedule.Name = "DatePickerSessionSchedule";
            this.DatePickerSessionSchedule.Size = new System.Drawing.Size(145, 29);
            this.DatePickerSessionSchedule.TabIndex = 38;
            // 
            // textBoxOverallTotalFee
            // 
            this.textBoxOverallTotalFee.Enabled = false;
            this.textBoxOverallTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOverallTotalFee.Location = new System.Drawing.Point(287, 106);
            this.textBoxOverallTotalFee.Name = "textBoxOverallTotalFee";
            this.textBoxOverallTotalFee.Size = new System.Drawing.Size(197, 31);
            this.textBoxOverallTotalFee.TabIndex = 34;
            // 
            // textBoxSessionDuration
            // 
            this.textBoxSessionDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSessionDuration.Location = new System.Drawing.Point(12, 106);
            this.textBoxSessionDuration.Name = "textBoxSessionDuration";
            this.textBoxSessionDuration.Size = new System.Drawing.Size(234, 31);
            this.textBoxSessionDuration.TabIndex = 32;
            this.textBoxSessionDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumerical_KeyPress);
            // 
            // TimePickerSessionSchedule
            // 
            this.TimePickerSessionSchedule.CustomFormat = "MMM dd yyyy";
            this.TimePickerSessionSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePickerSessionSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerSessionSchedule.Location = new System.Drawing.Point(438, 40);
            this.TimePickerSessionSchedule.Name = "TimePickerSessionSchedule";
            this.TimePickerSessionSchedule.ShowUpDown = true;
            this.TimePickerSessionSchedule.Size = new System.Drawing.Size(140, 29);
            this.TimePickerSessionSchedule.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Session Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Session Duration";
            // 
            // PanelStudentInfo
            // 
            this.PanelStudentInfo.Controls.Add(this.TextBoxEnrollmentStudName);
            this.PanelStudentInfo.Controls.Add(this.TextBoxStudEmail);
            this.PanelStudentInfo.Controls.Add(this.labelStudentName);
            this.PanelStudentInfo.Controls.Add(this.labelStudentEmail);
            this.PanelStudentInfo.Location = new System.Drawing.Point(18, 18);
            this.PanelStudentInfo.Name = "PanelStudentInfo";
            this.PanelStudentInfo.Size = new System.Drawing.Size(274, 160);
            this.PanelStudentInfo.TabIndex = 39;
            // 
            // TextBoxEnrollmentStudName
            // 
            this.TextBoxEnrollmentStudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEnrollmentStudName.Location = new System.Drawing.Point(18, 38);
            this.TextBoxEnrollmentStudName.Name = "TextBoxEnrollmentStudName";
            this.TextBoxEnrollmentStudName.Size = new System.Drawing.Size(234, 31);
            this.TextBoxEnrollmentStudName.TabIndex = 1;
            this.TextBoxEnrollmentStudName.TextChanged += new System.EventHandler(this.TextBoxEnrollmentStudName_TextChanged);
            // 
            // TextBoxStudEmail
            // 
            this.TextBoxStudEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStudEmail.Location = new System.Drawing.Point(18, 106);
            this.TextBoxStudEmail.Name = "TextBoxStudEmail";
            this.TextBoxStudEmail.Size = new System.Drawing.Size(234, 31);
            this.TextBoxStudEmail.TabIndex = 2;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentName.Location = new System.Drawing.Point(13, 10);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(148, 25);
            this.labelStudentName.TabIndex = 5;
            this.labelStudentName.Text = "Student Name";
            // 
            // labelStudentEmail
            // 
            this.labelStudentEmail.AutoSize = true;
            this.labelStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentEmail.Location = new System.Drawing.Point(13, 78);
            this.labelStudentEmail.Name = "labelStudentEmail";
            this.labelStudentEmail.Size = new System.Drawing.Size(73, 25);
            this.labelStudentEmail.TabIndex = 6;
            this.labelStudentEmail.Text = "E-Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tutors in the Subject";
            // 
            // lablePreferredSubjects
            // 
            this.lablePreferredSubjects.AutoSize = true;
            this.lablePreferredSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablePreferredSubjects.Location = new System.Drawing.Point(14, 360);
            this.lablePreferredSubjects.Name = "lablePreferredSubjects";
            this.lablePreferredSubjects.Size = new System.Drawing.Size(165, 24);
            this.lablePreferredSubjects.TabIndex = 15;
            this.lablePreferredSubjects.Text = "Preferred Subjects";
            // 
            // dataGridViewTutorInTheSubject
            // 
            this.dataGridViewTutorInTheSubject.AllowUserToAddRows = false;
            this.dataGridViewTutorInTheSubject.AllowUserToDeleteRows = false;
            this.dataGridViewTutorInTheSubject.AllowUserToResizeColumns = false;
            this.dataGridViewTutorInTheSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTutorInTheSubject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTutorInTheSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTutorInTheSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTutorInTheSubject.Location = new System.Drawing.Point(512, 223);
            this.dataGridViewTutorInTheSubject.Name = "dataGridViewTutorInTheSubject";
            this.dataGridViewTutorInTheSubject.ReadOnly = true;
            this.dataGridViewTutorInTheSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTutorInTheSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTutorInTheSubject.ShowEditingIcon = false;
            this.dataGridViewTutorInTheSubject.Size = new System.Drawing.Size(570, 115);
            this.dataGridViewTutorInTheSubject.TabIndex = 14;
            // 
            // buttonRegisterPrefSub
            // 
            this.buttonRegisterPrefSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterPrefSub.Location = new System.Drawing.Point(919, 15);
            this.buttonRegisterPrefSub.Name = "buttonRegisterPrefSub";
            this.buttonRegisterPrefSub.Size = new System.Drawing.Size(163, 34);
            this.buttonRegisterPrefSub.TabIndex = 12;
            this.buttonRegisterPrefSub.Text = "Register";
            this.buttonRegisterPrefSub.UseVisualStyleBackColor = true;
            this.buttonRegisterPrefSub.Click += new System.EventHandler(this.buttonRegisterPrefSub_Click);
            // 
            // buttonRemoveSub
            // 
            this.buttonRemoveSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSub.Location = new System.Drawing.Point(919, 62);
            this.buttonRemoveSub.Name = "buttonRemoveSub";
            this.buttonRemoveSub.Size = new System.Drawing.Size(163, 34);
            this.buttonRemoveSub.TabIndex = 11;
            this.buttonRemoveSub.Text = "Remove";
            this.buttonRemoveSub.UseVisualStyleBackColor = true;
            this.buttonRemoveSub.Click += new System.EventHandler(this.buttonRemoveSub_Click);
            // 
            // ButtonEnrollStudent
            // 
            this.ButtonEnrollStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnrollStudent.Location = new System.Drawing.Point(919, 140);
            this.ButtonEnrollStudent.Name = "ButtonEnrollStudent";
            this.ButtonEnrollStudent.Size = new System.Drawing.Size(163, 38);
            this.ButtonEnrollStudent.TabIndex = 9;
            this.ButtonEnrollStudent.Text = "Enroll";
            this.ButtonEnrollStudent.UseVisualStyleBackColor = true;
            this.ButtonEnrollStudent.Click += new System.EventHandler(this.buttonEnrollStudent_Click);
            // 
            // dataGridViewPreferredSubjects
            // 
            this.dataGridViewPreferredSubjects.AllowUserToAddRows = false;
            this.dataGridViewPreferredSubjects.AllowUserToDeleteRows = false;
            this.dataGridViewPreferredSubjects.AllowUserToResizeColumns = false;
            this.dataGridViewPreferredSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPreferredSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPreferredSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreferredSubjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPreferredSubjects.Location = new System.Drawing.Point(18, 387);
            this.dataGridViewPreferredSubjects.Name = "dataGridViewPreferredSubjects";
            this.dataGridViewPreferredSubjects.ReadOnly = true;
            this.dataGridViewPreferredSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPreferredSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPreferredSubjects.ShowEditingIcon = false;
            this.dataGridViewPreferredSubjects.Size = new System.Drawing.Size(1064, 132);
            this.dataGridViewPreferredSubjects.TabIndex = 0;
            // 
            // tabPageTutorRegistration
            // 
            this.tabPageTutorRegistration.Controls.Add(this.dateTimePickerEndTime);
            this.tabPageTutorRegistration.Controls.Add(this.dateTimePickerBeginTime);
            this.tabPageTutorRegistration.Controls.Add(this.labelEndTime);
            this.tabPageTutorRegistration.Controls.Add(this.labelBeginTime);
            this.tabPageTutorRegistration.Controls.Add(this.textBoxTutorEmail);
            this.tabPageTutorRegistration.Controls.Add(this.labelTutorEmail);
            this.tabPageTutorRegistration.Controls.Add(this.comboBoxExpertise);
            this.tabPageTutorRegistration.Controls.Add(this.labelExpertise);
            this.tabPageTutorRegistration.Controls.Add(this.textBoxTutorName);
            this.tabPageTutorRegistration.Controls.Add(this.textBoxTutorHourlyRate);
            this.tabPageTutorRegistration.Controls.Add(this.labelHourlyRate);
            this.tabPageTutorRegistration.Controls.Add(this.label5);
            this.tabPageTutorRegistration.Controls.Add(this.buttonTutorDelete);
            this.tabPageTutorRegistration.Controls.Add(this.buttonRegisterTutor);
            this.tabPageTutorRegistration.Controls.Add(this.dataGridViewTutorManagement);
            this.tabPageTutorRegistration.Location = new System.Drawing.Point(4, 25);
            this.tabPageTutorRegistration.Name = "tabPageTutorRegistration";
            this.tabPageTutorRegistration.Size = new System.Drawing.Size(1102, 539);
            this.tabPageTutorRegistration.TabIndex = 3;
            this.tabPageTutorRegistration.Text = "Tutor Management";
            this.tabPageTutorRegistration.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(222, 367);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.ShowUpDown = true;
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(177, 29);
            this.dateTimePickerEndTime.TabIndex = 36;
            // 
            // dateTimePickerBeginTime
            // 
            this.dateTimePickerBeginTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerBeginTime.Location = new System.Drawing.Point(39, 367);
            this.dateTimePickerBeginTime.Name = "dateTimePickerBeginTime";
            this.dateTimePickerBeginTime.ShowUpDown = true;
            this.dateTimePickerBeginTime.Size = new System.Drawing.Size(177, 29);
            this.dateTimePickerBeginTime.TabIndex = 35;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTime.Location = new System.Drawing.Point(218, 339);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(103, 25);
            this.labelEndTime.TabIndex = 34;
            this.labelEndTime.Text = "End Time";
            // 
            // labelBeginTime
            // 
            this.labelBeginTime.AutoSize = true;
            this.labelBeginTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeginTime.Location = new System.Drawing.Point(34, 339);
            this.labelBeginTime.Name = "labelBeginTime";
            this.labelBeginTime.Size = new System.Drawing.Size(120, 25);
            this.labelBeginTime.TabIndex = 33;
            this.labelBeginTime.Text = "Begin Time";
            // 
            // textBoxTutorEmail
            // 
            this.textBoxTutorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTutorEmail.Location = new System.Drawing.Point(39, 150);
            this.textBoxTutorEmail.Name = "textBoxTutorEmail";
            this.textBoxTutorEmail.Size = new System.Drawing.Size(361, 31);
            this.textBoxTutorEmail.TabIndex = 32;
            // 
            // labelTutorEmail
            // 
            this.labelTutorEmail.AutoSize = true;
            this.labelTutorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutorEmail.Location = new System.Drawing.Point(34, 122);
            this.labelTutorEmail.Name = "labelTutorEmail";
            this.labelTutorEmail.Size = new System.Drawing.Size(65, 25);
            this.labelTutorEmail.TabIndex = 31;
            this.labelTutorEmail.Text = "Email";
            // 
            // comboBoxExpertise
            // 
            this.comboBoxExpertise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExpertise.FormattingEnabled = true;
            this.comboBoxExpertise.Location = new System.Drawing.Point(39, 220);
            this.comboBoxExpertise.Name = "comboBoxExpertise";
            this.comboBoxExpertise.Size = new System.Drawing.Size(361, 33);
            this.comboBoxExpertise.TabIndex = 29;
            // 
            // labelExpertise
            // 
            this.labelExpertise.AutoSize = true;
            this.labelExpertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpertise.Location = new System.Drawing.Point(34, 192);
            this.labelExpertise.Name = "labelExpertise";
            this.labelExpertise.Size = new System.Drawing.Size(102, 25);
            this.labelExpertise.TabIndex = 28;
            this.labelExpertise.Text = "Expertise";
            // 
            // textBoxTutorName
            // 
            this.textBoxTutorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTutorName.Location = new System.Drawing.Point(39, 77);
            this.textBoxTutorName.Name = "textBoxTutorName";
            this.textBoxTutorName.Size = new System.Drawing.Size(361, 31);
            this.textBoxTutorName.TabIndex = 26;
            this.textBoxTutorName.TextChanged += new System.EventHandler(this.textBoxTutorName_TextChanged);
            // 
            // textBoxTutorHourlyRate
            // 
            this.textBoxTutorHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTutorHourlyRate.Location = new System.Drawing.Point(39, 290);
            this.textBoxTutorHourlyRate.Name = "textBoxTutorHourlyRate";
            this.textBoxTutorHourlyRate.Size = new System.Drawing.Size(361, 31);
            this.textBoxTutorHourlyRate.TabIndex = 24;
            this.textBoxTutorHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumerical_KeyPress);
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyRate.Location = new System.Drawing.Point(34, 262);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(125, 25);
            this.labelHourlyRate.TabIndex = 25;
            this.labelHourlyRate.Text = "Hourly Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tutor Name";
            // 
            // buttonTutorDelete
            // 
            this.buttonTutorDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutorDelete.Location = new System.Drawing.Point(223, 445);
            this.buttonTutorDelete.Name = "buttonTutorDelete";
            this.buttonTutorDelete.Size = new System.Drawing.Size(177, 41);
            this.buttonTutorDelete.TabIndex = 14;
            this.buttonTutorDelete.Text = "Delete";
            this.buttonTutorDelete.UseVisualStyleBackColor = true;
            this.buttonTutorDelete.Click += new System.EventHandler(this.buttonTutorDelete_Click);
            // 
            // buttonRegisterTutor
            // 
            this.buttonRegisterTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterTutor.Location = new System.Drawing.Point(39, 445);
            this.buttonRegisterTutor.Name = "buttonRegisterTutor";
            this.buttonRegisterTutor.Size = new System.Drawing.Size(177, 41);
            this.buttonRegisterTutor.TabIndex = 12;
            this.buttonRegisterTutor.Text = "Register";
            this.buttonRegisterTutor.UseVisualStyleBackColor = true;
            this.buttonRegisterTutor.Click += new System.EventHandler(this.buttonRegisterTutor_Click);
            // 
            // dataGridViewTutorManagement
            // 
            this.dataGridViewTutorManagement.AllowUserToAddRows = false;
            this.dataGridViewTutorManagement.AllowUserToDeleteRows = false;
            this.dataGridViewTutorManagement.AllowUserToResizeColumns = false;
            this.dataGridViewTutorManagement.AllowUserToResizeRows = false;
            this.dataGridViewTutorManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTutorManagement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTutorManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTutorManagement.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTutorManagement.Location = new System.Drawing.Point(435, 26);
            this.dataGridViewTutorManagement.Name = "dataGridViewTutorManagement";
            this.dataGridViewTutorManagement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTutorManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTutorManagement.ShowEditingIcon = false;
            this.dataGridViewTutorManagement.ShowRowErrors = false;
            this.dataGridViewTutorManagement.Size = new System.Drawing.Size(633, 460);
            this.dataGridViewTutorManagement.TabIndex = 0;
            // 
            // tabPageSubjectLibrary
            // 
            this.tabPageSubjectLibrary.Controls.Add(this.dataGridViewTutorPerSubject);
            this.tabPageSubjectLibrary.Controls.Add(this.textBoxSubjectLib);
            this.tabPageSubjectLibrary.Controls.Add(this.buttonDeleteToolInventory);
            this.tabPageSubjectLibrary.Controls.Add(this.buttonAddToolInventory);
            this.tabPageSubjectLibrary.Controls.Add(this.labelInventoryService);
            this.tabPageSubjectLibrary.Controls.Add(this.dataGridViewSubjects);
            this.tabPageSubjectLibrary.Location = new System.Drawing.Point(4, 25);
            this.tabPageSubjectLibrary.Name = "tabPageSubjectLibrary";
            this.tabPageSubjectLibrary.Size = new System.Drawing.Size(1102, 539);
            this.tabPageSubjectLibrary.TabIndex = 6;
            this.tabPageSubjectLibrary.Text = "Subjects Library";
            this.tabPageSubjectLibrary.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTutorPerSubject
            // 
            this.dataGridViewTutorPerSubject.AllowUserToAddRows = false;
            this.dataGridViewTutorPerSubject.AllowUserToDeleteRows = false;
            this.dataGridViewTutorPerSubject.AllowUserToResizeColumns = false;
            this.dataGridViewTutorPerSubject.AllowUserToResizeRows = false;
            this.dataGridViewTutorPerSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTutorPerSubject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTutorPerSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTutorPerSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTutorPerSubject.Location = new System.Drawing.Point(810, 35);
            this.dataGridViewTutorPerSubject.Name = "dataGridViewTutorPerSubject";
            this.dataGridViewTutorPerSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTutorPerSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTutorPerSubject.Size = new System.Drawing.Size(263, 460);
            this.dataGridViewTutorPerSubject.TabIndex = 30;
            // 
            // textBoxSubjectLib
            // 
            this.textBoxSubjectLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectLib.Location = new System.Drawing.Point(85, 225);
            this.textBoxSubjectLib.Name = "textBoxSubjectLib";
            this.textBoxSubjectLib.Size = new System.Drawing.Size(345, 31);
            this.textBoxSubjectLib.TabIndex = 29;
            this.textBoxSubjectLib.TextChanged += new System.EventHandler(this.textBoxTutorinServiceLib_TextChanged);
            // 
            // buttonDeleteToolInventory
            // 
            this.buttonDeleteToolInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteToolInventory.Location = new System.Drawing.Point(268, 281);
            this.buttonDeleteToolInventory.Name = "buttonDeleteToolInventory";
            this.buttonDeleteToolInventory.Size = new System.Drawing.Size(162, 37);
            this.buttonDeleteToolInventory.TabIndex = 28;
            this.buttonDeleteToolInventory.Text = "Delete";
            this.buttonDeleteToolInventory.UseVisualStyleBackColor = true;
            this.buttonDeleteToolInventory.Click += new System.EventHandler(this.buttonDeleteToolInventory_Click);
            // 
            // buttonAddToolInventory
            // 
            this.buttonAddToolInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToolInventory.Location = new System.Drawing.Point(85, 281);
            this.buttonAddToolInventory.Name = "buttonAddToolInventory";
            this.buttonAddToolInventory.Size = new System.Drawing.Size(162, 37);
            this.buttonAddToolInventory.TabIndex = 26;
            this.buttonAddToolInventory.Text = "Add";
            this.buttonAddToolInventory.UseVisualStyleBackColor = true;
            this.buttonAddToolInventory.Click += new System.EventHandler(this.buttonAddISubject_Click);
            // 
            // labelInventoryService
            // 
            this.labelInventoryService.AutoSize = true;
            this.labelInventoryService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryService.Location = new System.Drawing.Point(80, 197);
            this.labelInventoryService.Name = "labelInventoryService";
            this.labelInventoryService.Size = new System.Drawing.Size(84, 25);
            this.labelInventoryService.TabIndex = 24;
            this.labelInventoryService.Text = "Subject";
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.AllowUserToAddRows = false;
            this.dataGridViewSubjects.AllowUserToDeleteRows = false;
            this.dataGridViewSubjects.AllowUserToResizeColumns = false;
            this.dataGridViewSubjects.AllowUserToResizeRows = false;
            this.dataGridViewSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSubjects.Location = new System.Drawing.Point(521, 35);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(263, 460);
            this.dataGridViewSubjects.TabIndex = 23;
            this.dataGridViewSubjects.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSubjects_RowHeaderMouseClick);
            // 
            // tabPageBilling
            // 
            this.tabPageBilling.Controls.Add(this.SearchBoxBilling);
            this.tabPageBilling.Controls.Add(this.labelPartialPayment);
            this.tabPageBilling.Controls.Add(this.DataGridViewPartialPayment);
            this.tabPageBilling.Controls.Add(this.labelPayment);
            this.tabPageBilling.Controls.Add(this.textBoxPayment);
            this.tabPageBilling.Controls.Add(this.labelPayedPayments);
            this.tabPageBilling.Controls.Add(this.labelPendingPayments);
            this.tabPageBilling.Controls.Add(this.DataGridViewPaidPayment);
            this.tabPageBilling.Controls.Add(this.buttonPaid);
            this.tabPageBilling.Controls.Add(this.DataGridViewPendingPayment);
            this.tabPageBilling.Location = new System.Drawing.Point(4, 25);
            this.tabPageBilling.Name = "tabPageBilling";
            this.tabPageBilling.Size = new System.Drawing.Size(1102, 539);
            this.tabPageBilling.TabIndex = 4;
            this.tabPageBilling.Text = "Billing Management";
            this.tabPageBilling.UseVisualStyleBackColor = true;
            // 
            // SearchBoxBilling
            // 
            this.SearchBoxBilling.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBoxBilling.Location = new System.Drawing.Point(788, 23);
            this.SearchBoxBilling.Name = "SearchBoxBilling";
            this.SearchBoxBilling.Size = new System.Drawing.Size(306, 33);
            this.SearchBoxBilling.TabIndex = 9;
            this.SearchBoxBilling.Visible = false;
            this.SearchBoxBilling.TextChanged += new System.EventHandler(this.SearchBoxBilling_TextChanged);
            // 
            // labelPartialPayment
            // 
            this.labelPartialPayment.AutoSize = true;
            this.labelPartialPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartialPayment.Location = new System.Drawing.Point(3, 192);
            this.labelPartialPayment.Name = "labelPartialPayment";
            this.labelPartialPayment.Size = new System.Drawing.Size(174, 25);
            this.labelPartialPayment.TabIndex = 8;
            this.labelPartialPayment.Text = "Partial Payments";
            // 
            // DataGridViewPartialPayment
            // 
            this.DataGridViewPartialPayment.AllowUserToAddRows = false;
            this.DataGridViewPartialPayment.AllowUserToDeleteRows = false;
            this.DataGridViewPartialPayment.AllowUserToResizeColumns = false;
            this.DataGridViewPartialPayment.AllowUserToResizeRows = false;
            this.DataGridViewPartialPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridViewPartialPayment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewPartialPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPartialPayment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewPartialPayment.Location = new System.Drawing.Point(8, 220);
            this.DataGridViewPartialPayment.Name = "DataGridViewPartialPayment";
            this.DataGridViewPartialPayment.ReadOnly = true;
            this.DataGridViewPartialPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridViewPartialPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPartialPayment.ShowEditingIcon = false;
            this.DataGridViewPartialPayment.Size = new System.Drawing.Size(1086, 110);
            this.DataGridViewPartialPayment.TabIndex = 7;
            this.DataGridViewPartialPayment.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewPartialPayment_RowHeaderMouseClick);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayment.Location = new System.Drawing.Point(591, 508);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(107, 20);
            this.labelPayment.TabIndex = 6;
            this.labelPayment.Text = "Payment Fee:";
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPayment.Location = new System.Drawing.Point(704, 505);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(226, 26);
            this.textBoxPayment.TabIndex = 5;
            this.textBoxPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumerical_KeyPress);
            // 
            // labelPayedPayments
            // 
            this.labelPayedPayments.AutoSize = true;
            this.labelPayedPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayedPayments.Location = new System.Drawing.Point(8, 348);
            this.labelPayedPayments.Name = "labelPayedPayments";
            this.labelPayedPayments.Size = new System.Drawing.Size(156, 25);
            this.labelPayedPayments.TabIndex = 4;
            this.labelPayedPayments.Text = "Paid Payments";
            // 
            // labelPendingPayments
            // 
            this.labelPendingPayments.AutoSize = true;
            this.labelPendingPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendingPayments.Location = new System.Drawing.Point(3, 34);
            this.labelPendingPayments.Name = "labelPendingPayments";
            this.labelPendingPayments.Size = new System.Drawing.Size(192, 25);
            this.labelPendingPayments.TabIndex = 3;
            this.labelPendingPayments.Text = "Pending Payments";
            // 
            // DataGridViewPaidPayment
            // 
            this.DataGridViewPaidPayment.AllowUserToAddRows = false;
            this.DataGridViewPaidPayment.AllowUserToDeleteRows = false;
            this.DataGridViewPaidPayment.AllowUserToResizeColumns = false;
            this.DataGridViewPaidPayment.AllowUserToResizeRows = false;
            this.DataGridViewPaidPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridViewPaidPayment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewPaidPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPaidPayment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewPaidPayment.Location = new System.Drawing.Point(8, 376);
            this.DataGridViewPaidPayment.Name = "DataGridViewPaidPayment";
            this.DataGridViewPaidPayment.ReadOnly = true;
            this.DataGridViewPaidPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridViewPaidPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPaidPayment.ShowEditingIcon = false;
            this.DataGridViewPaidPayment.Size = new System.Drawing.Size(1086, 110);
            this.DataGridViewPaidPayment.TabIndex = 2;
            // 
            // buttonPaid
            // 
            this.buttonPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaid.Location = new System.Drawing.Point(936, 505);
            this.buttonPaid.Name = "buttonPaid";
            this.buttonPaid.Size = new System.Drawing.Size(158, 26);
            this.buttonPaid.TabIndex = 1;
            this.buttonPaid.Text = "Pay";
            this.buttonPaid.UseVisualStyleBackColor = true;
            this.buttonPaid.Click += new System.EventHandler(this.buttonPaid_Click);
            // 
            // DataGridViewPendingPayment
            // 
            this.DataGridViewPendingPayment.AllowUserToAddRows = false;
            this.DataGridViewPendingPayment.AllowUserToDeleteRows = false;
            this.DataGridViewPendingPayment.AllowUserToResizeColumns = false;
            this.DataGridViewPendingPayment.AllowUserToResizeRows = false;
            this.DataGridViewPendingPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridViewPendingPayment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewPendingPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPendingPayment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewPendingPayment.Location = new System.Drawing.Point(8, 62);
            this.DataGridViewPendingPayment.Name = "DataGridViewPendingPayment";
            this.DataGridViewPendingPayment.ReadOnly = true;
            this.DataGridViewPendingPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridViewPendingPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPendingPayment.ShowEditingIcon = false;
            this.DataGridViewPendingPayment.Size = new System.Drawing.Size(1086, 110);
            this.DataGridViewPendingPayment.TabIndex = 0;
            this.DataGridViewPendingPayment.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewPendingPayment_RowHeaderMouseClick);
            // 
            // tabPageReceiptReport
            // 
            this.tabPageReceiptReport.Controls.Add(this.reportViewerReceipt);
            this.tabPageReceiptReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageReceiptReport.Name = "tabPageReceiptReport";
            this.tabPageReceiptReport.Size = new System.Drawing.Size(1102, 539);
            this.tabPageReceiptReport.TabIndex = 7;
            this.tabPageReceiptReport.Text = "Receipt";
            this.tabPageReceiptReport.UseVisualStyleBackColor = true;
            // 
            // reportViewerReceipt
            // 
            this.reportViewerReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportViewerReceipt.Location = new System.Drawing.Point(194, 20);
            this.reportViewerReceipt.Name = "reportViewerReceipt";
            this.reportViewerReceipt.ServerReport.BearerToken = null;
            this.reportViewerReceipt.Size = new System.Drawing.Size(713, 495);
            this.reportViewerReceipt.TabIndex = 0;
            this.reportViewerReceipt.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 568);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido Online Tutoring Service";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEnroll.ResumeLayout(false);
            this.tabPageEnroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudentList)).EndInit();
            this.PanelSubjectEnrollment.ResumeLayout(false);
            this.PanelSubjectEnrollment.PerformLayout();
            this.PanelStudentInfo.ResumeLayout(false);
            this.PanelStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorInTheSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreferredSubjects)).EndInit();
            this.tabPageTutorRegistration.ResumeLayout(false);
            this.tabPageTutorRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorManagement)).EndInit();
            this.tabPageSubjectLibrary.ResumeLayout(false);
            this.tabPageSubjectLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorPerSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            this.tabPageBilling.ResumeLayout(false);
            this.tabPageBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPartialPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPaidPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPendingPayment)).EndInit();
            this.tabPageReceiptReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEnroll;
        private System.Windows.Forms.Button ButtonEnrollStudent;
        private System.Windows.Forms.Label labelStudentEmail;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.TextBox TextBoxStudEmail;
        private System.Windows.Forms.TextBox TextBoxEnrollmentStudName;
        private System.Windows.Forms.TabPage tabPageTutorRegistration;
        private System.Windows.Forms.TextBox textBoxTutorName;
        private System.Windows.Forms.TextBox textBoxTutorHourlyRate;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTutorDelete;
        private System.Windows.Forms.Button buttonRegisterTutor;
        private System.Windows.Forms.DataGridView dataGridViewTutorManagement;
        private System.Windows.Forms.TabPage tabPageSubjectLibrary;
        private System.Windows.Forms.TextBox textBoxSubjectLib;
        private System.Windows.Forms.Button buttonAddToolInventory;
        private System.Windows.Forms.Label labelInventoryService;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.TabPage tabPageBilling;
        private System.Windows.Forms.Label labelPayedPayments;
        private System.Windows.Forms.Label labelPendingPayments;
        private System.Windows.Forms.DataGridView DataGridViewPaidPayment;
        private System.Windows.Forms.Button buttonPaid;
        private System.Windows.Forms.DataGridView DataGridViewPendingPayment;
        private System.Windows.Forms.Label labelExpertise;
        private System.Windows.Forms.Button buttonRegisterPrefSub;
        private System.Windows.Forms.Button buttonRemoveSub;
        private System.Windows.Forms.ComboBox comboBoxExpertise;
        private System.Windows.Forms.DataGridView dataGridViewTutorInTheSubject;
        private System.Windows.Forms.DataGridView dataGridViewPreferredSubjects;
        private System.Windows.Forms.Label lablePreferredSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSessionDuration;
        private System.Windows.Forms.Label labelSubjects;
        private System.Windows.Forms.ComboBox ComboBoxEnrollmentSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTutorEmail;
        private System.Windows.Forms.Label labelTutorEmail;
        private System.Windows.Forms.Label labelOverallTotalFee;
        private System.Windows.Forms.TextBox textBoxOverallTotalFee;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.Button buttonDeleteToolInventory;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelBeginTime;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.DataGridView dataGridViewTutorPerSubject;
        private System.Windows.Forms.DateTimePicker TimePickerSessionSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageReceiptReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReceipt;
        private System.Windows.Forms.DateTimePicker DatePickerSessionSchedule;
        private System.Windows.Forms.Panel PanelSubjectEnrollment;
        private System.Windows.Forms.Panel PanelStudentInfo;
        private System.Windows.Forms.Label labelStudentList;
        private System.Windows.Forms.DataGridView DataGridViewStudentList;
        private System.Windows.Forms.Label labelPartialPayment;
        private System.Windows.Forms.DataGridView DataGridViewPartialPayment;
        private System.Windows.Forms.TextBox SearchBoxBilling;
    }
}