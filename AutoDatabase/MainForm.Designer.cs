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
			this.tabControl1 = new System.Windows.Forms.TabControl();
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
			this.textBoxTelefonas = new System.Windows.Forms.TextBox();
			this.textBoxAdresas = new System.Windows.Forms.TextBox();
			this.BuyPartsTab = new System.Windows.Forms.TabPage();
			this.JobsTab = new System.Windows.Forms.TabPage();
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
			this.PartsForClientTab = new System.Windows.Forms.TabPage();
			this.DocumentsTab = new System.Windows.Forms.TabPage();
			this.SearchTab = new System.Windows.Forms.TabPage();
			this.DataEntryTab = new System.Windows.Forms.TabPage();
			this.DataEditTab = new System.Windows.Forms.TabPage();
			this.SystemLogTab = new System.Windows.Forms.TabPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.autoShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carTableAdapter = new AutoDatabase.AutoShopDataSetTableAdapters.CarTableAdapter();
			this.employeeTableAdapter = new AutoDatabase.AutoShopDataSetTableAdapters.EmployeeTableAdapter();
			this.tabControl1.SuspendLayout();
			this.RegistrateClientTab.SuspendLayout();
			this.EmployeesTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoShopDataSet)).BeginInit();
			this.SystemLogTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.autoShopDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.RegistrateClientTab);
			this.tabControl1.Controls.Add(this.BuyPartsTab);
			this.tabControl1.Controls.Add(this.JobsTab);
			this.tabControl1.Controls.Add(this.EmployeesTab);
			this.tabControl1.Controls.Add(this.PartsForClientTab);
			this.tabControl1.Controls.Add(this.DocumentsTab);
			this.tabControl1.Controls.Add(this.SearchTab);
			this.tabControl1.Controls.Add(this.DataEntryTab);
			this.tabControl1.Controls.Add(this.DataEditTab);
			this.tabControl1.Controls.Add(this.SystemLogTab);
			this.tabControl1.Location = new System.Drawing.Point(-1, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(857, 551);
			this.tabControl1.TabIndex = 0;
			// 
			// RegistrateClientTab
			// 
			this.RegistrateClientTab.Controls.Add(this.textClient1);
			this.RegistrateClientTab.Controls.Add(this.textClient2);
			this.RegistrateClientTab.Controls.Add(this.textBoxClient1);
			this.RegistrateClientTab.Controls.Add(this.textBoxClient2);
			this.RegistrateClientTab.Controls.Add(this.textBox2);
			this.RegistrateClientTab.Controls.Add(this.textBox1);
			this.RegistrateClientTab.Controls.Add(this.buttonSelectPerson);
			this.RegistrateClientTab.Controls.Add(this.buttonSelectCompany);
			this.RegistrateClientTab.Controls.Add(this.buttonRegisterClient);
			this.RegistrateClientTab.Controls.Add(this.textBoxTelefonas);
			this.RegistrateClientTab.Controls.Add(this.textBoxAdresas);
			this.RegistrateClientTab.Location = new System.Drawing.Point(4, 22);
			this.RegistrateClientTab.Name = "RegistrateClientTab";
			this.RegistrateClientTab.Padding = new System.Windows.Forms.Padding(3);
			this.RegistrateClientTab.Size = new System.Drawing.Size(849, 525);
			this.RegistrateClientTab.TabIndex = 0;
			this.RegistrateClientTab.Text = "Registruoti klientą";
			this.RegistrateClientTab.UseVisualStyleBackColor = true;
			// 
			// textClient1
			// 
			this.textClient1.BackColor = System.Drawing.SystemColors.Window;
			this.textClient1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textClient1.Location = new System.Drawing.Point(192, 165);
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
			this.textClient2.Location = new System.Drawing.Point(192, 191);
			this.textClient2.Name = "textClient2";
			this.textClient2.ReadOnly = true;
			this.textClient2.Size = new System.Drawing.Size(67, 13);
			this.textClient2.TabIndex = 9;
			this.textClient2.Text = "Pavarde";
			// 
			// textBoxClient1
			// 
			this.textBoxClient1.Location = new System.Drawing.Point(265, 162);
			this.textBoxClient1.Name = "textBoxClient1";
			this.textBoxClient1.Size = new System.Drawing.Size(224, 20);
			this.textBoxClient1.TabIndex = 8;
			// 
			// textBoxClient2
			// 
			this.textBoxClient2.Location = new System.Drawing.Point(265, 188);
			this.textBoxClient2.Name = "textBoxClient2";
			this.textBoxClient2.Size = new System.Drawing.Size(224, 20);
			this.textBoxClient2.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Window;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Location = new System.Drawing.Point(192, 243);
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
			this.textBox1.Location = new System.Drawing.Point(192, 217);
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
			this.buttonSelectCompany.Location = new System.Drawing.Point(607, 64);
			this.buttonSelectCompany.Name = "buttonSelectCompany";
			this.buttonSelectCompany.Size = new System.Drawing.Size(91, 37);
			this.buttonSelectCompany.TabIndex = 3;
			this.buttonSelectCompany.Text = "Imone";
			this.buttonSelectCompany.UseVisualStyleBackColor = true;
			this.buttonSelectCompany.Click += new System.EventHandler(this.buttonSelectCompany_Click);
			// 
			// buttonRegisterClient
			// 
			this.buttonRegisterClient.Location = new System.Drawing.Point(313, 266);
			this.buttonRegisterClient.Name = "buttonRegisterClient";
			this.buttonRegisterClient.Size = new System.Drawing.Size(123, 35);
			this.buttonRegisterClient.TabIndex = 2;
			this.buttonRegisterClient.Text = "Registruoti";
			this.buttonRegisterClient.UseVisualStyleBackColor = true;
			// 
			// textBoxTelefonas
			// 
			this.textBoxTelefonas.Location = new System.Drawing.Point(265, 240);
			this.textBoxTelefonas.Name = "textBoxTelefonas";
			this.textBoxTelefonas.Size = new System.Drawing.Size(224, 20);
			this.textBoxTelefonas.TabIndex = 1;
			// 
			// textBoxAdresas
			// 
			this.textBoxAdresas.Location = new System.Drawing.Point(265, 214);
			this.textBoxAdresas.Name = "textBoxAdresas";
			this.textBoxAdresas.Size = new System.Drawing.Size(224, 20);
			this.textBoxAdresas.TabIndex = 0;
			// 
			// BuyPartsTab
			// 
			this.BuyPartsTab.Location = new System.Drawing.Point(4, 22);
			this.BuyPartsTab.Name = "BuyPartsTab";
			this.BuyPartsTab.Padding = new System.Windows.Forms.Padding(3);
			this.BuyPartsTab.Size = new System.Drawing.Size(849, 525);
			this.BuyPartsTab.TabIndex = 1;
			this.BuyPartsTab.Text = "Pirkti detales";
			this.BuyPartsTab.UseVisualStyleBackColor = true;
			// 
			// JobsTab
			// 
			this.JobsTab.Location = new System.Drawing.Point(4, 22);
			this.JobsTab.Name = "JobsTab";
			this.JobsTab.Padding = new System.Windows.Forms.Padding(3);
			this.JobsTab.Size = new System.Drawing.Size(849, 525);
			this.JobsTab.TabIndex = 9;
			this.JobsTab.Text = "Darbai";
			this.JobsTab.UseVisualStyleBackColor = true;
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
			this.EmployeesTab.Size = new System.Drawing.Size(849, 525);
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
			// PartsForClientTab
			// 
			this.PartsForClientTab.Location = new System.Drawing.Point(4, 22);
			this.PartsForClientTab.Name = "PartsForClientTab";
			this.PartsForClientTab.Padding = new System.Windows.Forms.Padding(3);
			this.PartsForClientTab.Size = new System.Drawing.Size(849, 525);
			this.PartsForClientTab.TabIndex = 5;
			this.PartsForClientTab.Text = "Detalės klientui";
			this.PartsForClientTab.UseVisualStyleBackColor = true;
			// 
			// DocumentsTab
			// 
			this.DocumentsTab.Location = new System.Drawing.Point(4, 22);
			this.DocumentsTab.Name = "DocumentsTab";
			this.DocumentsTab.Padding = new System.Windows.Forms.Padding(3);
			this.DocumentsTab.Size = new System.Drawing.Size(849, 525);
			this.DocumentsTab.TabIndex = 6;
			this.DocumentsTab.Text = "Dokumentai";
			this.DocumentsTab.UseVisualStyleBackColor = true;
			// 
			// SearchTab
			// 
			this.SearchTab.Location = new System.Drawing.Point(4, 22);
			this.SearchTab.Name = "SearchTab";
			this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
			this.SearchTab.Size = new System.Drawing.Size(849, 525);
			this.SearchTab.TabIndex = 7;
			this.SearchTab.Text = "Paieška";
			this.SearchTab.UseVisualStyleBackColor = true;
			// 
			// DataEntryTab
			// 
			this.DataEntryTab.Location = new System.Drawing.Point(4, 22);
			this.DataEntryTab.Name = "DataEntryTab";
			this.DataEntryTab.Padding = new System.Windows.Forms.Padding(3);
			this.DataEntryTab.Size = new System.Drawing.Size(849, 525);
			this.DataEntryTab.TabIndex = 8;
			this.DataEntryTab.Text = "Duomenų įvedimas";
			this.DataEntryTab.UseVisualStyleBackColor = true;
			// 
			// DataEditTab
			// 
			this.DataEditTab.Location = new System.Drawing.Point(4, 22);
			this.DataEditTab.Name = "DataEditTab";
			this.DataEditTab.Padding = new System.Windows.Forms.Padding(3);
			this.DataEditTab.Size = new System.Drawing.Size(849, 525);
			this.DataEditTab.TabIndex = 3;
			this.DataEditTab.Text = "Redaguoti duomenis";
			this.DataEditTab.UseVisualStyleBackColor = true;
			// 
			// SystemLogTab
			// 
			this.SystemLogTab.Controls.Add(this.richTextBox1);
			this.SystemLogTab.Location = new System.Drawing.Point(4, 22);
			this.SystemLogTab.Name = "SystemLogTab";
			this.SystemLogTab.Padding = new System.Windows.Forms.Padding(3);
			this.SystemLogTab.Size = new System.Drawing.Size(849, 525);
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
			// autoShopDataSetBindingSource
			// 
			this.autoShopDataSetBindingSource.DataSource = this.autoShopDataSet;
			this.autoShopDataSetBindingSource.Position = 0;
			// 
			// carBindingSource
			// 
			this.carBindingSource.DataMember = "Car";
			this.carBindingSource.DataSource = this.autoShopDataSet;
			// 
			// carTableAdapter
			// 
			this.carTableAdapter.ClearBeforeFill = true;
			// 
			// employeeTableAdapter
			// 
			this.employeeTableAdapter.ClearBeforeFill = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 564);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Mechanikas";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.RegistrateClientTab.ResumeLayout(false);
			this.RegistrateClientTab.PerformLayout();
			this.EmployeesTab.ResumeLayout(false);
			this.EmployeesTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoShopDataSet)).EndInit();
			this.SystemLogTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.autoShopDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage RegistrateClientTab;
		private System.Windows.Forms.TabPage BuyPartsTab;
		private System.Windows.Forms.TabPage DataEditTab;
		private System.Windows.Forms.TabPage EmployeesTab;
		private System.Windows.Forms.TabPage PartsForClientTab;
		private System.Windows.Forms.TabPage DocumentsTab;
		private System.Windows.Forms.TabPage SearchTab;
		private System.Windows.Forms.TabPage DataEntryTab;
		private System.Windows.Forms.TabPage JobsTab;
		private System.Windows.Forms.TabPage SystemLogTab;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBoxTelefonas;
		private System.Windows.Forms.TextBox textBoxAdresas;
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
		private System.Windows.Forms.BindingSource autoShopDataSetBindingSource;
		private AutoShopDataSet autoShopDataSet;
		private System.Windows.Forms.BindingSource carBindingSource;
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
	}
}

