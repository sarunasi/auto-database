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

		}


		private void buttonAddEmployee_Click(object sender, EventArgs e)
		{
			employees.Insert(textBoxInsertEmployeeName.Text, textBoxInsertEmployeeSurname.Text);

		}

		private void buttonUpdateEmployee_Click(object sender, EventArgs e)
		{
			employees.Update(textBoxUpdateEmployeeId.Text, textBoxUpdateEmployeeName.Text, textBoxUpdateEmployeeSurname.Text);
		}

		private void buttonDeleteEmployee_Click(object sender, EventArgs e)
		{
			employees.Delete(textBoxDeleteEmployeeId.Text);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'autoShopDataSet.Employee' table. You can move, or remove it, as needed.
			this.employeeTableAdapter.Fill(this.autoShopDataSet.Employee);
			// TODO: This line of code loads data into the 'autoShopDataSet.Car' table. You can move, or remove it, as needed.
			this.carTableAdapter.Fill(this.autoShopDataSet.Car);

		}
	}
}
