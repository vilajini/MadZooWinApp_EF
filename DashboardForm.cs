using System;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MadZooWinApp_EF.Data;
using MadZooWinApp_EF.Models;
using AppUser = MadZooWinApp_EF.Models.User;

namespace MadZooWinApp_EF
{
    public partial class DashboardForm : Form
    {
        private AppUser _user;

        public DashboardForm(AppUser user)
        {
            InitializeComponent();
            _user = user;

            lblUsername.Text = $"Welcome, {_user.FullName}";
            lblFullName.Text = $"Full Name: {_user.FullName}";
            lblEmail.Text = $"Email: {_user.Email}";
            lblMembershipType.Text = $"Membership Type: {_user.MembershipType}";
            lblMembershipDuration.Text = $"Membership Duration: {_user.MembershipDuration}";
            lblWeight.Text = $"Weight (kg): {_user.Weight}";
            lblMatches.Text = $"Matches Played: {_user.Matches}";

            lblCoachingHours.Text = $"Coaching Hours: {_user.CoachingHours}";
            lblCoachingFee.Text = $"Coaching Fee: Rs {_user.CoachingHours * 500}";
            lblMatchFee.Text = $"Match Entry Fee: Rs {_user.Matches * 250}";
            lblTotalFee.Text = $"Total Monthly Fee: Rs {_user.CoachingHours * 500 + _user.Matches * 250}";
        }

        private void btnSelectPlan_Click(object sender, EventArgs e)
        {
            // Open the SelectMembershipForm and pass the current user
            SelectMembershipForm planForm = new SelectMembershipForm(_user);
            this.Hide();
            planForm.ShowDialog();
            this.Show();
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: UI styling or border drawing
        }

        private void lblCoachingHours_Click(object sender, EventArgs e)
        {
            // Optional: Actions when coaching hours label is clicked
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
