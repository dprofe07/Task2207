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

        }

        private void btnDelete_Click(object sender, EventArgs e) {

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