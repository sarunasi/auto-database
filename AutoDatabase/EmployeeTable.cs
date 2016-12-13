using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
	class EmployeeTable
	{
		private string connectionString;
		SqlDataAdapter dataAdapter;
		DataSet dataSet;
		public string TableName { get; private set; } = "Employee";

		public EmployeeTable(string connectionString, DataSet dataSet)
		{
			this.connectionString = connectionString;
			this.dataSet = dataSet;

			var connection = new SqlConnection(connectionString);
			using (connection)
			{
				dataAdapter = new SqlDataAdapter("SELECT * FROM Employee", connection);
				dataAdapter.Fill(dataSet, TableName);
				
			}
			//dataAdapter.Dispose();
			DataColumn[] keys = new DataColumn[1];
			keys[0] = dataSet.Tables[TableName].Columns[0];
			dataSet.Tables[TableName].PrimaryKey = keys;

		}

		public void Insert(string name, string surname)
		{
			var cmd = new SqlCommand("Insert INTO Employee (Name, Surname) values (@Name, @Surname)");
			cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name"));
			cmd.Parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar, 50, "Surname"));
			dataAdapter.InsertCommand = cmd;

			DataRow newRow = dataSet.Tables[TableName].NewRow();
			newRow["Name"] = name;
			newRow["Surname"] = surname;

			dataSet.Tables[TableName].Rows.Add(newRow);

			var connection = new SqlConnection(connectionString);
			using (connection)
			{
				dataAdapter.InsertCommand.Connection = connection;
				dataAdapter.Update(dataSet, TableName);
			}
			
		}

		public void Delete(string idString)
		{
			var cmd = new SqlCommand("DELETE FROM Employee WHERE Id = @Id");
			cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 50, "Id"));
			dataAdapter.DeleteCommand = cmd;

			int id = int.Parse(idString);

			dataSet.Tables[TableName].Rows.Find(id).Delete();

			var connection = new SqlConnection(connectionString);
			using (connection)
			{
				dataAdapter.DeleteCommand.Connection = connection;
				dataAdapter.Update(dataSet, TableName);
			}
		}

		public void Update(string idString, string name, string surname)
		{
			var cmd = new SqlCommand("UPDATE Employee SET Vardas = @Vardas, Pavarde = @Surname WHERE Id = @Id");
			cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name"));
			cmd.Parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar, 50, "Surname"));
			cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 50,  "Id"));
			dataAdapter.UpdateCommand = cmd;


			int id = int.Parse(idString);

			dataSet.Tables[TableName].Rows.Find(id)["Name"] = name;
			dataSet.Tables[TableName].Rows.Find(id)["Surname"] = surname;

			var connection = new SqlConnection(connectionString);
			using (connection)
			{
				dataAdapter.UpdateCommand.Connection = connection;
				dataAdapter.Update(dataSet, TableName);
			}
		}
	}
}
