using task2207_agents.Model;

namespace task2207_agents {
    public partial class AgentForm : Form {
        public List<Agent> agents;
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
            lstAgents.Items.Clear();
            foreach (Agent a in agents) {
                lstAgents.Items.Add(a.FullName ?? "");
            }

            lstAgents.SelectedIndex = 0;
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
            if (lstAgents.SelectedIndex == -1) {
                MessageBox.Show("Сначала нужно выбрать риэлтора");
                return;
            }
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
                ag = ctx.Agents.Where(c => c.Id == agents[lstAgents.SelectedIndex].Id).First();
            }

            ag.FirstName = txtFirstName.Text;
            ag.SecondName = txtSecondName.Text;
            ag.LastName = txtLastName.Text;
            ag.DealShare = (byte)nudDealShare.Value;

            if (creating) {
                agents.Add(ag);
                ctx.Add(ag);
                lstAgents.Items.Add(ag.FullName);
                lstAgents.SelectedIndex = lstAgents.Items.Count - 1;
            }
            agents[lstAgents.SelectedIndex] = ag;
            lstAgents.Items[lstAgents.SelectedIndex] = ag.FullName;
            ctx.SaveChanges();
            creating = false;
            MessageBox.Show("Сохранено");
        }


        private void btnDelete_Click(object sender, EventArgs e) {
            if (lstAgents.SelectedIndex == -1) {
                MessageBox.Show("Сначала нужно выбрать риэлтора");
                return;
            }

            Task2207Context? ctx = connectToDb();
            if (ctx == null) {
                return;
            }

            ctx.Agents.Remove(ctx.Agents.Where(c => c.Id == agents[lstAgents.SelectedIndex].Id).First());
            ctx.SaveChanges();
            agents.RemoveAt(lstAgents.SelectedIndex);
            lstAgents.Items.RemoveAt(lstAgents.SelectedIndex);

            MessageBox.Show("Риэлтор успешно удалён");
            creating = false;
        }

        private void lstAgents_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstAgents.SelectedIndex == -1) return;

            txtFirstName.Text = (agents[lstAgents.SelectedIndex].FirstName ?? "").Trim();
            txtSecondName.Text = (agents[lstAgents.SelectedIndex].SecondName ?? "").Trim();
            txtLastName.Text = (agents[lstAgents.SelectedIndex].LastName ?? "").Trim();
            nudDealShare.Value = (decimal)(agents[lstAgents.SelectedIndex].DealShare ?? 0);
            creating = false;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            creating = true;
            nudDealShare.Value = 0;
            txtFirstName.Text = txtSecondName.Text = txtLastName.Text = "";
            MessageBox.Show("Введите данные риэлтора, затем нажмите кнопку \"Сохранить\"");
        }
    }
}