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
			dataAdapter = new SqlDataAdapter("SELECT * FROM [Table]", connection);
		}


	}
}
