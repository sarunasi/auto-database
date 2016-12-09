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
		SqlConnection connection;
		DataSet dataSet;
		SqlDataAdapter dataAdapter;

		public MainForm()
		{
			InitializeComponent();
			connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Sarunas\Documents\Visual Studio 2015\Projects\AutoDatabase\AutoDatabase\AutoShop.mdf';Integrated Security=True");
			dataSet = new DataSet();
			dataAdapter = new SqlDataAdapter("SELECT * FROM Darbuotojas", connection);

			

		}

		private void buttonRegisterClient_Click(object sender, EventArgs e)
		{
			
		}

		private void buttonAddEmployee_Click(object sender, EventArgs e)
		{
			
			dataAdapter.Fill(dataSet, "Darbuotojas");
			

			var cmd = new SqlCommand("Insert INTO Darbuotojas (Vardas, Pavarde) values (@Vardas, @Pavarde)", connection);
			cmd.Parameters.Add(new SqlParameter("@Vardas", SqlDbType.NVarChar, 50, "Vardas"));
			cmd.Parameters.Add(new SqlParameter("@Pavarde", SqlDbType.NVarChar, 50, "Pavarde"));

			dataAdapter.InsertCommand = cmd;

			DataRow newRow = dataSet.Tables["Darbuotojas"].NewRow();
			newRow["Vardas"] = textBoxDarbuotojasVardas.Text;
			newRow["Pavarde"] = textBoxDarbuotojasPavarde.Text;

			dataSet.Tables["Darbuotojas"].Rows.Add(newRow);



			dataAdapter.Update(dataSet, "Darbuotojas");
			connection.Close();
		}
	}
}
