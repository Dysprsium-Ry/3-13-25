﻿namespace BienvenidoOnlineTutorServices.D2.Forms
{
    partial class mainForm
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
            this.labelOverallTotalFee = new System.Windows.Forms.Label();
            this.textBoxOverallTotalFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSessionDuration = new System.Windows.Forms.TextBox();
            this.labelSubjects = new System.Windows.Forms.Label();
            this.comboBoxPreferredSubjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lablePreferredSubjects = new System.Windows.Forms.Label();
            this.dataGridViewTutorInSubject = new System.Windows.Forms.DataGridView();
            this.buttonRegisterPrefSub = new System.Windows.Forms.Button();
            this.buttonRemoveSub = new System.Windows.Forms.Button();
            this.buttonEnrollStudent = new System.Windows.Forms.Button();
            this.labelStudentEmail = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.TextBox_StudentEmail = new System.Windows.Forms.TextBox();
            this.TextBox_StudentName = new System.Windows.Forms.TextBox();
            this.dataGridViewPreferredSubjects = new System.Windows.Forms.DataGridView();
            this.tabPagTutorRegistration = new System.Windows.Forms.TabPage();
            this.textBoxTutorEmail = new System.Windows.Forms.TextBox();
            this.labelTutorEmail = new System.Windows.Forms.Label();
            this.buttonTutorUpdate = new System.Windows.Forms.Button();
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
            this.dataGridViewTutorInTheSubject = new System.Windows.Forms.DataGridView();
            this.textBoxSubjectInSubjectLib = new System.Windows.Forms.TextBox();
            this.buttonDeleteToolInventory = new System.Windows.Forms.Button();
            this.buttonEditToolInventory = new System.Windows.Forms.Button();
            this.buttonAddToolInventory = new System.Windows.Forms.Button();
            this.labelInventoryService = new System.Windows.Forms.Label();
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.tabPageBilling = new System.Windows.Forms.TabPage();
            this.labelPayedPayments = new System.Windows.Forms.Label();
            this.labelPendingPayments = new System.Windows.Forms.Label();
            this.dataGridViewPayedBilling = new System.Windows.Forms.DataGridView();
            this.buttonPaid = new System.Windows.Forms.Button();
            this.dataGridViewPendingBilling = new System.Windows.Forms.DataGridView();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageEnroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorInSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreferredSubjects)).BeginInit();
            this.tabPagTutorRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorManagement)).BeginInit();
            this.tabPageSubjectLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorInTheSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            this.tabPageBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayedBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEnroll);
            this.tabControlMain.Controls.Add(this.tabPagTutorRegistration);
            this.tabControlMain.Controls.Add(this.tabPageSubjectLibrary);
            this.tabControlMain.Controls.Add(this.tabPageBilling);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1005, 549);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageEnroll
            // 
            this.tabPageEnroll.Controls.Add(this.labelOverallTotalFee);
            this.tabPageEnroll.Controls.Add(this.textBoxOverallTotalFee);
            this.tabPageEnroll.Controls.Add(this.label2);
            this.tabPageEnroll.Controls.Add(this.textBoxSessionDuration);
            this.tabPageEnroll.Controls.Add(this.labelSubjects);
            this.tabPageEnroll.Controls.Add(this.comboBoxPreferredSubjects);
            this.tabPageEnroll.Controls.Add(this.label1);
            this.tabPageEnroll.Controls.Add(this.lablePreferredSubjects);
            this.tabPageEnroll.Controls.Add(this.dataGridViewTutorInSubject);
            this.tabPageEnroll.Controls.Add(this.buttonRegisterPrefSub);
            this.tabPageEnroll.Controls.Add(this.buttonRemoveSub);
            this.tabPageEnroll.Controls.Add(this.buttonEnrollStudent);
            this.tabPageEnroll.Controls.Add(this.labelStudentEmail);
            this.tabPageEnroll.Controls.Add(this.labelStudentName);
            this.tabPageEnroll.Controls.Add(this.TextBox_StudentEmail);
            this.tabPageEnroll.Controls.Add(this.TextBox_StudentName);
            this.tabPageEnroll.Controls.Add(this.dataGridViewPreferredSubjects);
            this.tabPageEnroll.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnroll.Name = "tabPageEnroll";
            this.tabPageEnroll.Size = new System.Drawing.Size(997, 520);
            this.tabPageEnroll.TabIndex = 2;
            this.tabPageEnroll.Text = "Student Enrollment";
            this.tabPageEnroll.UseVisualStyleBackColor = true;
            // 
            // labelOverallTotalFee
            // 
            this.labelOverallTotalFee.AutoSize = true;
            this.labelOverallTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverallTotalFee.Location = new System.Drawing.Point(808, 412);
            this.labelOverallTotalFee.Name = "labelOverallTotalFee";
            this.labelOverallTotalFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelOverallTotalFee.Size = new System.Drawing.Size(165, 25);
            this.labelOverallTotalFee.TabIndex = 35;
            this.labelOverallTotalFee.Text = "OverallTotalFee";
            this.labelOverallTotalFee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxOverallTotalFee
            // 
            this.textBoxOverallTotalFee.Enabled = false;
            this.textBoxOverallTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOverallTotalFee.Location = new System.Drawing.Point(704, 440);
            this.textBoxOverallTotalFee.Name = "textBoxOverallTotalFee";
            this.textBoxOverallTotalFee.Size = new System.Drawing.Size(264, 31);
            this.textBoxOverallTotalFee.TabIndex = 34;
            this.textBoxOverallTotalFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Session Duration";
            // 
            // textBoxSessionDuration
            // 
            this.textBoxSessionDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSessionDuration.Location = new System.Drawing.Point(46, 321);
            this.textBoxSessionDuration.Name = "textBoxSessionDuration";
            this.textBoxSessionDuration.Size = new System.Drawing.Size(264, 31);
            this.textBoxSessionDuration.TabIndex = 32;
            // 
            // labelSubjects
            // 
            this.labelSubjects.AutoSize = true;
            this.labelSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjects.Location = new System.Drawing.Point(41, 211);
            this.labelSubjects.Name = "labelSubjects";
            this.labelSubjects.Size = new System.Drawing.Size(95, 25);
            this.labelSubjects.TabIndex = 31;
            this.labelSubjects.Text = "Subjects";
            // 
            // comboBoxPreferredSubjects
            // 
            this.comboBoxPreferredSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPreferredSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPreferredSubjects.FormattingEnabled = true;
            this.comboBoxPreferredSubjects.Location = new System.Drawing.Point(46, 239);
            this.comboBoxPreferredSubjects.Name = "comboBoxPreferredSubjects";
            this.comboBoxPreferredSubjects.Size = new System.Drawing.Size(264, 33);
            this.comboBoxPreferredSubjects.TabIndex = 30;
            this.comboBoxPreferredSubjects.SelectedValueChanged += new System.EventHandler(this.comboBoxPreferredSubjects_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tutors in the Subject";
            // 
            // lablePreferredSubjects
            // 
            this.lablePreferredSubjects.AutoSize = true;
            this.lablePreferredSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablePreferredSubjects.Location = new System.Drawing.Point(348, 49);
            this.lablePreferredSubjects.Name = "lablePreferredSubjects";
            this.lablePreferredSubjects.Size = new System.Drawing.Size(165, 24);
            this.lablePreferredSubjects.TabIndex = 15;
            this.lablePreferredSubjects.Text = "Preferred Subjects";
            // 
            // dataGridViewTutorInSubject
            // 
            this.dataGridViewTutorInSubject.AllowUserToAddRows = false;
            this.dataGridViewTutorInSubject.AllowUserToDeleteRows = false;
            this.dataGridViewTutorInSubject.AllowUserToResizeColumns = false;
            this.dataGridViewTutorInSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTutorInSubject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTutorInSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTutorInSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTutorInSubject.Location = new System.Drawing.Point(352, 295);
            this.dataGridViewTutorInSubject.Name = "dataGridViewTutorInSubject";
            this.dataGridViewTutorInSubject.ReadOnly = true;
            this.dataGridViewTutorInSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTutorInSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTutorInSubject.ShowEditingIcon = false;
            this.dataGridViewTutorInSubject.Size = new System.Drawing.Size(343, 176);
            this.dataGridViewTutorInSubject.TabIndex = 14;
            this.dataGridViewTutorInSubject.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTutorInSubject_RowHeaderMouseClick);
            // 
            // buttonRegisterPrefSub
            // 
            this.buttonRegisterPrefSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterPrefSub.Location = new System.Drawing.Point(46, 433);
            this.buttonRegisterPrefSub.Name = "buttonRegisterPrefSub";
            this.buttonRegisterPrefSub.Size = new System.Drawing.Size(130, 38);
            this.buttonRegisterPrefSub.TabIndex = 12;
            this.buttonRegisterPrefSub.Text = "Register";
            this.buttonRegisterPrefSub.UseVisualStyleBackColor = true;
            this.buttonRegisterPrefSub.Click += new System.EventHandler(this.buttonRegisterPrefSub_Click);
            // 
            // buttonRemoveSub
            // 
            this.buttonRemoveSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveSub.Location = new System.Drawing.Point(180, 433);
            this.buttonRemoveSub.Name = "buttonRemoveSub";
            this.buttonRemoveSub.Size = new System.Drawing.Size(130, 38);
            this.buttonRemoveSub.TabIndex = 11;
            this.buttonRemoveSub.Text = "Remove";
            this.buttonRemoveSub.UseVisualStyleBackColor = true;
            // 
            // buttonEnrollStudent
            // 
            this.buttonEnrollStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnrollStudent.Location = new System.Drawing.Point(46, 391);
            this.buttonEnrollStudent.Name = "buttonEnrollStudent";
            this.buttonEnrollStudent.Size = new System.Drawing.Size(264, 38);
            this.buttonEnrollStudent.TabIndex = 9;
            this.buttonEnrollStudent.Text = "Enroll";
            this.buttonEnrollStudent.UseVisualStyleBackColor = true;
            this.buttonEnrollStudent.Click += new System.EventHandler(this.buttonEnrollStudent_Click);
            // 
            // labelStudentEmail
            // 
            this.labelStudentEmail.AutoSize = true;
            this.labelStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentEmail.Location = new System.Drawing.Point(41, 127);
            this.labelStudentEmail.Name = "labelStudentEmail";
            this.labelStudentEmail.Size = new System.Drawing.Size(73, 25);
            this.labelStudentEmail.TabIndex = 6;
            this.labelStudentEmail.Text = "E-Mail";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentName.Location = new System.Drawing.Point(41, 49);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(148, 25);
            this.labelStudentName.TabIndex = 5;
            this.labelStudentName.Text = "Student Name";
            // 
            // TextBox_StudentEmail
            // 
            this.TextBox_StudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_StudentEmail.Location = new System.Drawing.Point(46, 155);
            this.TextBox_StudentEmail.Name = "TextBox_StudentEmail";
            this.TextBox_StudentEmail.Size = new System.Drawing.Size(264, 31);
            this.TextBox_StudentEmail.TabIndex = 2;
            // 
            // TextBox_StudentName
            // 
            this.TextBox_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_StudentName.Location = new System.Drawing.Point(46, 77);
            this.TextBox_StudentName.Name = "TextBox_StudentName";
            this.TextBox_StudentName.Size = new System.Drawing.Size(264, 31);
            this.TextBox_StudentName.TabIndex = 1;
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
            this.dataGridViewPreferredSubjects.Location = new System.Drawing.Point(353, 77);
            this.dataGridViewPreferredSubjects.Name = "dataGridViewPreferredSubjects";
            this.dataGridViewPreferredSubjects.ReadOnly = true;
            this.dataGridViewPreferredSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPreferredSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPreferredSubjects.ShowEditingIcon = false;
            this.dataGridViewPreferredSubjects.Size = new System.Drawing.Size(615, 175);
            this.dataGridViewPreferredSubjects.TabIndex = 0;
            // 
            // tabPagTutorRegistration
            // 
            this.tabPagTutorRegistration.Controls.Add(this.textBoxTutorEmail);
            this.tabPagTutorRegistration.Controls.Add(this.labelTutorEmail);
            this.tabPagTutorRegistration.Controls.Add(this.buttonTutorUpdate);
            this.tabPagTutorRegistration.Controls.Add(this.comboBoxExpertise);
            this.tabPagTutorRegistration.Controls.Add(this.labelExpertise);
            this.tabPagTutorRegistration.Controls.Add(this.textBoxTutorName);
            this.tabPagTutorRegistration.Controls.Add(this.textBoxTutorHourlyRate);
            this.tabPagTutorRegistration.Controls.Add(this.labelHourlyRate);
            this.tabPagTutorRegistration.Controls.Add(this.label5);
            this.tabPagTutorRegistration.Controls.Add(this.buttonTutorDelete);
            this.tabPagTutorRegistration.Controls.Add(this.buttonRegisterTutor);
            this.tabPagTutorRegistration.Controls.Add(this.dataGridViewTutorManagement);
            this.tabPagTutorRegistration.Location = new System.Drawing.Point(4, 25);
            this.tabPagTutorRegistration.Name = "tabPagTutorRegistration";
            this.tabPagTutorRegistration.Size = new System.Drawing.Size(997, 520);
            this.tabPagTutorRegistration.TabIndex = 3;
            this.tabPagTutorRegistration.Text = "Tutor Management";
            this.tabPagTutorRegistration.UseVisualStyleBackColor = true;
            // 
            // textBoxTutorEmail
            // 
            this.textBoxTutorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTutorEmail.Location = new System.Drawing.Point(39, 163);
            this.textBoxTutorEmail.Name = "textBoxTutorEmail";
            this.textBoxTutorEmail.Size = new System.Drawing.Size(361, 31);
            this.textBoxTutorEmail.TabIndex = 32;
            // 
            // labelTutorEmail
            // 
            this.labelTutorEmail.AutoSize = true;
            this.labelTutorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutorEmail.Location = new System.Drawing.Point(34, 135);
            this.labelTutorEmail.Name = "labelTutorEmail";
            this.labelTutorEmail.Size = new System.Drawing.Size(65, 25);
            this.labelTutorEmail.TabIndex = 31;
            this.labelTutorEmail.Text = "Email";
            // 
            // buttonTutorUpdate
            // 
            this.buttonTutorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutorUpdate.Location = new System.Drawing.Point(160, 400);
            this.buttonTutorUpdate.Name = "buttonTutorUpdate";
            this.buttonTutorUpdate.Size = new System.Drawing.Size(117, 41);
            this.buttonTutorUpdate.TabIndex = 30;
            this.buttonTutorUpdate.Text = "Update";
            this.buttonTutorUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxExpertise
            // 
            this.comboBoxExpertise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExpertise.FormattingEnabled = true;
            this.comboBoxExpertise.Location = new System.Drawing.Point(39, 246);
            this.comboBoxExpertise.Name = "comboBoxExpertise";
            this.comboBoxExpertise.Size = new System.Drawing.Size(361, 33);
            this.comboBoxExpertise.TabIndex = 29;
            // 
            // labelExpertise
            // 
            this.labelExpertise.AutoSize = true;
            this.labelExpertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpertise.Location = new System.Drawing.Point(34, 218);
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
            // 
            // textBoxTutorHourlyRate
            // 
            this.textBoxTutorHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTutorHourlyRate.Location = new System.Drawing.Point(39, 329);
            this.textBoxTutorHourlyRate.Name = "textBoxTutorHourlyRate";
            this.textBoxTutorHourlyRate.Size = new System.Drawing.Size(361, 31);
            this.textBoxTutorHourlyRate.TabIndex = 24;
            this.textBoxTutorHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumericalTextBox_KeyPress);
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyRate.Location = new System.Drawing.Point(34, 301);
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
            this.buttonTutorDelete.Location = new System.Drawing.Point(283, 400);
            this.buttonTutorDelete.Name = "buttonTutorDelete";
            this.buttonTutorDelete.Size = new System.Drawing.Size(117, 41);
            this.buttonTutorDelete.TabIndex = 14;
            this.buttonTutorDelete.Text = "Delete";
            this.buttonTutorDelete.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterTutor
            // 
            this.buttonRegisterTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterTutor.Location = new System.Drawing.Point(37, 400);
            this.buttonRegisterTutor.Name = "buttonRegisterTutor";
            this.buttonRegisterTutor.Size = new System.Drawing.Size(117, 41);
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
            this.dataGridViewTutorManagement.Location = new System.Drawing.Point(480, 26);
            this.dataGridViewTutorManagement.Name = "dataGridViewTutorManagement";
            this.dataGridViewTutorManagement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTutorManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTutorManagement.ShowEditingIcon = false;
            this.dataGridViewTutorManagement.ShowRowErrors = false;
            this.dataGridViewTutorManagement.Size = new System.Drawing.Size(486, 460);
            this.dataGridViewTutorManagement.TabIndex = 0;
            // 
            // tabPageSubjectLibrary
            // 
            this.tabPageSubjectLibrary.Controls.Add(this.dataGridViewTutorInTheSubject);
            this.tabPageSubjectLibrary.Controls.Add(this.textBoxSubjectInSubjectLib);
            this.tabPageSubjectLibrary.Controls.Add(this.buttonDeleteToolInventory);
            this.tabPageSubjectLibrary.Controls.Add(this.buttonEditToolInventory);
            this.tabPageSubjectLibrary.Controls.Add(this.buttonAddToolInventory);
            this.tabPageSubjectLibrary.Controls.Add(this.labelInventoryService);
            this.tabPageSubjectLibrary.Controls.Add(this.dataGridViewSubjects);
            this.tabPageSubjectLibrary.Location = new System.Drawing.Point(4, 25);
            this.tabPageSubjectLibrary.Name = "tabPageSubjectLibrary";
            this.tabPageSubjectLibrary.Size = new System.Drawing.Size(997, 520);
            this.tabPageSubjectLibrary.TabIndex = 6;
            this.tabPageSubjectLibrary.Text = "Subjects Library";
            this.tabPageSubjectLibrary.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTutorInTheSubject
            // 
            this.dataGridViewTutorInTheSubject.AllowUserToAddRows = false;
            this.dataGridViewTutorInTheSubject.AllowUserToDeleteRows = false;
            this.dataGridViewTutorInTheSubject.AllowUserToResizeColumns = false;
            this.dataGridViewTutorInTheSubject.AllowUserToResizeRows = false;
            this.dataGridViewTutorInTheSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTutorInTheSubject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTutorInTheSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTutorInTheSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewTutorInTheSubject.Location = new System.Drawing.Point(694, 29);
            this.dataGridViewTutorInTheSubject.Name = "dataGridViewTutorInTheSubject";
            this.dataGridViewTutorInTheSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTutorInTheSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTutorInTheSubject.Size = new System.Drawing.Size(261, 460);
            this.dataGridViewTutorInTheSubject.TabIndex = 30;
            // 
            // textBoxSubjectInSubjectLib
            // 
            this.textBoxSubjectInSubjectLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectInSubjectLib.Location = new System.Drawing.Point(28, 107);
            this.textBoxSubjectInSubjectLib.Name = "textBoxSubjectInSubjectLib";
            this.textBoxSubjectInSubjectLib.Size = new System.Drawing.Size(345, 31);
            this.textBoxSubjectInSubjectLib.TabIndex = 29;
            this.textBoxSubjectInSubjectLib.TextChanged += new System.EventHandler(this.textBoxTutorinServiceLib_TextChanged);
            // 
            // buttonDeleteToolInventory
            // 
            this.buttonDeleteToolInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteToolInventory.Location = new System.Drawing.Point(262, 174);
            this.buttonDeleteToolInventory.Name = "buttonDeleteToolInventory";
            this.buttonDeleteToolInventory.Size = new System.Drawing.Size(111, 37);
            this.buttonDeleteToolInventory.TabIndex = 28;
            this.buttonDeleteToolInventory.Text = "Delete";
            this.buttonDeleteToolInventory.UseVisualStyleBackColor = true;
            // 
            // buttonEditToolInventory
            // 
            this.buttonEditToolInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditToolInventory.Location = new System.Drawing.Point(145, 174);
            this.buttonEditToolInventory.Name = "buttonEditToolInventory";
            this.buttonEditToolInventory.Size = new System.Drawing.Size(111, 37);
            this.buttonEditToolInventory.TabIndex = 27;
            this.buttonEditToolInventory.Text = "Update";
            this.buttonEditToolInventory.UseVisualStyleBackColor = true;
            // 
            // buttonAddToolInventory
            // 
            this.buttonAddToolInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToolInventory.Location = new System.Drawing.Point(28, 174);
            this.buttonAddToolInventory.Name = "buttonAddToolInventory";
            this.buttonAddToolInventory.Size = new System.Drawing.Size(111, 37);
            this.buttonAddToolInventory.TabIndex = 26;
            this.buttonAddToolInventory.Text = "Add";
            this.buttonAddToolInventory.UseVisualStyleBackColor = true;
            // 
            // labelInventoryService
            // 
            this.labelInventoryService.AutoSize = true;
            this.labelInventoryService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryService.Location = new System.Drawing.Point(23, 79);
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
            this.dataGridViewSubjects.Location = new System.Drawing.Point(406, 29);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(263, 460);
            this.dataGridViewSubjects.TabIndex = 23;
            // 
            // tabPageBilling
            // 
            this.tabPageBilling.Controls.Add(this.textBoxPayment);
            this.tabPageBilling.Controls.Add(this.labelPayedPayments);
            this.tabPageBilling.Controls.Add(this.labelPendingPayments);
            this.tabPageBilling.Controls.Add(this.dataGridViewPayedBilling);
            this.tabPageBilling.Controls.Add(this.buttonPaid);
            this.tabPageBilling.Controls.Add(this.dataGridViewPendingBilling);
            this.tabPageBilling.Location = new System.Drawing.Point(4, 25);
            this.tabPageBilling.Name = "tabPageBilling";
            this.tabPageBilling.Size = new System.Drawing.Size(997, 520);
            this.tabPageBilling.TabIndex = 4;
            this.tabPageBilling.Text = "Billing Management";
            this.tabPageBilling.UseVisualStyleBackColor = true;
            // 
            // labelPayedPayments
            // 
            this.labelPayedPayments.AutoSize = true;
            this.labelPayedPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayedPayments.Location = new System.Drawing.Point(24, 248);
            this.labelPayedPayments.Name = "labelPayedPayments";
            this.labelPayedPayments.Size = new System.Drawing.Size(174, 25);
            this.labelPayedPayments.TabIndex = 4;
            this.labelPayedPayments.Text = "Payed Payments";
            // 
            // labelPendingPayments
            // 
            this.labelPendingPayments.AutoSize = true;
            this.labelPendingPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendingPayments.Location = new System.Drawing.Point(24, 23);
            this.labelPendingPayments.Name = "labelPendingPayments";
            this.labelPendingPayments.Size = new System.Drawing.Size(192, 25);
            this.labelPendingPayments.TabIndex = 3;
            this.labelPendingPayments.Text = "Pending Payments";
            // 
            // dataGridViewPayedBilling
            // 
            this.dataGridViewPayedBilling.AllowUserToAddRows = false;
            this.dataGridViewPayedBilling.AllowUserToDeleteRows = false;
            this.dataGridViewPayedBilling.AllowUserToResizeColumns = false;
            this.dataGridViewPayedBilling.AllowUserToResizeRows = false;
            this.dataGridViewPayedBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPayedBilling.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPayedBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayedBilling.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPayedBilling.Location = new System.Drawing.Point(29, 276);
            this.dataGridViewPayedBilling.Name = "dataGridViewPayedBilling";
            this.dataGridViewPayedBilling.ReadOnly = true;
            this.dataGridViewPayedBilling.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPayedBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPayedBilling.ShowEditingIcon = false;
            this.dataGridViewPayedBilling.Size = new System.Drawing.Size(940, 184);
            this.dataGridViewPayedBilling.TabIndex = 2;
            // 
            // buttonPaid
            // 
            this.buttonPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaid.Location = new System.Drawing.Point(772, 477);
            this.buttonPaid.Name = "buttonPaid";
            this.buttonPaid.Size = new System.Drawing.Size(197, 35);
            this.buttonPaid.TabIndex = 1;
            this.buttonPaid.Text = "Paid";
            this.buttonPaid.UseVisualStyleBackColor = true;
            this.buttonPaid.Click += new System.EventHandler(this.buttonPaid_Click);
            // 
            // dataGridViewPendingBilling
            // 
            this.dataGridViewPendingBilling.AllowUserToAddRows = false;
            this.dataGridViewPendingBilling.AllowUserToDeleteRows = false;
            this.dataGridViewPendingBilling.AllowUserToResizeColumns = false;
            this.dataGridViewPendingBilling.AllowUserToResizeRows = false;
            this.dataGridViewPendingBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPendingBilling.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPendingBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingBilling.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPendingBilling.Location = new System.Drawing.Point(29, 51);
            this.dataGridViewPendingBilling.Name = "dataGridViewPendingBilling";
            this.dataGridViewPendingBilling.ReadOnly = true;
            this.dataGridViewPendingBilling.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPendingBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPendingBilling.ShowEditingIcon = false;
            this.dataGridViewPendingBilling.Size = new System.Drawing.Size(940, 175);
            this.dataGridViewPendingBilling.TabIndex = 0;
            this.dataGridViewPendingBilling.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPendingBilling_RowHeaderMouseClick);
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPayment.Location = new System.Drawing.Point(540, 477);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(226, 35);
            this.textBoxPayment.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 549);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido Online Tutoring Service";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEnroll.ResumeLayout(false);
            this.tabPageEnroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorInSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreferredSubjects)).EndInit();
            this.tabPagTutorRegistration.ResumeLayout(false);
            this.tabPagTutorRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorManagement)).EndInit();
            this.tabPageSubjectLibrary.ResumeLayout(false);
            this.tabPageSubjectLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorInTheSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            this.tabPageBilling.ResumeLayout(false);
            this.tabPageBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayedBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingBilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEnroll;
        private System.Windows.Forms.Button buttonEnrollStudent;
        private System.Windows.Forms.Label labelStudentEmail;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.TextBox TextBox_StudentEmail;
        private System.Windows.Forms.TextBox TextBox_StudentName;
        private System.Windows.Forms.TabPage tabPagTutorRegistration;
        private System.Windows.Forms.TextBox textBoxTutorName;
        private System.Windows.Forms.TextBox textBoxTutorHourlyRate;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTutorDelete;
        private System.Windows.Forms.Button buttonRegisterTutor;
        private System.Windows.Forms.DataGridView dataGridViewTutorManagement;
        private System.Windows.Forms.TabPage tabPageSubjectLibrary;
        private System.Windows.Forms.TextBox textBoxSubjectInSubjectLib;
        private System.Windows.Forms.Button buttonDeleteToolInventory;
        private System.Windows.Forms.Button buttonEditToolInventory;
        private System.Windows.Forms.Button buttonAddToolInventory;
        private System.Windows.Forms.Label labelInventoryService;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.TabPage tabPageBilling;
        private System.Windows.Forms.Label labelPayedPayments;
        private System.Windows.Forms.Label labelPendingPayments;
        private System.Windows.Forms.DataGridView dataGridViewPayedBilling;
        private System.Windows.Forms.Button buttonPaid;
        private System.Windows.Forms.DataGridView dataGridViewPendingBilling;
        private System.Windows.Forms.Label labelExpertise;
        private System.Windows.Forms.Button buttonRegisterPrefSub;
        private System.Windows.Forms.Button buttonRemoveSub;
        private System.Windows.Forms.ComboBox comboBoxExpertise;
        private System.Windows.Forms.Button buttonTutorUpdate;
        private System.Windows.Forms.DataGridView dataGridViewTutorInSubject;
        private System.Windows.Forms.DataGridView dataGridViewPreferredSubjects;
        private System.Windows.Forms.Label lablePreferredSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSessionDuration;
        private System.Windows.Forms.Label labelSubjects;
        private System.Windows.Forms.ComboBox comboBoxPreferredSubjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTutorEmail;
        private System.Windows.Forms.Label labelTutorEmail;
        private System.Windows.Forms.Label labelOverallTotalFee;
        private System.Windows.Forms.TextBox textBoxOverallTotalFee;
        private System.Windows.Forms.DataGridView dataGridViewTutorInTheSubject;
        private System.Windows.Forms.TextBox textBoxPayment;
    }
}