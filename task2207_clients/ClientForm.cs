using Microsoft.IdentityModel.Tokens;
using task2207_clients.Model;

namespace task2207_clients {
    public partial class ClientForm : Form {
        public List<Client> clients;
        bool creating = false;

        public ClientForm() {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e) {
            Task2207Context? ctx = connectToDb();
            if (ctx == null) {
                Close();
                return;
            }
            clients = ctx.Clients.ToList();
            lstClients.Items.Clear();
            foreach (Client c in clients) {
                lstClients.Items.Add(c.FullName ?? "");
            }

            lstClients.SelectedIndex = 0;
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstClients.SelectedIndex == -1) return;

            txtFirstName.Text = (clients[lstClients.SelectedIndex].FirstName ?? "").Trim();
            txtSecondName.Text = (clients[lstClients.SelectedIndex].SecondName ?? "").Trim();
            txtLastName.Text = (clients[lstClients.SelectedIndex].LastName ?? "").Trim();
            txtEmail.Text = (clients[lstClients.SelectedIndex].Email ?? "").Trim();
            txtPhoneNumber.Text = (clients[lstClients.SelectedIndex].PhoneNumber ?? "").Trim();
            creating = false;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (lstClients.SelectedIndex == -1) {
                MessageBox.Show("Сначала нужно выбрать клиента");
                return;
            }
            if (txtEmail.Text == "" && txtPhoneNumber.Text == "") {
                MessageBox.Show("Нужно заполнить хотя бы одно из следующих полей: телефон, email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Task2207Context? ctx = connectToDb();
            if (ctx == null) {
                return;
            }
            Client cl;
            if (creating) {
                cl = new();
                cl.Id = ctx.Clients.Select(x => x.Id).Max() + 1;


            } else {
                cl = ctx.Clients.Where(c => c.Id == clients[lstClients.SelectedIndex].Id).First();
            }

            cl.Email = valueOrNull(txtEmail.Text);
            cl.PhoneNumber = valueOrNull(txtPhoneNumber.Text);
            cl.FirstName = valueOrNull(txtFirstName.Text);
            cl.SecondName = valueOrNull(txtSecondName.Text);
            cl.LastName = valueOrNull(txtLastName.Text);

            if (creating) {
                clients.Add(cl);
                ctx.Add(cl);
                lstClients.Items.Add(cl.FullName);
                lstClients.SelectedIndex = lstClients.Items.Count - 1;
            }
            clients[lstClients.SelectedIndex] = cl;
            lstClients.Items[lstClients.SelectedIndex] = cl.FullName;
            ctx.SaveChanges();
            creating = false;
            MessageBox.Show("Сохранено");

        }

        private Task2207Context? connectToDb() {
            try {
                return new();
            } catch (Exception) {
                MessageBox.Show("Нет соединения с БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private string? valueOrNull(string value) {
            if (value == "") return null;
            return value;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            creating = true;
            txtEmail.Text = txtPhoneNumber.Text = txtFirstName.Text = txtSecondName.Text = txtLastName.Text = "";
            MessageBox.Show("Введите данные клиента, затем нажмите кнопку \"Сохранить\"");

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (lstClients.SelectedIndex == -1) {
                MessageBox.Show("Сначала нужно выбрать клиента");
                return;
            }

            Task2207Context? ctx = connectToDb();
            if (ctx == null) {
                return;
            }
            
            ctx.Clients.Remove(ctx.Clients.Where(c => c.Id == clients[lstClients.SelectedIndex].Id).First());
            ctx.SaveChanges();
            clients.RemoveAt(lstClients.SelectedIndex);
            lstClients.Items.RemoveAt(lstClients.SelectedIndex);

            MessageBox.Show("Пользователь успешно удалён");
        }
    }
}