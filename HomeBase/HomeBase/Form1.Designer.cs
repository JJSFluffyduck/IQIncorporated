namespace HomeBase
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.jobDescriptionLbl = new System.Windows.Forms.Label();
            this.jobLocationLbl = new System.Windows.Forms.Label();
            this.jobDateLbl = new System.Windows.Forms.Label();
            this.jobTimeLbl = new System.Windows.Forms.Label();
            this.jobPrioritylbl = new System.Windows.Forms.Label();
            this.jobDateBox = new System.Windows.Forms.DateTimePicker();
            this.jobDescriptionBox = new System.Windows.Forms.TextBox();
            this.JobLocationBox = new System.Windows.Forms.TextBox();
            this.jobTimeBox = new System.Windows.Forms.TextBox();
            this.jobSaveBtn = new System.Windows.Forms.Button();
            this.jobClearBtn = new System.Windows.Forms.Button();
            this.jobDataGridView1 = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileassignment3DataSet = new HomeBase.agileassignment3DataSet();
            this.jobPriorityBox = new System.Windows.Forms.ComboBox();
            this.tableTableAdapter = new HomeBase.agileassignment3DataSetTableAdapters.TableTableAdapter();
            this.jobLbl = new System.Windows.Forms.Label();
            this.clientLbl = new System.Windows.Forms.Label();
            this.contractorLbl = new System.Windows.Forms.Label();
            this.clientFirstNameBox = new System.Windows.Forms.TextBox();
            this.clientFirstNameLbl = new System.Windows.Forms.Label();
            this.clientLastNameBox = new System.Windows.Forms.TextBox();
            this.clientAddressBox = new System.Windows.Forms.TextBox();
            this.clientLandLineBox = new System.Windows.Forms.TextBox();
            this.clientMobileBox = new System.Windows.Forms.TextBox();
            this.clientBuisinessNameBox = new System.Windows.Forms.TextBox();
            this.clientEmailBox = new System.Windows.Forms.TextBox();
            this.clientLastNameLbl = new System.Windows.Forms.Label();
            this.clientAddressLbl = new System.Windows.Forms.Label();
            this.clientLandLineLbl = new System.Windows.Forms.Label();
            this.clientMobilelbl = new System.Windows.Forms.Label();
            this.clientBuisinessNameLbl = new System.Windows.Forms.Label();
            this.clientEmailLbl = new System.Windows.Forms.Label();
            this.clientSavebtn = new System.Windows.Forms.Button();
            this.clientClearBtn = new System.Windows.Forms.Button();
            this.contractorClearBtn = new System.Windows.Forms.Button();
            this.contractorSaveBtn = new System.Windows.Forms.Button();
            this.contractorEmailLbl = new System.Windows.Forms.Label();
            this.contractorEmployeeIdLbl = new System.Windows.Forms.Label();
            this.contractorMobileLbl = new System.Windows.Forms.Label();
            this.contractorLandLineLbl = new System.Windows.Forms.Label();
            this.contractorAddressLbl = new System.Windows.Forms.Label();
            this.contractorLastNameLbl = new System.Windows.Forms.Label();
            this.contractorEmailBox = new System.Windows.Forms.TextBox();
            this.contractorEmployeeIdBox = new System.Windows.Forms.TextBox();
            this.contractorMobileBox = new System.Windows.Forms.TextBox();
            this.contractorLandLineBox = new System.Windows.Forms.TextBox();
            this.contractorAddressBox = new System.Windows.Forms.TextBox();
            this.contractorLastNameBox = new System.Windows.Forms.TextBox();
            this.contractorFirstNameLbl = new System.Windows.Forms.Label();
            this.contractorFirstNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileassignment3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe Script", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(154, 773);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 42);
            this.Title.TabIndex = 0;
            // 
            // jobDescriptionLbl
            // 
            this.jobDescriptionLbl.AutoSize = true;
            this.jobDescriptionLbl.Location = new System.Drawing.Point(28, 609);
            this.jobDescriptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobDescriptionLbl.Name = "jobDescriptionLbl";
            this.jobDescriptionLbl.Size = new System.Drawing.Size(79, 17);
            this.jobDescriptionLbl.TabIndex = 1;
            this.jobDescriptionLbl.Text = "Description";
            // 
            // jobLocationLbl
            // 
            this.jobLocationLbl.AutoSize = true;
            this.jobLocationLbl.Location = new System.Drawing.Point(28, 708);
            this.jobLocationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobLocationLbl.Name = "jobLocationLbl";
            this.jobLocationLbl.Size = new System.Drawing.Size(62, 17);
            this.jobLocationLbl.TabIndex = 2;
            this.jobLocationLbl.Text = "Location";
            // 
            // jobDateLbl
            // 
            this.jobDateLbl.AutoSize = true;
            this.jobDateLbl.Location = new System.Drawing.Point(28, 749);
            this.jobDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobDateLbl.Name = "jobDateLbl";
            this.jobDateLbl.Size = new System.Drawing.Size(38, 17);
            this.jobDateLbl.TabIndex = 3;
            this.jobDateLbl.Text = "Date";
            // 
            // jobTimeLbl
            // 
            this.jobTimeLbl.AutoSize = true;
            this.jobTimeLbl.Location = new System.Drawing.Point(28, 781);
            this.jobTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobTimeLbl.Name = "jobTimeLbl";
            this.jobTimeLbl.Size = new System.Drawing.Size(39, 17);
            this.jobTimeLbl.TabIndex = 4;
            this.jobTimeLbl.Text = "Time";
            // 
            // jobPrioritylbl
            // 
            this.jobPrioritylbl.AutoSize = true;
            this.jobPrioritylbl.Location = new System.Drawing.Point(28, 817);
            this.jobPrioritylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobPrioritylbl.Name = "jobPrioritylbl";
            this.jobPrioritylbl.Size = new System.Drawing.Size(52, 17);
            this.jobPrioritylbl.TabIndex = 5;
            this.jobPrioritylbl.Text = "Priority";
            // 
            // jobDateBox
            // 
            this.jobDateBox.Location = new System.Drawing.Point(131, 741);
            this.jobDateBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobDateBox.Name = "jobDateBox";
            this.jobDateBox.Size = new System.Drawing.Size(265, 22);
            this.jobDateBox.TabIndex = 7;
            // 
            // jobDescriptionBox
            // 
            this.jobDescriptionBox.Location = new System.Drawing.Point(131, 605);
            this.jobDescriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobDescriptionBox.Multiline = true;
            this.jobDescriptionBox.Name = "jobDescriptionBox";
            this.jobDescriptionBox.Size = new System.Drawing.Size(265, 89);
            this.jobDescriptionBox.TabIndex = 8;
            // 
            // JobLocationBox
            // 
            this.JobLocationBox.Location = new System.Drawing.Point(131, 704);
            this.JobLocationBox.Margin = new System.Windows.Forms.Padding(4);
            this.JobLocationBox.Name = "JobLocationBox";
            this.JobLocationBox.Size = new System.Drawing.Size(265, 22);
            this.JobLocationBox.TabIndex = 9;
            // 
            // jobTimeBox
            // 
            this.jobTimeBox.Location = new System.Drawing.Point(131, 777);
            this.jobTimeBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobTimeBox.Name = "jobTimeBox";
            this.jobTimeBox.Size = new System.Drawing.Size(265, 22);
            this.jobTimeBox.TabIndex = 10;
            // 
            // jobSaveBtn
            // 
            this.jobSaveBtn.Location = new System.Drawing.Point(131, 848);
            this.jobSaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.jobSaveBtn.Name = "jobSaveBtn";
            this.jobSaveBtn.Size = new System.Drawing.Size(100, 31);
            this.jobSaveBtn.TabIndex = 12;
            this.jobSaveBtn.Text = "Save";
            this.jobSaveBtn.UseVisualStyleBackColor = true;
            this.jobSaveBtn.Click += new System.EventHandler(this.save_Click);
            // 
            // jobClearBtn
            // 
            this.jobClearBtn.Location = new System.Drawing.Point(276, 848);
            this.jobClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.jobClearBtn.Name = "jobClearBtn";
            this.jobClearBtn.Size = new System.Drawing.Size(100, 31);
            this.jobClearBtn.TabIndex = 13;
            this.jobClearBtn.Text = "Clear";
            this.jobClearBtn.UseVisualStyleBackColor = true;
            this.jobClearBtn.Click += new System.EventHandler(this.clear_Click);
            // 
            // jobDataGridView1
            // 
            this.jobDataGridView1.AllowUserToAddRows = false;
            this.jobDataGridView1.AllowUserToDeleteRows = false;
            this.jobDataGridView1.AutoGenerateColumns = false;
            this.jobDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn});
            this.jobDataGridView1.DataSource = this.tableBindingSource;
            this.jobDataGridView1.Location = new System.Drawing.Point(406, 609);
            this.jobDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.jobDataGridView1.Name = "jobDataGridView1";
            this.jobDataGridView1.ReadOnly = true;
            this.jobDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.jobDataGridView1.RowTemplate.Height = 23;
            this.jobDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobDataGridView1.Size = new System.Drawing.Size(725, 200);
            this.jobDataGridView1.TabIndex = 14;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.agileassignment3DataSet;
            // 
            // agileassignment3DataSet
            // 
            this.agileassignment3DataSet.DataSetName = "agileassignment3DataSet";
            this.agileassignment3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobPriorityBox
            // 
            this.jobPriorityBox.FormattingEnabled = true;
            this.jobPriorityBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.jobPriorityBox.Location = new System.Drawing.Point(131, 813);
            this.jobPriorityBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobPriorityBox.Name = "jobPriorityBox";
            this.jobPriorityBox.Size = new System.Drawing.Size(160, 24);
            this.jobPriorityBox.TabIndex = 15;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // jobLbl
            // 
            this.jobLbl.AutoSize = true;
            this.jobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLbl.Location = new System.Drawing.Point(24, 543);
            this.jobLbl.Name = "jobLbl";
            this.jobLbl.Size = new System.Drawing.Size(81, 39);
            this.jobLbl.TabIndex = 16;
            this.jobLbl.Text = "Job:";
            this.jobLbl.Click += new System.EventHandler(this.jobLbl_Click);
            // 
            // clientLbl
            // 
            this.clientLbl.AutoSize = true;
            this.clientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLbl.Location = new System.Drawing.Point(24, 39);
            this.clientLbl.Name = "clientLbl";
            this.clientLbl.Size = new System.Drawing.Size(114, 39);
            this.clientLbl.TabIndex = 17;
            this.clientLbl.Text = "Client:";
            this.clientLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // contractorLbl
            // 
            this.contractorLbl.AutoSize = true;
            this.contractorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorLbl.Location = new System.Drawing.Point(24, 281);
            this.contractorLbl.Name = "contractorLbl";
            this.contractorLbl.Size = new System.Drawing.Size(175, 39);
            this.contractorLbl.TabIndex = 18;
            this.contractorLbl.Text = "Contractor";
            // 
            // clientFirstNameBox
            // 
            this.clientFirstNameBox.Location = new System.Drawing.Point(131, 104);
            this.clientFirstNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientFirstNameBox.Name = "clientFirstNameBox";
            this.clientFirstNameBox.Size = new System.Drawing.Size(265, 22);
            this.clientFirstNameBox.TabIndex = 19;
            // 
            // clientFirstNameLbl
            // 
            this.clientFirstNameLbl.AutoSize = true;
            this.clientFirstNameLbl.Location = new System.Drawing.Point(28, 104);
            this.clientFirstNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientFirstNameLbl.Name = "clientFirstNameLbl";
            this.clientFirstNameLbl.Size = new System.Drawing.Size(76, 17);
            this.clientFirstNameLbl.TabIndex = 20;
            this.clientFirstNameLbl.Text = "First Name";
            // 
            // clientLastNameBox
            // 
            this.clientLastNameBox.Location = new System.Drawing.Point(131, 150);
            this.clientLastNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientLastNameBox.Name = "clientLastNameBox";
            this.clientLastNameBox.Size = new System.Drawing.Size(265, 22);
            this.clientLastNameBox.TabIndex = 21;
            // 
            // clientAddressBox
            // 
            this.clientAddressBox.Location = new System.Drawing.Point(131, 196);
            this.clientAddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientAddressBox.Name = "clientAddressBox";
            this.clientAddressBox.Size = new System.Drawing.Size(265, 22);
            this.clientAddressBox.TabIndex = 22;
            // 
            // clientLandLineBox
            // 
            this.clientLandLineBox.Location = new System.Drawing.Point(131, 241);
            this.clientLandLineBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientLandLineBox.Name = "clientLandLineBox";
            this.clientLandLineBox.Size = new System.Drawing.Size(265, 22);
            this.clientLandLineBox.TabIndex = 23;
            // 
            // clientMobileBox
            // 
            this.clientMobileBox.Location = new System.Drawing.Point(679, 104);
            this.clientMobileBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientMobileBox.Name = "clientMobileBox";
            this.clientMobileBox.Size = new System.Drawing.Size(265, 22);
            this.clientMobileBox.TabIndex = 24;
            // 
            // clientBuisinessNameBox
            // 
            this.clientBuisinessNameBox.Location = new System.Drawing.Point(679, 150);
            this.clientBuisinessNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientBuisinessNameBox.Name = "clientBuisinessNameBox";
            this.clientBuisinessNameBox.Size = new System.Drawing.Size(265, 22);
            this.clientBuisinessNameBox.TabIndex = 25;
            // 
            // clientEmailBox
            // 
            this.clientEmailBox.Location = new System.Drawing.Point(679, 196);
            this.clientEmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientEmailBox.Name = "clientEmailBox";
            this.clientEmailBox.Size = new System.Drawing.Size(265, 22);
            this.clientEmailBox.TabIndex = 26;
            // 
            // clientLastNameLbl
            // 
            this.clientLastNameLbl.AutoSize = true;
            this.clientLastNameLbl.Location = new System.Drawing.Point(28, 150);
            this.clientLastNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientLastNameLbl.Name = "clientLastNameLbl";
            this.clientLastNameLbl.Size = new System.Drawing.Size(76, 17);
            this.clientLastNameLbl.TabIndex = 27;
            this.clientLastNameLbl.Text = "Last Name";
            // 
            // clientAddressLbl
            // 
            this.clientAddressLbl.AutoSize = true;
            this.clientAddressLbl.Location = new System.Drawing.Point(28, 196);
            this.clientAddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientAddressLbl.Name = "clientAddressLbl";
            this.clientAddressLbl.Size = new System.Drawing.Size(60, 17);
            this.clientAddressLbl.TabIndex = 28;
            this.clientAddressLbl.Text = "Address";
            // 
            // clientLandLineLbl
            // 
            this.clientLandLineLbl.AutoSize = true;
            this.clientLandLineLbl.Location = new System.Drawing.Point(28, 246);
            this.clientLandLineLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientLandLineLbl.Name = "clientLandLineLbl";
            this.clientLandLineLbl.Size = new System.Drawing.Size(83, 17);
            this.clientLandLineLbl.TabIndex = 29;
            this.clientLandLineLbl.Text = "Land Line #";
            // 
            // clientMobilelbl
            // 
            this.clientMobilelbl.AutoSize = true;
            this.clientMobilelbl.Location = new System.Drawing.Point(567, 104);
            this.clientMobilelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientMobilelbl.Name = "clientMobilelbl";
            this.clientMobilelbl.Size = new System.Drawing.Size(61, 17);
            this.clientMobilelbl.TabIndex = 30;
            this.clientMobilelbl.Text = "Mobile #";
            // 
            // clientBuisinessNameLbl
            // 
            this.clientBuisinessNameLbl.AutoSize = true;
            this.clientBuisinessNameLbl.Location = new System.Drawing.Point(567, 153);
            this.clientBuisinessNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientBuisinessNameLbl.Name = "clientBuisinessNameLbl";
            this.clientBuisinessNameLbl.Size = new System.Drawing.Size(109, 17);
            this.clientBuisinessNameLbl.TabIndex = 31;
            this.clientBuisinessNameLbl.Text = "Buisiness Name";
            // 
            // clientEmailLbl
            // 
            this.clientEmailLbl.AutoSize = true;
            this.clientEmailLbl.Location = new System.Drawing.Point(567, 199);
            this.clientEmailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientEmailLbl.Name = "clientEmailLbl";
            this.clientEmailLbl.Size = new System.Drawing.Size(42, 17);
            this.clientEmailLbl.TabIndex = 32;
            this.clientEmailLbl.Text = "Email";
            // 
            // clientSavebtn
            // 
            this.clientSavebtn.Location = new System.Drawing.Point(570, 241);
            this.clientSavebtn.Margin = new System.Windows.Forms.Padding(4);
            this.clientSavebtn.Name = "clientSavebtn";
            this.clientSavebtn.Size = new System.Drawing.Size(100, 31);
            this.clientSavebtn.TabIndex = 33;
            this.clientSavebtn.Text = "Save";
            this.clientSavebtn.UseVisualStyleBackColor = true;
            // 
            // clientClearBtn
            // 
            this.clientClearBtn.Location = new System.Drawing.Point(714, 241);
            this.clientClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clientClearBtn.Name = "clientClearBtn";
            this.clientClearBtn.Size = new System.Drawing.Size(100, 31);
            this.clientClearBtn.TabIndex = 34;
            this.clientClearBtn.Text = "Clear";
            this.clientClearBtn.UseVisualStyleBackColor = true;
            // 
            // contractorClearBtn
            // 
            this.contractorClearBtn.Location = new System.Drawing.Point(721, 471);
            this.contractorClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.contractorClearBtn.Name = "contractorClearBtn";
            this.contractorClearBtn.Size = new System.Drawing.Size(100, 31);
            this.contractorClearBtn.TabIndex = 51;
            this.contractorClearBtn.Text = "Clear";
            this.contractorClearBtn.UseVisualStyleBackColor = true;
            // 
            // contractorSaveBtn
            // 
            this.contractorSaveBtn.Location = new System.Drawing.Point(577, 471);
            this.contractorSaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.contractorSaveBtn.Name = "contractorSaveBtn";
            this.contractorSaveBtn.Size = new System.Drawing.Size(100, 31);
            this.contractorSaveBtn.TabIndex = 50;
            this.contractorSaveBtn.Text = "Save";
            this.contractorSaveBtn.UseVisualStyleBackColor = true;
            // 
            // contractorEmailLbl
            // 
            this.contractorEmailLbl.AutoSize = true;
            this.contractorEmailLbl.Location = new System.Drawing.Point(574, 429);
            this.contractorEmailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractorEmailLbl.Name = "contractorEmailLbl";
            this.contractorEmailLbl.Size = new System.Drawing.Size(42, 17);
            this.contractorEmailLbl.TabIndex = 49;
            this.contractorEmailLbl.Text = "Email";
            // 
            // contractorEmployeeIdLbl
            // 
            this.contractorEmployeeIdLbl.AutoSize = true;
            this.contractorEmployeeIdLbl.Location = new System.Drawing.Point(574, 383);
            this.contractorEmployeeIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractorEmployeeIdLbl.Name = "contractorEmployeeIdLbl";
            this.contractorEmployeeIdLbl.Size = new System.Drawing.Size(87, 17);
            this.contractorEmployeeIdLbl.TabIndex = 48;
            this.contractorEmployeeIdLbl.Text = "Employee ID";
            // 
            // contractorMobileLbl
            // 
            this.contractorMobileLbl.AutoSize = true;
            this.contractorMobileLbl.Location = new System.Drawing.Point(574, 334);
            this.contractorMobileLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractorMobileLbl.Name = "contractorMobileLbl";
            this.contractorMobileLbl.Size = new System.Drawing.Size(61, 17);
            this.contractorMobileLbl.TabIndex = 47;
            this.contractorMobileLbl.Text = "Mobile #";
            // 
            // contractorLandLineLbl
            // 
            this.contractorLandLineLbl.AutoSize = true;
            this.contractorLandLineLbl.Location = new System.Drawing.Point(35, 476);
            this.contractorLandLineLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractorLandLineLbl.Name = "contractorLandLineLbl";
            this.contractorLandLineLbl.Size = new System.Drawing.Size(83, 17);
            this.contractorLandLineLbl.TabIndex = 46;
            this.contractorLandLineLbl.Text = "Land Line #";
            // 
            // contractorAddressLbl
            // 
            this.contractorAddressLbl.AutoSize = true;
            this.contractorAddressLbl.Location = new System.Drawing.Point(35, 426);
            this.contractorAddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractorAddressLbl.Name = "contractorAddressLbl";
            this.contractorAddressLbl.Size = new System.Drawing.Size(60, 17);
            this.contractorAddressLbl.TabIndex = 45;
            this.contractorAddressLbl.Text = "Address";
            // 
            // contractorLastNameLbl
            // 
            this.contractorLastNameLbl.AutoSize = true;
            this.contractorLastNameLbl.Location = new System.Drawing.Point(35, 380);
            this.contractorLastNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractorLastNameLbl.Name = "contractorLastNameLbl";
            this.contractorLastNameLbl.Size = new System.Drawing.Size(76, 17);
            this.contractorLastNameLbl.TabIndex = 44;
            this.contractorLastNameLbl.Text = "Last Name";
            // 
            // contractorEmailBox
            // 
            this.contractorEmailBox.Location = new System.Drawing.Point(686, 426);
            this.contractorEmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractorEmailBox.Name = "contractorEmailBox";
            this.contractorEmailBox.Size = new System.Drawing.Size(265, 22);
            this.contractorEmailBox.TabIndex = 43;
            // 
            // contractorEmployeeIdBox
            // 
            this.contractorEmployeeIdBox.Location = new System.Drawing.Point(686, 380);
            this.contractorEmployeeIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractorEmployeeIdBox.Name = "contractorEmployeeIdBox";
            this.contractorEmployeeIdBox.Size = new System.Drawing.Size(265, 22);
            this.contractorEmployeeIdBox.TabIndex = 42;
            // 
            // contractorMobileBox
            // 
            this.contractorMobileBox.Location = new System.Drawing.Point(686, 334);
            this.contractorMobileBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractorMobileBox.Name = "contractorMobileBox";
            this.contractorMobileBox.Size = new System.Drawing.Size(265, 22);
            this.contractorMobileBox.TabIndex = 41;
            // 
            // contractorLandLineBox
            // 
            this.contractorLandLineBox.Location = new System.Drawing.Point(138, 471);
            this.contractorLandLineBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractorLandLineBox.Name = "contractorLandLineBox";
            this.contractorLandLineBox.Size = new System.Drawing.Size(265, 22);
            this.contractorLandLineBox.TabIndex = 40;
            // 
            // contractorAddressBox
            // 
            this.contractorAddressBox.Location = new System.Drawing.Point(138, 426);
            this.contractorAddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractorAddressBox.Name = "contractorAddressBox";
            this.contractorAddressBox.Size = new System.Drawing.Size(265, 22);
            this.contractorAddressBox.TabIndex = 39;
            // 
            // contractorLastNameBox
            // 
            this.contractorLastNameBox.Location = new System.Drawing.Point(138, 380);
            this.contractorLastNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractorLastNameBox.Name = "contractorLastNameBox";
            this.contractorLastNameBox.Size = new System.Drawing.Size(265, 22);
            this.contractorLastNameBox.TabIndex = 38;
            // 
            // contractorFirstNameLbl
            // 
            this.contractorFirstNameLbl.AutoSize = true;
            this.contractorFirstNameLbl.Location = new System.Drawing.Point(35, 334);
            this.contractorFirstNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractorFirstNameLbl.Name = "contractorFirstNameLbl";
            this.contractorFirstNameLbl.Size = new System.Drawing.Size(76, 17);
            this.contractorFirstNameLbl.TabIndex = 37;
            this.contractorFirstNameLbl.Text = "First Name";
            // 
            // contractorFirstNameBox
            // 
            this.contractorFirstNameBox.Location = new System.Drawing.Point(138, 334);
            this.contractorFirstNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.contractorFirstNameBox.Name = "contractorFirstNameBox";
            this.contractorFirstNameBox.Size = new System.Drawing.Size(265, 22);
            this.contractorFirstNameBox.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 901);
            this.Controls.Add(this.contractorClearBtn);
            this.Controls.Add(this.contractorSaveBtn);
            this.Controls.Add(this.contractorEmailLbl);
            this.Controls.Add(this.contractorEmployeeIdLbl);
            this.Controls.Add(this.contractorMobileLbl);
            this.Controls.Add(this.contractorLandLineLbl);
            this.Controls.Add(this.contractorAddressLbl);
            this.Controls.Add(this.contractorLastNameLbl);
            this.Controls.Add(this.contractorEmailBox);
            this.Controls.Add(this.contractorEmployeeIdBox);
            this.Controls.Add(this.contractorMobileBox);
            this.Controls.Add(this.contractorLandLineBox);
            this.Controls.Add(this.contractorAddressBox);
            this.Controls.Add(this.contractorLastNameBox);
            this.Controls.Add(this.contractorFirstNameLbl);
            this.Controls.Add(this.contractorFirstNameBox);
            this.Controls.Add(this.clientClearBtn);
            this.Controls.Add(this.clientSavebtn);
            this.Controls.Add(this.clientEmailLbl);
            this.Controls.Add(this.clientBuisinessNameLbl);
            this.Controls.Add(this.clientMobilelbl);
            this.Controls.Add(this.clientLandLineLbl);
            this.Controls.Add(this.clientAddressLbl);
            this.Controls.Add(this.clientLastNameLbl);
            this.Controls.Add(this.clientEmailBox);
            this.Controls.Add(this.clientBuisinessNameBox);
            this.Controls.Add(this.clientMobileBox);
            this.Controls.Add(this.clientLandLineBox);
            this.Controls.Add(this.clientAddressBox);
            this.Controls.Add(this.clientLastNameBox);
            this.Controls.Add(this.clientFirstNameLbl);
            this.Controls.Add(this.clientFirstNameBox);
            this.Controls.Add(this.contractorLbl);
            this.Controls.Add(this.clientLbl);
            this.Controls.Add(this.jobLbl);
            this.Controls.Add(this.jobPriorityBox);
            this.Controls.Add(this.jobDataGridView1);
            this.Controls.Add(this.jobClearBtn);
            this.Controls.Add(this.jobSaveBtn);
            this.Controls.Add(this.jobTimeBox);
            this.Controls.Add(this.JobLocationBox);
            this.Controls.Add(this.jobDescriptionBox);
            this.Controls.Add(this.jobDateBox);
            this.Controls.Add(this.jobPrioritylbl);
            this.Controls.Add(this.jobTimeLbl);
            this.Controls.Add(this.jobDateLbl);
            this.Controls.Add(this.jobLocationLbl);
            this.Controls.Add(this.jobDescriptionLbl);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileassignment3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label jobDescriptionLbl;
        private System.Windows.Forms.Label jobLocationLbl;
        private System.Windows.Forms.Label jobDateLbl;
        private System.Windows.Forms.Label jobTimeLbl;
        private System.Windows.Forms.Label jobPrioritylbl;
        private System.Windows.Forms.DateTimePicker jobDateBox;
        private System.Windows.Forms.TextBox jobDescriptionBox;
        private System.Windows.Forms.TextBox JobLocationBox;
        private System.Windows.Forms.TextBox jobTimeBox;
        private System.Windows.Forms.Button jobSaveBtn;
        private System.Windows.Forms.Button jobClearBtn;
        private System.Windows.Forms.DataGridView jobDataGridView1;
        private System.Windows.Forms.ComboBox jobPriorityBox;
        private agileassignment3DataSet agileassignment3DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private agileassignment3DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label jobLbl;
        private System.Windows.Forms.Label clientLbl;
        private System.Windows.Forms.Label contractorLbl;
        private System.Windows.Forms.TextBox clientFirstNameBox;
        private System.Windows.Forms.Label clientFirstNameLbl;
        private System.Windows.Forms.TextBox clientLastNameBox;
        private System.Windows.Forms.TextBox clientAddressBox;
        private System.Windows.Forms.TextBox clientLandLineBox;
        private System.Windows.Forms.TextBox clientMobileBox;
        private System.Windows.Forms.TextBox clientBuisinessNameBox;
        private System.Windows.Forms.TextBox clientEmailBox;
        private System.Windows.Forms.Label clientLastNameLbl;
        private System.Windows.Forms.Label clientAddressLbl;
        private System.Windows.Forms.Label clientLandLineLbl;
        private System.Windows.Forms.Label clientMobilelbl;
        private System.Windows.Forms.Label clientBuisinessNameLbl;
        private System.Windows.Forms.Label clientEmailLbl;
        private System.Windows.Forms.Button clientSavebtn;
        private System.Windows.Forms.Button clientClearBtn;
        private System.Windows.Forms.Button contractorClearBtn;
        private System.Windows.Forms.Button contractorSaveBtn;
        private System.Windows.Forms.Label contractorEmailLbl;
        private System.Windows.Forms.Label contractorEmployeeIdLbl;
        private System.Windows.Forms.Label contractorMobileLbl;
        private System.Windows.Forms.Label contractorLandLineLbl;
        private System.Windows.Forms.Label contractorAddressLbl;
        private System.Windows.Forms.Label contractorLastNameLbl;
        private System.Windows.Forms.TextBox contractorEmailBox;
        private System.Windows.Forms.TextBox contractorEmployeeIdBox;
        private System.Windows.Forms.TextBox contractorMobileBox;
        private System.Windows.Forms.TextBox contractorLandLineBox;
        private System.Windows.Forms.TextBox contractorAddressBox;
        private System.Windows.Forms.TextBox contractorLastNameBox;
        private System.Windows.Forms.Label contractorFirstNameLbl;
        private System.Windows.Forms.TextBox contractorFirstNameBox;
    }
}

