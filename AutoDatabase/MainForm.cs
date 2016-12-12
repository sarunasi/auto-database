using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
	public partial class MainForm : Form
	{
		DataSet dataSet;
		EmployeeTable employees;
		
		public MainForm()
		{
			InitializeComponent();
			dataSet = new DataSet();
			employees = new EmployeeTable(Properties.Settings.Default.connectionString, dataSet);
			//this.darbuotojasTableAdapter.Fill(this.autoShopDataSet.Darbuotojas);

		}

		private void buttonRegisterClient_Click(object sender, EventArgs e)
		{
			
		}

		private void buttonAddEmployee_Click(object sender, EventArgs e)
		{
			employees.Insert(textBoxDarbuotojasVardas.Text, textBoxDarbuotojasPavarde.Text);
			this.darbuotojasTableAdapter.Fill(this.autoShopDataSet.Darbuotojas);

		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
