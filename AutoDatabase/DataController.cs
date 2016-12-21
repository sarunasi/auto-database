using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
	class DataController
	{
		public void PopulateListBoxJobEmployees(ListBox listBoxJobEmployees, ListBox listBoxCarJobs)
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

        public List<dynamic> getEmployees(String str)
        {
            using (var context = new AutoShopEntities())
            {  
                var result = (from emp in context.Employees
                              where emp.Surname.Contains(str) || emp.Name.Contains(str)
                              select new { Name = emp.Name + " " + emp.Surname }).ToList<dynamic>();
                return result;
            }
        }

		public void PopulateTopClients(ListBox listBoxTopClients)
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.People
							   orderby c.Client.Cars.Count() descending
							   select new { Id = c.Id, Row = c.Name + "    " + c.Surname + "  " + c.Client.Cars.Count() }).ToList().Take(5);

				listBoxTopClients.DataSource = results.ToList();
				listBoxTopClients.DisplayMember = "Row";
				listBoxTopClients.ValueMember = "Id";
			}
		}

		public void PopulateListBoxClients(bool selectedClientPerson, ListBox listBoxClients)
		{
			if (selectedClientPerson)
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
			else
			{
				using (var context = new AutoShopEntities())
				{
					var results = (from c in context.Companies
								   select new { Id = c.Id, Row = c.Name + " " + c.Code }).ToList();

					listBoxClients.DataSource = results;
					listBoxClients.DisplayMember = "Row";
					listBoxClients.ValueMember = "Id";

				}
			}
		}

		public void PopulateListBoxArrivedCars(ListBox listBoxArrivedCars)
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

		public void PopulateListBoxServices(ListBox listBoxServices)
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

		public void PopulateListBoxEmployees(ListBox listBoxEmployees)
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

		public void PopulateListBoxJobs(string carVIN, ListBox listBoxCarJobs)
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

		public void PopulateListBoxClientCars(int clientId, ListBox listBoxClientCars)
		{
			using (var context = new AutoShopEntities())
			{
				var results = (from c in context.Cars
							   where c.Client_Id == clientId
							   select new { VIN = c.VIN, NumberPlate = c.NumberPlate, Row = c.NumberPlate + "    " + c.VIN }).ToList();

				listBoxClientCars.DataSource = results;
				listBoxClientCars.DisplayMember = "Row";
				listBoxClientCars.ValueMember = "VIN";
			}
		}

		public void AddNewClient(bool isPerson, string s1, string s2, string address, string telephone)
		{
			var client = new Client
			{
				Adress = address,
				Telephone = telephone
			};

			if (isPerson)
			{
				var person = new Person
				{
					Id = client.Id,
					Name = s1,
					Surname = s2
				};
				client.Person = person;
			}
			else
			{
				var company = new Company
				{
					Id = client.Id,
					Name = s1,
					Code = s2
				};
				client.Company = company;
			}

			using (var context = new AutoShopEntities())
			{
				context.Clients.Add(client);
				context.SaveChanges();
			}
		}

		public void AddNewCar(string carVIN, string plate, string make, string model, string run, string engine, string year, int clientId)
		{
			var car = new Car
			{
				VIN = carVIN,
				NumberPlate = plate,
				Make = make,
				Model = model,
				Run = int.Parse(run),
				Engine = engine,
				Year = int.Parse(year)
			};

			car.Client_Id = clientId;

			using (var context = new AutoShopEntities())
			{
				context.Cars.Add(car);
				context.SaveChanges();
			}
		}

		public void FinishJob(object jobId)
		{
			using (var context = new AutoShopEntities())
			{
				if (jobId != null)
				{
					var job = context.Jobs.FirstOrDefault(x => x.Id == (int)jobId);
					job.Finished = true;

					context.SaveChanges();
				}
			}
		}

		public void CarArrived(object carId)
		{
			using (var context = new AutoShopEntities())
			{
				if (carId != null)
				{
					var car = context.Cars.FirstOrDefault(x => x.VIN == (string)carId);
					car.Arrived = true;

					context.SaveChanges();
				}
			}
		}

		public void CarLeft(object carId)
		{
			using (var context = new AutoShopEntities())
			{
				if (carId != null)
				{
					var car = context.Cars.FirstOrDefault(x => x.VIN == (string)carId);

					if (car.Jobs.Any(job => job.Finished == false))
					{
						MessageBox.Show("Automobilis turi neuzbaigtu darbu");
					}
					else
					{
						car.Arrived = false;

						foreach (Job job in car.Jobs)
						{
							job.Employees.Clear();
						}

						context.Jobs.RemoveRange(car.Jobs);
						context.SaveChanges();
					}
				}
			}
		}

		public void AddNewService(string name, string price, string hours)
		{
			var service = new Service
			{
				Name = name,
				Price = double.Parse(price),
				Default_hours = double.Parse(hours)
			};

			using (var context = new AutoShopEntities())
			{
				context.Services.Add(service);
				context.SaveChanges();
			}
		}

		public void DeleteJob(object jobId)
		{
			using (var context = new AutoShopEntities())
			{
				if (jobId != null)
				{
					var job = context.Jobs.FirstOrDefault(x => x.Id == (int)jobId);

					context.Jobs.Remove(job);
					context.SaveChanges();
				}
			}
		}

		public void AddEmployeeToJob(object employeeId, object jobId)
		{
			using (var context = new AutoShopEntities())
			{
				var employee = context.Employees.FirstOrDefault(x => x.Id == (int)employeeId);
				if (jobId != null)
				{
					var job = context.Jobs.FirstOrDefault(x => x.Id == (int)jobId);

					job.Employees.Add(employee);

					context.SaveChanges();
				}

			}
		}

		public void AddJobToCar(int serviceId, string carVin)
		{
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
		}
	}

	

}
