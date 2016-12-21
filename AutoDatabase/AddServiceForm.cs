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
            Service serv = new Service
            {
                Name = textBoxServiceName.Text,
                Price = int.Parse(textBoxServicePrice.Text)
            };
            data.addData(serv);
            this.Dispose();
        }
    }
}
