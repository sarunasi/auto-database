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
				//dataAdapter.Fill(dataSet, TableName);
				
			}


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

			
			using (var connection = new SqlConnection(connectionString))
			{
				dataAdapter.InsertCommand.Connection = connection;
				dataAdapter.Update(dataSet, TableName);
			}
			
		}

		public void Delete(string idString)
		{
			int id = int.Parse(idString);

			var cmd = new SqlCommand("DELETE FROM Employee WHERE Id = @Id");
			cmd.Parameters.AddWithValue("@Id", id);
			dataAdapter.DeleteCommand = cmd;

			var connection = new SqlConnection(connectionString);
			using (connection)
			{
				connection.Open();
				dataAdapter.DeleteCommand.Connection = connection;
				dataAdapter.DeleteCommand.ExecuteNonQuery();
			}
		}

		public void Update(string idString, string name, string surname)
		{
			int id = int.Parse(idString);
			var cmd = new SqlCommand("UPDATE Employee SET Name = @Name, Surname = @Surname WHERE Id = @Id");
			cmd.Parameters.AddWithValue("@Name", name);
			cmd.Parameters.AddWithValue("@Surname", surname);
			cmd.Parameters.AddWithValue("@Id", id);
			dataAdapter.UpdateCommand = cmd;

			var connection = new SqlConnection(connectionString);
			using (connection)
			{
				connection.Open();
				dataAdapter.UpdateCommand.Connection = connection;
				dataAdapter.UpdateCommand.ExecuteNonQuery();
			}
		}
	}
}
