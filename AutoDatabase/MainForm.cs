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

			populateListBoxClient();
			populateListBoxCars();
			populateListBoxServices();


			using (var context = new AutoShopEntities())
			{
			

			}
		}

		private void populateListBoxServices()
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.Services
							   select new { Id = c.Id, Row = c.Name + "    " + c.Price }).ToList();

				listBoxServices.DataSource = results;
				listBoxServices.DisplayMember = "Row";
				listBoxServices.ValueMember = "Id";

			}
		}

		private void populateListBoxCars()
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.Cars
							   select new { VIN = c.VIN, NumberPlate = c.NumberPlate, Row = c.NumberPlate + "    " + c.VIN }).ToList();

				listBoxCars.DataSource = results;
				listBoxCars.DisplayMember = "Row";
				listBoxCars.ValueMember = "VIN";
			}
		}

		private void populateListBoxClient()
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.People
							   select new { Id = c.Id, Row = c.Name + " " + c.Surname }).ToList();

				listBoxClients.DataSource = results;
				listBoxClients.DisplayMember = "Row";
				listBoxClients.ValueMember = "Id";

			}

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
			// TODO: This line of code loads data into the 'autoShopDataSet.Person' table. You can move, or remove it, as needed.
			this.personTableAdapter.Fill(this.autoShopDataSet.Person);
			// TODO: This line of code loads data into the 'autoShopDataSet.Client' table. You can move, or remove it, as needed.
			this.clientTableAdapter.Fill(this.autoShopDataSet.Client);
			// TODO: This line of code loads data into the 'autoShopDataSet.Employee' table. You can move, or remove it, as needed.
			this.employeeTableAdapter.Fill(this.autoShopDataSet.Employee);
			// TODO: This line of code loads data into the 'autoShopDataSet.Car' table. You can move, or remove it, as needed.
			this.carTableAdapter.Fill(this.autoShopDataSet.Car);

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
			var client = new Client
			{
				Adress = textBoxAddress.Text,
				Telephone = textBoxTelephone.Text
			};

			if (textClient1.Text == "Vardas")
			{
				var person = new Person
				{
					Id = client.Id,
					Name = textBoxClient1.Text,
					Surname = textBoxClient2.Text
				};
				client.Person = person;
			}
			else
			{
				var company = new Company
				{
					Id = client.Id,
					Name = textBoxClient1.Text,
					Code = textBoxClient2.Text
				};
				client.Company = company;
			}

			using (var context = new AutoShopEntities())
			{
				context.Clients.Add(client);
				context.SaveChanges();
			}

			populateListBoxClient();
			this.clientTableAdapter.Fill(this.autoShopDataSet.Client);

		}

		private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBoxCars.ValueMember = "VIN";
			populateListBoxJobs((string)listBoxCars.SelectedValue);
		}

		private void populateListBoxJobs(string carVIN)
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.Jobs
							   where c.Car_VIN == carVIN
						   select new { Id = c.Id, Row = c.Service.Name + "    " + c.Hours }).ToList();

			listBoxCarJobs.DataSource = results;
			listBoxCars.DisplayMember = "Row";
			listBoxClients.ValueMember = "Id";
			}
		}

		private void buttonAddNewCar_Click(object sender, EventArgs e)
		{
			var car = new Car
			{
				VIN = textBoxCarVIN.Text,
				NumberPlate = textBoxCarPlate.Text,
				Make = textBoxCarMake.Text,
				Model = textBoxCarModel.Text,
				Run = int.Parse(textBoxCarRun.Text),
				Engine = textBoxCarEngine.Text,
				Year = int.Parse(textBoxCarYear.Text)
			};

			car.Client_Id = (int)listBoxClients.SelectedValue;

			using (var context = new AutoShopEntities())
			{
				context.Cars.Add(car);
				context.SaveChanges();
			}

			populateListBoxCars();
		}

		
	}
}
