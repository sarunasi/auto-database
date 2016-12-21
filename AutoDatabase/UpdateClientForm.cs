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
    public partial class UpdateClientForm : Form
    {
        DataController data;
        int clientId;
        Client client = null;
        Person person = null;
        Company company = null;

        public bool isPerson = false;
        public UpdateClientForm(object id)
        {
            InitializeComponent();
            clientId = (int)id;
        }

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {
            data = new DataController();
            client = data.findClient(clientId);
            if (data.isPerson(clientId))
            {
                textClient1.Text = "Vardas";
                textClient2.Text = "Pavarde";
                client = data.findClient(clientId);
                person = data.findPerson(clientId);
            }else if (data.isCompany(clientId))
            {
                textClient1.Text = "Pavadinimas";
                textClient2.Text = "Kodas";
                client = data.findClient(clientId);
                company = data.findCompany(clientId);
            }
            fillTextFields();
        }

        private void fillTextFields()
        {
            if (data.isPerson(clientId))
            {
                textBoxClientName.Text = person.Name;
                textBoxClientSurname.Text = person.Surname;
                textBoxAddress.Text = client.Adress;
                textBoxTelephone.Text = client.Telephone;
            }else if (data.isCompany(clientId))
            {
                textBoxClientName.Text = company.Name;
                textBoxClientSurname.Text =company.Code;
                textBoxAddress.Text = client.Adress;
                textBoxTelephone.Text = client.Telephone;
            }
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            data.updateClientData(clientId, textBoxClientName.Text, textBoxClientSurname.Text, textBoxClientSurname.Text, textBoxAddress.Text, textBoxTelephone.Text);
            this.Dispose();
        }
    }
}
