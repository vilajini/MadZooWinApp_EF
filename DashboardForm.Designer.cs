namespace MadZooWinApp_EF
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            topPanel = new Panel();
            btnSelectPlan = new Button();
            lblUsername = new Label();
            btnLogout = new Button();
            lblFullName = new Label();
            lblEmail = new Label();
            lblCoachingHours = new Label();
            lblCoachingFee = new Label();
            lblMatchFee = new Label();
            lblTotalFee = new Label();
            contentPanel = new Panel();
            lblWeight = new Label();
            lblMatches = new Label();
            lblMembershipDuration = new Label();
            lblMembershipType = new Label();
            panelFees = new Panel();
            headingLabel = new Label();
            topPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            panelFees.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(0, 122, 204);
            topPanel.Controls.Add(btnSelectPlan);
            topPanel.Controls.Add(lblUsername);
            topPanel.Controls.Add(btnLogout);
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 50);
            topPanel.TabIndex = 0;
            // 
            // btnSelectPlan
            // 
            btnSelectPlan.Location = new Point(628, 14);
            btnSelectPlan.Name = "btnSelectPlan";
            btnSelectPlan.Size = new Size(85, 23);
            btnSelectPlan.TabIndex = 20;
            btnSelectPlan.Text = "Select Plan";
            btnSelectPlan.UseVisualStyleBackColor = true;
            btnSelectPlan.Click += btnSelectPlan_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(392, 16);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Welcome, User";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(725, 14);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(60, 25);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(3, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(250, 23);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(3, 33);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(250, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblCoachingHours
            // 
            lblCoachingHours.Location = new Point(199, 13);
            lblCoachingHours.Name = "lblCoachingHours";
            lblCoachingHours.Size = new Size(218, 23);
            lblCoachingHours.TabIndex = 3;
            lblCoachingHours.Text = "Coaching Hours:";
            // 
            // lblCoachingFee
            // 
            lblCoachingFee.Location = new Point(3, 13);
            lblCoachingFee.Name = "lblCoachingFee";
            lblCoachingFee.Size = new Size(190, 23);
            lblCoachingFee.TabIndex = 2;
            lblCoachingFee.Text = "Coaching Fee (Rs):";
            // 
            // lblMatchFee
            // 
            lblMatchFee.Location = new Point(423, 13);
            lblMatchFee.Name = "lblMatchFee";
            lblMatchFee.Size = new Size(254, 23);
            lblMatchFee.TabIndex = 1;
            lblMatchFee.Text = "Match Entry Fee (Rs):";
            // 
            // lblTotalFee
            // 
            lblTotalFee.Location = new Point(3, 59);
            lblTotalFee.Name = "lblTotalFee";
            lblTotalFee.Size = new Size(333, 23);
            lblTotalFee.TabIndex = 0;
            lblTotalFee.Text = "Total Monthly Fee (Rs):";
            // 
            // contentPanel
            // 
            contentPanel.BorderStyle = BorderStyle.FixedSingle;
            contentPanel.Controls.Add(lblEmail);
            contentPanel.Controls.Add(lblFullName);
            contentPanel.Controls.Add(lblWeight);
            contentPanel.Controls.Add(lblMatches);
            contentPanel.Controls.Add(lblMembershipDuration);
            contentPanel.Controls.Add(lblMembershipType);
            contentPanel.Location = new Point(23, 91);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(750, 100);
            contentPanel.TabIndex = 2;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // lblWeight
            // 
            lblWeight.Location = new Point(3, 60);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(100, 23);
            lblWeight.TabIndex = 2;
            lblWeight.Text = "Weight (kg):";
            // 
            // lblMatches
            // 
            lblMatches.Location = new Point(279, 60);
            lblMatches.Name = "lblMatches";
            lblMatches.Size = new Size(288, 23);
            lblMatches.TabIndex = 3;
            lblMatches.Text = "Matches Played:";
            // 
            // lblMembershipDuration
            // 
            lblMembershipDuration.Location = new Point(279, 0);
            lblMembershipDuration.Name = "lblMembershipDuration";
            lblMembershipDuration.Size = new Size(292, 23);
            lblMembershipDuration.TabIndex = 4;
            lblMembershipDuration.Text = "Membership Duration:";
            // 
            // lblMembershipType
            // 
            lblMembershipType.Location = new Point(279, 33);
            lblMembershipType.Name = "lblMembershipType";
            lblMembershipType.Size = new Size(292, 23);
            lblMembershipType.TabIndex = 5;
            lblMembershipType.Text = "Membership Type:";
            // 
            // panelFees
            // 
            panelFees.BorderStyle = BorderStyle.FixedSingle;
            panelFees.Controls.Add(lblTotalFee);
            panelFees.Controls.Add(lblMatchFee);
            panelFees.Controls.Add(lblCoachingFee);
            panelFees.Controls.Add(lblCoachingHours);
            panelFees.Location = new Point(23, 210);
            panelFees.Name = "panelFees";
            panelFees.Size = new Size(750, 100);
            panelFees.TabIndex = 3;
            // 
            // headingLabel
            // 
            headingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            headingLabel.Location = new Point(23, 60);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(300, 25);
            headingLabel.TabIndex = 4;
            headingLabel.Text = "Your Membership Details";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFees);
            Controls.Add(contentPanel);
            Controls.Add(headingLabel);
            Controls.Add(topPanel);
            Name = "DashboardForm";
            Text = "Dashboard";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            panelFees.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Label lblUsername;
        private Button btnLogout;
        private Button btnSelectPlan;
        private Label lblFullName;
        private Label lblEmail;
        private Label lblCoachingHours;
        private Label lblCoachingFee;
        private Label lblMatchFee;
        private Label lblTotalFee;
        private Panel contentPanel;
        private Label lblMatches;
        private Label lblWeight;
        private Label lblMembershipType;
        private Label lblMembershipDuration;
        private Panel panelFees;
        private Label headingLabel;
    }
}
