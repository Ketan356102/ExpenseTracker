# 💰 Expense Tracker (ASP.NET Core MVC with MySQL)

An Expense Tracker web application built using **ASP.NET Core 9.0 MVC**, **Entity Framework Core**, and **MySQL**.  
This project helps users record their **incomes** and **expenses**, categorize them, and view summaries.

---

## 🚀 Features

- Add, edit, and delete income and expense entries  
- Categorize transactions (Food, Travel, Rent, etc.)  
- View detailed transaction lists  
- Filter by date and category  
- Simple, clean Bootstrap-based UI  

---

## 🛠️ Tech Stack

- **Frontend:** ASP.NET Core MVC (Razor Views, Bootstrap)
- **Backend:** ASP.NET Core 9.0
- **Database:** MySQL
- **ORM:** Entity Framework Core
- **IDE:** Visual Studio Code

---

## 📂 Folder Structure
ExpenseTracker/
│
├── Controllers/
│ └── ExpenseController.cs
│
├── Models/
│ └── Expense.cs
│
├── Views/
│ ├── Expense/
│ │ ├── Index.cshtml
│ │ ├── Create.cshtml
│ │ ├── Edit.cshtml
│ │ ├── Details.cshtml
│ │ └── Delete.cshtml
│
├── Data/
│ └── ApplicationDbContext.cs
│
├── appsettings.json
├── Program.cs
├── ExpenseTracker.csproj
└── README.md

## ⚙️ Installation Guide

### 1️⃣ Prerequisites

Make sure you have the following installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download)
- [MySQL Server & Workbench](https://dev.mysql.com/downloads/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

---

### 2️⃣ Clone the Repository

```bash
git clone https://github.com/<your-username>/ExpenseTracker.git
cd ExpenseTracker
3️⃣ Configure Database Connection
Open appsettings.json and update your MySQL credentials:
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;database=expense_db;user=root;password=YourPassword;"
}
4️⃣ Create Database in MySQL (Manually)
Open MySQL Workbench or terminal and run:
<img width="1050" height="82" alt="image" src="https://github.com/user-attachments/assets/04209298-95a0-4dfb-81ee-6ba849462d04" />
5️⃣ Apply Migrations (If You Use EF Core)
If you have set up Entity Framework Core migrations:
<img width="941" height="123" alt="image" src="https://github.com/user-attachments/assets/5603723f-ad9e-47ef-9028-9b65b2cf665a" />
(If EF tools are missing, install them:)
<img width="939" height="66" alt="image" src="https://github.com/user-attachments/assets/9ab5f11a-4dbc-405f-924a-b8611edff515" />
6️⃣ Run the Application
<img width="961" height="64" alt="image" src="https://github.com/user-attachments/assets/6b7be2f0-9aa5-441b-ae3b-f3c4f10c262b" />
Then open your browser and go to:
http://localhost:5175/


