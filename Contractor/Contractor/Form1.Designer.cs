﻿namespace Contractor
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
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.JobListView = new System.Windows.Forms.ListView();
            this.ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobLbl = new System.Windows.Forms.Label();
            this.contractorEmailLbl = new System.Windows.Forms.Label();
            this.contractorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.jobDescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionOutput = new System.Windows.Forms.Label();
            this.jobLocationLbl = new System.Windows.Forms.Label();
            this.LocationOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeOutput = new System.Windows.Forms.Label();
            this.jobPrioritylbl = new System.Windows.Forms.Label();
            this.PriorityOutput = new System.Windows.Forms.CheckBox();
            this.clientEmailLbl = new System.Windows.Forms.Label();
            this.clientBuisinessNameLbl = new System.Windows.Forms.Label();
            this.clientMobilelbl = new System.Windows.Forms.Label();
            this.clientLandLineLbl = new System.Windows.Forms.Label();
            this.clientAddressLbl = new System.Windows.Forms.Label();
            this.clientFirstNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameOutput = new System.Windows.Forms.Label();
            this.AddressOutput = new System.Windows.Forms.Label();
            this.LandLineOutput = new System.Windows.Forms.Label();
            this.MobileOutput = new System.Windows.Forms.Label();
            this.BusinessOutput = new System.Windows.Forms.Label();
            this.EmailOutput = new System.Windows.Forms.Label();
            this.CompleteLabel = new System.Windows.Forms.Label();
            this.CompleteCost = new System.Windows.Forms.TextBox();
            this.jobContractorEmailLbl = new System.Windows.Forms.Label();
            this.jobClientEmailLbl = new System.Windows.Forms.Label();
            this.FinishedCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CompleteDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CompleteSave = new System.Windows.Forms.Button();
            this.Invoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(1506, 1022);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(136, 56);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(1344, 1022);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(136, 56);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // JobListView
            // 
            this.JobListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientName,
            this.Time,
            this.Priority,
            this.Email,
            this.JobID});
            this.JobListView.Location = new System.Drawing.Point(765, 164);
            this.JobListView.Name = "JobListView";
            this.JobListView.Size = new System.Drawing.Size(877, 843);
            this.JobListView.TabIndex = 4;
            this.JobListView.UseCompatibleStateImageBehavior = false;
            this.JobListView.View = System.Windows.Forms.View.Details;
            this.JobListView.SelectedIndexChanged += new System.EventHandler(this.JobListView_SelectedIndexChanged);
            // 
            // ClientName
            // 
            this.ClientName.Text = "Client\'s Name";
            this.ClientName.Width = 163;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 109;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 84;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            // 
            // JobID
            // 
            this.JobID.Text = "Job Number";
            // 
            // jobLbl
            // 
            this.jobLbl.AutoSize = true;
            this.jobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLbl.Location = new System.Drawing.Point(754, 31);
            this.jobLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobLbl.Name = "jobLbl";
            this.jobLbl.Size = new System.Drawing.Size(211, 63);
            this.jobLbl.TabIndex = 17;
            this.jobLbl.Text = "Job list:";
            // 
            // contractorEmailLbl
            // 
            this.contractorEmailLbl.AutoSize = true;
            this.contractorEmailLbl.Location = new System.Drawing.Point(760, 123);
            this.contractorEmailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.contractorEmailLbl.Name = "contractorEmailLbl";
            this.contractorEmailLbl.Size = new System.Drawing.Size(133, 25);
            this.contractorEmailLbl.TabIndex = 51;
            this.contractorEmailLbl.Text = "Employee ID";
            // 
            // contractorID
            // 
            this.contractorID.Location = new System.Drawing.Point(904, 123);
            this.contractorID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.contractorID.Name = "contractorID";
            this.contractorID.Size = new System.Drawing.Size(738, 31);
            this.contractorID.TabIndex = 50;
            this.contractorID.TextChanged += new System.EventHandler(this.contractorID_TextChanged);
            this.contractorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractorID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 63);
            this.label1.TabIndex = 52;
            this.label1.Text = "Job Details:";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLabel.Location = new System.Drawing.Point(39, 327);
            this.ClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(363, 63);
            this.ClientLabel.TabIndex = 53;
            this.ClientLabel.Text = "Client Details:";
            //this.ClientLabel.Click += new System.EventHandler(this.ClientLabel_Click);
            // 
            // jobDescriptionLbl
            // 
            this.jobDescriptionLbl.AutoSize = true;
            this.jobDescriptionLbl.Location = new System.Drawing.Point(45, 116);
            this.jobDescriptionLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobDescriptionLbl.Name = "jobDescriptionLbl";
            this.jobDescriptionLbl.Size = new System.Drawing.Size(120, 25);
            this.jobDescriptionLbl.TabIndex = 54;
            this.jobDescriptionLbl.Text = "Description";
            // 
            // DescriptionOutput
            // 
            this.DescriptionOutput.AutoSize = true;
            this.DescriptionOutput.Location = new System.Drawing.Point(201, 116);
            this.DescriptionOutput.Name = "DescriptionOutput";
            this.DescriptionOutput.Size = new System.Drawing.Size(184, 25);
            this.DescriptionOutput.TabIndex = 55;
            this.DescriptionOutput.Text = "DescriptionOutput";
            // 
            // jobLocationLbl
            // 
            this.jobLocationLbl.AutoSize = true;
            this.jobLocationLbl.Location = new System.Drawing.Point(45, 167);
            this.jobLocationLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobLocationLbl.Name = "jobLocationLbl";
            this.jobLocationLbl.Size = new System.Drawing.Size(94, 25);
            this.jobLocationLbl.TabIndex = 56;
            this.jobLocationLbl.Text = "Location";
            // 
            // LocationOutput
            // 
            this.LocationOutput.AutoSize = true;
            this.LocationOutput.Location = new System.Drawing.Point(201, 167);
            this.LocationOutput.Name = "LocationOutput";
            this.LocationOutput.Size = new System.Drawing.Size(158, 25);
            this.LocationOutput.TabIndex = 57;
            this.LocationOutput.Text = "LocationOutput";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Time";
            // 
            // TimeOutput
            // 
            this.TimeOutput.AutoSize = true;
            this.TimeOutput.Location = new System.Drawing.Point(201, 223);
            this.TimeOutput.Name = "TimeOutput";
            this.TimeOutput.Size = new System.Drawing.Size(123, 25);
            this.TimeOutput.TabIndex = 59;
            this.TimeOutput.Text = "TimeOutput";
            // 
            // jobPrioritylbl
            // 
            this.jobPrioritylbl.AutoSize = true;
            this.jobPrioritylbl.Location = new System.Drawing.Point(51, 275);
            this.jobPrioritylbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobPrioritylbl.Name = "jobPrioritylbl";
            this.jobPrioritylbl.Size = new System.Drawing.Size(79, 25);
            this.jobPrioritylbl.TabIndex = 60;
            this.jobPrioritylbl.Text = "Priority";
            // 
            // PriorityOutput
            // 
            this.PriorityOutput.AutoCheck = false;
            this.PriorityOutput.AutoSize = true;
            this.PriorityOutput.Location = new System.Drawing.Point(206, 275);
            this.PriorityOutput.Name = "PriorityOutput";
            this.PriorityOutput.Size = new System.Drawing.Size(28, 27);
            this.PriorityOutput.TabIndex = 61;
            this.PriorityOutput.UseVisualStyleBackColor = true;
            // 
            // clientEmailLbl
            // 
            this.clientEmailLbl.AutoSize = true;
            this.clientEmailLbl.Location = new System.Drawing.Point(54, 670);
            this.clientEmailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientEmailLbl.Name = "clientEmailLbl";
            this.clientEmailLbl.Size = new System.Drawing.Size(65, 25);
            this.clientEmailLbl.TabIndex = 68;
            this.clientEmailLbl.Text = "Email";
            // 
            // clientBuisinessNameLbl
            // 
            this.clientBuisinessNameLbl.AutoSize = true;
            this.clientBuisinessNameLbl.Location = new System.Drawing.Point(51, 620);
            this.clientBuisinessNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientBuisinessNameLbl.Name = "clientBuisinessNameLbl";
            this.clientBuisinessNameLbl.Size = new System.Drawing.Size(100, 25);
            this.clientBuisinessNameLbl.TabIndex = 67;
            this.clientBuisinessNameLbl.Text = "Business";
            // 
            // clientMobilelbl
            // 
            this.clientMobilelbl.AutoSize = true;
            this.clientMobilelbl.Location = new System.Drawing.Point(51, 570);
            this.clientMobilelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientMobilelbl.Name = "clientMobilelbl";
            this.clientMobilelbl.Size = new System.Drawing.Size(94, 25);
            this.clientMobilelbl.TabIndex = 66;
            this.clientMobilelbl.Text = "Mobile #";
            // 
            // clientLandLineLbl
            // 
            this.clientLandLineLbl.AutoSize = true;
            this.clientLandLineLbl.Location = new System.Drawing.Point(51, 516);
            this.clientLandLineLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientLandLineLbl.Name = "clientLandLineLbl";
            this.clientLandLineLbl.Size = new System.Drawing.Size(125, 25);
            this.clientLandLineLbl.TabIndex = 65;
            this.clientLandLineLbl.Text = "Land Line #";
            // 
            // clientAddressLbl
            // 
            this.clientAddressLbl.AutoSize = true;
            this.clientAddressLbl.Location = new System.Drawing.Point(51, 459);
            this.clientAddressLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientAddressLbl.Name = "clientAddressLbl";
            this.clientAddressLbl.Size = new System.Drawing.Size(91, 25);
            this.clientAddressLbl.TabIndex = 64;
            this.clientAddressLbl.Text = "Address";
            // 
            // clientFirstNameLbl
            // 
            this.clientFirstNameLbl.AutoSize = true;
            this.clientFirstNameLbl.Location = new System.Drawing.Point(51, 411);
            this.clientFirstNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clientFirstNameLbl.Name = "clientFirstNameLbl";
            this.clientFirstNameLbl.Size = new System.Drawing.Size(68, 25);
            this.clientFirstNameLbl.TabIndex = 63;
            this.clientFirstNameLbl.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(868, 1523);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Priority";
            // 
            // NameOutput
            // 
            this.NameOutput.AutoSize = true;
            this.NameOutput.Location = new System.Drawing.Point(201, 411);
            this.NameOutput.Name = "NameOutput";
            this.NameOutput.Size = new System.Drawing.Size(132, 25);
            this.NameOutput.TabIndex = 69;
            this.NameOutput.Text = "NameOutput";
            // 
            // AddressOutput
            // 
            this.AddressOutput.AutoSize = true;
            this.AddressOutput.Location = new System.Drawing.Point(204, 459);
            this.AddressOutput.Name = "AddressOutput";
            this.AddressOutput.Size = new System.Drawing.Size(155, 25);
            this.AddressOutput.TabIndex = 70;
            this.AddressOutput.Text = "AddressOutput";
            // 
            // LandLineOutput
            // 
            this.LandLineOutput.AutoSize = true;
            this.LandLineOutput.Location = new System.Drawing.Point(204, 516);
            this.LandLineOutput.Name = "LandLineOutput";
            this.LandLineOutput.Size = new System.Drawing.Size(165, 25);
            this.LandLineOutput.TabIndex = 71;
            this.LandLineOutput.Text = "LandLineOutput";
            // 
            // MobileOutput
            // 
            this.MobileOutput.AutoSize = true;
            this.MobileOutput.Location = new System.Drawing.Point(204, 570);
            this.MobileOutput.Name = "MobileOutput";
            this.MobileOutput.Size = new System.Drawing.Size(140, 25);
            this.MobileOutput.TabIndex = 72;
            this.MobileOutput.Text = "MobileOutput";
            // 
            // BusinessOutput
            // 
            this.BusinessOutput.AutoSize = true;
            this.BusinessOutput.Location = new System.Drawing.Point(201, 620);
            this.BusinessOutput.Name = "BusinessOutput";
            this.BusinessOutput.Size = new System.Drawing.Size(164, 25);
            this.BusinessOutput.TabIndex = 73;
            this.BusinessOutput.Text = "BusinessOutput";
            // 
            // EmailOutput
            // 
            this.EmailOutput.AutoSize = true;
            this.EmailOutput.Location = new System.Drawing.Point(201, 670);
            this.EmailOutput.Name = "EmailOutput";
            this.EmailOutput.Size = new System.Drawing.Size(129, 25);
            this.EmailOutput.TabIndex = 74;
            this.EmailOutput.Text = "EmailOutput";
            // 
            // CompleteLabel
            // 
            this.CompleteLabel.AutoSize = true;
            this.CompleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteLabel.Location = new System.Drawing.Point(39, 709);
            this.CompleteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompleteLabel.Name = "CompleteLabel";
            this.CompleteLabel.Size = new System.Drawing.Size(317, 63);
            this.CompleteLabel.TabIndex = 75;
            this.CompleteLabel.Text = "Completion:";
            // 
            // CompleteCost
            // 
            this.CompleteCost.Location = new System.Drawing.Point(206, 784);
            this.CompleteCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CompleteCost.Name = "CompleteCost";
            this.CompleteCost.Size = new System.Drawing.Size(514, 31);
            this.CompleteCost.TabIndex = 78;
            this.CompleteCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CompleteCost_KeyPress);
            // 
            // jobContractorEmailLbl
            // 
            this.jobContractorEmailLbl.AutoSize = true;
            this.jobContractorEmailLbl.Location = new System.Drawing.Point(54, 834);
            this.jobContractorEmailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobContractorEmailLbl.Name = "jobContractorEmailLbl";
            this.jobContractorEmailLbl.Size = new System.Drawing.Size(120, 25);
            this.jobContractorEmailLbl.TabIndex = 77;
            this.jobContractorEmailLbl.Text = "Description";
            // 
            // jobClientEmailLbl
            // 
            this.jobClientEmailLbl.AutoSize = true;
            this.jobClientEmailLbl.Location = new System.Drawing.Point(51, 791);
            this.jobClientEmailLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.jobClientEmailLbl.Name = "jobClientEmailLbl";
            this.jobClientEmailLbl.Size = new System.Drawing.Size(56, 25);
            this.jobClientEmailLbl.TabIndex = 76;
            this.jobClientEmailLbl.Text = "Cost";
            // 
            // FinishedCheck
            // 
            this.FinishedCheck.AutoSize = true;
            this.FinishedCheck.Location = new System.Drawing.Point(206, 955);
            this.FinishedCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FinishedCheck.Name = "FinishedCheck";
            this.FinishedCheck.Size = new System.Drawing.Size(28, 27);
            this.FinishedCheck.TabIndex = 81;
            this.FinishedCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 956);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "Finished";
            // 
            // CompleteDescription
            // 
            this.CompleteDescription.Location = new System.Drawing.Point(206, 834);
            this.CompleteDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CompleteDescription.Multiline = true;
            this.CompleteDescription.Name = "CompleteDescription";
            this.CompleteDescription.Size = new System.Drawing.Size(514, 110);
            this.CompleteDescription.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 784);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 83;
            // 
            // CompleteSave
            // 
            this.CompleteSave.Location = new System.Drawing.Point(56, 1022);
            this.CompleteSave.Name = "CompleteSave";
            this.CompleteSave.Size = new System.Drawing.Size(136, 56);
            this.CompleteSave.TabIndex = 85;
            this.CompleteSave.Text = "Save";
            this.CompleteSave.UseVisualStyleBackColor = true;
            this.CompleteSave.Click += new System.EventHandler(this.CompleteSave_Click);
            // 
            // Invoice
            // 
            this.Invoice.Location = new System.Drawing.Point(206, 1022);
            this.Invoice.Name = "Invoice";
            this.Invoice.Size = new System.Drawing.Size(136, 56);
            this.Invoice.TabIndex = 84;
            this.Invoice.Text = "Invoice";
            this.Invoice.UseVisualStyleBackColor = true;
            this.Invoice.Click += new System.EventHandler(this.Invoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 1097);
            this.Controls.Add(this.CompleteSave);
            this.Controls.Add(this.Invoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CompleteDescription);
            this.Controls.Add(this.FinishedCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CompleteCost);
            this.Controls.Add(this.jobContractorEmailLbl);
            this.Controls.Add(this.jobClientEmailLbl);
            this.Controls.Add(this.CompleteLabel);
            this.Controls.Add(this.EmailOutput);
            this.Controls.Add(this.BusinessOutput);
            this.Controls.Add(this.MobileOutput);
            this.Controls.Add(this.LandLineOutput);
            this.Controls.Add(this.AddressOutput);
            this.Controls.Add(this.NameOutput);
            this.Controls.Add(this.clientEmailLbl);
            this.Controls.Add(this.clientBuisinessNameLbl);
            this.Controls.Add(this.clientMobilelbl);
            this.Controls.Add(this.clientLandLineLbl);
            this.Controls.Add(this.clientAddressLbl);
            this.Controls.Add(this.clientFirstNameLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriorityOutput);
            this.Controls.Add(this.jobPrioritylbl);
            this.Controls.Add(this.TimeOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocationOutput);
            this.Controls.Add(this.jobLocationLbl);
            this.Controls.Add(this.DescriptionOutput);
            this.Controls.Add(this.jobDescriptionLbl);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contractorEmailLbl);
            this.Controls.Add(this.contractorID);
            this.Controls.Add(this.jobLbl);
            this.Controls.Add(this.JobListView);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ExportButton);
            this.Name = "Form1";
            this.Text = "Contractor";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.ListView JobListView;
        private System.Windows.Forms.Label jobLbl;
        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.Label contractorEmailLbl;
        private System.Windows.Forms.TextBox contractorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label jobDescriptionLbl;
        private System.Windows.Forms.Label DescriptionOutput;
        private System.Windows.Forms.Label jobLocationLbl;
        private System.Windows.Forms.Label LocationOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeOutput;
        private System.Windows.Forms.Label jobPrioritylbl;
        private System.Windows.Forms.CheckBox PriorityOutput;
        private System.Windows.Forms.Label clientEmailLbl;
        private System.Windows.Forms.Label clientBuisinessNameLbl;
        private System.Windows.Forms.Label clientMobilelbl;
        private System.Windows.Forms.Label clientLandLineLbl;
        private System.Windows.Forms.Label clientAddressLbl;
        private System.Windows.Forms.Label clientFirstNameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameOutput;
        private System.Windows.Forms.Label AddressOutput;
        private System.Windows.Forms.Label LandLineOutput;
        private System.Windows.Forms.Label MobileOutput;
        private System.Windows.Forms.Label BusinessOutput;
        private System.Windows.Forms.Label EmailOutput;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader JobID;
        private System.Windows.Forms.Label CompleteLabel;
        private System.Windows.Forms.TextBox CompleteCost;
        private System.Windows.Forms.Label jobContractorEmailLbl;
        private System.Windows.Forms.Label jobClientEmailLbl;
        private System.Windows.Forms.CheckBox FinishedCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CompleteDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CompleteSave;
        private System.Windows.Forms.Button Invoice;
    }
}

