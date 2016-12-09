using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDatabase
{
	class EmployeeTable
	{
		private string connectionString;
		SqlDataAdapter dataAdapter;
		DataSet dataSet;
		public string TableName { get; private set; } = "Darbuotojas";

		public EmployeeTable(string connectionString, DataSet dataSet)
		{
			this.connectionString = connectionString;
			this.dataSet = dataSet;

			var connection = new SqlConnection(connectionString);
			using (connection)
			{
				dataAdapter = new SqlDataAdapter("SELECT * FROM Darbuotojas", connection);
				dataAdapter.Fill(dataSet, TableName);
			}

		}

		public void Insert(string name, string surname)
		{
			var cmd = new SqlCommand("Insert INTO Darbuotojas (Vardas, Pavarde) values (@Vardas, @Pavarde)");
			cmd.Parameters.Add(new SqlParameter("@Vardas", SqlDbType.NVarChar, 50, "Vardas"));
			cmd.Parameters.Add(new SqlParameter("@Pavarde", SqlDbType.NVarChar, 50, "Pavarde"));
			dataAdapter.InsertCommand = cmd;

			DataRow newRow = dataSet.Tables[TableName].NewRow();
			newRow["Vardas"] = name;
			newRow["Pavarde"] = surname;

			dataSet.Tables[TableName].Rows.Add(newRow);

			var connection = new SqlConnection(connectionString);
			using (connection)
			{
				dataAdapter.InsertCommand.Connection = connection;
				dataAdapter.Update(dataSet, TableName);
			}
			
		}
	}
}
