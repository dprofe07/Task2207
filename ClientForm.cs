using Task2207.Model;

namespace Task2207 {
    public partial class ClientForm : Form {
        public List<Client> clients, showClients;
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
            showClients = ctx.Clients.ToList();

            dgClients.DataSource = showClients;

            formatColumns();

            dgClients.Rows[0].Selected = true;
        }

        void formatColumns() {
            dgClients.Columns["LastNameTrimmed"].HeaderText = "Фамилия";
            dgClients.Columns["FirstNameTrimmed"].HeaderText = "Имя";
            dgClients.Columns["SecondNameTrimmed"].HeaderText = "Отчество";
            dgClients.Columns["PhoneNumberTrimmed"].HeaderText = "Телефон";
            dgClients.Columns["EmailTrimmed"].HeaderText = "Email";
            dgClients.Columns["LastName"].Visible = false;
            dgClients.Columns["FirstName"].Visible = false;
            dgClients.Columns["SecondName"].Visible = false;
            dgClients.Columns["FullName"].Visible = false;
            dgClients.Columns["PhoneNumber"].Visible = false;
            dgClients.Columns["Email"].Visible = false;
            dgClients.Columns["Id"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (dgClients.SelectedRows.Count == 0) {
                MessageBox.Show("Сначала нужно выбрать клиента");
                return;
            }
            int idx = dgClients.SelectedRows[0].Index;

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
                cl = ctx.Clients.Where(c => c.Id == clients[idx].Id).First();
            }

            cl.Email = valueOrNull(txtEmail.Text);
            cl.PhoneNumber = valueOrNull(txtPhoneNumber.Text);
            cl.FirstName = valueOrNull(txtFirstName.Text);
            cl.SecondName = valueOrNull(txtSecondName.Text);
            cl.LastName = valueOrNull(txtLastName.Text);

            if (creating) {
                clients.Add(cl);
                showClients.Add(cl);
                ctx.Add(cl);
                idx = showClients.Count - 1;
                //txtSearch.Text = "";
            }
            for (int i = 0; i < clients.Count; i++) {
                if (clients[i].Id == cl.Id) {
                    clients[i] = cl;
                    break;
                }
            }
            showClients[idx] = cl;
            ctx.SaveChanges();
            creating = false;

            dgClients.Refresh();
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
            if (dgClients.SelectedRows.Count == 0) {
                MessageBox.Show("Сначала нужно выбрать клиента");
                return;
            }
            int idx = dgClients.SelectedRows[0].Index;

            Task2207Context? ctx = connectToDb();
            if (ctx == null) {
                return;
            }

            ctx.Clients.Remove(ctx.Clients.Where(c => c.Id == clients[idx].Id).First());
            ctx.SaveChanges();
            for (int i = 0; i < clients.Count; i++) {
                if (clients[i].Id == showClients[idx].Id) {
                    clients.RemoveAt(i);
                    break;
                }
            }
            dgClients.DataSource = null;
            showClients.RemoveAt(idx);
            dgClients.DataSource = showClients;
            formatColumns();

            dgClients.Refresh();

            MessageBox.Show("Клиент успешно удалён");
        }

        private void dgAgents_SelectionChanged(object sender, EventArgs e) {
            if (dgClients.SelectedRows.Count == 0) return;
            int idx = dgClients.SelectedRows[0].Index;

            txtFirstName.Text = clients[idx].FirstNameTrimmed;
            txtSecondName.Text = clients[idx].SecondNameTrimmed;
            txtLastName.Text = clients[idx].LastNameTrimmed;
            txtEmail.Text = clients[idx].EmailTrimmed;
            txtPhoneNumber.Text = clients[idx].PhoneNumberTrimmed;
            creating = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (txtSearch.Text == "") {
                showClients = (from a in clients select a).ToList();
            } else {
                showClients = (
                    from a in clients
                    where
                    LevDistance.count(a.FirstNameTrimmed, txtSearch.Text) <= 3 ||
                    LevDistance.count(a.SecondNameTrimmed, txtSearch.Text) <= 3 ||
                    LevDistance.count(a.LastNameTrimmed, txtSearch.Text) <= 3
                    select a
                ).ToList();
            }


            dgClients.Refresh();
        }
    }
}