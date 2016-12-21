using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
    public partial class AddServiceForm : Form
    {
        DataController data;
        public AddServiceForm()
        {
            InitializeComponent();
            data = new DataController();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace (textBoxServicePrice.Text) || string.IsNullOrWhiteSpace (textBoxServiceName.Text))
                return;

            int price;
            int.TryParse (textBoxServicePrice.Text, out price);

            Service serv = new Service
            {
                Name = textBoxServiceName.Text,
                Price = price
            };
            data.addData(serv);
            this.Dispose();
        }
    }
}
