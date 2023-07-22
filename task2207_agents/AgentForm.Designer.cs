namespace task2207_agents {
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
            Label label5;
            Label label3;
            Label label2;
            Label label1;
            txtSecondName = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            lstAgents = new ListBox();
            nudDealShare = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDealShare).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(610, 179);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 25;
            label5.Text = "Доля от комиссии";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(610, 104);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 23;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(610, 61);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 22;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(610, 16);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 21;
            label1.Text = "Фамилия";
            // 
            // txtSecondName
            // 
            txtSecondName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSecondName.Location = new Point(760, 101);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(152, 27);
            txtSecondName.TabIndex = 28;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFirstName.Location = new Point(760, 58);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(152, 27);
            txtFirstName.TabIndex = 27;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLastName.Location = new Point(760, 13);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(152, 27);
            txtLastName.TabIndex = 24;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(610, 500);
            btnSave.MinimumSize = new Size(94, 29);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(818, 500);
            btnDelete.MinimumSize = new Size(94, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(12, 500);
            btnAdd.MinimumSize = new Size(94, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(577, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstAgents
            // 
            lstAgents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstAgents.FormattingEnabled = true;
            lstAgents.ItemHeight = 20;
            lstAgents.Location = new Point(12, 12);
            lstAgents.Name = "lstAgents";
            lstAgents.Size = new Size(577, 464);
            lstAgents.TabIndex = 17;
            lstAgents.SelectedIndexChanged += lstAgents_SelectedIndexChanged;
            // 
            // nudDealShare
            // 
            nudDealShare.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nudDealShare.Location = new Point(760, 177);
            nudDealShare.Name = "nudDealShare";
            nudDealShare.Size = new Size(152, 27);
            nudDealShare.TabIndex = 29;
            // 
            // AgentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 541);
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
            Controls.Add(lstAgents);
            Name = "AgentForm";
            ShowIcon = false;
            Text = "RealEstate";
            Load += AgentForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudDealShare).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSecondName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSave;
        private Button btnDelete;
        private Button btnAdd;
        private ListBox lstAgents;
        private NumericUpDown nudDealShare;
    }
}