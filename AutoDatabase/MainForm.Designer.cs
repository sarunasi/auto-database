namespace AutoDatabase
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
			this.components = new System.ComponentModel.Container();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.RegistrateClientTab = new System.Windows.Forms.TabPage();
			this.textClient1 = new System.Windows.Forms.TextBox();
			this.textClient2 = new System.Windows.Forms.TextBox();
			this.textBoxClient1 = new System.Windows.Forms.TextBox();
			this.textBoxClient2 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonSelectPerson = new System.Windows.Forms.Button();
			this.buttonSelectCompany = new System.Windows.Forms.Button();
			this.buttonRegisterClient = new System.Windows.Forms.Button();
			this.textBoxTelephone = new System.Windows.Forms.TextBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.tabAddCar = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonCarLeft = new System.Windows.Forms.Button();
			this.buttonCarArrived = new System.Windows.Forms.Button();
			this.listBoxClientCars = new System.Windows.Forms.ListBox();
			this.JobsTab = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listBoxJobEmployees = new System.Windows.Forms.ListBox();
			this.buttonAddEmployeeToJob = new System.Windows.Forms.Button();
			this.listBoxEmployees = new System.Windows.Forms.ListBox();
			this.buttonDeleteJob = new System.Windows.Forms.Button();
			this.buttonFinishJob = new System.Windows.Forms.Button();
			this.listBoxCarJobs = new System.Windows.Forms.ListBox();
			this.buttonAddJobToCar = new System.Windows.Forms.Button();
			this.listBoxServices = new System.Windows.Forms.ListBox();
			this.listBoxArrivedCars = new System.Windows.Forms.ListBox();
			this.EmployeesTab = new System.Windows.Forms.TabPage();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.buttonDeleteEmployee = new System.Windows.Forms.Button();
			this.textBoxDeleteEmployeeId = new System.Windows.Forms.TextBox();
			this.textBoxUpdateEmployeeId = new System.Windows.Forms.TextBox();
			this.buttonUpdateEmployee = new System.Windows.Forms.Button();
			this.textBoxUpdateEmployeeSurname = new System.Windows.Forms.TextBox();
			this.textBoxUpdateEmployeeName = new System.Windows.Forms.TextBox();
			this.buttonAddEmployee = new System.Windows.Forms.Button();
			this.textBoxInsertEmployeeSurname = new System.Windows.Forms.TextBox();
			this.textBoxInsertEmployeeName = new System.Windows.Forms.TextBox();
			this.tabAddServices = new System.Windows.Forms.TabPage();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.buttonAddService = new System.Windows.Forms.Button();
			this.textBoxServiceDefaultHours = new System.Windows.Forms.TextBox();
			this.textBoxServicePrice = new System.Windows.Forms.TextBox();
			this.textBoxServiceName = new System.Windows.Forms.TextBox();
			this.SearchTab = new System.Windows.Forms.TabPage();
			this.SystemLogTab = new System.Windows.Forms.TabPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.buttonPerson = new System.Windows.Forms.Button();
			this.buttonCompany = new System.Windows.Forms.Button();
			this.listBoxClients = new System.Windows.Forms.ListBox();
			this.buttonAddNewCar = new System.Windows.Forms.Button();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBoxCarYear = new System.Windows.Forms.TextBox();
			this.textBoxCarEngine = new System.Windows.Forms.TextBox();
			this.textBoxCarRun = new System.Windows.Forms.TextBox();
			this.textBoxCarModel = new System.Windows.Forms.TextBox();
			this.textBoxCarMake = new System.Windows.Forms.TextBox();
			this.textBoxCarPlate = new System.Windows.Forms.TextBox();
			this.textBoxCarVIN = new System.Windows.Forms.TextBox();
			this.tabControl.SuspendLayout();
			this.RegistrateClientTab.SuspendLayout();
			this.tabAddCar.SuspendLayout();
			this.JobsTab.SuspendLayout();
			this.EmployeesTab.SuspendLayout();
			this.tabAddServices.SuspendLayout();
			this.SystemLogTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.RegistrateClientTab);
			this.tabControl.Controls.Add(this.tabAddCar);
			this.tabControl.Controls.Add(this.JobsTab);
			this.tabControl.Controls.Add(this.EmployeesTab);
			this.tabControl.Controls.Add(this.tabAddServices);
			this.tabControl.Controls.Add(this.SearchTab);
			this.tabControl.Controls.Add(this.SystemLogTab);
			this.tabControl.Location = new System.Drawing.Point(-1, 1);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1174, 507);
			this.tabControl.TabIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// RegistrateClientTab
			// 
			this.RegistrateClientTab.Controls.Add(this.buttonPerson);
			this.RegistrateClientTab.Controls.Add(this.buttonCompany);
			this.RegistrateClientTab.Controls.Add(this.listBoxClients);
			this.RegistrateClientTab.Controls.Add(this.buttonAddNewCar);
			this.RegistrateClientTab.Controls.Add(this.textBox16);
			this.RegistrateClientTab.Controls.Add(this.textBox15);
			this.RegistrateClientTab.Controls.Add(this.textBox14);
			this.RegistrateClientTab.Controls.Add(this.textBox10);
			this.RegistrateClientTab.Controls.Add(this.textBox11);
			this.RegistrateClientTab.Controls.Add(this.textBox12);
			this.RegistrateClientTab.Controls.Add(this.textBox13);
			this.RegistrateClientTab.Controls.Add(this.textBoxCarYear);
			this.RegistrateClientTab.Controls.Add(this.textBoxCarEngine);
			this.RegistrateClientTab.Controls.Add(this.textBoxCarRun);
			this.RegistrateClientTab.Controls.Add(this.textBoxCarModel);
			this.RegistrateClientTab.Controls.Add(this.textBoxCarMake);
			this.RegistrateClientTab.Controls.Add(this.textBoxCarPlate);
			this.RegistrateClientTab.Controls.Add(this.textBoxCarVIN);
			this.RegistrateClientTab.Controls.Add(this.textClient1);
			this.RegistrateClientTab.Controls.Add(this.textClient2);
			this.RegistrateClientTab.Controls.Add(this.textBoxClient1);
			this.RegistrateClientTab.Controls.Add(this.textBoxClient2);
			this.RegistrateClientTab.Controls.Add(this.textBox2);
			this.RegistrateClientTab.Controls.Add(this.textBox1);
			this.RegistrateClientTab.Controls.Add(this.buttonSelectPerson);
			this.RegistrateClientTab.Controls.Add(this.buttonSelectCompany);
			this.RegistrateClientTab.Controls.Add(this.buttonRegisterClient);
			this.RegistrateClientTab.Controls.Add(this.textBoxTelephone);
			this.RegistrateClientTab.Controls.Add(this.textBoxAddress);
			this.RegistrateClientTab.Location = new System.Drawing.Point(4, 22);
			this.RegistrateClientTab.Name = "RegistrateClientTab";
			this.RegistrateClientTab.Padding = new System.Windows.Forms.Padding(3);
			this.RegistrateClientTab.Size = new System.Drawing.Size(1166, 481);
			this.RegistrateClientTab.TabIndex = 0;
			this.RegistrateClientTab.Text = "Registruoti klientą";
			this.RegistrateClientTab.UseVisualStyleBackColor = true;
			// 
			// textClient1
			// 
			this.textClient1.BackColor = System.Drawing.SystemColors.Window;
			this.textClient1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textClient1.Location = new System.Drawing.Point(48, 156);
			this.textClient1.Name = "textClient1";
			this.textClient1.ReadOnly = true;
			this.textClient1.Size = new System.Drawing.Size(67, 13);
			this.textClient1.TabIndex = 10;
			this.textClient1.Text = "Vardas";
			// 
			// textClient2
			// 
			this.textClient2.BackColor = System.Drawing.SystemColors.Window;
			this.textClient2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textClient2.Location = new System.Drawing.Point(48, 182);
			this.textClient2.Name = "textClient2";
			this.textClient2.ReadOnly = true;
			this.textClient2.Size = new System.Drawing.Size(67, 13);
			this.textClient2.TabIndex = 9;
			this.textClient2.Text = "Pavarde";
			// 
			// textBoxClient1
			// 
			this.textBoxClient1.Location = new System.Drawing.Point(121, 153);
			this.textBoxClient1.MaxLength = 50;
			this.textBoxClient1.Name = "textBoxClient1";
			this.textBoxClient1.Size = new System.Drawing.Size(224, 20);
			this.textBoxClient1.TabIndex = 8;
			this.textBoxClient1.Validated += new System.EventHandler(this.textBoxClient1_Validated);
			// 
			// textBoxClient2
			// 
			this.textBoxClient2.Location = new System.Drawing.Point(121, 179);
			this.textBoxClient2.MaxLength = 50;
			this.textBoxClient2.Name = "textBoxClient2";
			this.textBoxClient2.Size = new System.Drawing.Size(224, 20);
			this.textBoxClient2.TabIndex = 7;
			this.textBoxClient2.Validated += new System.EventHandler(this.textBoxClient2_Validated);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Window;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Location = new System.Drawing.Point(48, 234);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(67, 13);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "Telefonas";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Window;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(48, 208);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(67, 13);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "Adresas";
			// 
			// buttonSelectPerson
			// 
			this.buttonSelectPerson.Location = new System.Drawing.Point(72, 64);
			this.buttonSelectPerson.Name = "buttonSelectPerson";
			this.buttonSelectPerson.Size = new System.Drawing.Size(91, 37);
			this.buttonSelectPerson.TabIndex = 4;
			this.buttonSelectPerson.Text = "Asmuo";
			this.buttonSelectPerson.UseVisualStyleBackColor = true;
			this.buttonSelectPerson.Click += new System.EventHandler(this.buttonSelectPerson_Click);
			// 
			// buttonSelectCompany
			// 
			this.buttonSelectCompany.Location = new System.Drawing.Point(254, 64);
			this.buttonSelectCompany.Name = "buttonSelectCompany";
			this.buttonSelectCompany.Size = new System.Drawing.Size(91, 37);
			this.buttonSelectCompany.TabIndex = 3;
			this.buttonSelectCompany.Text = "Imone";
			this.buttonSelectCompany.UseVisualStyleBackColor = true;
			this.buttonSelectCompany.Click += new System.EventHandler(this.buttonSelectCompany_Click);
			// 
			// buttonRegisterClient
			// 
			this.buttonRegisterClient.Location = new System.Drawing.Point(169, 257);
			this.buttonRegisterClient.Name = "buttonRegisterClient";
			this.buttonRegisterClient.Size = new System.Drawing.Size(123, 35);
			this.buttonRegisterClient.TabIndex = 2;
			this.buttonRegisterClient.Text = "Registruoti";
			this.buttonRegisterClient.UseVisualStyleBackColor = true;
			this.buttonRegisterClient.Click += new System.EventHandler(this.buttonRegisterClient_Click);
			// 
			// textBoxTelephone
			// 
			this.textBoxTelephone.Location = new System.Drawing.Point(121, 231);
			this.textBoxTelephone.MaxLength = 30;
			this.textBoxTelephone.Name = "textBoxTelephone";
			this.textBoxTelephone.Size = new System.Drawing.Size(224, 20);
			this.textBoxTelephone.TabIndex = 1;
			this.textBoxTelephone.Validated += new System.EventHandler(this.textBoxTelephone_Validated);
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(121, 205);
			this.textBoxAddress.MaxLength = 50;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(224, 20);
			this.textBoxAddress.TabIndex = 0;
			this.textBoxAddress.Validated += new System.EventHandler(this.textBoxAddress_Validated);
			// 
			// tabAddCar
			// 
			this.tabAddCar.Controls.Add(this.label6);
			this.tabAddCar.Controls.Add(this.buttonCarLeft);
			this.tabAddCar.Controls.Add(this.buttonCarArrived);
			this.tabAddCar.Controls.Add(this.listBoxClientCars);
			this.tabAddCar.Location = new System.Drawing.Point(4, 22);
			this.tabAddCar.Name = "tabAddCar";
			this.tabAddCar.Padding = new System.Windows.Forms.Padding(3);
			this.tabAddCar.Size = new System.Drawing.Size(1166, 481);
			this.tabAddCar.TabIndex = 11;
			this.tabAddCar.Text = "Prideti Automobili";
			this.tabAddCar.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(745, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 13);
			this.label6.TabIndex = 25;
			this.label6.Text = "Kliento automobiliai";
			// 
			// buttonCarLeft
			// 
			this.buttonCarLeft.Location = new System.Drawing.Point(927, 232);
			this.buttonCarLeft.Name = "buttonCarLeft";
			this.buttonCarLeft.Size = new System.Drawing.Size(141, 38);
			this.buttonCarLeft.TabIndex = 22;
			this.buttonCarLeft.Text = "Automobilis Isvyko";
			this.buttonCarLeft.UseVisualStyleBackColor = true;
			this.buttonCarLeft.Click += new System.EventHandler(this.buttonCarLeft_Click);
			// 
			// buttonCarArrived
			// 
			this.buttonCarArrived.Location = new System.Drawing.Point(927, 128);
			this.buttonCarArrived.Name = "buttonCarArrived";
			this.buttonCarArrived.Size = new System.Drawing.Size(141, 38);
			this.buttonCarArrived.TabIndex = 21;
			this.buttonCarArrived.Text = "Automobilis Atvyko";
			this.buttonCarArrived.UseVisualStyleBackColor = true;
			this.buttonCarArrived.Click += new System.EventHandler(this.buttonCarArrived_Click);
			// 
			// listBoxClientCars
			// 
			this.listBoxClientCars.FormattingEnabled = true;
			this.listBoxClientCars.Location = new System.Drawing.Point(693, 30);
			this.listBoxClientCars.Name = "listBoxClientCars";
			this.listBoxClientCars.Size = new System.Drawing.Size(215, 381);
			this.listBoxClientCars.TabIndex = 20;
			// 
			// JobsTab
			// 
			this.JobsTab.Controls.Add(this.label5);
			this.JobsTab.Controls.Add(this.label4);
			this.JobsTab.Controls.Add(this.label3);
			this.JobsTab.Controls.Add(this.label2);
			this.JobsTab.Controls.Add(this.label1);
			this.JobsTab.Controls.Add(this.listBoxJobEmployees);
			this.JobsTab.Controls.Add(this.buttonAddEmployeeToJob);
			this.JobsTab.Controls.Add(this.listBoxEmployees);
			this.JobsTab.Controls.Add(this.buttonDeleteJob);
			this.JobsTab.Controls.Add(this.buttonFinishJob);
			this.JobsTab.Controls.Add(this.listBoxCarJobs);
			this.JobsTab.Controls.Add(this.buttonAddJobToCar);
			this.JobsTab.Controls.Add(this.listBoxServices);
			this.JobsTab.Controls.Add(this.listBoxArrivedCars);
			this.JobsTab.Location = new System.Drawing.Point(4, 22);
			this.JobsTab.Name = "JobsTab";
			this.JobsTab.Padding = new System.Windows.Forms.Padding(3);
			this.JobsTab.Size = new System.Drawing.Size(1166, 481);
			this.JobsTab.TabIndex = 9;
			this.JobsTab.Text = "Darbai";
			this.JobsTab.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(968, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Darbuotojai";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(968, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Paslaugos";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(522, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Darbuotojai priskirti darbui";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(291, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Darbai automobiliui";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(85, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Automobiliai servise";
			// 
			// listBoxJobEmployees
			// 
			this.listBoxJobEmployees.FormattingEnabled = true;
			this.listBoxJobEmployees.Location = new System.Drawing.Point(477, 21);
			this.listBoxJobEmployees.Name = "listBoxJobEmployees";
			this.listBoxJobEmployees.Size = new System.Drawing.Size(206, 199);
			this.listBoxJobEmployees.TabIndex = 10;
			// 
			// buttonAddEmployeeToJob
			// 
			this.buttonAddEmployeeToJob.Location = new System.Drawing.Point(814, 249);
			this.buttonAddEmployeeToJob.Name = "buttonAddEmployeeToJob";
			this.buttonAddEmployeeToJob.Size = new System.Drawing.Size(90, 40);
			this.buttonAddEmployeeToJob.TabIndex = 9;
			this.buttonAddEmployeeToJob.Text = "Prideti Darbuotoja";
			this.buttonAddEmployeeToJob.UseVisualStyleBackColor = true;
			this.buttonAddEmployeeToJob.Click += new System.EventHandler(this.buttonAddEmployeeToJob_Click);
			// 
			// listBoxEmployees
			// 
			this.listBoxEmployees.FormattingEnabled = true;
			this.listBoxEmployees.Location = new System.Drawing.Point(924, 249);
			this.listBoxEmployees.Name = "listBoxEmployees";
			this.listBoxEmployees.Size = new System.Drawing.Size(206, 212);
			this.listBoxEmployees.TabIndex = 8;
			// 
			// buttonDeleteJob
			// 
			this.buttonDeleteJob.Location = new System.Drawing.Point(477, 421);
			this.buttonDeleteJob.Name = "buttonDeleteJob";
			this.buttonDeleteJob.Size = new System.Drawing.Size(87, 33);
			this.buttonDeleteJob.TabIndex = 7;
			this.buttonDeleteJob.Text = "Istrinti Darba";
			this.buttonDeleteJob.UseVisualStyleBackColor = true;
			this.buttonDeleteJob.Click += new System.EventHandler(this.buttonDeleteJob_Click);
			// 
			// buttonFinishJob
			// 
			this.buttonFinishJob.Location = new System.Drawing.Point(477, 264);
			this.buttonFinishJob.Name = "buttonFinishJob";
			this.buttonFinishJob.Size = new System.Drawing.Size(87, 36);
			this.buttonFinishJob.TabIndex = 6;
			this.buttonFinishJob.Text = "BaigtiDarba";
			this.buttonFinishJob.UseVisualStyleBackColor = true;
			this.buttonFinishJob.Click += new System.EventHandler(this.buttonFinishJob_Click);
			// 
			// listBoxCarJobs
			// 
			this.listBoxCarJobs.FormattingEnabled = true;
			this.listBoxCarJobs.Location = new System.Drawing.Point(249, 21);
			this.listBoxCarJobs.Name = "listBoxCarJobs";
			this.listBoxCarJobs.Size = new System.Drawing.Size(206, 433);
			this.listBoxCarJobs.TabIndex = 5;
			this.listBoxCarJobs.SelectedIndexChanged += new System.EventHandler(this.listBoxCarJobs_SelectedIndexChanged);
			// 
			// buttonAddJobToCar
			// 
			this.buttonAddJobToCar.Location = new System.Drawing.Point(814, 46);
			this.buttonAddJobToCar.Name = "buttonAddJobToCar";
			this.buttonAddJobToCar.Size = new System.Drawing.Size(90, 40);
			this.buttonAddJobToCar.TabIndex = 4;
			this.buttonAddJobToCar.Text = "Prideti darba";
			this.buttonAddJobToCar.UseVisualStyleBackColor = true;
			this.buttonAddJobToCar.Click += new System.EventHandler(this.buttonAddJobToCar_Click);
			// 
			// listBoxServices
			// 
			this.listBoxServices.FormattingEnabled = true;
			this.listBoxServices.Location = new System.Drawing.Point(924, 21);
			this.listBoxServices.Name = "listBoxServices";
			this.listBoxServices.Size = new System.Drawing.Size(206, 199);
			this.listBoxServices.TabIndex = 2;
			// 
			// listBoxArrivedCars
			// 
			this.listBoxArrivedCars.FormattingEnabled = true;
			this.listBoxArrivedCars.Location = new System.Drawing.Point(25, 21);
			this.listBoxArrivedCars.Name = "listBoxArrivedCars";
			this.listBoxArrivedCars.Size = new System.Drawing.Size(206, 433);
			this.listBoxArrivedCars.TabIndex = 1;
			this.listBoxArrivedCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
			// 
			// EmployeesTab
			// 
			this.EmployeesTab.Controls.Add(this.textBox18);
			this.EmployeesTab.Controls.Add(this.textBox17);
			this.EmployeesTab.Controls.Add(this.textBox9);
			this.EmployeesTab.Controls.Add(this.textBox3);
			this.EmployeesTab.Controls.Add(this.textBox4);
			this.EmployeesTab.Controls.Add(this.textBox7);
			this.EmployeesTab.Controls.Add(this.buttonDeleteEmployee);
			this.EmployeesTab.Controls.Add(this.textBoxDeleteEmployeeId);
			this.EmployeesTab.Controls.Add(this.textBoxUpdateEmployeeId);
			this.EmployeesTab.Controls.Add(this.buttonUpdateEmployee);
			this.EmployeesTab.Controls.Add(this.textBoxUpdateEmployeeSurname);
			this.EmployeesTab.Controls.Add(this.textBoxUpdateEmployeeName);
			this.EmployeesTab.Controls.Add(this.buttonAddEmployee);
			this.EmployeesTab.Controls.Add(this.textBoxInsertEmployeeSurname);
			this.EmployeesTab.Controls.Add(this.textBoxInsertEmployeeName);
			this.EmployeesTab.Location = new System.Drawing.Point(4, 22);
			this.EmployeesTab.Name = "EmployeesTab";
			this.EmployeesTab.Padding = new System.Windows.Forms.Padding(3);
			this.EmployeesTab.Size = new System.Drawing.Size(1166, 481);
			this.EmployeesTab.TabIndex = 4;
			this.EmployeesTab.Text = "Darbuotojai";
			this.EmployeesTab.UseVisualStyleBackColor = true;
			// 
			// textBox18
			// 
			this.textBox18.BackColor = System.Drawing.SystemColors.Window;
			this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox18.Location = new System.Drawing.Point(385, 89);
			this.textBox18.Name = "textBox18";
			this.textBox18.ReadOnly = true;
			this.textBox18.Size = new System.Drawing.Size(35, 13);
			this.textBox18.TabIndex = 16;
			this.textBox18.Text = "Id";
			// 
			// textBox17
			// 
			this.textBox17.BackColor = System.Drawing.SystemColors.Window;
			this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox17.Location = new System.Drawing.Point(36, 335);
			this.textBox17.Name = "textBox17";
			this.textBox17.ReadOnly = true;
			this.textBox17.Size = new System.Drawing.Size(67, 13);
			this.textBox17.TabIndex = 15;
			this.textBox17.Text = "Pavarde";
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.SystemColors.Window;
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox9.Location = new System.Drawing.Point(36, 312);
			this.textBox9.Name = "textBox9";
			this.textBox9.ReadOnly = true;
			this.textBox9.Size = new System.Drawing.Size(67, 13);
			this.textBox9.TabIndex = 14;
			this.textBox9.Text = "Vardas";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.Window;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Location = new System.Drawing.Point(36, 86);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(67, 13);
			this.textBox3.TabIndex = 13;
			this.textBox3.Text = "Vardas";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.Window;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Location = new System.Drawing.Point(36, 112);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(67, 13);
			this.textBox4.TabIndex = 12;
			this.textBox4.Text = "Pavarde";
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.SystemColors.Window;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox7.Location = new System.Drawing.Point(36, 286);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(67, 13);
			this.textBox7.TabIndex = 11;
			this.textBox7.Text = "Id";
			// 
			// buttonDeleteEmployee
			// 
			this.buttonDeleteEmployee.Location = new System.Drawing.Point(460, 112);
			this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
			this.buttonDeleteEmployee.Size = new System.Drawing.Size(112, 38);
			this.buttonDeleteEmployee.TabIndex = 10;
			this.buttonDeleteEmployee.Text = "Istrinti darbuotoja";
			this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
			this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
			// 
			// textBoxDeleteEmployeeId
			// 
			this.textBoxDeleteEmployeeId.Location = new System.Drawing.Point(426, 86);
			this.textBoxDeleteEmployeeId.Name = "textBoxDeleteEmployeeId";
			this.textBoxDeleteEmployeeId.Size = new System.Drawing.Size(180, 20);
			this.textBoxDeleteEmployeeId.TabIndex = 9;
			// 
			// textBoxUpdateEmployeeId
			// 
			this.textBoxUpdateEmployeeId.Location = new System.Drawing.Point(109, 283);
			this.textBoxUpdateEmployeeId.Name = "textBoxUpdateEmployeeId";
			this.textBoxUpdateEmployeeId.Size = new System.Drawing.Size(180, 20);
			this.textBoxUpdateEmployeeId.TabIndex = 8;
			// 
			// buttonUpdateEmployee
			// 
			this.buttonUpdateEmployee.Location = new System.Drawing.Point(140, 361);
			this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
			this.buttonUpdateEmployee.Size = new System.Drawing.Size(112, 38);
			this.buttonUpdateEmployee.TabIndex = 7;
			this.buttonUpdateEmployee.Text = "Atnaujinti darbuotoja";
			this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
			this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
			// 
			// textBoxUpdateEmployeeSurname
			// 
			this.textBoxUpdateEmployeeSurname.Location = new System.Drawing.Point(109, 335);
			this.textBoxUpdateEmployeeSurname.Name = "textBoxUpdateEmployeeSurname";
			this.textBoxUpdateEmployeeSurname.Size = new System.Drawing.Size(180, 20);
			this.textBoxUpdateEmployeeSurname.TabIndex = 6;
			// 
			// textBoxUpdateEmployeeName
			// 
			this.textBoxUpdateEmployeeName.Location = new System.Drawing.Point(109, 309);
			this.textBoxUpdateEmployeeName.Name = "textBoxUpdateEmployeeName";
			this.textBoxUpdateEmployeeName.Size = new System.Drawing.Size(180, 20);
			this.textBoxUpdateEmployeeName.TabIndex = 5;
			// 
			// buttonAddEmployee
			// 
			this.buttonAddEmployee.Location = new System.Drawing.Point(140, 138);
			this.buttonAddEmployee.Name = "buttonAddEmployee";
			this.buttonAddEmployee.Size = new System.Drawing.Size(112, 38);
			this.buttonAddEmployee.TabIndex = 2;
			this.buttonAddEmployee.Text = "Prideti darbuotoja";
			this.buttonAddEmployee.UseVisualStyleBackColor = true;
			this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
			// 
			// textBoxInsertEmployeeSurname
			// 
			this.textBoxInsertEmployeeSurname.Location = new System.Drawing.Point(109, 112);
			this.textBoxInsertEmployeeSurname.Name = "textBoxInsertEmployeeSurname";
			this.textBoxInsertEmployeeSurname.Size = new System.Drawing.Size(180, 20);
			this.textBoxInsertEmployeeSurname.TabIndex = 1;
			// 
			// textBoxInsertEmployeeName
			// 
			this.textBoxInsertEmployeeName.Location = new System.Drawing.Point(109, 86);
			this.textBoxInsertEmployeeName.Name = "textBoxInsertEmployeeName";
			this.textBoxInsertEmployeeName.Size = new System.Drawing.Size(180, 20);
			this.textBoxInsertEmployeeName.TabIndex = 0;
			// 
			// tabAddServices
			// 
			this.tabAddServices.Controls.Add(this.textBox5);
			this.tabAddServices.Controls.Add(this.textBox6);
			this.tabAddServices.Controls.Add(this.textBox8);
			this.tabAddServices.Controls.Add(this.buttonAddService);
			this.tabAddServices.Controls.Add(this.textBoxServiceDefaultHours);
			this.tabAddServices.Controls.Add(this.textBoxServicePrice);
			this.tabAddServices.Controls.Add(this.textBoxServiceName);
			this.tabAddServices.Location = new System.Drawing.Point(4, 22);
			this.tabAddServices.Name = "tabAddServices";
			this.tabAddServices.Padding = new System.Windows.Forms.Padding(3);
			this.tabAddServices.Size = new System.Drawing.Size(1166, 481);
			this.tabAddServices.TabIndex = 12;
			this.tabAddServices.Text = "Serviso paslaugos";
			this.tabAddServices.UseVisualStyleBackColor = true;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.Window;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Location = new System.Drawing.Point(158, 75);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(95, 13);
			this.textBox5.TabIndex = 20;
			this.textBox5.Text = "Pavadinimas";
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.SystemColors.Window;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Location = new System.Drawing.Point(158, 101);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(95, 13);
			this.textBox6.TabIndex = 19;
			this.textBox6.Text = "Valandine kaina";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.SystemColors.Window;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox8.Location = new System.Drawing.Point(158, 127);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(95, 13);
			this.textBox8.TabIndex = 17;
			this.textBox8.Text = "Trukme valandomis";
			// 
			// buttonAddService
			// 
			this.buttonAddService.Location = new System.Drawing.Point(279, 165);
			this.buttonAddService.Name = "buttonAddService";
			this.buttonAddService.Size = new System.Drawing.Size(118, 35);
			this.buttonAddService.TabIndex = 3;
			this.buttonAddService.Text = "Prideti paslauga";
			this.buttonAddService.UseVisualStyleBackColor = true;
			this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
			// 
			// textBoxServiceDefaultHours
			// 
			this.textBoxServiceDefaultHours.Location = new System.Drawing.Point(259, 124);
			this.textBoxServiceDefaultHours.Name = "textBoxServiceDefaultHours";
			this.textBoxServiceDefaultHours.Size = new System.Drawing.Size(174, 20);
			this.textBoxServiceDefaultHours.TabIndex = 2;
			// 
			// textBoxServicePrice
			// 
			this.textBoxServicePrice.Location = new System.Drawing.Point(259, 98);
			this.textBoxServicePrice.Name = "textBoxServicePrice";
			this.textBoxServicePrice.Size = new System.Drawing.Size(174, 20);
			this.textBoxServicePrice.TabIndex = 1;
			// 
			// textBoxServiceName
			// 
			this.textBoxServiceName.Location = new System.Drawing.Point(259, 72);
			this.textBoxServiceName.Name = "textBoxServiceName";
			this.textBoxServiceName.Size = new System.Drawing.Size(174, 20);
			this.textBoxServiceName.TabIndex = 0;
			// 
			// SearchTab
			// 
			this.SearchTab.Location = new System.Drawing.Point(4, 22);
			this.SearchTab.Name = "SearchTab";
			this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
			this.SearchTab.Size = new System.Drawing.Size(1166, 481);
			this.SearchTab.TabIndex = 7;
			this.SearchTab.Text = "Paieška";
			this.SearchTab.UseVisualStyleBackColor = true;
			// 
			// SystemLogTab
			// 
			this.SystemLogTab.Controls.Add(this.richTextBox1);
			this.SystemLogTab.Location = new System.Drawing.Point(4, 22);
			this.SystemLogTab.Name = "SystemLogTab";
			this.SystemLogTab.Padding = new System.Windows.Forms.Padding(3);
			this.SystemLogTab.Size = new System.Drawing.Size(1166, 481);
			this.SystemLogTab.TabIndex = 10;
			this.SystemLogTab.Text = "Sistemos žurnalas";
			this.SystemLogTab.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(6, 6);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(818, 490);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "2016-11-09  16:03 Vartotojas Darbuotojas1 prisijungė į sistemą\n2016-11-09  16:04 " +
    "Užregistruotas naujas klientas Vardenis Pavardenis, Valst. Nr. AAA000\n\n";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// buttonPerson
			// 
			this.buttonPerson.Location = new System.Drawing.Point(441, 40);
			this.buttonPerson.Name = "buttonPerson";
			this.buttonPerson.Size = new System.Drawing.Size(75, 23);
			this.buttonPerson.TabIndex = 42;
			this.buttonPerson.Text = "Asmuo";
			this.buttonPerson.UseVisualStyleBackColor = true;
			// 
			// buttonCompany
			// 
			this.buttonCompany.Location = new System.Drawing.Point(581, 40);
			this.buttonCompany.Name = "buttonCompany";
			this.buttonCompany.Size = new System.Drawing.Size(75, 23);
			this.buttonCompany.TabIndex = 41;
			this.buttonCompany.Text = "Imone";
			this.buttonCompany.UseVisualStyleBackColor = true;
			// 
			// listBoxClients
			// 
			this.listBoxClients.FormattingEnabled = true;
			this.listBoxClients.Location = new System.Drawing.Point(441, 64);
			this.listBoxClients.Name = "listBoxClients";
			this.listBoxClients.Size = new System.Drawing.Size(215, 381);
			this.listBoxClients.TabIndex = 40;
			// 
			// buttonAddNewCar
			// 
			this.buttonAddNewCar.Location = new System.Drawing.Point(792, 341);
			this.buttonAddNewCar.Name = "buttonAddNewCar";
			this.buttonAddNewCar.Size = new System.Drawing.Size(141, 38);
			this.buttonAddNewCar.TabIndex = 39;
			this.buttonAddNewCar.Text = "Prideti automobili";
			this.buttonAddNewCar.UseVisualStyleBackColor = true;
			// 
			// textBox16
			// 
			this.textBox16.BackColor = System.Drawing.SystemColors.Window;
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox16.Location = new System.Drawing.Point(682, 305);
			this.textBox16.Name = "textBox16";
			this.textBox16.ReadOnly = true;
			this.textBox16.Size = new System.Drawing.Size(67, 13);
			this.textBox16.TabIndex = 38;
			this.textBox16.Text = "Metai";
			// 
			// textBox15
			// 
			this.textBox15.BackColor = System.Drawing.SystemColors.Window;
			this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox15.Location = new System.Drawing.Point(682, 279);
			this.textBox15.Name = "textBox15";
			this.textBox15.ReadOnly = true;
			this.textBox15.Size = new System.Drawing.Size(67, 13);
			this.textBox15.TabIndex = 37;
			this.textBox15.Text = "Variklis";
			// 
			// textBox14
			// 
			this.textBox14.BackColor = System.Drawing.SystemColors.Window;
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox14.Location = new System.Drawing.Point(682, 253);
			this.textBox14.Name = "textBox14";
			this.textBox14.ReadOnly = true;
			this.textBox14.Size = new System.Drawing.Size(67, 13);
			this.textBox14.TabIndex = 36;
			this.textBox14.Text = "Rida";
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.SystemColors.Window;
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox10.Location = new System.Drawing.Point(682, 149);
			this.textBox10.Name = "textBox10";
			this.textBox10.ReadOnly = true;
			this.textBox10.Size = new System.Drawing.Size(67, 13);
			this.textBox10.TabIndex = 35;
			this.textBox10.Text = "VIN";
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.SystemColors.Window;
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox11.Location = new System.Drawing.Point(682, 175);
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(67, 13);
			this.textBox11.TabIndex = 34;
			this.textBox11.Text = "Valstybinis nr";
			// 
			// textBox12
			// 
			this.textBox12.BackColor = System.Drawing.SystemColors.Window;
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox12.Location = new System.Drawing.Point(682, 227);
			this.textBox12.Name = "textBox12";
			this.textBox12.ReadOnly = true;
			this.textBox12.Size = new System.Drawing.Size(67, 13);
			this.textBox12.TabIndex = 33;
			this.textBox12.Text = "Modelis";
			// 
			// textBox13
			// 
			this.textBox13.BackColor = System.Drawing.SystemColors.Window;
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox13.Location = new System.Drawing.Point(682, 201);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(67, 13);
			this.textBox13.TabIndex = 32;
			this.textBox13.Text = "Marke";
			// 
			// textBoxCarYear
			// 
			this.textBoxCarYear.Location = new System.Drawing.Point(755, 302);
			this.textBoxCarYear.MaxLength = 50;
			this.textBoxCarYear.Name = "textBoxCarYear";
			this.textBoxCarYear.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarYear.TabIndex = 31;
			// 
			// textBoxCarEngine
			// 
			this.textBoxCarEngine.Location = new System.Drawing.Point(755, 276);
			this.textBoxCarEngine.MaxLength = 50;
			this.textBoxCarEngine.Name = "textBoxCarEngine";
			this.textBoxCarEngine.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarEngine.TabIndex = 30;
			// 
			// textBoxCarRun
			// 
			this.textBoxCarRun.Location = new System.Drawing.Point(755, 250);
			this.textBoxCarRun.MaxLength = 50;
			this.textBoxCarRun.Name = "textBoxCarRun";
			this.textBoxCarRun.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarRun.TabIndex = 29;
			// 
			// textBoxCarModel
			// 
			this.textBoxCarModel.Location = new System.Drawing.Point(755, 224);
			this.textBoxCarModel.MaxLength = 50;
			this.textBoxCarModel.Name = "textBoxCarModel";
			this.textBoxCarModel.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarModel.TabIndex = 28;
			// 
			// textBoxCarMake
			// 
			this.textBoxCarMake.Location = new System.Drawing.Point(755, 198);
			this.textBoxCarMake.MaxLength = 50;
			this.textBoxCarMake.Name = "textBoxCarMake";
			this.textBoxCarMake.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarMake.TabIndex = 27;
			// 
			// textBoxCarPlate
			// 
			this.textBoxCarPlate.Location = new System.Drawing.Point(755, 172);
			this.textBoxCarPlate.MaxLength = 50;
			this.textBoxCarPlate.Name = "textBoxCarPlate";
			this.textBoxCarPlate.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarPlate.TabIndex = 26;
			// 
			// textBoxCarVIN
			// 
			this.textBoxCarVIN.Location = new System.Drawing.Point(755, 146);
			this.textBoxCarVIN.MaxLength = 50;
			this.textBoxCarVIN.Name = "textBoxCarVIN";
			this.textBoxCarVIN.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarVIN.TabIndex = 25;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1173, 520);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.Text = "Mechanikas";
			this.tabControl.ResumeLayout(false);
			this.RegistrateClientTab.ResumeLayout(false);
			this.RegistrateClientTab.PerformLayout();
			this.tabAddCar.ResumeLayout(false);
			this.tabAddCar.PerformLayout();
			this.JobsTab.ResumeLayout(false);
			this.JobsTab.PerformLayout();
			this.EmployeesTab.ResumeLayout(false);
			this.EmployeesTab.PerformLayout();
			this.tabAddServices.ResumeLayout(false);
			this.tabAddServices.PerformLayout();
			this.SystemLogTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage RegistrateClientTab;
		private System.Windows.Forms.TabPage EmployeesTab;
		private System.Windows.Forms.TabPage SearchTab;
		private System.Windows.Forms.TabPage JobsTab;
		private System.Windows.Forms.TabPage SystemLogTab;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBoxTelephone;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Button buttonRegisterClient;
		private System.Windows.Forms.Button buttonAddEmployee;
		private System.Windows.Forms.TextBox textBoxInsertEmployeeSurname;
		private System.Windows.Forms.TextBox textBoxInsertEmployeeName;
		private System.Windows.Forms.Button buttonUpdateEmployee;
		private System.Windows.Forms.TextBox textBoxUpdateEmployeeSurname;
		private System.Windows.Forms.TextBox textBoxUpdateEmployeeName;
		private System.Windows.Forms.TextBox textBoxUpdateEmployeeId;
		private System.Windows.Forms.Button buttonDeleteEmployee;
		private System.Windows.Forms.TextBox textBoxDeleteEmployeeId;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonSelectPerson;
		private System.Windows.Forms.Button buttonSelectCompany;
		private System.Windows.Forms.TextBox textClient1;
		private System.Windows.Forms.TextBox textClient2;
		private System.Windows.Forms.TextBox textBoxClient1;
		private System.Windows.Forms.TextBox textBoxClient2;
		private System.Windows.Forms.TabPage tabAddCar;
		private System.Windows.Forms.ListBox listBoxArrivedCars;
		private System.Windows.Forms.ListBox listBoxCarJobs;
		private System.Windows.Forms.Button buttonAddJobToCar;
		private System.Windows.Forms.ListBox listBoxServices;
		private System.Windows.Forms.Button buttonFinishJob;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.ListBox listBoxClientCars;
		private System.Windows.Forms.Button buttonCarLeft;
		private System.Windows.Forms.Button buttonCarArrived;
		private System.Windows.Forms.TabPage tabAddServices;
		private System.Windows.Forms.Button buttonAddService;
		private System.Windows.Forms.TextBox textBoxServiceDefaultHours;
		private System.Windows.Forms.TextBox textBoxServicePrice;
		private System.Windows.Forms.TextBox textBoxServiceName;
		private System.Windows.Forms.Button buttonDeleteJob;
		private System.Windows.Forms.ListBox listBoxJobEmployees;
		private System.Windows.Forms.Button buttonAddEmployeeToJob;
		private System.Windows.Forms.ListBox listBoxEmployees;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonPerson;
		private System.Windows.Forms.Button buttonCompany;
		private System.Windows.Forms.ListBox listBoxClients;
		private System.Windows.Forms.Button buttonAddNewCar;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBoxCarYear;
		private System.Windows.Forms.TextBox textBoxCarEngine;
		private System.Windows.Forms.TextBox textBoxCarRun;
		private System.Windows.Forms.TextBox textBoxCarModel;
		private System.Windows.Forms.TextBox textBoxCarMake;
		private System.Windows.Forms.TextBox textBoxCarPlate;
		private System.Windows.Forms.TextBox textBoxCarVIN;
	}
}

