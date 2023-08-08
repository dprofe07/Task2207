namespace Task2207 {
    public partial class StartForm : Form {
        public StartForm() {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e) {
            Hide();
            (new ClientForm()).ShowDialog();
            Show();
        }

        private void btnAgents_Click(object sender, EventArgs e) {
            Hide();
            (new AgentForm()).ShowDialog();
            Show();
        }
    }
}