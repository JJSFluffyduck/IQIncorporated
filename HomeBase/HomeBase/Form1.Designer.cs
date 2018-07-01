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
            this.jobPrioritylbl = new System.Windows.Forms.Label();
            this.jobDateBox = new System.Windows.Forms.DateTimePicker();
            this.jobDescriptionBox = new System.Windows.Forms.TextBox();
            this.JobLocationBox = new System.Windows.Forms.TextBox();
            this.jobSaveBtn = new System.Windows.Forms.Button();
            this.jobClearBtn = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agileassignment3DataSet = new HomeBase.agileassignment3DataSet();
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
            this.jobClientEmailLbl = new System.Windows.Forms.Label();
            this.jobContractorEmailLbl = new System.Windows.Forms.Label();
            this.jobClientEmailBox = new System.Windows.Forms.TextBox();
            this.jobContractorEmailBox = new System.Windows.Forms.TextBox();
            this.jobPriorityCbx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jobTimeBox = new System.Windows.Forms.DateTimePicker();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agileassignment3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe Script", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(231, 1208);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 68);
            this.Title.TabIndex = 0;
            // 
            // jobDescriptionLbl
            // 
            this.jobDescriptionLbl.AutoSize = true;
            this.jobDescriptionLbl.Location = new System.Drawing.Point(52, 1098);
            this.jobDescriptionLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobDescriptionLbl.Name = "jobDescriptionLbl";
            this.jobDescriptionLbl.Size = new System.Drawing.Size(120, 25);
            this.jobDescriptionLbl.TabIndex = 1;
            this.jobDescriptionLbl.Text = "Description";
            // 
            // jobLocationLbl
            // 
            this.jobLocationLbl.AutoSize = true;
            this.jobLocationLbl.Location = new System.Drawing.Point(861, 948);
            this.jobLocationLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobLocationLbl.Name = "jobLocationLbl";
            this.jobLocationLbl.Size = new System.Drawing.Size(94, 25);
            this.jobLocationLbl.TabIndex = 2;
            this.jobLocationLbl.Text = "Location";
            // 
            // jobDateLbl
            // 
            this.jobDateLbl.AutoSize = true;
            this.jobDateLbl.Location = new System.Drawing.Point(861, 1055);
            this.jobDateLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobDateLbl.Name = "jobDateLbl";
            this.jobDateLbl.Size = new System.Drawing.Size(57, 25);
            this.jobDateLbl.TabIndex = 3;
            this.jobDateLbl.Text = "Date";
            // 
            // jobPrioritylbl
            // 
            this.jobPrioritylbl.AutoSize = true;
            this.jobPrioritylbl.Location = new System.Drawing.Point(861, 1120);
            this.jobPrioritylbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobPrioritylbl.Name = "jobPrioritylbl";
            this.jobPrioritylbl.Size = new System.Drawing.Size(79, 25);
            this.jobPrioritylbl.TabIndex = 5;
            this.jobPrioritylbl.Text = "Priority";
            // 
            // jobDateBox
            // 
            this.jobDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jobDateBox.Location = new System.Drawing.Point(1029, 1047);
            this.jobDateBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jobDateBox.Name = "jobDateBox";
            this.jobDateBox.Size = new System.Drawing.Size(396, 31);
            this.jobDateBox.TabIndex = 7;
            // 
            // jobDescriptionBox
            // 
            this.jobDescriptionBox.Location = new System.Drawing.Point(232, 1094);
            this.jobDescriptionBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jobDescriptionBox.Multiline = true;
            this.jobDescriptionBox.Name = "jobDescriptionBox";
            this.jobDescriptionBox.Size = new System.Drawing.Size(396, 137);
            this.jobDescriptionBox.TabIndex = 8;
            // 
            // JobLocationBox
            // 
            this.JobLocationBox.Location = new System.Drawing.Point(1029, 944);
            this.JobLocationBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.JobLocationBox.Name = "JobLocationBox";
            this.JobLocationBox.Size = new System.Drawing.Size(396, 31);
            this.JobLocationBox.TabIndex = 9;
            // 
            // jobSaveBtn
            // 
            this.jobSaveBtn.Location = new System.Drawing.Point(864, 1184);
            this.jobSaveBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jobSaveBtn.Name = "jobSaveBtn";
            this.jobSaveBtn.Size = new System.Drawing.Size(150, 48);
            this.jobSaveBtn.TabIndex = 12;
            this.jobSaveBtn.Text = "Save";
            this.jobSaveBtn.UseVisualStyleBackColor = true;
            this.jobSaveBtn.Click += new System.EventHandler(this.save_Click);
            // 
            // jobClearBtn
            // 
            this.jobClearBtn.Location = new System.Drawing.Point(1082, 1184);
            this.jobClearBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jobClearBtn.Name = "jobClearBtn";
            this.jobClearBtn.Size = new System.Drawing.Size(150, 48);
            this.jobClearBtn.TabIndex = 13;
            this.jobClearBtn.Text = "Clear";
            this.jobClearBtn.UseVisualStyleBackColor = true;
            this.jobClearBtn.Click += new System.EventHandler(this.clear_Click);
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
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // jobLbl
            // 
            this.jobLbl.AutoSize = true;
            this.jobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLbl.Location = new System.Drawing.Point(36, 848);
            this.jobLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobLbl.Name = "jobLbl";
            this.jobLbl.Size = new System.Drawing.Size(129, 63);
            this.jobLbl.TabIndex = 16;
            this.jobLbl.Text = "Job:";
            // 
            // clientLbl
            // 
            this.clientLbl.AutoSize = true;
            this.clientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLbl.Location = new System.Drawing.Point(36, 61);
            this.clientLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientLbl.Name = "clientLbl";
            this.clientLbl.Size = new System.Drawing.Size(182, 63);
            this.clientLbl.TabIndex = 17;
            this.clientLbl.Text = "Client:";
            // 
            // contractorLbl
            // 
            this.contractorLbl.AutoSize = true;
            this.contractorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorLbl.Location = new System.Drawing.Point(36, 439);
            this.contractorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contractorLbl.Name = "contractorLbl";
            this.contractorLbl.Size = new System.Drawing.Size(294, 63);
            this.contractorLbl.TabIndex = 18;
            this.contractorLbl.Text = "Contractor:";
            // 
            // clientFirstNameBox
            // 
            this.clientFirstNameBox.Location = new System.Drawing.Point(196, 162);
            this.clientFirstNameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clientFirstNameBox.Name = "clientFirstNameBox";
            this.clientFirstNameBox.Size = new System.Drawing.Size(396, 31);
            this.clientFirstNameBox.TabIndex = 19;
            // 
            // clientFirstNameLbl
            // 
            this.clientFirstNameLbl.AutoSize = true;
            this.clientFirstNameLbl.Location = new System.Drawing.Point(42, 162);
            this.clientFirstNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientFirstNameLbl.Name = "clientFirstNameLbl";
            this.clientFirstNameLbl.Size = new System.Drawing.Size(116, 25);
            this.clientFirstNameLbl.TabIndex = 20;
            this.clientFirstNameLbl.Text = "First Name";
            // 
            // clientLastNameBox
            // 
            this.clientLastNameBox.Location = new System.Drawing.Point(196, 234);
            this.clientLastNameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clientLastNameBox.Name = "clientLastNameBox";
            this.clientLastNameBox.Size = new System.Drawing.Size(396, 31);
            this.clientLastNameBox.TabIndex = 21;
            // 
            // clientAddressBox
            // 
            this.clientAddressBox.Location = new System.Drawing.Point(196, 306);
            this.clientAddressBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clientAddressBox.Name = "clientAddressBox";
            this.clientAddressBox.Size = new System.Drawing.Size(396, 31);
            this.clientAddressBox.TabIndex = 22;
            // 
            // clientLandLineBox
            // 
            this.clientLandLineBox.Location = new System.Drawing.Point(196, 377);
            this.clientLandLineBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clientLandLineBox.Name = "clientLandLineBox";
            this.clientLandLineBox.Size = new System.Drawing.Size(396, 31);
            this.clientLandLineBox.TabIndex = 23;
            this.clientLandLineBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientLandLineBox_KeyPress);
            // 
            // clientMobileBox
            // 
            this.clientMobileBox.Location = new System.Drawing.Point(1018, 162);
            this.clientMobileBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clientMobileBox.Name = "clientMobileBox";
            this.clientMobileBox.Size = new System.Drawing.Size(396, 31);
            this.clientMobileBox.TabIndex = 24;
            this.clientMobileBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientMobileBox_KeyPress);
            // 
            // clientBuisinessNameBox
            // 
            this.clientBuisinessNameBox.Location = new System.Drawing.Point(1018, 234);
            this.clientBuisinessNameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clientBuisinessNameBox.Name = "clientBuisinessNameBox";
            this.clientBuisinessNameBox.Size = new System.Drawing.Size(396, 31);
            this.clientBuisinessNameBox.TabIndex = 25;
            // 
            // clientEmailBox
            // 
            this.clientEmailBox.Location = new System.Drawing.Point(1018, 306);
            this.clientEmailBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clientEmailBox.Name = "clientEmailBox";
            this.clientEmailBox.Size = new System.Drawing.Size(396, 31);
            this.clientEmailBox.TabIndex = 26;
            // 
            // clientLastNameLbl
            // 
            this.clientLastNameLbl.AutoSize = true;
            this.clientLastNameLbl.Location = new System.Drawing.Point(42, 234);
            this.clientLastNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientLastNameLbl.Name = "clientLastNameLbl";
            this.clientLastNameLbl.Size = new System.Drawing.Size(115, 25);
            this.clientLastNameLbl.TabIndex = 27;
            this.clientLastNameLbl.Text = "Last Name";
            // 
            // clientAddressLbl
            // 
            this.clientAddressLbl.AutoSize = true;
            this.clientAddressLbl.Location = new System.Drawing.Point(42, 306);
            this.clientAddressLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientAddressLbl.Name = "clientAddressLbl";
            this.clientAddressLbl.Size = new System.Drawing.Size(91, 25);
            this.clientAddressLbl.TabIndex = 28;
            this.clientAddressLbl.Text = "Address";
            // 
            // clientLandLineLbl
            // 
            this.clientLandLineLbl.AutoSize = true;
            this.clientLandLineLbl.Location = new System.Drawing.Point(42, 384);
            this.clientLandLineLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientLandLineLbl.Name = "clientLandLineLbl";
            this.clientLandLineLbl.Size = new System.Drawing.Size(125, 25);
            this.clientLandLineLbl.TabIndex = 29;
            this.clientLandLineLbl.Text = "Land Line #";
            // 
            // clientMobilelbl
            // 
            this.clientMobilelbl.AutoSize = true;
            this.clientMobilelbl.Location = new System.Drawing.Point(850, 162);
            this.clientMobilelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientMobilelbl.Name = "clientMobilelbl";
            this.clientMobilelbl.Size = new System.Drawing.Size(94, 25);
            this.clientMobilelbl.TabIndex = 30;
            this.clientMobilelbl.Text = "Mobile #";
            // 
            // clientBuisinessNameLbl
            // 
            this.clientBuisinessNameLbl.AutoSize = true;
            this.clientBuisinessNameLbl.Location = new System.Drawing.Point(850, 239);
            this.clientBuisinessNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientBuisinessNameLbl.Name = "clientBuisinessNameLbl";
            this.clientBuisinessNameLbl.Size = new System.Drawing.Size(167, 25);
            this.clientBuisinessNameLbl.TabIndex = 31;
            this.clientBuisinessNameLbl.Text = "Buisiness Name";
            // 
            // clientEmailLbl
            // 
            this.clientEmailLbl.AutoSize = true;
            this.clientEmailLbl.Location = new System.Drawing.Point(850, 311);
            this.clientEmailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientEmailLbl.Name = "clientEmailLbl";
            this.clientEmailLbl.Size = new System.Drawing.Size(65, 25);
            this.clientEmailLbl.TabIndex = 32;
            this.clientEmailLbl.Text = "Email";
            // 
            // clientSavebtn
            // 
            this.clientSavebtn.Location = new System.Drawing.Point(855, 377);
            this.clientSavebtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clientSavebtn.Name = "clientSavebtn";
            this.clientSavebtn.Size = new System.Drawing.Size(150, 48);
            this.clientSavebtn.TabIndex = 33;
            this.clientSavebtn.Text = "Save";
            this.clientSavebtn.UseVisualStyleBackColor = true;
            this.clientSavebtn.Click += new System.EventHandler(this.clientSavebtn_Click);
            // 
            // clientClearBtn
            // 
            this.clientClearBtn.Location = new System.Drawing.Point(1071, 377);
            this.clientClearBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clientClearBtn.Name = "clientClearBtn";
            this.clientClearBtn.Size = new System.Drawing.Size(150, 48);
            this.clientClearBtn.TabIndex = 34;
            this.clientClearBtn.Text = "Clear";
            this.clientClearBtn.UseVisualStyleBackColor = true;
            this.clientClearBtn.Click += new System.EventHandler(this.clientClearBtn_Click);
            // 
            // contractorClearBtn
            // 
            this.contractorClearBtn.Location = new System.Drawing.Point(1082, 736);
            this.contractorClearBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorClearBtn.Name = "contractorClearBtn";
            this.contractorClearBtn.Size = new System.Drawing.Size(150, 48);
            this.contractorClearBtn.TabIndex = 51;
            this.contractorClearBtn.Text = "Clear";
            this.contractorClearBtn.UseVisualStyleBackColor = true;
            this.contractorClearBtn.Click += new System.EventHandler(this.contractorClearBtn_Click);
            // 
            // contractorSaveBtn
            // 
            this.contractorSaveBtn.Location = new System.Drawing.Point(866, 736);
            this.contractorSaveBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorSaveBtn.Name = "contractorSaveBtn";
            this.contractorSaveBtn.Size = new System.Drawing.Size(150, 48);
            this.contractorSaveBtn.TabIndex = 50;
            this.contractorSaveBtn.Text = "Save";
            this.contractorSaveBtn.UseVisualStyleBackColor = true;
            this.contractorSaveBtn.Click += new System.EventHandler(this.contractorSaveBtn_Click);
            // 
            // contractorEmailLbl
            // 
            this.contractorEmailLbl.AutoSize = true;
            this.contractorEmailLbl.Location = new System.Drawing.Point(861, 670);
            this.contractorEmailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contractorEmailLbl.Name = "contractorEmailLbl";
            this.contractorEmailLbl.Size = new System.Drawing.Size(65, 25);
            this.contractorEmailLbl.TabIndex = 49;
            this.contractorEmailLbl.Text = "Email";
            // 
            // contractorEmployeeIdLbl
            // 
            this.contractorEmployeeIdLbl.AutoSize = true;
            this.contractorEmployeeIdLbl.Location = new System.Drawing.Point(861, 598);
            this.contractorEmployeeIdLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contractorEmployeeIdLbl.Name = "contractorEmployeeIdLbl";
            this.contractorEmployeeIdLbl.Size = new System.Drawing.Size(133, 25);
            this.contractorEmployeeIdLbl.TabIndex = 48;
            this.contractorEmployeeIdLbl.Text = "Employee ID";
            // 
            // contractorMobileLbl
            // 
            this.contractorMobileLbl.AutoSize = true;
            this.contractorMobileLbl.Location = new System.Drawing.Point(861, 522);
            this.contractorMobileLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contractorMobileLbl.Name = "contractorMobileLbl";
            this.contractorMobileLbl.Size = new System.Drawing.Size(94, 25);
            this.contractorMobileLbl.TabIndex = 47;
            this.contractorMobileLbl.Text = "Mobile #";
            // 
            // contractorLandLineLbl
            // 
            this.contractorLandLineLbl.AutoSize = true;
            this.contractorLandLineLbl.Location = new System.Drawing.Point(52, 744);
            this.contractorLandLineLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contractorLandLineLbl.Name = "contractorLandLineLbl";
            this.contractorLandLineLbl.Size = new System.Drawing.Size(125, 25);
            this.contractorLandLineLbl.TabIndex = 46;
            this.contractorLandLineLbl.Text = "Land Line #";
            // 
            // contractorAddressLbl
            // 
            this.contractorAddressLbl.AutoSize = true;
            this.contractorAddressLbl.Location = new System.Drawing.Point(52, 666);
            this.contractorAddressLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contractorAddressLbl.Name = "contractorAddressLbl";
            this.contractorAddressLbl.Size = new System.Drawing.Size(91, 25);
            this.contractorAddressLbl.TabIndex = 45;
            this.contractorAddressLbl.Text = "Address";
            // 
            // contractorLastNameLbl
            // 
            this.contractorLastNameLbl.AutoSize = true;
            this.contractorLastNameLbl.Location = new System.Drawing.Point(52, 594);
            this.contractorLastNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contractorLastNameLbl.Name = "contractorLastNameLbl";
            this.contractorLastNameLbl.Size = new System.Drawing.Size(115, 25);
            this.contractorLastNameLbl.TabIndex = 44;
            this.contractorLastNameLbl.Text = "Last Name";
            // 
            // contractorEmailBox
            // 
            this.contractorEmailBox.Location = new System.Drawing.Point(1029, 666);
            this.contractorEmailBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorEmailBox.Name = "contractorEmailBox";
            this.contractorEmailBox.Size = new System.Drawing.Size(396, 31);
            this.contractorEmailBox.TabIndex = 43;
            // 
            // contractorEmployeeIdBox
            // 
            this.contractorEmployeeIdBox.Location = new System.Drawing.Point(1029, 594);
            this.contractorEmployeeIdBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorEmployeeIdBox.Name = "contractorEmployeeIdBox";
            this.contractorEmployeeIdBox.Size = new System.Drawing.Size(396, 31);
            this.contractorEmployeeIdBox.TabIndex = 42;
            // 
            // contractorMobileBox
            // 
            this.contractorMobileBox.Location = new System.Drawing.Point(1029, 522);
            this.contractorMobileBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorMobileBox.Name = "contractorMobileBox";
            this.contractorMobileBox.Size = new System.Drawing.Size(396, 31);
            this.contractorMobileBox.TabIndex = 41;
            this.contractorMobileBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractorMobileBox_KeyPress);
            // 
            // contractorLandLineBox
            // 
            this.contractorLandLineBox.Location = new System.Drawing.Point(207, 736);
            this.contractorLandLineBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorLandLineBox.Name = "contractorLandLineBox";
            this.contractorLandLineBox.Size = new System.Drawing.Size(396, 31);
            this.contractorLandLineBox.TabIndex = 40;
            this.contractorLandLineBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractorLandLineBox_KeyPress);
            // 
            // contractorAddressBox
            // 
            this.contractorAddressBox.Location = new System.Drawing.Point(207, 666);
            this.contractorAddressBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorAddressBox.Name = "contractorAddressBox";
            this.contractorAddressBox.Size = new System.Drawing.Size(396, 31);
            this.contractorAddressBox.TabIndex = 39;
            // 
            // contractorLastNameBox
            // 
            this.contractorLastNameBox.Location = new System.Drawing.Point(207, 594);
            this.contractorLastNameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorLastNameBox.Name = "contractorLastNameBox";
            this.contractorLastNameBox.Size = new System.Drawing.Size(396, 31);
            this.contractorLastNameBox.TabIndex = 38;
            // 
            // contractorFirstNameLbl
            // 
            this.contractorFirstNameLbl.AutoSize = true;
            this.contractorFirstNameLbl.Location = new System.Drawing.Point(52, 522);
            this.contractorFirstNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contractorFirstNameLbl.Name = "contractorFirstNameLbl";
            this.contractorFirstNameLbl.Size = new System.Drawing.Size(116, 25);
            this.contractorFirstNameLbl.TabIndex = 37;
            this.contractorFirstNameLbl.Text = "First Name";
            // 
            // contractorFirstNameBox
            // 
            this.contractorFirstNameBox.Location = new System.Drawing.Point(207, 522);
            this.contractorFirstNameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorFirstNameBox.Name = "contractorFirstNameBox";
            this.contractorFirstNameBox.Size = new System.Drawing.Size(396, 31);
            this.contractorFirstNameBox.TabIndex = 36;
            // 
            // jobClientEmailLbl
            // 
            this.jobClientEmailLbl.AutoSize = true;
            this.jobClientEmailLbl.Location = new System.Drawing.Point(52, 948);
            this.jobClientEmailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobClientEmailLbl.Name = "jobClientEmailLbl";
            this.jobClientEmailLbl.Size = new System.Drawing.Size(126, 25);
            this.jobClientEmailLbl.TabIndex = 52;
            this.jobClientEmailLbl.Text = "Client Email";
            // 
            // jobContractorEmailLbl
            // 
            this.jobContractorEmailLbl.AutoSize = true;
            this.jobContractorEmailLbl.Location = new System.Drawing.Point(52, 1022);
            this.jobContractorEmailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobContractorEmailLbl.Name = "jobContractorEmailLbl";
            this.jobContractorEmailLbl.Size = new System.Drawing.Size(171, 25);
            this.jobContractorEmailLbl.TabIndex = 53;
            this.jobContractorEmailLbl.Text = "Contractor Email";
            // 
            // jobClientEmailBox
            // 
            this.jobClientEmailBox.Location = new System.Drawing.Point(232, 941);
            this.jobClientEmailBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jobClientEmailBox.Name = "jobClientEmailBox";
            this.jobClientEmailBox.Size = new System.Drawing.Size(396, 31);
            this.jobClientEmailBox.TabIndex = 54;
            // 
            // jobContractorEmailBox
            // 
            this.jobContractorEmailBox.Location = new System.Drawing.Point(232, 1017);
            this.jobContractorEmailBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jobContractorEmailBox.Name = "jobContractorEmailBox";
            this.jobContractorEmailBox.Size = new System.Drawing.Size(396, 31);
            this.jobContractorEmailBox.TabIndex = 55;
            // 
            // jobPriorityCbx
            // 
            this.jobPriorityCbx.AutoSize = true;
            this.jobPriorityCbx.Location = new System.Drawing.Point(1029, 1119);
            this.jobPriorityCbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobPriorityCbx.Name = "jobPriorityCbx";
            this.jobPriorityCbx.Size = new System.Drawing.Size(161, 29);
            this.jobPriorityCbx.TabIndex = 56;
            this.jobPriorityCbx.Text = "High Priority";
            this.jobPriorityCbx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 997);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Time";
            // 
            // jobTimeBox
            // 
            this.jobTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.jobTimeBox.Location = new System.Drawing.Point(1029, 989);
            this.jobTimeBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.jobTimeBox.Name = "jobTimeBox";
            this.jobTimeBox.ShowUpDown = true;
            this.jobTimeBox.Size = new System.Drawing.Size(396, 31);
            this.jobTimeBox.TabIndex = 58;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(1311, 1366);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(150, 47);
            this.ImportButton.TabIndex = 60;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(1526, 1366);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(150, 47);
            this.ExportButton.TabIndex = 59;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1738, 1450);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.jobTimeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobPriorityCbx);
            this.Controls.Add(this.jobContractorEmailBox);
            this.Controls.Add(this.jobClientEmailBox);
            this.Controls.Add(this.jobContractorEmailLbl);
            this.Controls.Add(this.jobClientEmailLbl);
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
            this.Controls.Add(this.jobClearBtn);
            this.Controls.Add(this.jobSaveBtn);
            this.Controls.Add(this.JobLocationBox);
            this.Controls.Add(this.jobDescriptionBox);
            this.Controls.Add(this.jobDateBox);
            this.Controls.Add(this.jobPrioritylbl);
            this.Controls.Add(this.jobDateLbl);
            this.Controls.Add(this.jobLocationLbl);
            this.Controls.Add(this.jobDescriptionLbl);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label jobPrioritylbl;
        private System.Windows.Forms.DateTimePicker jobDateBox;
        private System.Windows.Forms.TextBox jobDescriptionBox;
        private System.Windows.Forms.TextBox JobLocationBox;
        private System.Windows.Forms.Button jobSaveBtn;
        private System.Windows.Forms.Button jobClearBtn;
        private agileassignment3DataSet agileassignment3DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private agileassignment3DataSetTableAdapters.TableTableAdapter tableTableAdapter;
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
        private System.Windows.Forms.Label jobClientEmailLbl;
        private System.Windows.Forms.Label jobContractorEmailLbl;
        private System.Windows.Forms.TextBox jobClientEmailBox;
        private System.Windows.Forms.TextBox jobContractorEmailBox;
        private System.Windows.Forms.CheckBox jobPriorityCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker jobTimeBox;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
    }
}

