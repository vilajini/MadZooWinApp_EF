# 🐾 MadZooWinApp_EF - Membership Management System

MadZooWinApp_EF is a Windows Forms application developed in C# with Entity Framework and SQLite. It allows users to register, log in, select a membership plan, and view a personalized dashboard that calculates coaching and match fees.

## ✨ Features

- 📝 User Registration & Login
- 📅 Select Membership Plan (Type, Duration)
- ⚖️ Enter Weight, Matches Played, and Coaching Hours
- 📊 Personalized Dashboard with:
  - Membership Type & Duration
  - Coaching Fee
  - Match Entry Fee
  - Total Monthly Fee
- 🔐 Secure session and logout functionality

## 💡 Technologies Used

- C# (.NET Windows Forms)
- Entity Framework Core
- SQLite (Local DB)
- Visual Studio 2022

## 📸 Screenshots

![Login]
![image](https://github.com/user-attachments/assets/d97edc6a-c35f-4f77-9e39-eafd1586babf)

![Select Plan]
![image](https://github.com/user-attachments/assets/443414a5-df4f-4253-9ab2-4b49d96fd31e)


![Dashboard]
![image](https://github.com/user-attachments/assets/92702b87-8679-4f5c-a14a-998c394cd174)


## 🧪 Testing

| Test Case | Description | Expected Result | Status |
|-----------|-------------|-----------------|--------|
| Login Valid | Login with correct credentials | Dashboard loads | ✅ Pass |
| Membership Plan | Select values and confirm | Dashboard updates | ✅ Pass |
| Logout | Click Logout button | Returns to login | ✅ Pass |

## 🧠 How It Works

1. User logs in or registers.
2. On first login, they are prompted to select a membership plan.
3. User inputs weight, matches played, and coaching hours.
4. Dashboard calculates:
   - `Coaching Fee = Coaching Hours × 500`
   - `Match Entry Fee = Matches Played × 250`
   - `Total Monthly Fee = Coaching Fee + Match Entry Fee`
5. Data is stored using Entity Framework to SQLite.

## 🔄 Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/MadZooWinApp_EF.git

## Project Structure
MadZooWinApp_EF/
│
├── Models/
│   └── User.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Forms/
│   ├── LoginForm.cs
│   ├── RegisterForm.cs
│   ├── DashboardForm.cs
│   └── SelectMembershipForm.cs
│
├── Program.cs
├── README.md

## Author
Name: Vilajini Togeswaran
GitHub: @vilajini03
Email: vilajini03@gmail.com
