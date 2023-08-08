namespace Task2207 {
    partial class StartForm {
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
            Label lblTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            btnClients = new Button();
            btnAgents = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(776, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Управление";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClients
            // 
            btnClients.Location = new Point(12, 35);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(383, 32);
            btnClients.TabIndex = 1;
            btnClients.Text = "Клиентами";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnAgents
            // 
            btnAgents.Location = new Point(401, 35);
            btnAgents.Name = "btnAgents";
            btnAgents.Size = new Size(383, 32);
            btnAgents.TabIndex = 2;
            btnAgents.Text = "Риэлторами";
            btnAgents.UseVisualStyleBackColor = true;
            btnAgents.Click += btnAgents_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 81);
            Controls.Add(btnAgents);
            Controls.Add(btnClients);
            Controls.Add(lblTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartForm";
            Text = "RealEstate";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClients;
        private Button btnAgents;
    }
}