namespace Task2207 {
    partial class AgentForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Label label2;
            Label label1;
            Label label3;
            Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentForm));
            btnDelete = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            dgAgents = new DataGridView();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            nudDealShare = new NumericUpDown();
            btnSave = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgAgents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDealShare).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(534, 46);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 22;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(534, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 21;
            label1.Text = "Фамилия";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(534, 78);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 23;
            label3.Text = "Отчество";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(534, 134);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 25;
            label5.Text = "Доля от комиссии";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(717, 375);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.MinimumSize = new Size(82, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(10, 375);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.MinimumSize = new Size(82, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(505, 22);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(10, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(505, 23);
            txtSearch.TabIndex = 30;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgAgents
            // 
            dgAgents.AllowUserToAddRows = false;
            dgAgents.AllowUserToDeleteRows = false;
            dgAgents.AllowUserToResizeRows = false;
            dgAgents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgAgents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgAgents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAgents.Location = new Point(12, 38);
            dgAgents.MultiSelect = false;
            dgAgents.Name = "dgAgents";
            dgAgents.ReadOnly = true;
            dgAgents.RowHeadersVisible = false;
            dgAgents.RowTemplate.Height = 25;
            dgAgents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAgents.Size = new Size(503, 332);
            dgAgents.TabIndex = 31;
            dgAgents.SelectionChanged += dgAgents_SelectionChanged;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLastName.Location = new Point(665, 10);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(134, 23);
            txtLastName.TabIndex = 24;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFirstName.Location = new Point(665, 44);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(134, 23);
            txtFirstName.TabIndex = 27;
            // 
            // txtSecondName
            // 
            txtSecondName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSecondName.Location = new Point(665, 76);
            txtSecondName.Margin = new Padding(3, 2, 3, 2);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(134, 23);
            txtSecondName.TabIndex = 28;
            // 
            // nudDealShare
            // 
            nudDealShare.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudDealShare.Location = new Point(665, 133);
            nudDealShare.Margin = new Padding(3, 2, 3, 2);
            nudDealShare.Name = "nudDealShare";
            nudDealShare.Size = new Size(133, 23);
            nudDealShare.TabIndex = 29;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(521, 375);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.MinimumSize = new Size(82, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 20;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AgentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 406);
            Controls.Add(dgAgents);
            Controls.Add(txtSearch);
            Controls.Add(nudDealShare);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgentForm";
            Text = "RealEstate";
            Load += AgentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgAgents).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDealShare).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtSearch;
        private DataGridView dgAgents;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private NumericUpDown nudDealShare;
        private Button btnSave;
    }
}