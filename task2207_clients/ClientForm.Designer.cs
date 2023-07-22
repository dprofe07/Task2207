namespace task2207_clients {
    partial class ClientForm {
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
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            lstClients = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(566, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 4;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(566, 57);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(566, 100);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(566, 227);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 11;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(566, 175);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Телефон";
            // 
            // lstClients
            // 
            lstClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstClients.FormattingEnabled = true;
            lstClients.ItemHeight = 20;
            lstClients.Location = new Point(12, 12);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(526, 464);
            lstClients.TabIndex = 0;
            lstClients.SelectedIndexChanged += lstClients_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(12, 491);
            btnAdd.MinimumSize = new Size(94, 29);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(526, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(774, 491);
            btnDelete.MinimumSize = new Size(94, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(566, 491);
            btnSave.MinimumSize = new Size(94, 29);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLastName.Location = new Point(683, 9);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(185, 27);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFirstName.Location = new Point(683, 54);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 27);
            txtFirstName.TabIndex = 12;
            // 
            // txtSecondName
            // 
            txtSecondName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSecondName.Location = new Point(683, 97);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(185, 27);
            txtSecondName.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmail.Location = new Point(683, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhoneNumber.Location = new Point(683, 172);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(185, 27);
            txtPhoneNumber.TabIndex = 16;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 532);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstClients);
            MinimumSize = new Size(600, 400);
            Name = "ClientForm";
            ShowIcon = false;
            Text = "RealEstate";
            Load += ClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstClients;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
    }
}