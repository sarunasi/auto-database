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
			populateListBoxArrivedCars();
			populateListBoxServices();
			populateListBoxEmployees();
			populateListBoxJobEmployees();


			using (var context = new AutoShopEntities())
			{
			

			}

			errorProvider.SetError(textBoxCarRun, "Wat you doin m8");
		}

		private void populateListBoxJobEmployees()
		{
			using (var context = new AutoShopEntities())
			{
				if (listBoxCarJobs.SelectedValue != null)
				{
					var results = (from e in context.Employees
								   where e.Jobs.Any(j => j.Id == (int)listBoxCarJobs.SelectedValue)
								   select new { Id = e.Id, Row = e.Name + "    " + e.Surname }).ToList();

					listBoxJobEmployees.DataSource = results;
					listBoxJobEmployees.DisplayMember = "Row";
					listBoxJobEmployees.ValueMember = "Id";

				}

			}
		}

		private void populateListBoxEmployees()
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.Employees
							   select new { Id = c.Id, Row = c.Id + "  " + c.Name + "    " + c.Surname }).ToList();

				listBoxEmployees.DataSource = results;
				listBoxEmployees.DisplayMember = "Row";
				listBoxEmployees.ValueMember = "Id";

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

		private void populateListBoxArrivedCars()
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.Cars
							   where c.Arrived == true
							   select new { VIN = c.VIN, NumberPlate = c.NumberPlate, Row = c.NumberPlate + "    " + c.VIN }).ToList();

				listBoxArrivedCars.DataSource = results;
				listBoxArrivedCars.DisplayMember = "Row";
				listBoxArrivedCars.ValueMember = "VIN";
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
			populateListBoxEmployees();

		}

		private void buttonUpdateEmployee_Click(object sender, EventArgs e)
		{
			employees.Update(textBoxUpdateEmployeeId.Text, textBoxUpdateEmployeeName.Text, textBoxUpdateEmployeeSurname.Text);
			populateListBoxEmployees();
		}

		private void buttonDeleteEmployee_Click(object sender, EventArgs e)
		{
			employees.Delete(textBoxDeleteEmployeeId.Text);
			populateListBoxEmployees();
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
			listBoxArrivedCars.ValueMember = "VIN";
			populateListBoxJobs((string)listBoxArrivedCars.SelectedValue);
		}

		private void populateListBoxJobs(string carVIN)
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.Jobs
							   where c.Car_VIN == carVIN
						   select new { Id = c.Id, Row = c.Service.Name + "    " + c.Hours + "   " + c.Finished }).ToList();

			listBoxCarJobs.DataSource = results;
			listBoxCarJobs.DisplayMember = "Row";
			listBoxCarJobs.ValueMember = "Id";
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

			populateListBoxArrivedCars();
			populateListBoxClientCars();
		}

		private void buttonAddJobToCar_Click(object sender, EventArgs e)
		{
			string carVin = (string)listBoxArrivedCars.SelectedValue;
			int serviceId = (int)listBoxServices.SelectedValue;

			using (var context = new AutoShopEntities())
			{
				double hours = (from c in context.Services
								where c.Id == serviceId
								select c.Default_hours).FirstOrDefault();

				var job = new Job
				{
					Service_Id = serviceId,
					Car_VIN = carVin,
					Start = System.DateTime.Now,
					Hours = hours,
					Finished = false
				};

				context.Jobs.Add(job);
				context.SaveChanges();
			}

			populateListBoxJobs((string)listBoxArrivedCars.SelectedValue);
		}

		private void buttonFinishJob_Click(object sender, EventArgs e)
		{
			using (var context = new AutoShopEntities())
			{
				var job = context.Jobs.FirstOrDefault(x => x.Id == (int)listBoxCarJobs.SelectedValue);
				job.Finished = true;

				context.SaveChanges();
			}
			populateListBoxJobs((string)listBoxArrivedCars.SelectedValue);
		}

		private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBoxClients.ValueMember = "Id";
			populateListBoxClientCars();
			
		}

		private void populateListBoxClientCars()
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.Cars
							   where c.Client_Id == (int)listBoxClients.SelectedValue
							   select new { VIN = c.VIN, NumberPlate = c.NumberPlate, Row = c.NumberPlate + "    " + c.VIN }).ToList();

				listBoxClientCars.DataSource = results;
				listBoxClientCars.DisplayMember = "Row";
				listBoxClientCars.ValueMember = "VIN";
			}
		}

		private void buttonCarArrived_Click(object sender, EventArgs e)
		{
			using (var context = new AutoShopEntities())
			{
				var car = context.Cars.FirstOrDefault(x => x.VIN == (string)listBoxClientCars.SelectedValue);
				car.Arrived = true;

				context.SaveChanges();
			}

			populateListBoxArrivedCars();

		}

		private void buttonCarLeft_Click(object sender, EventArgs e)
		{
			using (var context = new AutoShopEntities())
			{
				var car = context.Cars.FirstOrDefault(x => x.VIN == (string)listBoxClientCars.SelectedValue);

				if (car.Jobs.Any(job => job.Finished == false))
				{
					MessageBox.Show("Automobilis turi neuzbaigtu darbu");
				}
				else
				{
					car.Arrived = false;

					foreach(Job job in car.Jobs)
					{
						job.Employees.Clear();

						
					}
					
					context.Jobs.RemoveRange(car.Jobs);
					context.SaveChanges();
				}
				
			}

			populateListBoxArrivedCars();

		}

		private void buttonAddService_Click(object sender, EventArgs e)
		{
			var service = new Service
			{
				Name = textBoxServiceName.Text,
				Price = double.Parse(textBoxServicePrice.Text),
				Default_hours = double.Parse(textBoxServiceDefaultHours.Text)
			};

			using (var context = new AutoShopEntities())
			{
				context.Services.Add(service);
				context.SaveChanges();
			}
			populateListBoxServices();
		}

		private void buttonDeleteJob_Click(object sender, EventArgs e)
		{
			using (var context = new AutoShopEntities())
			{
				var job = context.Jobs.FirstOrDefault(x => x.Id == (int)listBoxCarJobs.SelectedValue);

				context.Jobs.Remove(job);
				context.SaveChanges();
			}

			populateListBoxArrivedCars();
		}

		private void buttonAddEmployeeToJob_Click(object sender, EventArgs e)
		{
			using (var context = new AutoShopEntities())
			{
				var employee = context.Employees.FirstOrDefault(x => x.Id == (int)listBoxEmployees.SelectedValue);
				var job = context.Jobs.FirstOrDefault(x => x.Id == (int)listBoxCarJobs.SelectedValue);

				job.Employees.Add(employee);

				context.SaveChanges();
			}
			populateListBoxJobEmployees();
		}

		private void listBoxCarJobs_SelectedIndexChanged(object sender, EventArgs e)
		{
			populateListBoxJobEmployees();
		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
