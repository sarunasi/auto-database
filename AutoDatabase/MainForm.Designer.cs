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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.RegistrateClientTab = new System.Windows.Forms.TabPage();
			this.dataGridViewClients = new System.Windows.Forms.DataGridView();
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
			this.JobsTab = new System.Windows.Forms.TabPage();
			this.listBoxCars = new System.Windows.Forms.ListBox();
			this.EmployeesTab = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.autoShopDataSet = new AutoDatabase.AutoShopDataSet();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.buttonDeleteEmployee = new System.Windows.Forms.Button();
			this.textBoxDeleteEmployeeId = new System.Windows.Forms.TextBox();
			this.textBoxUpdateEmployeeId = new System.Windows.Forms.TextBox();
			this.buttonUpdateEmployee = new System.Windows.Forms.Button();
			this.textBoxUpdateEmployeeSurname = new System.Windows.Forms.TextBox();
			this.textBoxUpdateEmployeeName = new System.Windows.Forms.TextBox();
			this.buttonAddEmployee = new System.Windows.Forms.Button();
			this.textBoxInsertEmployeeSurname = new System.Windows.Forms.TextBox();
			this.textBoxInsertEmployeeName = new System.Windows.Forms.TextBox();
			this.SearchTab = new System.Windows.Forms.TabPage();
			this.SystemLogTab = new System.Windows.Forms.TabPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.carTableAdapter = new AutoDatabase.AutoShopDataSetTableAdapters.CarTableAdapter();
			this.employeeTableAdapter = new AutoDatabase.AutoShopDataSetTableAdapters.EmployeeTableAdapter();
			this.clientTableAdapter = new AutoDatabase.AutoShopDataSetTableAdapters.ClientTableAdapter();
			this.personTableAdapter = new AutoDatabase.AutoShopDataSetTableAdapters.PersonTableAdapter();
			this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.listBoxServices = new System.Windows.Forms.ListBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.buttonAddServiceToCar = new System.Windows.Forms.Button();
			this.listBoxCarJobs = new System.Windows.Forms.ListBox();
			this.tabControl.SuspendLayout();
			this.RegistrateClientTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
			this.tabAddCar.SuspendLayout();
			this.JobsTab.SuspendLayout();
			this.EmployeesTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoShopDataSet)).BeginInit();
			this.SystemLogTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
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
			this.tabControl.Controls.Add(this.SearchTab);
			this.tabControl.Controls.Add(this.SystemLogTab);
			this.tabControl.Location = new System.Drawing.Point(-1, 1);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1174, 507);
			this.tabControl.TabIndex = 0;
			// 
			// RegistrateClientTab
			// 
			this.RegistrateClientTab.Controls.Add(this.dataGridViewClients);
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
			// dataGridViewClients
			// 
			this.dataGridViewClients.AllowUserToAddRows = false;
			this.dataGridViewClients.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewClients.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewClients.Location = new System.Drawing.Point(418, 40);
			this.dataGridViewClients.Name = "dataGridViewClients";
			this.dataGridViewClients.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewClients.Size = new System.Drawing.Size(350, 252);
			this.dataGridViewClients.TabIndex = 11;
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
			this.textBoxClient1.Name = "textBoxClient1";
			this.textBoxClient1.Size = new System.Drawing.Size(224, 20);
			this.textBoxClient1.TabIndex = 8;
			// 
			// textBoxClient2
			// 
			this.textBoxClient2.Location = new System.Drawing.Point(121, 179);
			this.textBoxClient2.Name = "textBoxClient2";
			this.textBoxClient2.Size = new System.Drawing.Size(224, 20);
			this.textBoxClient2.TabIndex = 7;
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
			this.textBoxTelephone.Name = "textBoxTelephone";
			this.textBoxTelephone.Size = new System.Drawing.Size(224, 20);
			this.textBoxTelephone.TabIndex = 1;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(121, 205);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(224, 20);
			this.textBoxAddress.TabIndex = 0;
			// 
			// tabAddCar
			// 
			this.tabAddCar.Controls.Add(this.listBoxClients);
			this.tabAddCar.Controls.Add(this.buttonAddNewCar);
			this.tabAddCar.Controls.Add(this.textBox16);
			this.tabAddCar.Controls.Add(this.textBox15);
			this.tabAddCar.Controls.Add(this.textBox14);
			this.tabAddCar.Controls.Add(this.textBox10);
			this.tabAddCar.Controls.Add(this.textBox11);
			this.tabAddCar.Controls.Add(this.textBox12);
			this.tabAddCar.Controls.Add(this.textBox13);
			this.tabAddCar.Controls.Add(this.textBoxCarYear);
			this.tabAddCar.Controls.Add(this.textBoxCarEngine);
			this.tabAddCar.Controls.Add(this.textBoxCarRun);
			this.tabAddCar.Controls.Add(this.textBoxCarModel);
			this.tabAddCar.Controls.Add(this.textBoxCarMake);
			this.tabAddCar.Controls.Add(this.textBoxCarPlate);
			this.tabAddCar.Controls.Add(this.textBoxCarVIN);
			this.tabAddCar.Location = new System.Drawing.Point(4, 22);
			this.tabAddCar.Name = "tabAddCar";
			this.tabAddCar.Padding = new System.Windows.Forms.Padding(3);
			this.tabAddCar.Size = new System.Drawing.Size(1166, 481);
			this.tabAddCar.TabIndex = 11;
			this.tabAddCar.Text = "Prideti Automobili";
			this.tabAddCar.UseVisualStyleBackColor = true;
			// 
			// listBoxClients
			// 
			this.listBoxClients.FormattingEnabled = true;
			this.listBoxClients.Location = new System.Drawing.Point(23, 30);
			this.listBoxClients.Name = "listBoxClients";
			this.listBoxClients.Size = new System.Drawing.Size(215, 381);
			this.listBoxClients.TabIndex = 19;
			// 
			// buttonAddNewCar
			// 
			this.buttonAddNewCar.Location = new System.Drawing.Point(560, 242);
			this.buttonAddNewCar.Name = "buttonAddNewCar";
			this.buttonAddNewCar.Size = new System.Drawing.Size(141, 38);
			this.buttonAddNewCar.TabIndex = 18;
			this.buttonAddNewCar.Text = "Prideti automobili";
			this.buttonAddNewCar.UseVisualStyleBackColor = true;
			this.buttonAddNewCar.Click += new System.EventHandler(this.buttonAddNewCar_Click);
			// 
			// textBox16
			// 
			this.textBox16.BackColor = System.Drawing.SystemColors.Window;
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox16.Location = new System.Drawing.Point(450, 206);
			this.textBox16.Name = "textBox16";
			this.textBox16.ReadOnly = true;
			this.textBox16.Size = new System.Drawing.Size(67, 13);
			this.textBox16.TabIndex = 17;
			this.textBox16.Text = "Metai";
			// 
			// textBox15
			// 
			this.textBox15.BackColor = System.Drawing.SystemColors.Window;
			this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox15.Location = new System.Drawing.Point(450, 180);
			this.textBox15.Name = "textBox15";
			this.textBox15.ReadOnly = true;
			this.textBox15.Size = new System.Drawing.Size(67, 13);
			this.textBox15.TabIndex = 16;
			this.textBox15.Text = "Variklis";
			// 
			// textBox14
			// 
			this.textBox14.BackColor = System.Drawing.SystemColors.Window;
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox14.Location = new System.Drawing.Point(450, 154);
			this.textBox14.Name = "textBox14";
			this.textBox14.ReadOnly = true;
			this.textBox14.Size = new System.Drawing.Size(67, 13);
			this.textBox14.TabIndex = 15;
			this.textBox14.Text = "Rida";
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.SystemColors.Window;
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox10.Location = new System.Drawing.Point(450, 50);
			this.textBox10.Name = "textBox10";
			this.textBox10.ReadOnly = true;
			this.textBox10.Size = new System.Drawing.Size(67, 13);
			this.textBox10.TabIndex = 14;
			this.textBox10.Text = "VIN";
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.SystemColors.Window;
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox11.Location = new System.Drawing.Point(450, 76);
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(67, 13);
			this.textBox11.TabIndex = 13;
			this.textBox11.Text = "Valstybinis nr";
			// 
			// textBox12
			// 
			this.textBox12.BackColor = System.Drawing.SystemColors.Window;
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox12.Location = new System.Drawing.Point(450, 128);
			this.textBox12.Name = "textBox12";
			this.textBox12.ReadOnly = true;
			this.textBox12.Size = new System.Drawing.Size(67, 13);
			this.textBox12.TabIndex = 12;
			this.textBox12.Text = "Modelis";
			// 
			// textBox13
			// 
			this.textBox13.BackColor = System.Drawing.SystemColors.Window;
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox13.Location = new System.Drawing.Point(450, 102);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(67, 13);
			this.textBox13.TabIndex = 11;
			this.textBox13.Text = "Marke";
			// 
			// textBoxCarYear
			// 
			this.textBoxCarYear.Location = new System.Drawing.Point(523, 203);
			this.textBoxCarYear.Name = "textBoxCarYear";
			this.textBoxCarYear.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarYear.TabIndex = 7;
			// 
			// textBoxCarEngine
			// 
			this.textBoxCarEngine.Location = new System.Drawing.Point(523, 177);
			this.textBoxCarEngine.Name = "textBoxCarEngine";
			this.textBoxCarEngine.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarEngine.TabIndex = 6;
			// 
			// textBoxCarRun
			// 
			this.textBoxCarRun.Location = new System.Drawing.Point(523, 151);
			this.textBoxCarRun.Name = "textBoxCarRun";
			this.textBoxCarRun.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarRun.TabIndex = 5;
			// 
			// textBoxCarModel
			// 
			this.textBoxCarModel.Location = new System.Drawing.Point(523, 125);
			this.textBoxCarModel.Name = "textBoxCarModel";
			this.textBoxCarModel.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarModel.TabIndex = 4;
			// 
			// textBoxCarMake
			// 
			this.textBoxCarMake.Location = new System.Drawing.Point(523, 99);
			this.textBoxCarMake.Name = "textBoxCarMake";
			this.textBoxCarMake.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarMake.TabIndex = 3;
			// 
			// textBoxCarPlate
			// 
			this.textBoxCarPlate.Location = new System.Drawing.Point(523, 73);
			this.textBoxCarPlate.Name = "textBoxCarPlate";
			this.textBoxCarPlate.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarPlate.TabIndex = 2;
			// 
			// textBoxCarVIN
			// 
			this.textBoxCarVIN.Location = new System.Drawing.Point(523, 47);
			this.textBoxCarVIN.Name = "textBoxCarVIN";
			this.textBoxCarVIN.Size = new System.Drawing.Size(210, 20);
			this.textBoxCarVIN.TabIndex = 1;
			// 
			// JobsTab
			// 
			this.JobsTab.Controls.Add(this.listBoxCarJobs);
			this.JobsTab.Controls.Add(this.buttonAddServiceToCar);
			this.JobsTab.Controls.Add(this.textBox3);
			this.JobsTab.Controls.Add(this.listBoxServices);
			this.JobsTab.Controls.Add(this.listBoxCars);
			this.JobsTab.Location = new System.Drawing.Point(4, 22);
			this.JobsTab.Name = "JobsTab";
			this.JobsTab.Padding = new System.Windows.Forms.Padding(3);
			this.JobsTab.Size = new System.Drawing.Size(1166, 481);
			this.JobsTab.TabIndex = 9;
			this.JobsTab.Text = "Darbai";
			this.JobsTab.UseVisualStyleBackColor = true;
			// 
			// listBoxCars
			// 
			this.listBoxCars.FormattingEnabled = true;
			this.listBoxCars.Location = new System.Drawing.Point(25, 21);
			this.listBoxCars.Name = "listBoxCars";
			this.listBoxCars.Size = new System.Drawing.Size(206, 433);
			this.listBoxCars.TabIndex = 1;
			this.listBoxCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
			// 
			// EmployeesTab
			// 
			this.EmployeesTab.Controls.Add(this.dataGridView1);
			this.EmployeesTab.Controls.Add(this.comboBox1);
			this.EmployeesTab.Controls.Add(this.listBox1);
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
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.employeeBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(331, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(271, 316);
			this.dataGridView1.TabIndex = 13;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// surnameDataGridViewTextBoxColumn
			// 
			this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
			this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
			this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
			this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataMember = "Employee";
			this.employeeBindingSource.DataSource = this.autoShopDataSet;
			// 
			// autoShopDataSet
			// 
			this.autoShopDataSet.DataSetName = "AutoShopDataSet";
			this.autoShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.employeeBindingSource;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(678, 377);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 12;
			// 
			// listBox1
			// 
			this.listBox1.DataSource = this.employeeBindingSource;
			this.listBox1.DisplayMember = "Name";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(625, 28);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(192, 316);
			this.listBox1.TabIndex = 11;
			this.listBox1.ValueMember = "Surname";
			// 
			// buttonDeleteEmployee
			// 
			this.buttonDeleteEmployee.Location = new System.Drawing.Point(471, 421);
			this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
			this.buttonDeleteEmployee.Size = new System.Drawing.Size(112, 38);
			this.buttonDeleteEmployee.TabIndex = 10;
			this.buttonDeleteEmployee.Text = "Istrinti darbuotoja";
			this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
			this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
			// 
			// textBoxDeleteEmployeeId
			// 
			this.textBoxDeleteEmployeeId.Location = new System.Drawing.Point(439, 395);
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
			this.buttonUpdateEmployee.Location = new System.Drawing.Point(140, 377);
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
			this.buttonAddEmployee.Location = new System.Drawing.Point(140, 178);
			this.buttonAddEmployee.Name = "buttonAddEmployee";
			this.buttonAddEmployee.Size = new System.Drawing.Size(112, 38);
			this.buttonAddEmployee.TabIndex = 2;
			this.buttonAddEmployee.Text = "Prideti darbuotoja";
			this.buttonAddEmployee.UseVisualStyleBackColor = true;
			this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
			// 
			// textBoxInsertEmployeeSurname
			// 
			this.textBoxInsertEmployeeSurname.Location = new System.Drawing.Point(109, 125);
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
			// SearchTab
			// 
			this.SearchTab.Location = new System.Drawing.Point(4, 22);
			this.SearchTab.Name = "SearchTab";
			this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
			this.SearchTab.Size = new System.Drawing.Size(997, 648);
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
			this.SystemLogTab.Size = new System.Drawing.Size(997, 648);
			this.SystemLogTab.TabIndex = 10;
			this.SystemLogTab.Text = "Sistemos žurnalas";
			this.SystemLogTab.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(8, 40);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(818, 490);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "2016-11-09  16:03 Vartotojas Darbuotojas1 prisijungė į sistemą\n2016-11-09  16:04 " +
    "Užregistruotas naujas klientas Vardenis Pavardenis, Valst. Nr. AAA000\n\n";
			// 
			// carTableAdapter
			// 
			this.carTableAdapter.ClearBeforeFill = true;
			// 
			// employeeTableAdapter
			// 
			this.employeeTableAdapter.ClearBeforeFill = true;
			// 
			// clientTableAdapter
			// 
			this.clientTableAdapter.ClearBeforeFill = true;
			// 
			// personTableAdapter
			// 
			this.personTableAdapter.ClearBeforeFill = true;
			// 
			// clientBindingSource
			// 
			this.clientBindingSource.DataMember = "Client";
			this.clientBindingSource.DataSource = this.autoShopDataSet;
			// 
			// listBoxServices
			// 
			this.listBoxServices.FormattingEnabled = true;
			this.listBoxServices.Location = new System.Drawing.Point(924, 21);
			this.listBoxServices.Name = "listBoxServices";
			this.listBoxServices.Size = new System.Drawing.Size(206, 433);
			this.listBoxServices.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(806, 21);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(112, 20);
			this.textBox3.TabIndex = 3;
			// 
			// buttonAddServiceToCar
			// 
			this.buttonAddServiceToCar.Location = new System.Drawing.Point(816, 47);
			this.buttonAddServiceToCar.Name = "buttonAddServiceToCar";
			this.buttonAddServiceToCar.Size = new System.Drawing.Size(90, 40);
			this.buttonAddServiceToCar.TabIndex = 4;
			this.buttonAddServiceToCar.Text = "Prideti darba";
			this.buttonAddServiceToCar.UseVisualStyleBackColor = true;
			// 
			// listBoxCarJobs
			// 
			this.listBoxCarJobs.FormattingEnabled = true;
			this.listBoxCarJobs.Location = new System.Drawing.Point(249, 21);
			this.listBoxCarJobs.Name = "listBoxCarJobs";
			this.listBoxCarJobs.Size = new System.Drawing.Size(206, 433);
			this.listBoxCarJobs.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1173, 520);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.Text = "Mechanikas";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl.ResumeLayout(false);
			this.RegistrateClientTab.ResumeLayout(false);
			this.RegistrateClientTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
			this.tabAddCar.ResumeLayout(false);
			this.tabAddCar.PerformLayout();
			this.JobsTab.ResumeLayout(false);
			this.JobsTab.PerformLayout();
			this.EmployeesTab.ResumeLayout(false);
			this.EmployeesTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoShopDataSet)).EndInit();
			this.SystemLogTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
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
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ListBox listBox1;
		private AutoShopDataSet autoShopDataSet;
		private AutoShopDataSetTableAdapters.CarTableAdapter carTableAdapter;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private AutoShopDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonSelectPerson;
		private System.Windows.Forms.Button buttonSelectCompany;
		private System.Windows.Forms.TextBox textClient1;
		private System.Windows.Forms.TextBox textClient2;
		private System.Windows.Forms.TextBox textBoxClient1;
		private System.Windows.Forms.TextBox textBoxClient2;
		private System.Windows.Forms.DataGridView dataGridViewClients;
		private AutoShopDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
		private AutoShopDataSetTableAdapters.PersonTableAdapter personTableAdapter;
		private System.Windows.Forms.BindingSource clientBindingSource;
		private System.Windows.Forms.TabPage tabAddCar;
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
		private System.Windows.Forms.Button buttonAddNewCar;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.ListBox listBoxCars;
		private System.Windows.Forms.ListBox listBoxClients;
		private System.Windows.Forms.ListBox listBoxCarJobs;
		private System.Windows.Forms.Button buttonAddServiceToCar;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ListBox listBoxServices;
	}
}

