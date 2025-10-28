# 💰 Expense Tracker (ASP.NET Core MVC with MySQL)

An Expense Tracker web application built using **ASP.NET Core 9.0 MVC**, **Entity Framework Core**, and **MySQL**.  
This project helps users record their **incomes** and **expenses**, categorize them, and view summaries.

## 🚀 Features

- Add, edit, and delete income and expense entries  
- Categorize transactions (Food, Travel, Rent, etc.)  
- View detailed transaction lists  
- Filter by date and category  
- Simple, clean Bootstrap-based UI 

## 🛠️ Tech Stack

- **Frontend:** ASP.NET Core MVC (Razor Views, Bootstrap)
- **Backend:** ASP.NET Core 9.0
- **Database:** MySQL
- **ORM:** Entity Framework Core
- **IDE:** Visual Studio Code

  ## 📂 Folder Structure
  <img width="315" height="726" alt="image" src="https://github.com/user-attachments/assets/0982e731-d687-4040-ae12-b90fbce8a3cc" />

  ## ⚙️ Installation Guide

### 1️⃣ Prerequisites
Make sure you have the following installed:
- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download)
- [MySQL Server & Workbench](https://dev.mysql.com/downloads/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)
### 2️⃣ Clone the Repository

```bash
# Clone the repository from GitHub
git clone https://github.com/Ketan356102/ExpenseTracker.git

# Navigate into the project directory
cd ExpenseTracker
```
  ### 3️⃣ Configure Database Connection
Open the `appsettings.json` file and update your MySQL credentials:

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;database=expense_db;user=root;password=YourPassword;"
}
```
⚠️ Replace YourPassword with your actual MySQL root password.

 ### 4️⃣ Create Database in MySQL (Manually)

Open **MySQL Workbench** or **MySQL Command-Line Client**, and run the following command to create the database:

```sql
CREATE DATABASE ExpenseDB;
```
### 5️⃣ Install Dependencies

Run the following command to restore all required NuGet packages:

```bash
dotnet restore
```
This will automatically install all dependencies defined in the project file.

If the dependencies are notnstalled automatically, you can manually add them using the following commands:
```bash
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
### 6️⃣ Apply Migrations (If You Use EF Core)
If you have set up Entity Framework Core migrations:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
(If EF tools are missing, install them:)
```bash
dotnet tool install --global dotnet-ef
```
### 7️⃣ Run the Application
```bash
dotnet run
```
Then open your browser and go to:
```bash
👉 http://localhost:5175/
```





