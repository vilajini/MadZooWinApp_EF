namespace MadZooWinApp_EF
{
    partial class SelectMembershipForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblType = new Label();
            cmbType = new ComboBox();
            lblDuration = new Label();
            cmbDuration = new ComboBox();
            lblWeight = new Label();
            lblMatches = new Label();
            lblHours = new Label();
            nudWeight = new NumericUpDown();
            nudMatches = new NumericUpDown();
            nudHours = new NumericUpDown();
            btnConfirm = new Button();
            lblHeading = new Label();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMatches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHours).BeginInit();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(71, 94);
            lblType.Name = "lblType";
            lblType.Size = new Size(104, 15);
            lblType.TabIndex = 0;
            lblType.Text = "Membership Type:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(181, 91);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(175, 23);
            cmbType.TabIndex = 1;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(380, 94);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(126, 15);
            lblDuration.TabIndex = 2;
            lblDuration.Text = "Membership Duration:";
            // 
            // cmbDuration
            // 
            cmbDuration.FormattingEnabled = true;
            cmbDuration.Location = new Point(512, 91);
            cmbDuration.Name = "cmbDuration";
            cmbDuration.Size = new Size(215, 23);
            cmbDuration.TabIndex = 3;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(103, 154);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(72, 15);
            lblWeight.TabIndex = 4;
            lblWeight.Text = "Weight (kg):";
            // 
            // lblMatches
            // 
            lblMatches.AutoSize = true;
            lblMatches.Location = new Point(404, 154);
            lblMatches.Name = "lblMatches";
            lblMatches.Size = new Size(93, 15);
            lblMatches.TabIndex = 5;
            lblMatches.Text = "Matches Played:";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(71, 226);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(96, 15);
            lblHours.TabIndex = 6;
            lblHours.Text = "Coaching Hours:";
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(181, 152);
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(175, 23);
            nudWeight.TabIndex = 7;
            // 
            // nudMatches
            // 
            nudMatches.Location = new Point(512, 152);
            nudMatches.Name = "nudMatches";
            nudMatches.Size = new Size(215, 23);
            nudMatches.TabIndex = 8;
            // 
            // nudHours
            // 
            nudHours.Location = new Point(181, 224);
            nudHours.Name = "nudHours";
            nudHours.Size = new Size(185, 23);
            nudHours.TabIndex = 9;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(359, 304);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHeading.Location = new Point(124, 25);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(194, 21);
            lblHeading.TabIndex = 11;
            lblHeading.Text = "Select Membership Plan";
            // 
            // SelectMembershipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeading);
            Controls.Add(btnConfirm);
            Controls.Add(nudHours);
            Controls.Add(nudMatches);
            Controls.Add(nudWeight);
            Controls.Add(lblHours);
            Controls.Add(lblMatches);
            Controls.Add(lblWeight);
            Controls.Add(cmbDuration);
            Controls.Add(lblDuration);
            Controls.Add(cmbType);
            Controls.Add(lblType);
            Name = "SelectMembershipForm";
            Text = "Select Membership";
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMatches).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblType;
        private ComboBox cmbType;
        private Label lblDuration;
        private ComboBox cmbDuration;
        private Label lblWeight;
        private Label lblMatches;
        private Label lblHours;
        private NumericUpDown nudWeight;
        private NumericUpDown nudMatches;
        private NumericUpDown nudHours;
        private Button btnConfirm;
        private Label lblHeading;
    }
}
