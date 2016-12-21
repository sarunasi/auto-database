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
		private bool selectedClientPerson = true;
		DataController data;

		public MainForm()
		{
			InitializeComponent();
			dataSet = new DataSet();
			employees = new EmployeeTable(Properties.Settings.Default.connectionString, dataSet);

			data = new DataController();

			data.PopulateListBoxClients(selectedClientPerson, listBoxClients);
			data.PopulateListBoxArrivedCars(listBoxArrivedCars);
			data.PopulateListBoxServices(listBoxServices);
			data.PopulateListBoxEmployees(listBoxEmployees);
			data.PopulateListBoxJobEmployees(listBoxJobEmployees, listBoxCarJobs);

		}

        private void showData()
        {
            listBoxDuomenys.DataSource = null;
            using (var context = new AutoShopEntities())
            {
                if (comboBoxData.Text == "Darbuotojai") {
                    var result = (from emp in context.Employees
                                  where emp.Surname.Contains(textBoxSearch.Text) || emp.Name.Contains(textBoxSearch.Text)
                                  select new { Name = emp.Name + " " + emp.Surname }).ToList();
                    listBoxDuomenys.DataSource = result;
                    listBoxDuomenys.DisplayMember = "Name";
                }
            }
        }
		private void buttonAddEmployee_Click(object sender, EventArgs e)
		{
			employees.Insert(textBoxInsertEmployeeName.Text, textBoxInsertEmployeeSurname.Text);
			data.PopulateListBoxEmployees(listBoxEmployees);

		}

		private void buttonUpdateEmployee_Click(object sender, EventArgs e)
		{
			employees.Update(textBoxUpdateEmployeeId.Text, textBoxUpdateEmployeeName.Text, textBoxUpdateEmployeeSurname.Text);
			data.PopulateListBoxEmployees(listBoxEmployees);
		}

		private void buttonDeleteEmployee_Click(object sender, EventArgs e)
		{
			employees.Delete(textBoxDeleteEmployeeId.Text);
			data.PopulateListBoxEmployees(listBoxEmployees);
		}

		private void buttonSelectPerson_Click(object sender, EventArgs e)
		{
			textClient1.Text = "Vardas";
			textClient2.Text = "Pavarde";
		}

		private void buttonSelectCompany_Click(object sender, EventArgs e)
		{
			textClient1.Text = "Pavadinimas";
			textClient2.Text = "Kodas";
		}

		private void buttonRegisterClient_Click(object sender, EventArgs e)
		{
			textBoxClient1_Validated(this, e);
			textBoxClient2_Validated(this, e);
			textBoxAddress_Validated(this, e);
			textBoxTelephone_Validated(this, e);

			if (textClient1.Text == "Vardas")
			{
				data.AddNewClient(true, textBoxClient1.Text, textBoxClient2.Text, textBoxAddress.Text, textBoxTelephone.Text);
			}
			else
			{
				data.AddNewClient(false, textBoxClient1.Text, textBoxClient2.Text, textBoxAddress.Text, textBoxTelephone.Text);
			}

			textBoxClient1.Text = "";
			textBoxClient2.Text = "";
			textBoxAddress.Text = "";
			textBoxTelephone.Text = "";

			data.PopulateListBoxClients(selectedClientPerson, listBoxClients);

		}

		private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBoxArrivedCars.ValueMember = "VIN";
			data.PopulateListBoxJobs((string)listBoxArrivedCars.SelectedValue, listBoxCarJobs);
		}

		private void buttonAddNewCar_Click(object sender, EventArgs e)
		{
			List<Control> textBoxes = new List<Control>();
			textBoxes.Add(textBoxCarEngine);
			textBoxes.Add(textBoxCarMake);
			textBoxes.Add(textBoxCarModel);
			textBoxes.Add(textBoxCarPlate);
			textBoxes.Add(textBoxCarRun);
			textBoxes.Add(textBoxCarVIN);
			textBoxes.Add(textBoxCarYear);

			data.AddNewCar(textBoxCarVIN.Text, textBoxCarPlate.Text, textBoxCarMake.Text,
				textBoxCarModel.Text, textBoxCarRun.Text, 
				textBoxCarEngine.Text, textBoxCarYear.Text, (int)listBoxClients.SelectedValue);
			

			textBoxes.ForEach(t => t.Text = "");

			data.PopulateListBoxArrivedCars(listBoxArrivedCars);
			data.PopulateListBoxClientCars((int)listBoxClients.SelectedValue, listBoxClientCars);
		}

		private void buttonAddJobToCar_Click(object sender, EventArgs e)
		{
			string carVin = (string)listBoxArrivedCars.SelectedValue;
			int serviceId = (int)listBoxServices.SelectedValue;

			data.AddJobToCar(serviceId, carVin);

			data.PopulateListBoxJobs((string)listBoxArrivedCars.SelectedValue, listBoxCarJobs);
		}

		private void buttonFinishJob_Click(object sender, EventArgs e)
		{
			data.FinishJob(listBoxCarJobs.SelectedValue);
			data.PopulateListBoxJobs((string)listBoxArrivedCars.SelectedValue, listBoxCarJobs);
		}

		private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBoxClients.ValueMember = "Id";
			data.PopulateListBoxClientCars((int)listBoxClients.SelectedValue, listBoxClientCars);

		}


		private void buttonCarArrived_Click(object sender, EventArgs e)
		{

			data.CarArrived(listBoxClientCars.SelectedValue);
			data.PopulateListBoxArrivedCars(listBoxArrivedCars);

		}

		private void buttonCarLeft_Click(object sender, EventArgs e)
		{

			data.CarLeft(listBoxClientCars.SelectedValue);
			data.PopulateListBoxArrivedCars(listBoxArrivedCars);

		}

		private void buttonAddService_Click(object sender, EventArgs e)
		{
			data.AddNewService(textBoxServiceName.Text, textBoxServicePrice.Text, textBoxServiceDefaultHours.Text);
			data.PopulateListBoxServices(listBoxServices);
		}

		private void buttonDeleteJob_Click(object sender, EventArgs e)
		{
			data.DeleteJob(listBoxCarJobs.SelectedValue);
			data.PopulateListBoxArrivedCars(listBoxArrivedCars);
		}

		private void buttonAddEmployeeToJob_Click(object sender, EventArgs e)
		{
			data.AddEmployeeToJob(listBoxEmployees.SelectedValue, listBoxCarJobs.SelectedValue);
			data.PopulateListBoxJobEmployees(listBoxJobEmployees, listBoxCarJobs);
		}

		private void listBoxCarJobs_SelectedIndexChanged(object sender, EventArgs e)
		{
			data.PopulateListBoxJobEmployees(listBoxJobEmployees, listBoxCarJobs);
		}

		private void buttonPerson_Click(object sender, EventArgs e)
		{
			selectedClientPerson = true;
			data.PopulateListBoxClients(selectedClientPerson, listBoxClients);
		}

		private void buttonCompany_Click(object sender, EventArgs e)
		{
			selectedClientPerson = false;
			data.PopulateListBoxClients(selectedClientPerson, listBoxClients);
		}

		private void CheckNumbersError(TextBox textBox, Button button, string name)
		{
			long parsedValue;
			if (!long.TryParse(textBox.Text, out parsedValue) || textBox.Text == "")
			{
				errorProvider.SetError(textBox, name + " turi sudaryti skaiciai");
				button.Enabled = false;
			}
			else
			{
				errorProvider.SetError(textBox, "");
				button.Enabled = true;
			}
		}

		private void textBoxTelephone_Validated(object sender, EventArgs e)
		{
			CheckNumbersError(textBoxTelephone, buttonRegisterClient, "Telefonas");
		}

		private void textBoxCarRun_Validated(object sender, EventArgs e)
		{
			CheckNumbersError(textBoxCarRun, buttonAddNewCar, "Rida");
		}

		private void textBoxCarYear_Validated(object sender, EventArgs e)
		{
			CheckNumbersError(textBoxCarYear, buttonAddNewCar, "Metai");
		}

		private void textBoxClient1_Validated(object sender, EventArgs e)
		{
			CheckEmptyError(textBoxClient1, buttonRegisterClient, textClient1.Text);
		}

		private void textBoxClient2_Validated(object sender, EventArgs e)
		{
			CheckEmptyError(textBoxClient2, buttonRegisterClient, textClient2.Text);
		}

		private void CheckEmptyError(TextBox textBox, Button button, string name)
		{
			if (textBox.Text == "")
			{
				errorProvider.SetError(textBox, name + " negali buti tuscias");
				button.Enabled = false;
			}
			else
			{
				errorProvider.SetError(textBox, "");
				button.Enabled = true;
			}
		}

		private void textBoxAddress_Validated(object sender, EventArgs e)
		{
			CheckEmptyError(textBoxAddress, buttonRegisterClient, "Adresas");
		}

        private void comboBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            showData();
        }
    }
}
