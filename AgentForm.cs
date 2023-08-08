using Task2207.Model;
using Task2207.Properties;

namespace Task2207 {
    public partial class AgentForm : Form {
        public List<Agent> agents;
        public List<Agent> showAgents;
        bool creating = false;

        public AgentForm() {
            InitializeComponent();
        }

        private void AgentForm_Load(object sender, EventArgs e) {
            Task2207Context? ctx = connectToDb();
            if (ctx == null) {
                Close();
                return;
            }
            agents = ctx.Agents.ToList();
            showAgents = ctx.Agents.ToList();

            dgAgents.DataSource = showAgents;

            dgFormat();
        }


        void dgFormat() {
            dgAgents.Columns["LastNameTrimmed"].HeaderText = "Фамилия";
            dgAgents.Columns["FirstNameTrimmed"].HeaderText = "Имя";
            dgAgents.Columns["SecondNameTrimmed"].HeaderText = "Отчество";
            dgAgents.Columns["DealShare"].HeaderText = "Доля от комиссии";
            dgAgents.Columns["DealShare"].FillWeight = 30;
            dgAgents.Columns["LastName"].Visible = false;
            dgAgents.Columns["FirstName"].Visible = false;
            dgAgents.Columns["SecondName"].Visible = false;
            dgAgents.Columns["FullName"].Visible = false;
            dgAgents.Columns["Id"].Visible = false;
        }

        private Task2207Context? connectToDb() {
            try {
                return new();
            } catch (Exception) {
                MessageBox.Show("Нет соединения с БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (dgAgents.SelectedRows.Count == 0) {
                MessageBox.Show("Сначала нужно выбрать риэлтора");
                return;
            }
            int idx = dgAgents.SelectedRows[0].Index;

            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtSecondName.Text == "") {
                MessageBox.Show("Нужно заполнить все следующие поля: фамилия, имя, отчество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Task2207Context? ctx = connectToDb();
            if (ctx == null) {
                return;
            }
            Agent ag;
            if (creating) {
                ag = new();
                ag.Id = ctx.Agents.Select(x => x.Id).Max() + 1;
            } else {
                ag = ctx.Agents.Where(c => c.Id == showAgents[idx].Id).First();
            }

            ag.FirstName = txtFirstName.Text;
            ag.SecondName = txtSecondName.Text;
            ag.LastName = txtLastName.Text;
            ag.DealShare = (byte)nudDealShare.Value;

            if (creating) {
                agents.Add(ag);
                showAgents.Add(ag);
                ctx.Add(ag);
                txtSearch.Text = "";
                idx = showAgents.Count - 1;
            }
            for (int i = 0; i < agents.Count; i++) {
                if (agents[i].Id == ag.Id) {
                    agents[i] = ag;
                    break;
                }
            }
            showAgents[idx] = ag;

            ctx.SaveChanges();
            creating = false;
            dgAgents.Refresh();
            MessageBox.Show("Сохранено");
        }


        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgAgents.SelectedRows.Count == 0) {
                MessageBox.Show("Сначала нужно выбрать риэлтора");
                return;
            }
            int idx = dgAgents.SelectedRows[0].Index;

            Task2207Context? ctx = connectToDb();
            if (ctx == null) {
                return;
            }

            ctx.Agents.Remove(ctx.Agents.Where(c => c.Id == agents[idx].Id).First());
            ctx.SaveChanges();
            for (int i = 0; i < agents.Count; i++) {
                if (agents[i].Id == showAgents[idx].Id) {
                    agents.RemoveAt(i);
                    break;
                }
            }
            dgAgents.DataSource = null;
            showAgents.RemoveAt(idx);
            dgAgents.DataSource = showAgents;
            dgFormat();

            MessageBox.Show("Риэлтор успешно удалён");
            dgAgents.Refresh();
            creating = false;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            creating = true;
            nudDealShare.Value = 0;
            txtFirstName.Text = txtSecondName.Text = txtLastName.Text = "";
            MessageBox.Show("Введите данные риэлтора, затем нажмите кнопку \"Сохранить\"");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (txtSearch.Text == "") {
                showAgents = (from a in agents select a).ToList();
            } else {
                showAgents = (
                    from a in agents
                    where
                    LevDistance.count(a.FirstNameTrimmed, txtSearch.Text) <= 3 ||
                    LevDistance.count(a.SecondNameTrimmed, txtSearch.Text) <= 3 ||
                    LevDistance.count(a.LastNameTrimmed, txtSearch.Text) <= 3
                    select a
                ).ToList();
            }


            dgAgents.Refresh();
        }

        private void dgAgents_SelectionChanged(object sender, EventArgs e) {
            if (dgAgents.SelectedRows.Count == 0) return;
            int idx = dgAgents.SelectedRows[0].Index;

            txtFirstName.Text = (agents[idx].FirstNameTrimmed ?? "");
            txtSecondName.Text = (agents[idx].SecondNameTrimmed ?? "");
            txtLastName.Text = (agents[idx].LastNameTrimmed ?? "");
            nudDealShare.Value = (decimal)(agents[idx].DealShare ?? 0);
            creating = false;
        }
    }
}