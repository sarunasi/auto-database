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

			data.PopulateListBoxServices(listBoxServices);
			data.PopulateListBoxEmployees(listBoxEmployees);
            populateJobsListBox();

            populateCarsListBox();

            populateClientsListBox();
            populateJobsListBox();
            populateJobEmployeesListBox();
		}

        private void populateCarsListBox()
        {
            listBoxArrivedCars.DataSource = data.getCars("");
            listBoxArrivedCars.DisplayMember = "Name";
            if (listBoxArrivedCars.ValueMember == "") listBoxArrivedCars.ValueMember = "Id";
        }
        private void populateJobEmployeesListBox()
        {
            if (listBoxCarJobs.SelectedValue != null)
            {
                //listBoxCarJobs.ValueMember = "Id";
                listBoxJobEmployees.DataSource = data.getJobEmployees((int)listBoxCarJobs.SelectedValue);
                listBoxJobEmployees.DisplayMember = "Name";
            }
        }

        private void populateClientsListBox()
        {
            listBoxClients.DataSource = data.getClients("");
            listBoxClients.DisplayMember = "Name";
            listBoxGeneratorClients.DataSource = data.getClients("");
            listBoxGeneratorClients.DisplayMember = "Name";
        }

        private void populateJobsListBox()
        {
            if (listBoxArrivedCars.SelectedValue != null)
            {
                listBoxCarJobs.DataSource = data.getJobs(Convert.ToString(listBoxArrivedCars.SelectedValue));
                listBoxCarJobs.DisplayMember = "Name";
            }
        }

        private void showData()
        {
            listBoxDuomenys.DataSource = null;
            //listBoxDuomenys.ValueMember = null;
            if (comboBoxData.Text == "Darbuotojai")
            {
                listBoxDuomenys.DataSource = data.getEmployees(textBoxSearch.Text);
            }
            if (comboBoxData.Text == "Klientai")
            {
                listBoxDuomenys.DataSource = data.getClients(textBoxSearch.Text);
            }
            if (comboBoxData.Text == "Paslaugos")
            {
                listBoxDuomenys.DataSource = data.getServices(textBoxSearch.Text);
            }
            if (comboBoxData.Text == "Automobiliai")
            {
                listBoxDuomenys.DataSource = data.getCars(textBoxSearch.Text);
            }
            if (comboBoxData.Text == "Taisymai")
            {
                listBoxDuomenys.DataSource = data.getAllJobs(textBoxSearch.Text);
            }
            listBoxDuomenys.DisplayMember = "Name";
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
            populateJobsListBox();
		}

		private void buttonAddJobToCar_Click(object sender, EventArgs e)
		{
            if (listBoxArrivedCars.SelectedValue == null || listBoxServices.SelectedValue == null)
                return;

			string carVin = (string)listBoxArrivedCars.SelectedValue;
			int serviceId = (int)listBoxServices.SelectedValue;

			data.AddJobToCar(serviceId, carVin);
            populateJobsListBox();
		}

		private void buttonFinishJob_Click(object sender, EventArgs e)
		{
			data.FinishJob(listBoxCarJobs.SelectedValue);
            populateJobsListBox();
		}

		private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBoxClients.ValueMember = "Id";
		}


		private void buttonCarArrived_Click(object sender, EventArgs e)
		{
			data.PopulateListBoxArrivedCars(listBoxArrivedCars);

		}

		private void buttonCarLeft_Click(object sender, EventArgs e)
		{
			data.PopulateListBoxArrivedCars(listBoxArrivedCars);

		}

		private void buttonAddService_Click(object sender, EventArgs e)
        { 
			data.PopulateListBoxServices(listBoxServices);
		}

		private void buttonDeleteJob_Click(object sender, EventArgs e)
		{
			data.DeleteJob(listBoxCarJobs.SelectedValue);
            populateJobsListBox();
            populateJobEmployeesListBox();
		}

		private void buttonAddEmployeeToJob_Click(object sender, EventArgs e)
		{
			data.AddEmployeeToJob(listBoxEmployees.SelectedValue, listBoxCarJobs.SelectedValue);
            populateJobEmployeesListBox();
        }

		private void listBoxCarJobs_SelectedIndexChanged(object sender, EventArgs e)
		{
            populateJobEmployeesListBox();
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
            if (comboBoxData.Text == "Klientai" || comboBoxData.Text == "Automobiliai" || comboBoxData.Text == "Darbuotojai" || comboBoxData.Text == "Taisymai")
            {
                buttonAddNew.Visible = false;
            }
            else {
                buttonAddNew.Visible = true;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void textBoxSearchClient_TextChanged(object sender, EventArgs e)
        {
            listBoxClients.DataSource = data.getClients(textBoxSearchClient.Text);
            listBoxClients.DisplayMember = "Name";
        }

        private void comboBoxClientType_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxClientType.Text == "Fizinis asmuo")
            {
                textClient1.Text = "Vardas";
                textClient2.Text = "Pavarde";
            }
            else if (comboBoxClientType.Text == "Įmonė")
            {
                textClient1.Text = "Pavadinimas";
                textClient2.Text = "Kodas";
            }
        }

        private void buttonUpdateData_Click(object sender, EventArgs e)
        {
            object id = listBoxDuomenys.SelectedValue;
            if (comboBoxData.Text == "Klientai")
            {
                using (var updateForm = new UpdateClientForm(id))
                {
                    updateForm.ShowDialog();
                }
            }
            showData();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            using (var sf = new AddServiceForm())
            {
                sf.ShowDialog();
            }
            showData();
        }

        private void buttonAddNewCar_Click_1(object sender, EventArgs e)
        {
            listBoxClients.ValueMember = "Id";
            data.PopulateListBoxArrivedCars(listBoxArrivedCars);

            if (string.IsNullOrWhiteSpace (textBoxCarEngine.Text) || string.IsNullOrWhiteSpace (textBoxCarMake.Text) ||
                string.IsNullOrWhiteSpace (textBoxCarModel.Text) || string.IsNullOrWhiteSpace (textBoxCarPlate.Text) ||
                string.IsNullOrWhiteSpace (textBoxCarRun.Text) || string.IsNullOrWhiteSpace (textBoxCarVIN.Text) ||
                string.IsNullOrWhiteSpace (textBoxCarYear.Text) || listBoxClients.SelectedValue == null)
                return;

            int run, year;
            int.TryParse (textBoxCarRun.Text, out run);
            int.TryParse (textBoxCarYear.Text, out year);

            Car car = new Car
            {
                Engine = textBoxCarEngine.Text,
                Make = textBoxCarMake.Text,
                Model = textBoxCarModel.Text,
                NumberPlate = textBoxCarPlate.Text,
                Run = run,
                VIN = textBoxCarVIN.Text,
                Year = year,
                Client_Id = (int)(listBoxClients.SelectedValue),
                Arrived = true
            };
            data.addData(car);
            data.PopulateListBoxArrivedCars(listBoxArrivedCars);
            textBoxCarEngine.Text = "";
            textBoxCarMake.Text = "";
            textBoxCarModel.Text = "";
            textBoxCarPlate.Text = "";
            textBoxCarRun.Text = "";
            textBoxCarVIN.Text = "";
            textBoxCarYear.Text = "";
        }

        private void buttonGenerateBill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sąskaita faktūra sugeneruota!");
        }

        private void buttonGenerateGuarantee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Garantija sugeneruota!");
        }

        private void buttonGenerateOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Užsakymo dokumentas sugeneruotas!");
        }

        private void buttonShowBusyness_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prototipas");
        }
    }
}
