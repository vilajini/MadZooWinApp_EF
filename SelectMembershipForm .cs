using MadZooWinApp_EF.Data;
using MadZooWinApp_EF.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUser = MadZooWinApp_EF.Models.User;


namespace MadZooWinApp_EF
{
    public partial class SelectMembershipForm : Form
    {
        private AppUser _user;

        public SelectMembershipForm(AppUser user)
        {
            InitializeComponent();
            _user = user;
            this.Load += SelectMembershipForm_Load;
        }

        private void SelectMembershipForm_Load(object sender, EventArgs e)
        {
            cmbType.Items.AddRange(new string[] { "Individual", "Family", "Junior" });
            cmbDuration.Items.AddRange(new string[] { "1Months", "3Months" , "6Months","Annual"});

            cmbType.SelectedIndex = 0;
            cmbDuration.SelectedIndex = 0;

            lblHeading.Text = $"Welcome, {_user.FullName}! Select your membership plan.";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string membershipType = cmbType.SelectedItem?.ToString();
            string membershipDuration = cmbDuration.SelectedItem?.ToString();
            int weight = (int)nudWeight.Value;
            int matches = (int)nudMatches.Value;
            int hours = (int)nudHours.Value;

            if (string.IsNullOrWhiteSpace(membershipType) || string.IsNullOrWhiteSpace(membershipDuration))
            {
                MessageBox.Show("Please select both membership type and duration.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new AppDbContext())
            {
                var userToUpdate = context.User.Find(_user.Id);
                if (userToUpdate != null)
                {
                    userToUpdate.MembershipType = membershipType;
                    userToUpdate.MembershipDuration = membershipDuration;
                    userToUpdate.Weight = weight;
                    userToUpdate.Matches = matches;
                    userToUpdate.CoachingHours = hours;

                    context.SaveChanges();

                    // ✅ Fetch updated user again
                    var updatedUser = context.User.Find(_user.Id);

                    MessageBox.Show("Membership selected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    DashboardForm dashboard = new DashboardForm(updatedUser); // ✅ Use fresh object
                    dashboard.ShowDialog();
                    this.Close();
                }
            }
        }


    }
}


