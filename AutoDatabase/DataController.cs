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
        /*
		public void PopulateListBoxJobEmployees(ListBox listBoxJobEmployees, ListBox listBoxCarJobs)
		{
			using (var context = new AutoShopEntities())
			{
				if (listBoxCarJobs.SelectedValue != null)
				{
					var results = (from e in context.Employees
								   where e.Jobs.Any(j => j.Id == (int)listBoxCarJobs.SelectedValue)
								   select new { Id = e.Id, Row = e.Name + " " + e.Surname }).ToList();

					listBoxJobEmployees.DataSource = results;
					listBoxJobEmployees.DisplayMember = "Row";
					listBoxJobEmployees.ValueMember = "Id";
				}
			}
		}
        */
        public void addData(object element)
        {
            Type type = element.GetType();

            using(var context = new AutoShopEntities())
            {
                if(type == typeof(Service))
                {
                    context.Services.Add((Service)element);
                }
                if(type == typeof(Car))
                {
                    context.Cars.Add((Car)element);
                }
                if (type == typeof(Employee))
                {
                    context.Employees.Add((Employee)element);
                }
                if (type == typeof(Job))
                {
                    context.Jobs.Add((Job)element);
                }
                if (type == typeof(Client))
                {
                    context.Clients.Add((Client)element);
                }
                if (type == typeof(Company))
                {
                    context.Companies.Add((Company)element);
                }
                if (type == typeof(Person))
                {
                    context.People.Add((Person)element);
                }
                context.SaveChanges();
            }
        }
        public List<dynamic> getCars(String str)
        {
            using (var context = new AutoShopEntities())
            {
                var result = (from car in context.Cars
                              where car.Model.Contains(str) || car.Make.Contains(str) || car.VIN.Contains(str) || car.NumberPlate.Contains(str)
                              select new { Name = car.Model + " " + car.Make + " " + car.NumberPlate, Id = car.VIN }).ToList<dynamic>();
                return result;
            }
        }

        public List<dynamic> getJobs(String vin)
        {
            using (var context = new AutoShopEntities())
            {
                var result = (from job in context.Jobs
                              where job.Car_VIN == vin
                              select new { Name = job.Service.Name + " Baigtas: "  +job.Finished.ToString(), Id = job.Id }).ToList<dynamic>();
                return result;
            }
        }

        public List<dynamic> getAllJobs(String str)
        {
            using (var context = new AutoShopEntities())
            {
                var result = (from job in context.Jobs
                              where job.Service.Name.Contains(str)
                              select new { Name = job.Service.Name + " Baigtas: " + job.Finished.ToString()+" " + job.Car.Make + " " + job.Car.Model, Id = job.Id }).ToList<dynamic>();
                return result;
            }
        }

        public List<dynamic> getJobEmployees(int id)
        {
            using (var context = new AutoShopEntities())
            {
                var result = (from emp in context.Employees
                              where emp.Jobs.Any(x => x.Id == id)
                              select new { Name = emp.Name + " " + emp.Surname, Id = emp.Id }).ToList<dynamic>();
                return result;
            }
        }

        public List<dynamic> getServices(String str)
        {
            using (var context = new AutoShopEntities())
            {
                var result = (from serv in context.Services
                              where serv.Name.Contains(str)
                              select new { Name =serv.Name + " Price: " + serv.Price, Id = serv.Id }).ToList<dynamic>();
                return result;
            }
        }

        public List<dynamic> getEmployees(String str)
        {
            using (var context = new AutoShopEntities())
            {  
                var result = (from emp in context.Employees
                              where emp.Surname.Contains(str) || emp.Name.Contains(str)
                              select new { Name = emp.Name + " " + emp.Surname , Id = emp.Id}).ToList<dynamic>();
                return result;
            }
        }

        public List<dynamic> getClients(String str)
        {
            using (var context = new AutoShopEntities())
            {
                var result = (from cl in context.Clients
                              where cl.Person.Surname.Contains(str) || cl.Person.Name.Contains(str) || cl.Company.Name.Contains(str)
                              select new { Name = cl.Person.Name + " " + cl.Person.Surname + cl.Company.Name, Id = cl.Id}).ToList<dynamic>();
                return result;
            }
        }

        public Client findClient(int id)
        {
            using (var context = new AutoShopEntities())
            {
                Client result = context.Clients.FirstOrDefault(x => x.Id == id);
                return result;
            }
        }

        public Person findPerson(int id)
        {
            using (var context = new AutoShopEntities())
            {
                Person result = context.People.FirstOrDefault(x => x.Id == id);
                return result;
            }
        }

        public Company findCompany(int id)
        {
            using (var context = new AutoShopEntities())
            {
                Company result = context.Companies.FirstOrDefault(x => x.Id == id);
                return result;
            }
        }

        public void updateClient(int id, String address, String phone)
        {
            using (var context = new AutoShopEntities())
            {
                Client result = context.Clients.FirstOrDefault(x => x.Id == id);
                result.Adress = address;
                result.Telephone = phone;
                context.SaveChanges();
            }
        }

        public void updatePerson(int id, String name, String surname)
        {
            using (var context = new AutoShopEntities())
            {
                Person result = context.People.FirstOrDefault(x => x.Id == id);
                result.Name = name;
                result.Surname = surname;
                context.SaveChanges();
            }
        }

        public void updateCompany(int id, String name, String code)
        {
            using (var context = new AutoShopEntities())
            {
                Company result = context.Companies.FirstOrDefault(x => x.Id == id);
                result.Name = name;
                result.Code = code;
                context.SaveChanges();
            }
        }

        public void updateClientData(int id, String name, String surname, String code, String address, String phone)
        {
            updateClient(id, address, phone);
            if (isPerson(id))
            {
                updatePerson(id, name, surname);
            }
            else if (isCompany(id))
            {
                updateCompany(id, name, code);
            }
        }

        public bool isPerson(int id)
        {
            using (var context = new AutoShopEntities())
            {
                Person pers = context.People.FirstOrDefault(x => x.Id == id);
                if (pers != null)
                {
                    return true;
                }
                else return false;
            }
        }


        public bool isCompany(int id)
        {
            using (var context = new AutoShopEntities())
            {
                Company comp = context.Companies.FirstOrDefault(x => x.Id == id);
                if (comp != null)
                {
                    return true;
                }
                else return false;
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
                    job.Employees.Clear();
                    context.Jobs.Remove(job);
                    context.SaveChanges();
                }
            }
            /*
            using (var context = new AutoShopEntities())
			{
				if (jobId != null)
				{
					var job = context.Jobs.FirstOrDefault(x => x.Id == (int)jobId);

					context.Jobs.Remove(job);
					context.SaveChanges();
				}
			}
            */
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
