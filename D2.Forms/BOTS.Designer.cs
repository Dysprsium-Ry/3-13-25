namespace BienvenidoOnlineTutorServices.D2.Forms
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
            this.checkedListBoxSubjects = new System.Windows.Forms.CheckedListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClientDelete = new System.Windows.Forms.Button();
            this.buttonEnrollStudent = new System.Windows.Forms.Button();
            this.labelStudentEmail = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.TextBox_StudentEmail = new System.Windows.Forms.TextBox();
            this.TextBox_StudentName = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.tabPagTutorRegistration = new System.Windows.Forms.TabPage();
            this.labelExpertise = new System.Windows.Forms.Label();
            this.textBoxServiceLib = new System.Windows.Forms.TextBox();
            this.textBoxTutorHourlyRate = new System.Windows.Forms.TextBox();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDeleteLibItem = new System.Windows.Forms.Button();
            this.buttonRegisterTutor = new System.Windows.Forms.Button();
            this.dataGridViewServiceLibrary = new System.Windows.Forms.DataGridView();
            this.tabPageSubjectLibrary = new System.Windows.Forms.TabPage();
            this.textBoxInventoryQuantity = new System.Windows.Forms.TextBox();
            this.buttonDeleteToolInventory = new System.Windows.Forms.Button();
            this.buttonEditToolInventory = new System.Windows.Forms.Button();
            this.buttonAddToolInventory = new System.Windows.Forms.Button();
            this.labelInventoryService = new System.Windows.Forms.Label();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.tabPageTransactionManagement = new System.Windows.Forms.TabPage();
            this.labelPayedPayments = new System.Windows.Forms.Label();
            this.labelPendingPayments = new System.Windows.Forms.Label();
            this.dataGridViewPayedBilling = new System.Windows.Forms.DataGridView();
            this.buttonPaid = new System.Windows.Forms.Button();
            this.dataGridViewPendingBilling = new System.Windows.Forms.DataGridView();
            this.tabPageSession = new System.Windows.Forms.TabPage();
            this.dataGridViewWeeklySchedule = new System.Windows.Forms.DataGridView();
            this.comboBoxExpertise = new System.Windows.Forms.ComboBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageEnroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabPagTutorRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceLibrary)).BeginInit();
            this.tabPageSubjectLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.tabPageTransactionManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayedBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingBilling)).BeginInit();
            this.tabPageSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklySchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEnroll);
            this.tabControlMain.Controls.Add(this.tabPagTutorRegistration);
            this.tabControlMain.Controls.Add(this.tabPageSubjectLibrary);
            this.tabControlMain.Controls.Add(this.tabPageTransactionManagement);
            this.tabControlMain.Controls.Add(this.tabPageSession);
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
            this.tabPageEnroll.Controls.Add(this.checkedListBoxSubjects);
            this.tabPageEnroll.Controls.Add(this.buttonUpdate);
            this.tabPageEnroll.Controls.Add(this.buttonClientDelete);
            this.tabPageEnroll.Controls.Add(this.buttonEnrollStudent);
            this.tabPageEnroll.Controls.Add(this.labelStudentEmail);
            this.tabPageEnroll.Controls.Add(this.labelStudentName);
            this.tabPageEnroll.Controls.Add(this.TextBox_StudentEmail);
            this.tabPageEnroll.Controls.Add(this.TextBox_StudentName);
            this.tabPageEnroll.Controls.Add(this.dataGridViewClients);
            this.tabPageEnroll.Location = new System.Drawing.Point(4, 25);
            this.tabPageEnroll.Name = "tabPageEnroll";
            this.tabPageEnroll.Size = new System.Drawing.Size(997, 520);
            this.tabPageEnroll.TabIndex = 2;
            this.tabPageEnroll.Text = "Student Enrollment";
            this.tabPageEnroll.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxSubjects
            // 
            this.checkedListBoxSubjects.FormattingEnabled = true;
            this.checkedListBoxSubjects.Location = new System.Drawing.Point(379, 191);
            this.checkedListBoxSubjects.Name = "checkedListBoxSubjects";
            this.checkedListBoxSubjects.Size = new System.Drawing.Size(441, 202);
            this.checkedListBoxSubjects.TabIndex = 13;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(677, 441);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(143, 38);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonClientDelete
            // 
            this.buttonClientDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientDelete.Location = new System.Drawing.Point(528, 441);
            this.buttonClientDelete.Name = "buttonClientDelete";
            this.buttonClientDelete.Size = new System.Drawing.Size(143, 38);
            this.buttonClientDelete.TabIndex = 11;
            this.buttonClientDelete.Text = "Delete";
            this.buttonClientDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEnrollStudent
            // 
            this.buttonEnrollStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnrollStudent.Location = new System.Drawing.Point(379, 441);
            this.buttonEnrollStudent.Name = "buttonEnrollStudent";
            this.buttonEnrollStudent.Size = new System.Drawing.Size(143, 38);
            this.buttonEnrollStudent.TabIndex = 9;
            this.buttonEnrollStudent.Text = "Add";
            this.buttonEnrollStudent.UseVisualStyleBackColor = true;
            this.buttonEnrollStudent.Click += new System.EventHandler(this.buttonEnrollStudent_Click);
            // 
            // labelStudentEmail
            // 
            this.labelStudentEmail.AutoSize = true;
            this.labelStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentEmail.Location = new System.Drawing.Point(374, 110);
            this.labelStudentEmail.Name = "labelStudentEmail";
            this.labelStudentEmail.Size = new System.Drawing.Size(73, 25);
            this.labelStudentEmail.TabIndex = 6;
            this.labelStudentEmail.Text = "E-Mail";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentName.Location = new System.Drawing.Point(374, 32);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(148, 25);
            this.labelStudentName.TabIndex = 5;
            this.labelStudentName.Text = "Student Name";
            // 
            // TextBox_StudentEmail
            // 
            this.TextBox_StudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_StudentEmail.Location = new System.Drawing.Point(379, 138);
            this.TextBox_StudentEmail.Name = "TextBox_StudentEmail";
            this.TextBox_StudentEmail.Size = new System.Drawing.Size(441, 31);
            this.TextBox_StudentEmail.TabIndex = 2;
            // 
            // TextBox_StudentName
            // 
            this.TextBox_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_StudentName.Location = new System.Drawing.Point(379, 60);
            this.TextBox_StudentName.Name = "TextBox_StudentName";
            this.TextBox_StudentName.Size = new System.Drawing.Size(441, 31);
            this.TextBox_StudentName.TabIndex = 1;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AllowUserToResizeColumns = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewClients.Location = new System.Drawing.Point(24, 27);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.ShowEditingIcon = false;
            this.dataGridViewClients.Size = new System.Drawing.Size(338, 468);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // tabPagTutorRegistration
            // 
            this.tabPagTutorRegistration.Controls.Add(this.comboBoxExpertise);
            this.tabPagTutorRegistration.Controls.Add(this.labelExpertise);
            this.tabPagTutorRegistration.Controls.Add(this.textBoxServiceLib);
            this.tabPagTutorRegistration.Controls.Add(this.textBoxTutorHourlyRate);
            this.tabPagTutorRegistration.Controls.Add(this.labelHourlyRate);
            this.tabPagTutorRegistration.Controls.Add(this.label5);
            this.tabPagTutorRegistration.Controls.Add(this.buttonDeleteLibItem);
            this.tabPagTutorRegistration.Controls.Add(this.buttonRegisterTutor);
            this.tabPagTutorRegistration.Controls.Add(this.dataGridViewServiceLibrary);
            this.tabPagTutorRegistration.Location = new System.Drawing.Point(4, 25);
            this.tabPagTutorRegistration.Name = "tabPagTutorRegistration";
            this.tabPagTutorRegistration.Size = new System.Drawing.Size(997, 520);
            this.tabPagTutorRegistration.TabIndex = 3;
            this.tabPagTutorRegistration.Text = "Tutor Registration";
            this.tabPagTutorRegistration.UseVisualStyleBackColor = true;
            // 
            // labelExpertise
            // 
            this.labelExpertise.AutoSize = true;
            this.labelExpertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpertise.Location = new System.Drawing.Point(34, 196);
            this.labelExpertise.Name = "labelExpertise";
            this.labelExpertise.Size = new System.Drawing.Size(102, 25);
            this.labelExpertise.TabIndex = 28;
            this.labelExpertise.Text = "Expertise";
            // 
            // textBoxServiceLib
            // 
            this.textBoxServiceLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServiceLib.Location = new System.Drawing.Point(37, 122);
            this.textBoxServiceLib.Name = "textBoxServiceLib";
            this.textBoxServiceLib.Size = new System.Drawing.Size(362, 31);
            this.textBoxServiceLib.TabIndex = 26;
            // 
            // textBoxTutorHourlyRate
            // 
            this.textBoxTutorHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTutorHourlyRate.Location = new System.Drawing.Point(37, 329);
            this.textBoxTutorHourlyRate.Name = "textBoxTutorHourlyRate";
            this.textBoxTutorHourlyRate.Size = new System.Drawing.Size(362, 31);
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
            this.label5.Location = new System.Drawing.Point(32, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tutor Name";
            // 
            // buttonDeleteLibItem
            // 
            this.buttonDeleteLibItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteLibItem.Location = new System.Drawing.Point(234, 400);
            this.buttonDeleteLibItem.Name = "buttonDeleteLibItem";
            this.buttonDeleteLibItem.Size = new System.Drawing.Size(165, 41);
            this.buttonDeleteLibItem.TabIndex = 14;
            this.buttonDeleteLibItem.Text = "Delete";
            this.buttonDeleteLibItem.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterTutor
            // 
            this.buttonRegisterTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterTutor.Location = new System.Drawing.Point(39, 400);
            this.buttonRegisterTutor.Name = "buttonRegisterTutor";
            this.buttonRegisterTutor.Size = new System.Drawing.Size(165, 41);
            this.buttonRegisterTutor.TabIndex = 12;
            this.buttonRegisterTutor.Text = "Register";
            this.buttonRegisterTutor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewServiceLibrary
            // 
            this.dataGridViewServiceLibrary.AllowUserToAddRows = false;
            this.dataGridViewServiceLibrary.AllowUserToDeleteRows = false;
            this.dataGridViewServiceLibrary.AllowUserToResizeColumns = false;
            this.dataGridViewServiceLibrary.AllowUserToResizeRows = false;
            this.dataGridViewServiceLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServiceLibrary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewServiceLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiceLibrary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewServiceLibrary.Location = new System.Drawing.Point(587, 26);
            this.dataGridViewServiceLibrary.Name = "dataGridViewServiceLibrary";
            this.dataGridViewServiceLibrary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewServiceLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServiceLibrary.ShowEditingIcon = false;
            this.dataGridViewServiceLibrary.ShowRowErrors = false;
            this.dataGridViewServiceLibrary.Size = new System.Drawing.Size(379, 460);
            this.dataGridViewServiceLibrary.TabIndex = 0;
            // 
            // tabPageSubjectLibrary
            // 
            this.tabPageSubjectLibrary.Controls.Add(this.textBoxInventoryQuantity);
            this.tabPageSubjectLibrary.Controls.Add(this.buttonDeleteToolInventory);
            this.tabPageSubjectLibrary.Controls.Add(this.buttonEditToolInventory);
            this.tabPageSubjectLibrary.Controls.Add(this.buttonAddToolInventory);
            this.tabPageSubjectLibrary.Controls.Add(this.labelInventoryService);
            this.tabPageSubjectLibrary.Controls.Add(this.dataGridViewInventory);
            this.tabPageSubjectLibrary.Location = new System.Drawing.Point(4, 25);
            this.tabPageSubjectLibrary.Name = "tabPageSubjectLibrary";
            this.tabPageSubjectLibrary.Size = new System.Drawing.Size(997, 520);
            this.tabPageSubjectLibrary.TabIndex = 6;
            this.tabPageSubjectLibrary.Text = "Subjects Library";
            this.tabPageSubjectLibrary.UseVisualStyleBackColor = true;
            // 
            // textBoxInventoryQuantity
            // 
            this.textBoxInventoryQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInventoryQuantity.Location = new System.Drawing.Point(69, 183);
            this.textBoxInventoryQuantity.Name = "textBoxInventoryQuantity";
            this.textBoxInventoryQuantity.Size = new System.Drawing.Size(345, 31);
            this.textBoxInventoryQuantity.TabIndex = 29;
            // 
            // buttonDeleteToolInventory
            // 
            this.buttonDeleteToolInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteToolInventory.Location = new System.Drawing.Point(303, 272);
            this.buttonDeleteToolInventory.Name = "buttonDeleteToolInventory";
            this.buttonDeleteToolInventory.Size = new System.Drawing.Size(111, 37);
            this.buttonDeleteToolInventory.TabIndex = 28;
            this.buttonDeleteToolInventory.Text = "Delete";
            this.buttonDeleteToolInventory.UseVisualStyleBackColor = true;
            // 
            // buttonEditToolInventory
            // 
            this.buttonEditToolInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditToolInventory.Location = new System.Drawing.Point(186, 272);
            this.buttonEditToolInventory.Name = "buttonEditToolInventory";
            this.buttonEditToolInventory.Size = new System.Drawing.Size(111, 37);
            this.buttonEditToolInventory.TabIndex = 27;
            this.buttonEditToolInventory.Text = "Update";
            this.buttonEditToolInventory.UseVisualStyleBackColor = true;
            // 
            // buttonAddToolInventory
            // 
            this.buttonAddToolInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToolInventory.Location = new System.Drawing.Point(69, 272);
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
            this.labelInventoryService.Location = new System.Drawing.Point(64, 155);
            this.labelInventoryService.Name = "labelInventoryService";
            this.labelInventoryService.Size = new System.Drawing.Size(84, 25);
            this.labelInventoryService.TabIndex = 24;
            this.labelInventoryService.Text = "Subject";
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.AllowUserToResizeColumns = false;
            this.dataGridViewInventory.AllowUserToResizeRows = false;
            this.dataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewInventory.Location = new System.Drawing.Point(502, 20);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInventory.Size = new System.Drawing.Size(472, 474);
            this.dataGridViewInventory.TabIndex = 23;
            // 
            // tabPageTransactionManagement
            // 
            this.tabPageTransactionManagement.Controls.Add(this.labelPayedPayments);
            this.tabPageTransactionManagement.Controls.Add(this.labelPendingPayments);
            this.tabPageTransactionManagement.Controls.Add(this.dataGridViewPayedBilling);
            this.tabPageTransactionManagement.Controls.Add(this.buttonPaid);
            this.tabPageTransactionManagement.Controls.Add(this.dataGridViewPendingBilling);
            this.tabPageTransactionManagement.Location = new System.Drawing.Point(4, 25);
            this.tabPageTransactionManagement.Name = "tabPageTransactionManagement";
            this.tabPageTransactionManagement.Size = new System.Drawing.Size(997, 520);
            this.tabPageTransactionManagement.TabIndex = 4;
            this.tabPageTransactionManagement.Text = "Transaction Management";
            this.tabPageTransactionManagement.UseVisualStyleBackColor = true;
            // 
            // labelPayedPayments
            // 
            this.labelPayedPayments.AutoSize = true;
            this.labelPayedPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayedPayments.Location = new System.Drawing.Point(26, 248);
            this.labelPayedPayments.Name = "labelPayedPayments";
            this.labelPayedPayments.Size = new System.Drawing.Size(174, 25);
            this.labelPayedPayments.TabIndex = 4;
            this.labelPayedPayments.Text = "Payed Payments";
            // 
            // labelPendingPayments
            // 
            this.labelPendingPayments.AutoSize = true;
            this.labelPendingPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendingPayments.Location = new System.Drawing.Point(26, 23);
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
            this.dataGridViewPayedBilling.Location = new System.Drawing.Point(19, 276);
            this.dataGridViewPayedBilling.Name = "dataGridViewPayedBilling";
            this.dataGridViewPayedBilling.ReadOnly = true;
            this.dataGridViewPayedBilling.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPayedBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPayedBilling.ShowEditingIcon = false;
            this.dataGridViewPayedBilling.Size = new System.Drawing.Size(950, 184);
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
            this.dataGridViewPendingBilling.Location = new System.Drawing.Point(19, 51);
            this.dataGridViewPendingBilling.Name = "dataGridViewPendingBilling";
            this.dataGridViewPendingBilling.ReadOnly = true;
            this.dataGridViewPendingBilling.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPendingBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPendingBilling.ShowEditingIcon = false;
            this.dataGridViewPendingBilling.Size = new System.Drawing.Size(950, 184);
            this.dataGridViewPendingBilling.TabIndex = 0;
            // 
            // tabPageSession
            // 
            this.tabPageSession.Controls.Add(this.dataGridViewWeeklySchedule);
            this.tabPageSession.Location = new System.Drawing.Point(4, 25);
            this.tabPageSession.Name = "tabPageSession";
            this.tabPageSession.Size = new System.Drawing.Size(997, 520);
            this.tabPageSession.TabIndex = 5;
            this.tabPageSession.Text = "Session";
            this.tabPageSession.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWeeklySchedule
            // 
            this.dataGridViewWeeklySchedule.AllowUserToAddRows = false;
            this.dataGridViewWeeklySchedule.AllowUserToDeleteRows = false;
            this.dataGridViewWeeklySchedule.AllowUserToResizeColumns = false;
            this.dataGridViewWeeklySchedule.AllowUserToResizeRows = false;
            this.dataGridViewWeeklySchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWeeklySchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewWeeklySchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeeklySchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewWeeklySchedule.Location = new System.Drawing.Point(18, 19);
            this.dataGridViewWeeklySchedule.Name = "dataGridViewWeeklySchedule";
            this.dataGridViewWeeklySchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewWeeklySchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWeeklySchedule.ShowEditingIcon = false;
            this.dataGridViewWeeklySchedule.Size = new System.Drawing.Size(813, 471);
            this.dataGridViewWeeklySchedule.TabIndex = 1;
            // 
            // comboBoxExpertise
            // 
            this.comboBoxExpertise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExpertise.FormattingEnabled = true;
            this.comboBoxExpertise.Location = new System.Drawing.Point(37, 224);
            this.comboBoxExpertise.Name = "comboBoxExpertise";
            this.comboBoxExpertise.Size = new System.Drawing.Size(362, 33);
            this.comboBoxExpertise.TabIndex = 29;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 549);
            this.Controls.Add(this.tabControlMain);
            this.Name = "mainForm";
            this.Text = "Bienvenido Online Tutoring Service";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEnroll.ResumeLayout(false);
            this.tabPageEnroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabPagTutorRegistration.ResumeLayout(false);
            this.tabPagTutorRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceLibrary)).EndInit();
            this.tabPageSubjectLibrary.ResumeLayout(false);
            this.tabPageSubjectLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.tabPageTransactionManagement.ResumeLayout(false);
            this.tabPageTransactionManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayedBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingBilling)).EndInit();
            this.tabPageSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklySchedule)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.TabPage tabPagTutorRegistration;
        private System.Windows.Forms.TextBox textBoxServiceLib;
        private System.Windows.Forms.TextBox textBoxTutorHourlyRate;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDeleteLibItem;
        private System.Windows.Forms.Button buttonRegisterTutor;
        private System.Windows.Forms.DataGridView dataGridViewServiceLibrary;
        private System.Windows.Forms.TabPage tabPageSubjectLibrary;
        private System.Windows.Forms.TextBox textBoxInventoryQuantity;
        private System.Windows.Forms.Button buttonDeleteToolInventory;
        private System.Windows.Forms.Button buttonEditToolInventory;
        private System.Windows.Forms.Button buttonAddToolInventory;
        private System.Windows.Forms.Label labelInventoryService;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.TabPage tabPageTransactionManagement;
        private System.Windows.Forms.Label labelPayedPayments;
        private System.Windows.Forms.Label labelPendingPayments;
        private System.Windows.Forms.DataGridView dataGridViewPayedBilling;
        private System.Windows.Forms.Button buttonPaid;
        private System.Windows.Forms.DataGridView dataGridViewPendingBilling;
        private System.Windows.Forms.TabPage tabPageSession;
        private System.Windows.Forms.DataGridView dataGridViewWeeklySchedule;
        private System.Windows.Forms.Label labelExpertise;
        private System.Windows.Forms.CheckedListBox checkedListBoxSubjects;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClientDelete;
        private System.Windows.Forms.ComboBox comboBoxExpertise;
    }
}