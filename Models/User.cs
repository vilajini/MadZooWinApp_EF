using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadZooWinApp_EF.Models
{
    public class User
    {
        public int Id { get; set; }

        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? MembershipType { get; set; }     // e.g., Individual
        public string? MembershipDuration { get; set; } // e.g., Monthly
        public int Weight { get; set; }
        public int Matches { get; set; }
        public int CoachingHours { get; set; }
    }
}
